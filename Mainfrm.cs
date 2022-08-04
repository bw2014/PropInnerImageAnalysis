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

        public SysConfig myconfig;   // 系統參數物件
        public PropJSON myProp;      // 辨識結果之JSON物件

        private List<PropImages.SingleHoleGrain> SHG = new List<PropImages.SingleHoleGrain>();
        private List<PropImages.Powder> PWD = new List<PropImages.Powder>();

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

        private SerialPort comport = new SerialPort(); //宣告一SerialPort物件為comport

        public bool comportOpened = false; // COM Port 連結狀態

        public bool PropTypeSelected = false;

        public bool PLCConnected = false;

        public string PropType; //藥柱代號

        public int operMode;   // 0: 單辨識   3:單研磨   1:全自動

        public string defUnit; // 預設單位

        public bool isOffline = false;

        public bool isUnitAdj = false;

        public bool isFirstLoad = false;

        public bool isCoated = false;

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
        ushort whiteStart = 100;    //開始自動作業   M接點
        int startcount = 0;       //拍照位置counter
        bool capReady = false;    //拍照完成旗標
        bool startFlag = false;    //拍照完成旗標
        bool polishReady = false;   //研磨完成旗標

        bool[] readPosition_coid;   //讀取粹盤暫存器陣列
        bool[] readAction_coid;     //讀取研磨作業陣列

        ushort X32 = 13362;             // 機台切換開關 X32 X33
                                        //               1   0   單辨識
                                        //               0   1   單切削
                                        //               0   0   自動

        bool[] ReadXButtons = new bool[2];    // 讀取 X32 及 X33

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
        private void toggleUnit(int type)
        {
            if (type == 0)
            {
                txtUnit_hole_rad.Text = "mm";
                txtUnit_hole_area.Text = "mm²";
                txtUnit_base_area.Text = "mm²";
            }
            else
            {
                txtUnit_hole_rad.Text = "inch";
                txtUnit_hole_area.Text = "inch²";
                txtUnit_base_area.Text = "inch²";
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
            myconfig= JsonConvert.DeserializeObject<SysConfig>(jStr);
            r.Close();
            pixLength = myconfig.pixLength;
            trackbar_fixed_threshold.Value = myconfig.fixedThres;
            textBox_fixed_threshold.Text = myconfig.fixedThres.ToString();

            textBox_Cam.Text = myconfig.cam;

            defUnit = myconfig.defUnit;
            if (defUnit == "mm")
                mmBtn.Checked = true;
            else
                inchBtn.Checked = true;
            SampleROI = new Rectangle(myconfig.mROI.X, myconfig.mROI.Y, myconfig.mROI.width, myconfig.mROI.height);
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
            if (!comportOpened)
                enInit = false;
            if (!PropTypeSelected)
                enInit = false;

            if (enInit)
                btnStart.Enabled = true;

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

            if (ApplyROIFaceDetection)
            {
                ApplyROIFaceDetection = false;
                SampleROI = ImageUtil.FindROI(bmp, 1200, 1200);
            }
            Bitmap temp = bmp.Clone(SampleROI, bmp.PixelFormat);
            if (mainCamShoot)
            {
                mainCamShoot = false;
            }
            Bitmap temp1 = ImageUtil.ResizeBitmap(temp, 300, 300);
            Bitmap temp2 = ImageUtil.ResizeBitmap(temp, 600, 600);
            picBoxCam.Invoke(new MethodInvoker(delegate
            {
                Bitmap old = picBoxCam.Image as Bitmap;
                picBoxCam.Image = temp1;
                picBox_Origin.Image = temp2;
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

            PropType = "";
            loadConfig("./config/sysconfig.json");
            textBox_sample_dir.Text = myconfig.workiDir;

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


        private void button_initial_Click(object sender, EventArgs e)
        {
            if (lblConnect.Text == "ON")
            {
                ToggleLed(lblConnect, false);
                btnStart.Enabled = false;
            }
            else
            {
                ToggleLed(lblConnect, true);
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
        private void button_start_Click(object sender, EventArgs e)
        {
             if (lblConnect.Text == "ON")
             {
                ToggleLed(lblConnect, false);
                btnStart.Enabled = false;
                //btnOffline.Enabled = true;
                btnSampling.Enabled = false;
                startFlag = false;
                polishReady = false;
                initVars();
             }
             else
             {
                ToggleLed(lblConnect, true);
                startFlag = true;
                //btnSampling.Enabled = true;
                master.WriteSingleCoil(slaveID, ushort.Parse(100.ToString()), true);
                dispMachineProcess(0);
                startcount = 0;
            }
        }

        private void comboBox_prop_type_Click(object sender, EventArgs e)
        {
            if ((cboProType.Text != "") && (comportOpened))
                gswPropType.Enabled = true;
        }

        private void gswPropType_Click(object sender, EventArgs e)
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
        }

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
                textBox_sample_dir.Text = folderBrowserDialog_working_dir.SelectedPath;
                myconfig.workiDir = textBox_sample_dir.Text;
            }
        }

        public void comport_init()
        {
            comportOpened = false;
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
          if (comportOpened)
          {

              //Activate_Flag = false;
              //Activate_clk_Flag = true;
              //richTextBox_logs.Text += DateTime.Now.ToString("HH:mm:ss") + "-機台連接斷開，取消取樣作業\n";

              comportOpened = false;
              ToggleSWwithLed(gswComport, lblComPortStatus , comportOpened);
              cboComPort.Enabled = true;
              if (PropTypeSelected)
              {
                  PropTypeSelected = false;
 
                  //master.WriteSingleRegister(slaveID, PropellantChoice, 0); 
              }

              comport.Close();
              cboComPort.Text = "";
              for(int i=0;i<2;i++)
              {
                  ledOperMode[operMode].BackColor = Color.Red;
              }

              cboProType.Enabled = false;
              ToggleSWwithLed(gswPropType, lblProTypeStatus, false);
              gswPropType.Enabled = false;

              lblConnect.Text = "OFF";
              lblConnect.BackColor = Color.Red;
              btnStart.Enabled = false;

              initVars();
          }
          else
          {
              if (cboComPort.Text != "")
              {
                  String com = cboComPort.Text;
                  try
                  {
                      comport = new SerialPort(ComName(com), 9600, Parity.None, 8, StopBits.One);
                      comport.ReadTimeout = 1000;
                      comport.Open();
                      master = ModbusSerialMaster.CreateRtu(comport); //設置Modbus RTU連結
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
                      comportOpened = true;
                      ToggleSWwithLed(gswComport, lblComPortStatus, comportOpened);
                      cboComPort.Enabled = false;
                      cboProType.Enabled = true;

                      updateInitUI();
                  }
                  catch (ArgumentException ex)
                  {
                      comport.Close();
                      //ComClose_Component(true);
                  }
                  catch (UnauthorizedAccessException ex)
                  {
                      comport.Close();
                      //ComClose_Component(true);
                  }
              }
          }
        }

        private void comboBox_comport_Click(object sender, EventArgs e)
        {
            comportOpened = false;
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
                        comportOpened = true;
                        continue;
                    }
                }
                if (!comportOpened) cboComPort.Items.Add(port);
                else comportOpened = false;
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


        }

        private void button_next_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_prop_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProType.Text != "")
                gswPropType.Enabled = true;
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

            //await Task.Delay(500);
            //ushort[] holding_register = master.ReadHoldingRegisters(slaveID, startAddress, 10); // Read holding FC03
            //bool[] read_startCoid = master.ReadCoils(slaveID, readstartcoid, 10);  // Read coil FC01
            if (startFlag == true)
            {
                await Task.Delay(200);
                readPosition_coid = master.ReadCoils(slaveID, readPosition, 36); //讀取拍照位置暫存器
            }

            await Task.Delay(200);
            readAction_coid = master.ReadCoils(slaveID, readAction, 2);        //處理站號暫存器讀取

            if (readAction_coid[0] == true) dispMachineProcess(1);
            if (readAction_coid[1] == true) dispMachineProcess(2);
                //textBox1.Text = read_coid[0].ToString();
                //textBox11.Text = Convert.ToString(holding_register[0]); // 16bit

            if (polishReady == true)   //循環依序讀取 照相位置M接點條件式
            {
                dispMachineProcess(3);

                //while (MessageBox.Show((readPosition_coid[startcount] ? startcount.ToString() + "到位" : "未到位"), "問題", MessageBoxButtons.YesNo) != DialogResult.Yes) ;

                if (readPosition_coid[startcount] == true)
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
                        master.WriteSingleCoil(slaveID, ushort.Parse((286).ToString()), true);//寫入確認M接點
                    }
                }
            }
            if (capReady == true)     //拍照完成  切割影像
            {
                polishReady = false;
                btnSampling.Enabled = false;
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
                    ledProcess[cnt].BackColor = Color.Green;
                else
                    ledProcess[cnt].BackColor = Color.SteelBlue;
            }
        }

        private void gswCam_Click(object sender, EventArgs e)
        {
            if (lblCamStatus.Text=="OFF")
            {
                openCam(mainCam, textBox_Cam.Text, "./config/" + myconfig.camConfig);
                if(mainCam.isOpened)
                {
                    ToggleSWwithLed(gswCam, lblCamStatus, true);               
                    mainCam.CameraImageEvent += Camera_CameraImageEvent;
                }
            }
            else
            {
                ToggleSWwithLed(gswCam, lblCamStatus, false);
                mainCam.DestroyCamera();
            }

        }

        private void panel_operation_status_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSampling_Click(object sender, EventArgs e)
        {
            polishReady = true;
            ToggleLed(lblSampling, true);
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gswDelSpl_Click(object sender, EventArgs e)
        {
            if(lblSplDel.Text=="現有")
            {
                lblSplDel.Text = "所有";
                lblSplDel.BackColor = Color.LightBlue;
                DelAllSamples = true;
                gswDelSpl.Image = Properties.Resources.toggle_on;
            }
            else
            {
                lblSplDel.Text = "現有";
                lblSplDel.BackColor = Color.Orange;
                DelAllSamples = false;
                gswDelSpl.Image = Properties.Resources.toggle_off;
            }
        }

        private void gswDelMark_Click(object sender, EventArgs e)
        {
            if (lblMarkDel.Text == "現有")
            {
                lblMarkDel.Text = "所有";
                lblMarkDel.BackColor = Color.LightBlue;
                DelAllMarks = true;
                gswDelMark.Image = Properties.Resources.toggle_on;
            }
            else
            {
                lblMarkDel.Text = "現有";
                lblMarkDel.BackColor = Color.Orange;
                DelAllMarks = false;
                gswDelMark.Image = Properties.Resources.toggle_off;
            }
        }
    }
}
    
