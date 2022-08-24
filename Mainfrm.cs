using Basler.Pylon;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using Modbus.Device;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Linq;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using System.Diagnostics;
using System.Management;
using PropImages;



namespace PropInnerImageAnalysis
{

    public partial class Mainfrm : Form
    {
        /*************************************************************************************************************/
        /*************************************************************************************************************/
        /*-----------------------------------系統公用變數設定--------------------------------------------------------*/
        /*************************************************************************************************************/
        /*************************************************************************************************************/

        private Label[] ledProcess;    // 機台運行顯示用 label陣列
        private PictureBox OrgImg;  // 原始影像
        private PictureBox RgnImgs; // 辨識後影像
        private Label[] ledOperMode; // 顯示運作模式
        private Label[] ledSamplePath; // 取樣路徑燈號

        private bool DelAllSamples = false; // 刪除所有樣本
        private bool DelAllMarks = false;   // 刪除所有標示


        private TextBox[] unitText;   // 單位顯示欄位

        public SysConfig myConfig;   // 系統參數物件
        public PropJSON myProp;      // 辨識結果之JSON物件

        private List<PropImages.SingleHoleGrain> listSHG = new List<PropImages.SingleHoleGrain>();
        private List<PropImages.Powder> listPWD = new List<PropImages.Powder>();

        private List<PropGrinds> listPropGrinds = new List<PropGrinds>();

        private Rectangle SampleROI;

        private bool ApplyROIFaceDetection = false;

        public double PropUnit;  //使用單位
        public CircleF editCircle;  // 調整用 Circle 變數

        public int sampleThres; // 正面二質化參數
        public int sampleCannyT1; // 正面 Canny 參數1
        public int sampleCannyT2; // 正面 Canny 參數2

        public float pixLength;


        List<ICameraInfo> allCameras = CameraFinder.Enumerate(); // 相機列表

        private BaslerCamera mainCam; //取樣相機

        public bool mainCamOpened = false; //相機狀態

        public bool mainCamShoot = false;  //相機擷取影像

        public int takePicDelay=100;

        private SerialPort ComPort = new SerialPort(); //宣告一SerialPort物件為comport

        public bool isComPortOpened = false; // COM Port 連結狀態

        public bool PropTypeSelected = false;

        public bool PLCConnected = false;

        public string PropType; //藥柱代號

        public int operMode;   // 0: 單辨識   3:單研磨   1:全自動

        public string defUnit; // 預設單位

        public bool isOffline = false;

        public bool isUnitAdj = false;

        public bool isFirstLoad = false;

        public bool isCoated = false;

        public bool isPLCStartPressed = false;   //開始按鈕按下
        public bool isSamplingPressed = false;  //取樣按鈕按下
        public bool isReturnPressed = false;    //回歸取料按鈕按下
        public bool isReGrindPressed = false;   //再研磨按鈕按下
        public int reGrindCount = 0;            //再研磨次數

        public bool isPropTypeSelected = false; //發射藥型選擇;

        public Bitmap currBMP;

        public string PropClassify = string.Empty; // 藥型種類
                                                   // OHGC: 包面型單孔
                                                   // OHGN: 單孔
                                                   // PWDC: 包面型球藥
                                                   // PWDN: 球藥
                                                   // SHGN: 七孔藥柱

        /*************************************************************************************************************/
        /*************************************************************************************************************/
        /*-----------------------------------MODBUS通訊部分變數設定--------------------------------------------------*/
        /*************************************************************************************************************/
        /*************************************************************************************************************/

        ModbusSerialMaster master; //MODBUS通訊主端配置
        byte slaveID = 0x01; //從端設備編號

        ushort readPosition = 201;   //讀取照相位置  M接點
        ushort startChoice = 998;   //讀取寫入選擇類型 D接點
        int writeAddress = 251;     //寫入照相位置   M接點
        ushort readAction = 198;    //讀取動作位置   M接點
        ushort PLCStart = 100;    //開始自動作業   M接點
        int startcount = 0;       //拍照位置counter
        bool capReady = false;    //拍照完成旗標
        bool startFlag = false;    //拍照完成旗標
        bool polishReady = false;   //研磨完成旗標

        bool[] readPosition_coil;   //讀取粹盤暫存器陣列
        bool[] readAction_coil;     //讀取研磨作業陣列
        ushort[] reGrindCoil = new ushort[6] {288,289,290,291,292,293 };

        ushort X32 = 13362;             // 機台切換開關 X32 X33
                                        //               1   0   單辨識
                                        //               0   1   單研磨
                                        //               0   0   自動

        bool[] ReadXButtons = new bool[2];    // 讀取 X32 及 X33
        Dictionary<string, feedRate> prevFeedrate = new Dictionary<string, feedRate>();
        Dictionary<string, feedRate> factoryFeedrate = new Dictionary<string, feedRate>();
        Dictionary<string, feedContact> factoryFeedcontact = new Dictionary<string, feedContact>();



        /*************************************************************************************************************/
        /*************************************************************************************************************/
        /*************************************************************************************************************/
        /*************************************************************************************************************/
        string dataTime = DateTime.Now.ToString("yyyyMMdd");

        private int CurrentSample;  // 目前樣本
        //------------------------------------------------------------------------------------

        public Mainfrm()
        {
            InitializeComponent();

            mainCam = new BaslerCamera();    //新增攝影機

            ledProcess = new Label[4]    //機台運行狀態用 label array 取料站-粗磨站-細磨站-辨識站
            {lblProcess0,lblProcess1,lblProcess2,lblProcess3 };

            ledOperMode = new Label[4]
            {
                lblSingleGrind,lblAuto,null,lblNoGrind
            };
            CurrentSample = -1;

            ledSamplePath = new Label[36]
            {
                lbl01,lbl02,lbl03,lbl04,lbl05,lbl06,
                lbl07,lbl08,lbl09,lbl10,lbl11,lbl12,
                lbl13,lbl14,lbl15,lbl16,lbl17,lbl18,
                lbl19,lbl20,lbl21,lbl22,lbl23,lbl24,
                lbl25,lbl26,lbl27,lbl28,lbl29,lbl30,
                lbl31,lbl32,lbl33,lbl34,lbl35,lbl36
            };
            
        }
        public void loadFeedRate(string propType)
        {
            feedRate frTmp=prevFeedrate[propType];
            feedContact fcTmp=factoryFeedcontact[propType];

            ushort[] result;
            result = master.ReadHoldingRegisters(slaveID, (ushort) fcTmp.feedrcontact01, 1);
            txt_feedrate01_default.Text = ((double)result[0] / 100).ToString();

            result = master.ReadHoldingRegisters(slaveID, (ushort)fcTmp.feedrcontact02, 1);
            txt_feedrate02_default.Text = ((double)result[0] / 100).ToString();

            result = master.ReadHoldingRegisters(slaveID, (ushort)fcTmp.feedrcontact03, 1);
            txt_feedrate03_default.Text = ((double)result[0] / 100).ToString();

            result = master.ReadHoldingRegisters(slaveID, (ushort)fcTmp.feedccontact01, 1);
            txt_feedcount01_default.Text = ((int)result[0]).ToString();

            result = master.ReadHoldingRegisters(slaveID, (ushort)fcTmp.feedccontact02, 1);
            txt_feedcount02_default.Text = ((int)result[0]).ToString();

            result = master.ReadHoldingRegisters(slaveID, (ushort)fcTmp.feedccontact03, 1);
            txt_feedcount03_default.Text = ((int)result[0]).ToString();

            txt_feedrate01.Text = ((double)frTmp.feedrate01 / 100).ToString();
            txt_feedrate02.Text = ((double)frTmp.feedrate02 / 100).ToString();
            txt_feedrate03.Text = ((double)frTmp.feedrate03 / 100).ToString();

            txt_feedcount01.Text = frTmp.feedcount01.ToString();
            txt_feedcount02.Text = frTmp.feedcount02.ToString();
            txt_feedcount03.Text = frTmp.feedcount03.ToString();
        }


        private void toggleUnit(int type)
        {
            if (type == 0)
            {
                txt_hole_rad_unit.Text = "mm";
                txt_cont_dia_unit.Text = "mm";
                txt_pixel_length_unit.Text = "mm";
                txt_2p_measure_unit.Text = "mm";
                txt_enclose_area_unit.Text = "mm²";
                txt_area_unit.Text = "mm²";
                txt_base_area_unit.Text = "mm²";
            }
            else
            {
                txt_hole_rad_unit.Text = "inch";
                txt_cont_dia_unit.Text = "inch";
                txt_pixel_length_unit.Text = "inch";
                txt_2p_measure_unit.Text = "inch";
                txt_enclose_area_unit.Text = "inch²";
                txt_area_unit.Text = "inch²";
                txt_base_area_unit.Text = "inch²";
            }
        }
        private void updateSampleCnt()
        {
            //textBox_sample_count.Text = (CurrentSample + 1).ToString() + "/" + .Count.ToString();
        }

        private void loadConfig(string JsonFName)
        {
            StreamReader r = new StreamReader(JsonFName);
            string jStr = r.ReadToEnd();
            myConfig= JsonConvert.DeserializeObject<SysConfig>(jStr);
            r.Close();
            pixLength = myConfig.pixLength;
            tb_threshold.Value = myConfig.fixedThres;
            txt_threshold.Text = myConfig.fixedThres.ToString();

            textBox_Cam.Text = myConfig.cam;

            defUnit = myConfig.defUnit;
            if (defUnit == "mm")
                rad_unit_mm.Checked = true;
            else
                rad_unit_inch.Checked = true;
            SampleROI = new Rectangle(myConfig.mROI.X, myConfig.mROI.Y, myConfig.mROI.width, myConfig.mROI.height);
            foreach(feedRate fr in myConfig.PrevFRates)
            {
                prevFeedrate.Add(fr.typeCode, fr);
            }
            foreach (feedRate fr in myConfig.FactFRates)
            {
                factoryFeedrate.Add(fr.typeCode, fr);
            }
            foreach (feedContact fc in myConfig.FactContacts)
            {
                factoryFeedcontact.Add(fc.typeCode, fc);
            }
        }
        private void loadSamples(int currentSample)
        {
            /*Bitmap tempBmp;
            if (currentSample>=0)
            {
                for (int i=0;i < operMode+1; i++)
                {
                    tempBmp = ResizeBitmap(PropSamples[currentSample].SrcImage[i].ToBitmap(), 400, 400);
                    PBFaceImgs[i,0].Image = tempBmp;
                    if (PropSamples[currentSample].FacePropStatus[i] == 0)
                    {
                        tempBmp = ResizeBitmap(PropSamples[currentSample].ThresImage[i].ToBitmap(), 400, 400);
                    }
                    else
                    {
                        PropSamples[currentSample].MarkFaceImage(i, 2, 0);
                        tempBmp = ResizeBitmap(PropSamples[currentSample].TempFaceImage.ToBitmap(), 400, 400);
                    }
                    PBFaceImgs[i,1].Image = tempBmp;
                    for(int j=0;j<4;j++)
                    {
                        tempBmp= ResizeBitmap(PropSamples[currentSample].SideSrcImage[i, j].ToBitmap(), 200, 200);
                        PBSideImgs[i, j, 0].Image = tempBmp;
                        if (PropSamples[currentSample].SidePropStatus[i] == 0)
                        {
                            tempBmp = ResizeBitmap(PropSamples[currentSample].SideThresImage[i, j].ToBitmap(), 200, 200);
                        }
                        else
                        {
                            PropSamples[currentSample].MarkSideImage(i, j, 0);
                            tempBmp = ResizeBitmap(PropSamples[currentSample].TempSideImage[j].ToBitmap(), 200, 200);
                        }
                        PBSideImgs[i, j, 1].Image = tempBmp;
                    }
                }
                textBox_sample_count.Text = (CurrentSample + 1).ToString() + "/" + PropSamples.Count.ToString();
            }*/
        }
        private void loadOneSamples(int currentSample, int currentPage)
        {
            /*if (currentSample == -1) return;
            Bitmap tempBmp;
            tempBmp = ResizeBitmap(PropSamples[currentSample].SrcImage[currentPage].ToBitmap(), 400, 400);
            tabControl_Original_Images.SelectedIndex = currentPage;
            PBFaceImgs[currentPage, 0].Image = tempBmp;
            if (PropSamples[currentSample].FacePropStatus[currentPage]==0)
            {
                tempBmp = ResizeBitmap(PropSamples[currentSample].ThresImage[currentPage].ToBitmap(), 400, 400);
            }
            else
            {
                PropSamples[currentSample].MarkFaceImage(currentPage, 2, 1);
                tempBmp = ResizeBitmap(PropSamples[currentSample].TempFaceImage.ToBitmap(), 400, 400);
            }

            PBFaceImgs[currentPage, 1].Image = tempBmp;
            for (int j = 0; j < 4; j++)
            {
                tempBmp = ResizeBitmap(PropSamples[currentSample].SideSrcImage[currentPage, j].ToBitmap(), 200, 200);
                PBSideImgs[currentPage, j, 0].Image = tempBmp;
                if(PropSamples[currentSample].SidePropStatus[currentPage]==0)
                {
                    tempBmp = ResizeBitmap(PropSamples[currentSample].SideThresImage[currentPage, j].ToBitmap(), 200, 200);
                }
                else
                {
                    PropSamples[currentSample].MarkSideImage(currentPage, j, 1);
                    tempBmp = ResizeBitmap(PropSamples[currentSample].TempSideImage[j].ToBitmap(), 200, 200);
                }

                PBSideImgs[currentPage, j, 1].Image = tempBmp;
            }
            textBox_sample_count.Text = (CurrentSample+1).ToString() + "/" + PropSamples.Count.ToString();*/
        }

        private void updateInitUI()
        {
            bool enInit = true;
            if (!mainCam.isOpened)
                enInit = false;
            if (!isComPortOpened)
                enInit = false;
            if (!isPropTypeSelected)
                enInit = false;

            if (enInit)
                btn_plc_start.Enabled = true;

        }
        private void openCam(BaslerCamera cam, string camID, string conFN)
        {
            try
            {
                ICameraInfo selectedCamera = findCameraInfo(camID);
                if (selectedCamera != null)
                {
                    cam.CameraInit(selectedCamera, conFN);
                    cam.isOpened = true;
                    cam.KeepShot();
                    updateInitUI();
                }
                else
                    MessageBox.Show(camID + "-相機未連結");
            }
            catch (Exception except)
            {
                MessageBox.Show("Exception caught:\n" + except.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeCam(BaslerCamera cam)
        {
            try
            {

                cam.Stop();
                cam.DestroyCamera();
            }
            catch (Exception except)
            {
                MessageBox.Show("Exception caught:\n" + except.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private ICameraInfo findCameraInfo(string cname)
        {
            foreach (ICameraInfo cameraInfo in allCameras)
            {
                // Create the item to display.
                if (cameraInfo[CameraInfoKey.FriendlyName] == cname)
                    return cameraInfo;
            }
            return null;
        }

        private void Camera_CameraImageEvent(Bitmap bmp)
        {
            if (isOffline) return;
            currBMP = bmp;
            Bitmap temp = bmp.Clone(SampleROI, bmp.PixelFormat);
            if (mainCamShoot)
            {
                mainCamShoot = false;
                SingleHoleGrain stmp;
                Powder ptmp;
                PropGrinds pgrind;
                switch(PropClassify)
                {
                    case "OHGC":
                        stmp = new SingleHoleGrain(PropType, temp, true);
                        pgrind = new PropGrinds(stmp,true);
                        listPropGrinds.Add(pgrind);
                        break;
                    case "OHGN":
                        stmp = new SingleHoleGrain(PropType, temp, false);
                        pgrind = new PropGrinds(stmp, false);
                        listPropGrinds.Add(pgrind);
                        break;
                    case "PWDC":
                        ptmp =new Powder(PropType, temp);
                        pgrind = new PropGrinds(ptmp);
                        listPropGrinds.Add(pgrind);
                        break;
                }
                ob_origin.Image = ImageUtil.ResizeBitmap(temp, 500, 500);
            }
            Bitmap temp1 = ImageUtil.ResizeBitmap(temp, 300, 300);
            picBoxCam.Invoke(new MethodInvoker(delegate
            {
                Bitmap old = picBoxCam.Image as Bitmap;
                picBoxCam.Image = temp1;
                //ob_origin.Image = temp2;
                if (old != null)
                    old.Dispose();
            }));
        }


        //視窗功能部分---------------------------------------------------------------------
        private void end_btn_Click(object sender, EventArgs e)
        {
            //camH.DestroyCamera();
            //camV.DestroyCamera();
            this.Close();
            Application.Exit();
        }

        private void minus_Click(object sender, EventArgs e)
        {
            //縮小至工作列
            this.WindowState = FormWindowState.Minimized;        //決定視窗大小
            this.ShowInTaskbar = true;                           //決定是否出現在工作列

        }
        private void Mainfrm_Load(object sender, EventArgs e)
        {
            Timer_system.Interval = 100;
            Timer_system.Enabled = true;

            Blink_timer.Interval = 200;
            Blink_timer.Enabled = true;

            PropType = "";

            loadConfig("./config/sysconfig.json");
            txt_config.Text = "./config/sysconfig.json";
            txt_sample_dir.Text = myConfig.workiDir;
            ResetUI();
        }
        public void ResetUI()
        {
            cboProType.SelectedIndex = -1;
            cboProType.Text = "";

            txt_feedrate01.Text = "0.00";
            txt_feedrate02.Text = "0.00";
            txt_feedrate03.Text = "0.00";

            txt_feedrate01_default.Text = "0.00";
            txt_feedrate02_default.Text = "0.00";
            txt_feedrate03_default.Text = "0.00";

            txt_feedcount01.Text = "00";
            txt_feedcount02.Text = "00";
            txt_feedcount03.Text = "00";

            txt_feedcount01_default.Text = "00";
            txt_feedcount02_default.Text = "00";
            txt_feedcount03_default.Text = "00";

            txt_grindcount.Text = "0";
        }
        private void changeUnit(string dUnit)
        {
            float ratio;
            if (dUnit == "mm")
                ratio = (float)(25.4);
            else
                ratio = (float)(1 / 25.4);

        }
        void ToggleSWwithLed(Button swBtn, Label swLed, bool stat)
        {
            if (stat)
            {
                swBtn.Image = Properties.Resources.toggle_on;
                swLed.Text = "ON";
                swLed.BackColor = Color.Green;
            }
            else
            {
                swBtn.Image = Properties.Resources.toggle_off;
                swLed.Text = "OFF";
                swLed.BackColor = Color.Red;
            }
        }
        void ToggleLed(Label swLed, bool stat)
        {
            if (stat)
            {
                swLed.Text = "ON";
                swLed.BackColor = Color.Green;
            }
            else
            {
                swLed.Text = "OFF";
                swLed.BackColor = Color.Red;
            }
        }


        private void initVars()
        {
            /* CycleCount = 0;
             RotationCount = 0;
             CurrentSample = -1;
             CurrentPage = 0;
             PropSamples.Clear();
             textBox_sample_count.Text = "--";
             clearAll();
             updateInitUI();
             ApplyROIFaceDetection = false;*/
        }

        /*private void gswPropType_Click(object sender, EventArgs e)
        {
              if (lblProTypeStatus.Text=="ON")
              {
                PropTypeSelected = false;
                ToggleSWwithLed(gswPropType, lblProTypeStatus, false);             
                master.WriteSingleRegister(slaveID, startChoice, 0);
              }
              else
              {
                PropTypeSelected = true;
                ToggleSWwithLed(gswPropType, lblProTypeStatus, true);
                switch (cboProType.SelectedIndex)
                  {
                    case 0:
                        master.WriteSingleRegister(slaveID, startChoice, 1); 
                        PropType = "B1";
                        break;
                    case 1:
                        master.WriteSingleRegister(slaveID, startChoice, 2); 
                        PropType = "B2";
                        break;
                    case 2:
                        master.WriteSingleRegister(slaveID, startChoice, 3); 
                        PropType = "B3";
                        break;
                    case 3:
                        master.WriteSingleRegister(slaveID, startChoice, 4);
                        PropType = "B4";
                        break;
                    case 4:
                        master.WriteSingleRegister(slaveID, startChoice, 5);
                        PropType = "B5";
                        break;
                    case 5:
                        master.WriteSingleRegister(slaveID, startChoice, 6);
                        PropType = "C1";
                        break;
                    case 6:
                        master.WriteSingleRegister(slaveID, startChoice, 7);
                        PropType = "C2";
                        break;
                }
              }

              updateInitUI();
        }*/

        private void button_Save_Click(object sender, EventArgs e)
        {
            /*     if (textBox_working_dir.Text != "")
                 {
                     string str = chkCompleted(operMode);
                     if (str!="")
                     {
                         MessageBox.Show(str);
                         return;
                     }
                     saveSamples(operMode);*/
        }
    
        private async void SoftBlink(Control ctrl, Color c1, Color c2, short CycleTime_ms, bool BkClr)
        {
            var sw = new Stopwatch(); sw.Start();
            short halfCycle = (short)Math.Round(CycleTime_ms * 0.5);
            while (true)
            {
                await Task.Delay(1);
                var n = sw.ElapsedMilliseconds % CycleTime_ms;
                var per = (double)Math.Abs(n - halfCycle) / halfCycle;
                var red = (short)Math.Round((c2.R - c1.R) * per) + c1.R;
                var grn = (short)Math.Round((c2.G - c1.G) * per) + c1.G;
                var blw = (short)Math.Round((c2.B - c1.B) * per) + c1.B;
                var clr = Color.FromArgb(red, grn, blw);
                if (BkClr) ctrl.BackColor = clr; else ctrl.ForeColor = clr;
            }
        }
        private void saveSamples(int opermode)
        {
            /*string fileDir;
            string sfile1;
            string sfile2;
            String nowStr = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            PropJSON tmpJSON = new PropJSON();
            tmpJSON.PropType = PropType;
            tmpJSON.Opermode = operMode;
            tmpJSON.Timestamp = nowStr;
            tmpJSON.defUnit = defUnit;
            tmpJSON.FaceUnit = (float)faceUnit;
            tmpJSON.SideUnit = (float)sideUnit;
            tmpJSON.PImages = new List<PImage>();
            PImage tmpPImage;
            SimpleC simC;
            List<SimpleC> lSimC;
            List<float> lens;
            List<string> lSideImg;
            List<float> lSmallDi;
            List<float> lWi;
            List<float> lWo;
            List<int> HLItems;
            List<List<int>> ListHLItems;

            string opStr="";

            switch (operMode)
            {
                case 0:
                    opStr = "\\nocut\\";
                    break;
                case 1:
                    opStr = "\\onecut\\";
                    break;
                case 3:
                    opStr = "\\fullcut\\";
                    break;
            }

            fileDir = textBox_working_dir.Text + opStr + PropType + "\\" + nowStr;
            if (!Directory.Exists(fileDir))
            {
                Directory.CreateDirectory(fileDir);
            }
            for (int i = 0; i < PropSamples.Count; i++)
            {
                if (PropSamples[i].chkValid())
                {
                    tmpPImage = new PImage();
                    tmpPImage.BigC = new List<SimpleC>();
                    tmpPImage.SmallC = new List<List<SimpleC>>();
                    tmpPImage.SmallDiamter = new List<List<float>>();
                    tmpPImage.Wi = new List<List<float>>();
                    tmpPImage.Wo = new List<List<float>>();
                    tmpPImage.SrcImage = new List<string>();

                    tmpPImage.Length = new List<List<float>>();
                    tmpPImage.SideSrcImage = new List<List<string>>();
                    tmpPImage.HLineY = new List<List<List<int>>>();

                    tmpPImage.BigDiameter = new List<float>();
                    tmpPImage.SmallDiamterAvg = new List<float>();
                    tmpPImage.WiAvg = new List<float>();
                    tmpPImage.WoAvg = new List<float>();
                    tmpPImage.LengthAvg = new List<float>();
                    tmpPImage.DOverd = new List<float>();
                    tmpPImage.LenOverD = new List<float>();

                    for (int j = 0; j < opermode + 1; j++)
                    {
                        simC = new SimpleC();
                        simC.X = (int)PropSamples[i].BigC[j].Center.X;
                        simC.Y = (int)PropSamples[i].BigC[j].Center.Y;
                        simC.Radius = (int)PropSamples[i].BigC[j].Radius;
                        tmpPImage.BigC.Add(simC);
                        lSimC=new List<SimpleC>();
                        lSmallDi = new List<float>();
                        lWi = new List<float>();
                        lWo = new List<float>();
                        for (int k = 0; k < 7; k++)
                        {
                            simC = new SimpleC();
                            simC.X = (int)PropSamples[i].SmallC[j,k].Center.X;
                            simC.Y = (int)PropSamples[i].SmallC[j,k].Center.Y;
                            simC.Radius = (int)PropSamples[i].SmallC[j,k].Radius;
                            lSimC.Add(simC);

                            lSmallDi.Add(PropSamples[i].SmallDiamter[j, k]);
                            lWi.Add(PropSamples[i].Wi[j, k]);
                            lWo.Add(PropSamples[i].Wo[j, k]);
                        }

                        tmpPImage.SmallC.Add(lSimC);
                        tmpPImage.SmallDiamter.Add(lSmallDi);
                        tmpPImage.Wi.Add(lWi);
                        tmpPImage.Wo.Add(lWo);

                        sfile1 = fileDir + "\\" + i.ToString() + "_cut" + j.ToString() + ".bmp";
                        PropSamples[i].SrcImage[j].Save(sfile1);

                        tmpPImage.SrcImage.Add(sfile1);

                        lens = new List<float>();
                        lSideImg = new List<string>();
                        ListHLItems = new List<List<int>>();

                        for (int k = 0; k < 4; k++)
                        {
                            lens.Add(PropSamples[i].Length[j, k]);
                            sfile2 = fileDir + "\\" + i.ToString() + "_cut" + j.ToString() + "_S" + k.ToString() + ".bmp";
                            PropSamples[i].SideSrcImage[j, k].Save(sfile2);
                            lSideImg.Add(sfile2);
                            HLItems = new List<int>();
                            HLItems.Add(PropSamples[i].HLineY[j, k, 0]);
                            HLItems.Add(PropSamples[i].HLineY[j, k, 1]);
                            ListHLItems.Add(HLItems);
                        }
                        tmpPImage.Length.Add(lens);

                        tmpPImage.SideSrcImage.Add(lSideImg);

                        tmpPImage.SmallDiamter.Add(lSmallDi);

                        tmpPImage.HLineY.Add(ListHLItems);                        

                        tmpPImage.BigDiameter.Add(PropSamples[i].BigDiameter[j]);

                        tmpPImage.SmallDiamterAvg.Add(PropSamples[i].SmallDiamterAvg[j]);

                        tmpPImage.WiAvg.Add(PropSamples[i].WiAvg[j]);

                        tmpPImage.WoAvg.Add(PropSamples[i].WoAvg[j]);

                        tmpPImage.LengthAvg.Add(PropSamples[i].LengthAvg[j]);

                        tmpPImage.DOverd.Add(PropSamples[i].DOverd[j]);
                        tmpPImage.LenOverD.Add(PropSamples[i].LenOverD[j]);

                        tmpPImage.FaceUnit = (float)faceUnit;
                        tmpPImage.SideUnit = (float)sideUnit;

                        tmpPImage.defUnit = defUnit;
                    }
                    tmpJSON.PImages.Add(tmpPImage);                    
                }
            }
            StreamWriter file = File.CreateText(fileDir+"\\result.json");
            JsonSerializer serializer = new JsonSerializer();
            serializer.Serialize(file, tmpJSON);
            file.Close();
            richTextBox_logs.Text += DateTime.Now.ToString("HH:mm:ss")+"-完成儲存結果至" +fileDir+"\n";*/
        }
        private void Timer_system_Tick(object sender, EventArgs e)
        {
            label_time.Text = DateTime.Now.ToString("yyyy / MM / dd  HH:mm:ss");
        }
        private void button_face_unit_adj_Click(object sender, EventArgs e)
        {
            /*if (PropSamples.Count == 0) return;
            frmAdjCircle myAdjfrm= new frmAdjCircle();
            myAdjfrm.Owner = this;
            PropSamples[0].GetFaceFeats(0, 1,30);
            myAdjfrm.cir = PropSamples[0].BigC[0];
            myAdjfrm.baseImage = PropSamples[0].SrcImage[0];
            myAdjfrm.opmode = 1;
            if (textBox_face_unit.Text !="")
            {
                TextBox unitBox = (TextBox)myAdjfrm.Controls.Find("textBox_Unit", true)[0];
                unitBox.Text = textBox_face_unit.Text.ToString();
            }
            if (myAdjfrm.ShowDialog() == DialogResult.OK)
            {
                textBox_face_unit.Text = faceUnit.ToString();
                PropSamples[0].BigC[0] = editCircle;
                PropSamples[0].MarkFaceImage(0, 1, 0);
                DispFaceColorSingleImage(PropSamples[0].TempFaceImage, 0, 1);
            }*/
        }

        private void mainPanel(bool activated)
        {
            /*if(activated)
            {
                tabControl_Original_Images.Enabled = true;
                tabControl_Result_Images.Enabled = true;
                button_all_auto.Enabled = true;
                button_recogn.Enabled = true;
                button_side_length.Enabled = true;
                Button_abandon.Enabled = true;
                button_prev.Enabled = true;
                button_reset.Enabled = true;
                button_next.Enabled = true;
                button_Save.Enabled = true;
                Button_save_report.Enabled = true;
                xuiButton_Rotate.Enabled = true;
                button_BigC_adj.Enabled = true;
                for(int i=0;i<7;i++)
                {
                    BSmallcEdit[i].Enabled = true;
                }
                for(int i=0;i<4;i++)
                {
                    BLength[i].Enabled = true;
                }
            }
            else
            {
                tabControl_Original_Images.Enabled = false;
                tabControl_Result_Images.Enabled = false;
                button_all_auto.Enabled = false;
                button_recogn.Enabled = false;
                button_side_length.Enabled = false;
                Button_abandon.Enabled = false;
                button_prev.Enabled = false;
                button_reset.Enabled = false;
                button_next.Enabled = false;
                button_Save.Enabled = false;
                Button_save_report.Enabled = false;
                xuiButton_Rotate.Enabled = false;
                button_BigC_adj.Enabled = false;
                for (int i = 0; i < 7; i++)
                {
                    BSmallcEdit[i].Enabled = false;
                }
                for (int i = 0; i < 4; i++)
                {
                    BLength[i].Enabled = false;
                }
            }*/
        }
        private void button_recogn_Click(object sender, EventArgs e)
        {

        }


        private void Button_load_config_Click(object sender, EventArgs e)
        {
            loadConfig("./config/sysconfig.json");
        }

        private void trackBar_face_threshold_ValueChanged(object sender, EventArgs e)
        {
            /*textBox_face_Threshold.Text = trackBar_face_threshold.Value.ToString();
            myconfig.faceThres = trackBar_face_threshold.Value;
            if (CurrentSample == -1) return;
            if (PropSamples[CurrentSample].FacePropStatus[CurrentPage]==0)
            {
                PropSamples[CurrentSample].setThreshold(1, trackBar_face_threshold.Value,CurrentPage);
                DispFaceGraySingleImage(PropSamples[CurrentSample].ThresImage[CurrentPage], CurrentPage, 1);
            }*/
        }

        private void textBox_face_Threshold_TextChanged(object sender, EventArgs e)
        {

            /*trackBar_face_threshold.Value=int.Parse(textBox_face_Threshold.Text);
            myconfig.faceThres = trackBar_face_threshold.Value;
            if (CurrentSample == -1) return;
            if (PropSamples[CurrentSample].FacePropStatus[CurrentPage] == 0)
            {
                PropSamples[CurrentSample].setThreshold(1, trackBar_face_threshold.Value, CurrentPage);
                DispFaceGraySingleImage(PropSamples[CurrentSample].ThresImage[CurrentPage], CurrentPage, 1);
            }*/
        }

        private void trackBar_side_threshold_ValueChanged(object sender, EventArgs e)
        {
            /*textBox_side_Threshold.Text = trackBar_side_threshold.Value.ToString();
            myconfig.sideThres = trackBar_side_threshold.Value;
            if (CurrentSample == -1) return;
            if (PropSamples[CurrentSample].SidePropStatus[CurrentPage] == 0)
            {
                for(int i=0;i<4;i++)
                {
                    PropSamples[CurrentSample].setThreshold(2, trackBar_side_threshold.Value, CurrentPage,i);
                    DispSideGraySingleImage(PropSamples[CurrentSample].SideThresImage[CurrentPage,i], CurrentPage,i, 1);
                }
            }*/
        }

        private void textBox_side_Threshold_TextChanged(object sender, EventArgs e)
        {
            /*trackBar_side_threshold.Value = int.Parse(textBox_side_Threshold.Text);
            myconfig.sideThres = trackBar_side_threshold.Value;
            if (CurrentSample == -1) return;
            if (PropSamples[CurrentSample].SidePropStatus[CurrentPage] == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    PropSamples[CurrentSample].setThreshold(2, trackBar_side_threshold.Value, CurrentPage, i);
                    DispSideGraySingleImage(PropSamples[CurrentSample].SideThresImage[CurrentPage, i], CurrentPage, i, 1);
                }
            }*/
        }

        private void Button_save_config_Click(object sender, EventArgs e)
        {

            /*      StreamWriter file = File.CreateText(@"./config/sysconfig.json");
                  JsonSerializer serializer = new JsonSerializer();
                  myconfig.sideUnit = (float)sideUnit;
                  myconfig.faceUnit = (float)faceUnit;
                  myconfig.defUnit = defUnit;
                  serializer.Serialize(file, myconfig);
                  file.Close();*/
        }

        private void textBox_face_unit_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_side_unit_TextChanged(object sender, EventArgs e)
        {

        }



        private void button_images_selector_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog_working_dir.ShowDialog() == DialogResult.OK)
            {
                txt_sample_dir.Text = folderBrowserDialog_working_dir.SelectedPath;
                myConfig.workiDir = txt_sample_dir.Text;
            }
        }

        public void ComPort_init()
        {
            isComPortOpened = false;
            cboComPort.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("Select * From Win32_SerialPort");
            string[] com = new string[10];
            int i = 0;
            foreach (ManagementObject port in searcher.Get())
            {
                string name = port.GetPropertyValue("DeviceID").ToString();
                string description = port.GetPropertyValue("Caption").ToString();
                cboComPort.Items.Add(description);
                com[i] = name;
                i++;
            }
        }

        private void button_comport_sw_Click(object sender, EventArgs e)
        {
            if (isComPortOpened)
            {
                isComPortOpened = false;
                ToggleSWwithLed(gswComport, lblComPortStatus, isComPortOpened);
                cboComPort.Enabled = true;
                if (PropTypeSelected) PropTypeSelected = false;
                ComPort.Close();
                cboComPort.Text = "";
                for (int i = 0; i < 2; i++) ledOperMode[operMode].BackColor = Color.Red;
                cboProType.Enabled = false;
                btn_plc_start.Enabled = false;
                initVars();
            }
            else
            {
                if (cboComPort.Text != "")
                {
                  String com = cboComPort.Text;
                  try
                  {
                      ComPort = new SerialPort(ComName(com), 9600, Parity.None, 8, StopBits.One);
                      ComPort.ReadTimeout = 1000;
                      ComPort.Open();
                      master = ModbusSerialMaster.CreateRtu(ComPort); //設置Modbus RTU連結
                      ReadXButtons = master.ReadInputs(slaveID, X32, 2);
                      if (!ReadXButtons[0])
                      {
                          if (!ReadXButtons[1])
                          {
                              operMode = 3; // 單辨識
                          }
                          else
                          {
                              operMode = 1; // 自動
                          }
                      }
                      else
                      {
                          operMode = 0; // 單研磨
                      }
                      ledOperMode[operMode].BackColor = Color.Green;
                      BeginWork(); //啟用非同步流程
                      isComPortOpened = true;
                      ToggleSWwithLed(gswComport, lblComPortStatus, isComPortOpened);
                      cboComPort.Enabled = false;
                      cboProType.Enabled = true;

                      updateInitUI();
                  }
                  catch (ArgumentException ex)
                  {
                      ComPort.Close();
                      //ComClose_Component(true);
                  }
                  catch (UnauthorizedAccessException ex)
                  {
                      ComPort.Close();
                      //ComClose_Component(true);
                  }
              }
          }
        }

        private void comboBox_comport_Click(object sender, EventArgs e)
        {
            isComPortOpened = false;
            cboComPort.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("Select * From Win32_SerialPort");
            string[] com = new string[10];
            int i = 0;
            foreach (ManagementObject port in searcher.Get())
            {
                string name = port.GetPropertyValue("DeviceID").ToString();
                string description = port.GetPropertyValue("Caption").ToString();
                cboComPort.Items.Add(description);
                com[i] = name;
                i++;
            }
            foreach (string port in ports)
            {
                foreach (string coms in com)
                {
                    if (port == coms)
                    {
                        isComPortOpened = true;
                        continue;
                    }
                }
                if (!isComPortOpened) cboComPort.Items.Add(port);
                else isComPortOpened = false;
            }
        }


        private string ComName(string name) //調整comport(連接埠)名稱並回傳
        {
            if (name.IndexOf('(', 0, name.Length) != -1)
            {
                string[] com = name.Split('(');
                name = "";
                name += com[1];
                return name.Substring(0, name.Length - 1);
            }
            else
                return name;
        }


        private void button_prev_Click(object sender, EventArgs e)
        {
            if(listPropGrinds.Count>0)
            {
                if (CurrentSample > 0)
                {
                    CurrentSample--;
                    dispCurrentSample(CurrentSample);
                }
            }
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            if (listPropGrinds.Count > 0)
            {
                if (CurrentSample < listPropGrinds.Count-1)
                {
                    CurrentSample++;
                    dispCurrentSample(CurrentSample);
                }
            }
        }

        private void dispCurrentSample(int Curr)
        {
            PropGrinds tmpG = listPropGrinds[Curr];
            if(PropClassify=="PWDC")
            {
                List<Powder> lstPD = tmpG.getPWDCList();
                ob_origin.Image = ImageUtil.ResizeBitmap(lstPD[0].SrcImg, 500, 500); 
            }
            else
            {
                List<SingleHoleGrain> lstshg = tmpG.getOHGCList();
                ob_origin.Image = ImageUtil.ResizeBitmap(lstshg[0].SrcImg, 500, 500);
            }

            textBox_sample_count.Text = (CurrentSample + 1).ToString() + "/" + listPropGrinds.Count.ToString();
        }

        private void cboProType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProType.Text == "") return;
            if (cboProType.Text != "無")
            {
                btn_factory_reset.Enabled = true;

                txt_feedrate01.Enabled = true;
                txt_feedrate02.Enabled = true;
                txt_feedrate03.Enabled = true;

                txt_feedcount01.Enabled = true;
                txt_feedcount02.Enabled = true;
                txt_feedcount03.Enabled = true;

                btn_feed01.Enabled = true;
                btn_feed02.Enabled = true;
                btn_feed03.Enabled = true;

                isPropTypeSelected = true;
                updateInitUI();

                switch (cboProType.SelectedIndex)
                {
                    case 1:
                        master.WriteSingleRegister(slaveID, startChoice, 1);
                        PropType = "B1";
                        PropClassify = "OHGC";
                        break;
                    case 2:
                        master.WriteSingleRegister(slaveID, startChoice, 2);
                        PropType = "B2";
                        PropClassify = "OHGC";
                        break;
                    case 3:
                        master.WriteSingleRegister(slaveID, startChoice, 3);
                        PropType = "B3";
                        PropClassify = "OHGC";
                        break;
                    case 4:
                        master.WriteSingleRegister(slaveID, startChoice, 4);
                        PropType = "B4";
                        PropClassify = "OHGC";
                        break;
                    case 5:
                        master.WriteSingleRegister(slaveID, startChoice, 5);
                        PropType = "B5";
                        PropClassify = "OHGC";
                        break;
                    case 6:
                        master.WriteSingleRegister(slaveID, startChoice, 6);
                        PropType = "C1"; 
                        PropClassify = "PWDC";
                        break;
                    case 7:
                        master.WriteSingleRegister(slaveID, startChoice, 7);
                        PropType = "C2";
                        PropClassify = "PWDC";
                        break;
                }
                loadFeedRate(PropType);
            }
            else
            {
                isPropTypeSelected = false;
                PropType = "";
                PropClassify = "";
                master.WriteSingleRegister(slaveID, startChoice, 0);
            }

        }

        private void Button_abandon_Click(object sender, EventArgs e)
        {


        }

        private void button_reset_Click(object sender, EventArgs e)
        {

        }

        private void button_offline_Click(object sender, EventArgs e)
        {

        }

        private void label_time_TextChanged(object sender, EventArgs e)
        {
            if (isOffline)
            {
                label_time.ForeColor = Color.Black;
                label_time.BackColor = Color.Yellow;
            }
            else
            {
                if (isUnitAdj)
                {
                    label_time.ForeColor = Color.White;
                    label_time.BackColor = Color.Teal;
                }
                else
                {
                    label_time.ForeColor = Color.White;
                    label_time.BackColor = Color.DimGray;
                }
            }
        }

        private void button_all_auto_Click(object sender, EventArgs e)
        {

        }

        private void button_load_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog_load.ShowDialog() == DialogResult.OK)
            {


            }
        }


        private void button_unit_adj_Click(object sender, EventArgs e)
        {
        }

        private void Button_Load_Images_Click(object sender, EventArgs e)
        {
            /*   if (textBox_load_target.Text == "")
               {
                   MessageBox.Show("請選擇輸入目錄");
                   return;
               }
               if (!File.Exists(textBox_load_target.Text + "\\result.json"))
               {
                   MessageBox.Show("請選擇目錄中沒有資料檔，請重新選擇!");
                   return;
               }
               richTextBox_logs.Text += DateTime.Now.ToString("HH:mm:ss") + "-從"+textBox_load_target.Text + "\\result.json載入\n";
               StreamReader r = new StreamReader(textBox_load_target.Text + "\\result.json");
               string jStr = r.ReadToEnd();
               myProp = JsonConvert.DeserializeObject<PropJSON>(jStr);
               r.Close();

               if (PropSamples.Count == 0)
               {
                   string notify="";
                   operMode = myProp.Opermode;
                   switch (operMode)
                   {
                       case 0:
                           notify="模式：單辨識";
                           break;
                       case 1:
                           notify = "模式：單切削";
                           break;
                       case 3:
                           notify = "模式：全自動";
                           break;
                   } 

                   PropType = myProp.PropType;
                   defUnit = myProp.defUnit;
                   if (defUnit == "mm")
                       button_mm.Checked = true;
                   else
                       button_inch.Checked = true;

                   toggleUnit(defUnit);
                   textBox_face_unit.Text = Math.Round(myProp.FaceUnit, 4).ToString();
                   textBox_side_unit.Text = Math.Round(myProp.SideUnit, 4).ToString();
                   faceUnit = myProp.FaceUnit;
                   sideUnit = myProp.SideUnit;

                   notify = notify + " 藥型：" + PropType;
                   label_Title.Text = label_Title.Text + " " + notify;
                   isFirstLoad = true;
               }
               else
               {
                   if (operMode != myProp.Opermode)
                   {
                       MessageBox.Show("目錄中資料檔與現有樣本工作模式不符，請重新選擇!");
                       return;
                   }
                   if (PropType!=myProp.PropType)
                   {
                       MessageBox.Show("目錄中資料檔與現有樣本藥型種類不符，請重新選擇!");
                       return;
                   }
                   if (defUnit != myProp.defUnit)
                   {
                       MessageBox.Show("目錄中資料檔與現有樣本單位不符，請重新選擇!");
                       return;
                   }
                   isFirstLoad = false;
               }
               List<PImage> LPImages = new List<PImage>();
               LPImages = myProp.PImages;
               PropImage tmpProp;
               foreach(PImage currPImage in LPImages)
               {
                   tmpProp = new PropImage(PropType, currPImage.FaceUnit, currPImage.SideUnit, operMode);
                   List<SimpleC> LBigC = currPImage.BigC;
                   List<List<SimpleC>> LLSmallC = currPImage.SmallC; 
                   List<List<float>> LLLen = currPImage.Length;
                   List<List<string>> LLSideSrcImage = currPImage.SideSrcImage;
                   List<List<float>> LLSmallDiamter = currPImage.SmallDiamter;
                   List<List<float>> LLWi = currPImage.Wi;
                   List<List<float>> LLWo = currPImage.Wo;
                   List<List<List<int>>> LLLHLineY = currPImage.HLineY;
                   tmpProp.faceThres = trackBar_face_threshold.Value;
                   tmpProp.sideThres = trackBar_side_threshold.Value;
                   tmpProp.defUnit = defUnit;

                   for (int i=0;i<operMode+1;i++)
                   {
                       tmpProp.BigC[i] = new CircleF(Point2PointF(new Point(LBigC[i].X, LBigC[i].Y)), (float)LBigC[i].Radius);

                       tmpProp.AddFaceImage(currPImage.SrcImage[i], i);
                       tmpProp.ResetFaceImage(i);

                       tmpProp.BigDiameter[i] = currPImage.BigDiameter[i];

                       tmpProp.SmallDiamterAvg[i] = currPImage.SmallDiamterAvg[i];

                       tmpProp.WiAvg[i] = currPImage.WiAvg[i];

                       tmpProp.WoAvg[i] = currPImage.WoAvg[i];

                       tmpProp.LengthAvg[i] = currPImage.LengthAvg[i];

                       tmpProp.DOverd[i] = currPImage.DOverd[i];

                       tmpProp.LenOverD[i] = currPImage.LenOverD[i];

                       List<SimpleC> LSmallC = currPImage.SmallC[i];
                       List<CircleF> LSmallCTarget = new List<CircleF>();
                       List<float> LSmallDiamter = LLSmallDiamter[i];
                       List<float> LWi = LLWi[i];
                       List<float> LWo = LLWo[i];

                       for (int j=0;j<LSmallC.Count;j++)
                       {
                           tmpProp.SmallC[i,j]= new CircleF(Point2PointF(new Point(LSmallC[j].X, LSmallC[j].Y)), (float)LSmallC[j].Radius);
                           tmpProp.SmallDiamter[i, j] = LSmallDiamter[j];
                           tmpProp.Wi[i, j] = LWi[j];
                           tmpProp.Wo[i, j] = LWo[j];
                       }
                       List<string> LSideSrcImage = LLSideSrcImage[i];
                       List<float> LLen = currPImage.Length[i];
                       List<List<int>> LLHLineY = LLLHLineY[i];
                       for (int j = 0; j < 4; j++)
                       {
                           tmpProp.Length[i, j] = LLen[j];
                           tmpProp.AddSideImage(LSideSrcImage[j], i, j);
                           tmpProp.ResetSideImage(i, j);
                           tmpProp.HLineY[i, j, 0] = LLHLineY[j][0];
                           tmpProp.HLineY[i, j, 1] = LLHLineY[j][1];
                       }
                       tmpProp.FacePropStatus[i] = 1;
                       tmpProp.SidePropStatus[i] = 1;

                   }
                   PropSamples.Add(tmpProp);
               }
               CurrentPage = 0;
               CurrentSample = 0;
               loadSamples(CurrentSample);
               tabControl_Original_Images.SelectedIndex = CurrentPage;
               DispFaceData(CurrentSample, CurrentPage, 2);
               DispSideData(CurrentSample, CurrentPage, 2);
               mainPanel(true);
               updateFaceStatus(CurrentPage);
               updateSideStatus(CurrentPage); */
        }
        private void Button_save_report_Click(object sender, EventArgs e)
        {
            /*   if (CurrentSample == -1) return;

               string str = chkCompleted(operMode);
               if (str != "")
               {
                   MessageBox.Show(str);
                   return;
               }

               string fileDir;
               String nowStr = DateTime.Now.ToString("yyyyMMdd_HHmmss");

               string opStr = "";
               string opStrC = "";

               string unitStr = "";

               if (button_mm.Checked)
                   unitStr = "mm";
               else
                   unitStr = "in";

               switch (operMode)
               {
                   case 0:
                       opStr = "nocut";
                       opStrC = "單辨識";
                       break;
                   case 1:
                       opStr = "onecut";
                       opStrC = "單切削";
                       break;
                   case 3:
                       opStr = "fullcut";
                       opStrC = "全自動";
                       break;
               }

               fileDir = textBox_working_dir.Text +"\\reports";
               if (!Directory.Exists(fileDir))
               {
                   Directory.CreateDirectory(fileDir);
               }

               XSSFWorkbook xssfworkbook = new XSSFWorkbook();

               if (!validateAllSamples())
               {
                   MessageBox.Show("樣本中仍有無效樣本或未測樣本，請先處理後再行輸出excel");
                   return;
               }

               for (int i = 0; i < operMode + 1; i++)
               {
                   ISheet sheet = xssfworkbook.CreateSheet("cut"+i.ToString());
                   sheet.CreateRow(0);
                   sheet.AddMergedRegion(new CellRangeAddress(0, 0, 0, 1));
                   sheet.GetRow(0).CreateCell(0).SetCellValue("藥型:" + PropType);
                   sheet.AddMergedRegion(new CellRangeAddress(0, 0, 2, 3));
                   sheet.GetRow(0).CreateCell(2).SetCellValue("模式:" + opStrC);
                   sheet.AddMergedRegion(new CellRangeAddress(0, 0, 4, 6));
                   sheet.GetRow(0).CreateCell(4).SetCellValue("時間:" + nowStr);
                   sheet.AddMergedRegion(new CellRangeAddress(0, 0, 7, 8));
                   sheet.GetRow(0).CreateCell(7).SetCellValue("單位:" + unitStr);

                   sheet.CreateRow(1).CreateCell(0).SetCellValue("編號");
                   sheet.GetRow(1).CreateCell(1).SetCellValue("大圓(D)");
                   sheet.GetRow(1).CreateCell(2).SetCellValue("小圓(d)");
                   sheet.GetRow(1).CreateCell(3).SetCellValue("Wi");
                   sheet.GetRow(1).CreateCell(4).SetCellValue("Wo");
                   sheet.GetRow(1).CreateCell(5).SetCellValue("Wav");
                   sheet.GetRow(1).CreateCell(6).SetCellValue("長度(L)");
                   sheet.GetRow(1).CreateCell(7).SetCellValue("D/d");
                   sheet.GetRow(1).CreateCell(8).SetCellValue("L/D");
                   for (int j=0;j<PropSamples.Count;j++)
                   {
                       sheet.CreateRow(j+2).CreateCell(0).SetCellValue((j + 1).ToString());
                       sheet.GetRow(j+2).CreateCell(1).SetCellValue(PropSamples[j].BigDiameter[i]);
                       sheet.GetRow(j+2).CreateCell(2).SetCellValue(PropSamples[j].SmallDiamterAvg[i]);
                       sheet.GetRow(j+2).CreateCell(3).SetCellValue(PropSamples[j].WiAvg[i]);
                       sheet.GetRow(j+2).CreateCell(4).SetCellValue(PropSamples[j].WoAvg[i]);
                       sheet.GetRow(j+2).CreateCell(5).SetCellValue((PropSamples[j].WiAvg[i] + PropSamples[j].WoAvg[i]) / 2);
                       sheet.GetRow(j+2).CreateCell(6).SetCellValue(PropSamples[j].LengthAvg[i]);
                       sheet.GetRow(j+2).CreateCell(7).SetCellValue(PropSamples[j].DOverd[i]);
                       sheet.GetRow(j+2).CreateCell(8).SetCellValue(PropSamples[j].LenOverD[i]);
                   }
               }
               fileDir = fileDir + "\\" + PropType + "-" + opStr + "-" + nowStr + ".xlsx";
               FileStream file = new FileStream(fileDir, FileMode.Create, System.IO.FileAccess.Write);//產生檔案
               xssfworkbook.Write(file);
               file.Close();
               richTextBox_logs.Text += DateTime.Now.ToString("HH:mm:ss") + "-輸出EXCEL至" +fileDir+"\n"; */
        }
        /*public bool validateAllSamples()
        {
         bool tmp = true;
            for (int i=0;i<PropSamples.Count;i++)
            {
                if(!PropSamples[i].chkValid())
                {
                    tmp = false;
                    break;
                }
            }
            return tmp;
        }*/
        /**************************************************************************************************************/
        /*----------------------------------------------Modbus通訊 Task-----------------------------------------------*/
        /**************************************************************************************************************/
        private async Task BeginWork() //非同步呼叫，執行機台狀態讀取/控制
        {
            string timerTick;
            while (true)
            {
                timerTick = await DoWork();
            }
            label_time.Text = timerTick;
        }


        /*----------------------------------------------Modbus通訊end-----------------------------------------------*/
        private async Task<string> DoWork()      //非同步執行(機台狀態讀取副程式)
        {
            if (startFlag == true)
            {
                await Task.Delay(200);
                readPosition_coil = master.ReadCoils(slaveID, readPosition, 36); //讀取拍照位置暫存器
            }

            await Task.Delay(200);
            if(((operMode==0) || (operMode==1)) && (!polishReady))
            {
                readAction_coil = master.ReadCoils(slaveID, readAction, 2);        //處理站號暫存器讀取

                if (readAction_coil[0] == true) dispMachineProcess(1);
                if (readAction_coil[1] == true) dispMachineProcess(2);
                polishReady = true;
            }
            if((operMode==1) || (operMode==3)) btn_sampling.Enabled = true;

            if ((operMode == 0) && (polishReady)) btn_return.Enabled = true;

            if (isSamplingPressed)   //循環依序讀取 照相位置M接點條件式
            {
                dispMachineProcess(3);

                //while (MessageBox.Show((readPosition_coid[startcount] ? startcount.ToString() + "到位" : "未到位"), "問題", MessageBoxButtons.YesNo) != DialogResult.Yes) ;

                if (readPosition_coil[startcount] == true)
                {
                    if (startcount > 0) master.WriteSingleCoil(slaveID, ushort.Parse((startcount - 1 + writeAddress).ToString()), false);  //寫入取消上一個拍照確認的M接點
                    //while (MessageBox.Show((readPosition_coid[startcount] ? startcount.ToString() + "到位" : "未到位"), "問題", MessageBoxButtons.YesNo) != DialogResult.Yes) ;
                    await Task.Delay(800);
                    GC.Collect();
                    if (startcount <= 34)
                    {
                        setledSamplePath(startcount, Color.Red,Color.Green);
                        mainCamShoot = true;
                        await Task.Delay(takePicDelay);
                        master.WriteSingleCoil(slaveID, ushort.Parse((startcount + writeAddress).ToString()), true);//寫入拍照確認 M接點
                    }

                    if (startcount < 35)
                    {
                        startcount++;
                    }
                    else
                    {
                        setledSamplePath(startcount, Color.Red, Color.Green);
                        master.WriteSingleCoil(slaveID, ushort.Parse((startcount + writeAddress).ToString()), false);  //寫入上一個拍照確認的取消M接點
                        startcount = 0;     //count歸零
                        capReady = true;
                        btn_return.Enabled = true;
                        isSamplingPressed = false;
                    }
                }
            }
            if (capReady == true)     //拍照完成  切割影像
            {
                mainCamShoot = true;
                await Task.Delay(takePicDelay);
                polishReady = false;
                btn_sampling.Enabled = false;
                if (operMode == 1) btn_regrind.Enabled = true;
                /* startFlag = false;
                polishReady = false;
                Stop();
                this.panel9.Enabled = true;
                this.drawStartBtn.Enabled = true;

                string readingPath = originFile + "/";  //讀取資料夾路徑
                string[] readPathBmpAll = Directory.GetFiles(readingPath, "*.bmp");

                string[] oldPathBmpAll = Directory.GetFiles("./ReadImg/" + mode1.Text + "/", "*.bmp");

                foreach (string oldfile in oldPathBmpAll)   //清舊的暫存照片資料
                {
                    File.Delete(oldfile);
                }

                foreach (string file in readPathBmpAll)   //原始圖像進行分割處理
                {

                    Image<Bgr, byte> testImage = new Image<Bgr, byte>(file);
                    ROIcapture(testImage);
                    testImage.Dispose();
                    if (deleteFileFlag == true) File.Delete(file);
                } */
                capReady = false;
            }
            return DateTime.Now.ToString("yyyy/MM/dd  HH:mm:ss");
        }
        private void setledSamplePath(int column, Color backColor, Color setColor)
        {
            if(column>0)
            {
                ledSamplePath[column-1].BackColor = backColor;
            }
            ledSamplePath[column].BackColor = setColor;
        }
        private void clearledLabel()
        {
            for (int i = 0; i <= 3; i++)
                ledProcess[i].BackColor = Color.SteelBlue;
        }
        
        private void dispMachineProcess(int cnt)
        {
            if(cnt==-1)
            {
                lbl_Machine_Process.Text = "機台運行：未連結";
                clearledLabel();
                return;

            }
            
            
            switch (cnt)
            {
                case 0:
                    lbl_Machine_Process.Text = "機台運行：取料站";
                    break;
                case 1:
                    lbl_Machine_Process.Text = "機台運行：粗磨站";
                    break;
                case 2:
                    lbl_Machine_Process.Text = "機台運行：細磨站";
                    break;
                case 3:
                    lbl_Machine_Process.Text = "機台運行：辨識站";
                    break;
            }
            for(int i=0;i<4;i++)
            {
                if(i==cnt)
                    ledProcess[i].BackColor = Color.Green;
                else
                    ledProcess[i].BackColor = Color.SteelBlue;
            }
        }

        private void gswCam_Click(object sender, EventArgs e)
        {
            if (lblCamStatus.Text=="OFF")
            {
                openCam(mainCam, textBox_Cam.Text, "./config/" + myConfig.camConfig);
                if(mainCam.isOpened)
                {
                    ToggleSWwithLed(gswCam, lblCamStatus, true);               
                    mainCam.CameraImageEvent += Camera_CameraImageEvent;
                    btn_cROI.Enabled = true;
                    btn_nROI.Enabled = true;
                }
            }
            else
            {
                ToggleSWwithLed(gswCam, lblCamStatus, false);
                btn_cROI.Enabled = false;
                btn_nROI.Enabled = false;
                mainCam.DestroyCamera();
            }

        }

        private void panel_operation_status_Paint(object sender, PaintEventArgs e)
        {

        }


        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_load_config_Click(object sender, EventArgs e)
        {

        }

        private void btn_plc_start_Click(object sender, EventArgs e)
        {
            if(!isPLCStartPressed)
            {
                isPLCStartPressed = true;
                btn_plc_start.BackColor = Color.PaleGreen;
                startFlag = true;
                //btnSampling.Enabled = true;
                master.WriteSingleCoil(slaveID, PLCStart, true);
                dispMachineProcess(0);
                startcount = 0;
            }
            else
            {
                isPLCStartPressed = false;
                btn_plc_start.BackColor = Color.Silver;
                startFlag = false;
                //btnSampling.Enabled = true;
                master.WriteSingleCoil(slaveID, PLCStart, false);
                dispMachineProcess(-1);
            }
        }

        private void btn_sampling_Click(object sender, EventArgs e)
        {
            if(!isSamplingPressed)
            {
                isSamplingPressed = true;
                btn_plc_start.BackColor = Color.PaleGreen;
            }
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            ledSamplePath[35].BackColor = Color.Red;
            master.WriteSingleCoil(slaveID, (ushort)286, true);
            isReturnPressed = true;
            for(int i=0;i<6; i++)
            {
                master.WriteSingleCoil(slaveID, reGrindCoil[i], false);
            }
            isPLCStartPressed = false;
            btn_plc_start.BackColor = Color.Silver;
            startFlag = false;
            //btnSampling.Enabled = true;
            master.WriteSingleCoil(slaveID, PLCStart, false);

            dispMachineProcess(-1);
            btn_return.Enabled = false;
            if(listPropGrinds.Count>0)
            {
                CurrentSample = 0;
                dispCurrentSample(CurrentSample);
            }


        }

        private void btn_regrind_Click(object sender, EventArgs e)
        {
            if (txt_grindcount.Text == "6")
            {
                MessageBox.Show("已達再研磨次數上限!");
                return;
            }
            int cnt = Int32.Parse(txt_grindcount.Text) + 1;
            master.WriteSingleCoil(slaveID, reGrindCoil[cnt-1], true);
            txt_grindcount.Text = cnt.ToString();
        }

        private void Blink_timer_Tick(object sender, EventArgs e)
        {
            if (!isPLCStartPressed)
            {
                if ((btn_plc_start.BackColor == Color.PaleGreen) && (btn_plc_start.Enabled))
                {
                    btn_plc_start.BackColor = Color.Silver;
                }
                else
                {
                    btn_plc_start.BackColor = Color.PaleGreen;
                }
            }
        }

        private void btn_cROI_Click(object sender, EventArgs e)
        {
            SampleROI = new Rectangle(myConfig.mROI.X, myConfig.mROI.Y, myConfig.mROI.width, myConfig.mROI.height);
            ApplyROIFaceDetection = false;
        }

        private void btn_nROI_Click(object sender, EventArgs e)
        {
            SampleROI = ImageUtil.FindROI(currBMP, 1800, 1800);
            ApplyROIFaceDetection = true;
        }
    }

}
    
