using System;
using System.Windows.Forms;

namespace PropInnerImageAnalysis
{
    partial class Mainfrm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainfrm));
            this.panel_title = new System.Windows.Forms.Panel();
            this.label_time = new System.Windows.Forms.Label();
            this.munus_btn = new System.Windows.Forms.Button();
            this.end_btn = new System.Windows.Forms.Button();
            this.label_Title = new System.Windows.Forms.Label();
            this.panel_PLC_Com = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSingleGrind = new System.Windows.Forms.Label();
            this.lblAuto = new System.Windows.Forms.Label();
            this.lblNoGrind = new System.Windows.Forms.Label();
            this.cboComPort = new System.Windows.Forms.ComboBox();
            this.lblComPortStatus = new System.Windows.Forms.Label();
            this.gswComport = new System.Windows.Forms.Button();
            this.label_SideSample_stat = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.trackbar_fixed_threshold = new System.Windows.Forms.TrackBar();
            this.textBox_fixed_threshold = new System.Windows.Forms.TextBox();
            this.label85 = new System.Windows.Forms.Label();
            this.pictureBox29 = new System.Windows.Forms.PictureBox();
            this.button_reset = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_sample_count = new System.Windows.Forms.TextBox();
            this.Timer_system = new System.Windows.Forms.Timer(this.components);
            this.panel_Camera = new System.Windows.Forms.Panel();
            this.lblCamStatus = new System.Windows.Forms.Label();
            this.gswCam = new System.Windows.Forms.Button();
            this.textBox_Cam = new System.Windows.Forms.TextBox();
            this.picBoxCam = new System.Windows.Forms.PictureBox();
            this.label22 = new System.Windows.Forms.Label();
            this.panel_Prop_Select = new System.Windows.Forms.Panel();
            this.cboProType = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.folderBrowserDialog_working_dir = new System.Windows.Forms.FolderBrowserDialog();
            this.lbl_Machine_Process = new System.Windows.Forms.Label();
            this.lblProcess0 = new System.Windows.Forms.Label();
            this.lblProcess3 = new System.Windows.Forms.Label();
            this.lblProcess1 = new System.Windows.Forms.Label();
            this.panel_operation_status = new System.Windows.Forms.Panel();
            this.lbl31 = new System.Windows.Forms.Label();
            this.lbl30 = new System.Windows.Forms.Label();
            this.lbl19 = new System.Windows.Forms.Label();
            this.lbl18 = new System.Windows.Forms.Label();
            this.lbl07 = new System.Windows.Forms.Label();
            this.lbl06 = new System.Windows.Forms.Label();
            this.lbl32 = new System.Windows.Forms.Label();
            this.lbl29 = new System.Windows.Forms.Label();
            this.lbl20 = new System.Windows.Forms.Label();
            this.lbl17 = new System.Windows.Forms.Label();
            this.lbl08 = new System.Windows.Forms.Label();
            this.lbl05 = new System.Windows.Forms.Label();
            this.lbl33 = new System.Windows.Forms.Label();
            this.lbl28 = new System.Windows.Forms.Label();
            this.lbl21 = new System.Windows.Forms.Label();
            this.lbl16 = new System.Windows.Forms.Label();
            this.lbl09 = new System.Windows.Forms.Label();
            this.lbl04 = new System.Windows.Forms.Label();
            this.lbl34 = new System.Windows.Forms.Label();
            this.lbl27 = new System.Windows.Forms.Label();
            this.lbl22 = new System.Windows.Forms.Label();
            this.lbl15 = new System.Windows.Forms.Label();
            this.lbl10 = new System.Windows.Forms.Label();
            this.lbl03 = new System.Windows.Forms.Label();
            this.lbl35 = new System.Windows.Forms.Label();
            this.lbl26 = new System.Windows.Forms.Label();
            this.lbl23 = new System.Windows.Forms.Label();
            this.lbl14 = new System.Windows.Forms.Label();
            this.lbl11 = new System.Windows.Forms.Label();
            this.lbl02 = new System.Windows.Forms.Label();
            this.lbl36 = new System.Windows.Forms.Label();
            this.lbl25 = new System.Windows.Forms.Label();
            this.lbl24 = new System.Windows.Forms.Label();
            this.lbl13 = new System.Windows.Forms.Label();
            this.lbl12 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.lbl01 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblProcess2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog_load = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbo_polish_cnt = new System.Windows.Forms.ComboBox();
            this.label47 = new System.Windows.Forms.Label();
            this.textBox_sample_dir = new System.Windows.Forms.TextBox();
            this.btn_setup_sampledir = new XanderUI.XUIButton();
            this.btn_save_sample = new XanderUI.XUIButton();
            this.btn_load_sample = new XanderUI.XUIButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMarkDel = new System.Windows.Forms.Label();
            this.gswDelMark = new System.Windows.Forms.Button();
            this.lblSplDel = new System.Windows.Forms.Label();
            this.gswDelSpl = new System.Windows.Forms.Button();
            this.xuiButton3 = new XanderUI.XUIButton();
            this.xuiButton2 = new XanderUI.XUIButton();
            this.btn_sample_mark = new XanderUI.XUIButton();
            this.xuiButton1 = new XanderUI.XUIButton();
            this.btn_Rotate_OrgImg = new XanderUI.XUIButton();
            this.Button_abandon = new XanderUI.XUIButton();
            this.button_recgon = new XanderUI.XUIButton();
            this.button_prev = new XanderUI.XUIButton();
            this.button_next = new XanderUI.XUIButton();
            this.button_side_length = new XanderUI.XUIButton();
            this.button_all_auto = new XanderUI.XUIButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_load_parafile = new XanderUI.XUIButton();
            this.label20 = new System.Windows.Forms.Label();
            this.btn_save_parafile = new XanderUI.XUIButton();
            this.textBox_parafile = new System.Windows.Forms.TextBox();
            this.btn_setup_parafile = new XanderUI.XUIButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.picBox_Origin = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblResultStatus = new System.Windows.Forms.Label();
            this.gswResult = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.picBox_Result = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUnit_base_area = new System.Windows.Forms.TextBox();
            this.txtUnit_hole_area = new System.Windows.Forms.TextBox();
            this.txtUnit_hole_rad = new System.Windows.Forms.TextBox();
            this.txtRatio = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.txtBase_Area = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.txtHole_Area = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.txtHole_Rad = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.inchBtn = new System.Windows.Forms.RadioButton();
            this.mmBtn = new System.Windows.Forms.RadioButton();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.txt_Log = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel_title.SuspendLayout();
            this.panel_PLC_Com.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_fixed_threshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).BeginInit();
            this.panel_Camera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCam)).BeginInit();
            this.panel_Prop_Select.SuspendLayout();
            this.panel_operation_status.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Origin)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Result)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_title
            // 
            this.panel_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel_title.Controls.Add(this.label_time);
            this.panel_title.Controls.Add(this.munus_btn);
            this.panel_title.Controls.Add(this.end_btn);
            this.panel_title.Controls.Add(this.label_Title);
            this.panel_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_title.Location = new System.Drawing.Point(0, 0);
            this.panel_title.Name = "panel_title";
            this.panel_title.Size = new System.Drawing.Size(1919, 59);
            this.panel_title.TabIndex = 0;
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.BackColor = System.Drawing.Color.Silver;
            this.label_time.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_time.ForeColor = System.Drawing.Color.Black;
            this.label_time.Location = new System.Drawing.Point(945, 6);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(405, 40);
            this.label_time.TabIndex = 3;
            this.label_time.Text = "yyyy / MM / dd  HH:mm:ss";
            this.label_time.TextChanged += new System.EventHandler(this.label_time_TextChanged);
            // 
            // munus_btn
            // 
            this.munus_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.munus_btn.FlatAppearance.BorderSize = 0;
            this.munus_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.munus_btn.ForeColor = System.Drawing.Color.White;
            this.munus_btn.Image = ((System.Drawing.Image)(resources.GetObject("munus_btn.Image")));
            this.munus_btn.Location = new System.Drawing.Point(1822, 12);
            this.munus_btn.Name = "munus_btn";
            this.munus_btn.Size = new System.Drawing.Size(40, 40);
            this.munus_btn.TabIndex = 1;
            this.munus_btn.UseVisualStyleBackColor = false;
            this.munus_btn.Click += new System.EventHandler(this.minus_Click);
            // 
            // end_btn
            // 
            this.end_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.end_btn.FlatAppearance.BorderSize = 0;
            this.end_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.end_btn.ForeColor = System.Drawing.Color.White;
            this.end_btn.Image = ((System.Drawing.Image)(resources.GetObject("end_btn.Image")));
            this.end_btn.Location = new System.Drawing.Point(1874, 12);
            this.end_btn.Name = "end_btn";
            this.end_btn.Size = new System.Drawing.Size(39, 40);
            this.end_btn.TabIndex = 1;
            this.end_btn.UseVisualStyleBackColor = false;
            this.end_btn.Click += new System.EventHandler(this.end_btn_Click);
            // 
            // label_Title
            // 
            this.label_Title.BackColor = System.Drawing.Color.Silver;
            this.label_Title.Font = new System.Drawing.Font("標楷體", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Title.ForeColor = System.Drawing.Color.Black;
            this.label_Title.Location = new System.Drawing.Point(0, 0);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(1920, 59);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "發射藥包面分析檢測";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_PLC_Com
            // 
            this.panel_PLC_Com.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.panel_PLC_Com.Controls.Add(this.label3);
            this.panel_PLC_Com.Controls.Add(this.lblSingleGrind);
            this.panel_PLC_Com.Controls.Add(this.lblAuto);
            this.panel_PLC_Com.Controls.Add(this.lblNoGrind);
            this.panel_PLC_Com.Controls.Add(this.cboComPort);
            this.panel_PLC_Com.Controls.Add(this.lblComPortStatus);
            this.panel_PLC_Com.Controls.Add(this.gswComport);
            this.panel_PLC_Com.Location = new System.Drawing.Point(0, 448);
            this.panel_PLC_Com.Name = "panel_PLC_Com";
            this.panel_PLC_Com.Size = new System.Drawing.Size(316, 63);
            this.panel_PLC_Com.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Gold;
            this.label3.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(4, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 26);
            this.label3.TabIndex = 45;
            this.label3.Text = "通訊埠";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSingleGrind
            // 
            this.lblSingleGrind.BackColor = System.Drawing.Color.Red;
            this.lblSingleGrind.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSingleGrind.ForeColor = System.Drawing.Color.White;
            this.lblSingleGrind.Location = new System.Drawing.Point(216, 34);
            this.lblSingleGrind.Name = "lblSingleGrind";
            this.lblSingleGrind.Size = new System.Drawing.Size(94, 24);
            this.lblSingleGrind.TabIndex = 30;
            this.lblSingleGrind.Text = "單研磨";
            this.lblSingleGrind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAuto
            // 
            this.lblAuto.BackColor = System.Drawing.Color.Red;
            this.lblAuto.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAuto.ForeColor = System.Drawing.Color.White;
            this.lblAuto.Location = new System.Drawing.Point(102, 34);
            this.lblAuto.Name = "lblAuto";
            this.lblAuto.Size = new System.Drawing.Size(111, 24);
            this.lblAuto.TabIndex = 29;
            this.lblAuto.Text = "全自動";
            this.lblAuto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNoGrind
            // 
            this.lblNoGrind.BackColor = System.Drawing.Color.Red;
            this.lblNoGrind.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblNoGrind.ForeColor = System.Drawing.Color.White;
            this.lblNoGrind.Location = new System.Drawing.Point(4, 34);
            this.lblNoGrind.Name = "lblNoGrind";
            this.lblNoGrind.Size = new System.Drawing.Size(94, 24);
            this.lblNoGrind.TabIndex = 28;
            this.lblNoGrind.Text = "單辨識";
            this.lblNoGrind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboComPort
            // 
            this.cboComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboComPort.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboComPort.FormattingEnabled = true;
            this.cboComPort.Location = new System.Drawing.Point(102, 2);
            this.cboComPort.Name = "cboComPort";
            this.cboComPort.Size = new System.Drawing.Size(111, 27);
            this.cboComPort.TabIndex = 6;
            this.cboComPort.Click += new System.EventHandler(this.comboBox_comport_Click);
            // 
            // lblComPortStatus
            // 
            this.lblComPortStatus.AutoSize = true;
            this.lblComPortStatus.BackColor = System.Drawing.Color.Red;
            this.lblComPortStatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComPortStatus.ForeColor = System.Drawing.Color.White;
            this.lblComPortStatus.Location = new System.Drawing.Point(273, 7);
            this.lblComPortStatus.Name = "lblComPortStatus";
            this.lblComPortStatus.Size = new System.Drawing.Size(39, 19);
            this.lblComPortStatus.TabIndex = 5;
            this.lblComPortStatus.Text = "OFF";
            this.lblComPortStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gswComport
            // 
            this.gswComport.BackColor = System.Drawing.Color.Transparent;
            this.gswComport.FlatAppearance.BorderSize = 0;
            this.gswComport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.gswComport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gswComport.ForeColor = System.Drawing.Color.Black;
            this.gswComport.Image = global::PropInnerImageAnalysis.Properties.Resources.toggle_off;
            this.gswComport.Location = new System.Drawing.Point(224, 1);
            this.gswComport.Name = "gswComport";
            this.gswComport.Size = new System.Drawing.Size(38, 28);
            this.gswComport.TabIndex = 6;
            this.gswComport.UseVisualStyleBackColor = false;
            this.gswComport.Click += new System.EventHandler(this.button_comport_sw_Click);
            // 
            // label_SideSample_stat
            // 
            this.label_SideSample_stat.BackColor = System.Drawing.Color.Yellow;
            this.label_SideSample_stat.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_SideSample_stat.ForeColor = System.Drawing.Color.Black;
            this.label_SideSample_stat.Location = new System.Drawing.Point(4, 81);
            this.label_SideSample_stat.Name = "label_SideSample_stat";
            this.label_SideSample_stat.Size = new System.Drawing.Size(268, 39);
            this.label_SideSample_stat.TabIndex = 91;
            this.label_SideSample_stat.Text = "--";
            this.label_SideSample_stat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.trackbar_fixed_threshold);
            this.groupBox2.Controls.Add(this.textBox_fixed_threshold);
            this.groupBox2.Controls.Add(this.label85);
            this.groupBox2.Controls.Add(this.pictureBox29);
            this.groupBox2.Location = new System.Drawing.Point(2, 680);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 118);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            // 
            // trackbar_fixed_threshold
            // 
            this.trackbar_fixed_threshold.Location = new System.Drawing.Point(5, 69);
            this.trackbar_fixed_threshold.Maximum = 255;
            this.trackbar_fixed_threshold.Minimum = 1;
            this.trackbar_fixed_threshold.Name = "trackbar_fixed_threshold";
            this.trackbar_fixed_threshold.Size = new System.Drawing.Size(261, 45);
            this.trackbar_fixed_threshold.TabIndex = 83;
            this.trackbar_fixed_threshold.Value = 240;
            this.trackbar_fixed_threshold.ValueChanged += new System.EventHandler(this.trackBar_face_threshold_ValueChanged);
            // 
            // textBox_fixed_threshold
            // 
            this.textBox_fixed_threshold.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_fixed_threshold.Location = new System.Drawing.Point(120, 20);
            this.textBox_fixed_threshold.Name = "textBox_fixed_threshold";
            this.textBox_fixed_threshold.Size = new System.Drawing.Size(64, 32);
            this.textBox_fixed_threshold.TabIndex = 84;
            this.textBox_fixed_threshold.Text = "240";
            this.textBox_fixed_threshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_fixed_threshold.TextChanged += new System.EventHandler(this.textBox_face_Threshold_TextChanged);
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.BackColor = System.Drawing.Color.Gold;
            this.label85.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label85.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label85.Location = new System.Drawing.Point(12, 25);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(102, 21);
            this.label85.TabIndex = 27;
            this.label85.Text = "慣用閥值";
            // 
            // pictureBox29
            // 
            this.pictureBox29.BackColor = System.Drawing.Color.Gold;
            this.pictureBox29.Location = new System.Drawing.Point(3, 15);
            this.pictureBox29.Name = "pictureBox29";
            this.pictureBox29.Size = new System.Drawing.Size(263, 48);
            this.pictureBox29.TabIndex = 6;
            this.pictureBox29.TabStop = false;
            // 
            // button_reset
            // 
            this.button_reset.BackColor = System.Drawing.Color.NavajoWhite;
            this.button_reset.FlatAppearance.BorderSize = 0;
            this.button_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_reset.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_reset.ForeColor = System.Drawing.Color.Black;
            this.button_reset.Location = new System.Drawing.Point(63, 634);
            this.button_reset.Name = "button_reset";
            this.button_reset.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button_reset.Size = new System.Drawing.Size(149, 48);
            this.button_reset.TabIndex = 32;
            this.button_reset.Text = "辨識重置";
            this.button_reset.UseVisualStyleBackColor = false;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.label7.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.SystemColors.Info;
            this.label7.Location = new System.Drawing.Point(5, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(267, 30);
            this.label7.TabIndex = 27;
            this.label7.Text = "樣本數";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_sample_count
            // 
            this.textBox_sample_count.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.textBox_sample_count.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_sample_count.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_sample_count.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox_sample_count.Location = new System.Drawing.Point(4, 35);
            this.textBox_sample_count.Multiline = true;
            this.textBox_sample_count.Name = "textBox_sample_count";
            this.textBox_sample_count.ReadOnly = true;
            this.textBox_sample_count.Size = new System.Drawing.Size(268, 43);
            this.textBox_sample_count.TabIndex = 21;
            this.textBox_sample_count.Text = "--";
            this.textBox_sample_count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Timer_system
            // 
            this.Timer_system.Tick += new System.EventHandler(this.Timer_system_Tick);
            // 
            // panel_Camera
            // 
            this.panel_Camera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.panel_Camera.Controls.Add(this.lblCamStatus);
            this.panel_Camera.Controls.Add(this.gswCam);
            this.panel_Camera.Controls.Add(this.textBox_Cam);
            this.panel_Camera.Controls.Add(this.picBoxCam);
            this.panel_Camera.Controls.Add(this.label22);
            this.panel_Camera.Location = new System.Drawing.Point(0, 59);
            this.panel_Camera.Name = "panel_Camera";
            this.panel_Camera.Size = new System.Drawing.Size(317, 383);
            this.panel_Camera.TabIndex = 5;
            // 
            // lblCamStatus
            // 
            this.lblCamStatus.AutoSize = true;
            this.lblCamStatus.BackColor = System.Drawing.Color.Red;
            this.lblCamStatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCamStatus.ForeColor = System.Drawing.Color.White;
            this.lblCamStatus.Location = new System.Drawing.Point(271, 43);
            this.lblCamStatus.Name = "lblCamStatus";
            this.lblCamStatus.Size = new System.Drawing.Size(39, 19);
            this.lblCamStatus.TabIndex = 46;
            this.lblCamStatus.Text = "OFF";
            this.lblCamStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gswCam
            // 
            this.gswCam.BackColor = System.Drawing.Color.Transparent;
            this.gswCam.FlatAppearance.BorderSize = 0;
            this.gswCam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.gswCam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gswCam.ForeColor = System.Drawing.Color.Black;
            this.gswCam.Image = global::PropInnerImageAnalysis.Properties.Resources.toggle_off;
            this.gswCam.Location = new System.Drawing.Point(218, 37);
            this.gswCam.Name = "gswCam";
            this.gswCam.Size = new System.Drawing.Size(51, 28);
            this.gswCam.TabIndex = 31;
            this.gswCam.UseVisualStyleBackColor = false;
            this.gswCam.Click += new System.EventHandler(this.gswCam_Click);
            // 
            // textBox_Cam
            // 
            this.textBox_Cam.Enabled = false;
            this.textBox_Cam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Cam.Location = new System.Drawing.Point(3, 39);
            this.textBox_Cam.Name = "textBox_Cam";
            this.textBox_Cam.Size = new System.Drawing.Size(216, 26);
            this.textBox_Cam.TabIndex = 157;
            this.textBox_Cam.Text = "--";
            this.textBox_Cam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // picBoxCam
            // 
            this.picBoxCam.ErrorImage = null;
            this.picBoxCam.InitialImage = null;
            this.picBoxCam.Location = new System.Drawing.Point(6, 71);
            this.picBoxCam.Name = "picBoxCam";
            this.picBoxCam.Size = new System.Drawing.Size(300, 300);
            this.picBoxCam.TabIndex = 33;
            this.picBoxCam.TabStop = false;
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.Gold;
            this.label22.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label22.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label22.Location = new System.Drawing.Point(3, 5);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(308, 30);
            this.label22.TabIndex = 27;
            this.label22.Text = "相機狀態";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_Prop_Select
            // 
            this.panel_Prop_Select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.panel_Prop_Select.Controls.Add(this.button7);
            this.panel_Prop_Select.Controls.Add(this.textBox12);
            this.panel_Prop_Select.Controls.Add(this.label14);
            this.panel_Prop_Select.Controls.Add(this.button6);
            this.panel_Prop_Select.Controls.Add(this.textBox11);
            this.panel_Prop_Select.Controls.Add(this.label13);
            this.panel_Prop_Select.Controls.Add(this.button4);
            this.panel_Prop_Select.Controls.Add(this.textBox10);
            this.panel_Prop_Select.Controls.Add(this.label9);
            this.panel_Prop_Select.Controls.Add(this.cboProType);
            this.panel_Prop_Select.Controls.Add(this.label24);
            this.panel_Prop_Select.Location = new System.Drawing.Point(1, 515);
            this.panel_Prop_Select.Name = "panel_Prop_Select";
            this.panel_Prop_Select.Size = new System.Drawing.Size(313, 152);
            this.panel_Prop_Select.TabIndex = 28;
            // 
            // cboProType
            // 
            this.cboProType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProType.Enabled = false;
            this.cboProType.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboProType.FormattingEnabled = true;
            this.cboProType.Items.AddRange(new object[] {
            "B1- 30mm單基單孔",
            "B2- 105mm單基單孔",
            "B3- 7.62mm單基單孔(未光)",
            "B4- 7.62mm單基單孔(已光)",
            "B5- 5.56mm商用",
            "C1-5.56mm雙基(未輾)",
            "C2-5.56mm雙基(已輾)"});
            this.cboProType.Location = new System.Drawing.Point(67, 9);
            this.cboProType.Name = "cboProType";
            this.cboProType.Size = new System.Drawing.Size(245, 24);
            this.cboProType.TabIndex = 34;
            this.cboProType.SelectedIndexChanged += new System.EventHandler(this.comboBox_prop_type_SelectedIndexChanged);
            this.cboProType.Click += new System.EventHandler(this.comboBox_prop_type_Click);
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.Color.Gold;
            this.label24.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label24.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label24.Location = new System.Drawing.Point(4, 9);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(60, 24);
            this.label24.TabIndex = 27;
            this.label24.Text = "藥型";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Machine_Process
            // 
            this.lbl_Machine_Process.BackColor = System.Drawing.Color.Orange;
            this.lbl_Machine_Process.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Machine_Process.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbl_Machine_Process.Location = new System.Drawing.Point(5, 7);
            this.lbl_Machine_Process.Name = "lbl_Machine_Process";
            this.lbl_Machine_Process.Size = new System.Drawing.Size(301, 30);
            this.lbl_Machine_Process.TabIndex = 27;
            this.lbl_Machine_Process.Text = "機台運行：研磨前";
            this.lbl_Machine_Process.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProcess0
            // 
            this.lblProcess0.BackColor = System.Drawing.Color.SteelBlue;
            this.lblProcess0.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblProcess0.ForeColor = System.Drawing.SystemColors.Info;
            this.lblProcess0.Location = new System.Drawing.Point(4, 44);
            this.lblProcess0.Name = "lblProcess0";
            this.lblProcess0.Size = new System.Drawing.Size(58, 39);
            this.lblProcess0.TabIndex = 28;
            this.lblProcess0.Text = "取料";
            this.lblProcess0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProcess3
            // 
            this.lblProcess3.BackColor = System.Drawing.Color.SteelBlue;
            this.lblProcess3.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblProcess3.ForeColor = System.Drawing.SystemColors.Info;
            this.lblProcess3.Location = new System.Drawing.Point(244, 43);
            this.lblProcess3.Name = "lblProcess3";
            this.lblProcess3.Size = new System.Drawing.Size(58, 39);
            this.lblProcess3.TabIndex = 29;
            this.lblProcess3.Text = "辨識";
            this.lblProcess3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProcess1
            // 
            this.lblProcess1.BackColor = System.Drawing.Color.SteelBlue;
            this.lblProcess1.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblProcess1.ForeColor = System.Drawing.SystemColors.Info;
            this.lblProcess1.Location = new System.Drawing.Point(84, 43);
            this.lblProcess1.Name = "lblProcess1";
            this.lblProcess1.Size = new System.Drawing.Size(58, 39);
            this.lblProcess1.TabIndex = 31;
            this.lblProcess1.Text = "粗磨";
            this.lblProcess1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_operation_status
            // 
            this.panel_operation_status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.panel_operation_status.Controls.Add(this.lbl31);
            this.panel_operation_status.Controls.Add(this.lbl30);
            this.panel_operation_status.Controls.Add(this.lbl19);
            this.panel_operation_status.Controls.Add(this.lbl18);
            this.panel_operation_status.Controls.Add(this.lbl07);
            this.panel_operation_status.Controls.Add(this.lbl06);
            this.panel_operation_status.Controls.Add(this.lbl32);
            this.panel_operation_status.Controls.Add(this.lbl29);
            this.panel_operation_status.Controls.Add(this.lbl20);
            this.panel_operation_status.Controls.Add(this.lbl17);
            this.panel_operation_status.Controls.Add(this.lbl08);
            this.panel_operation_status.Controls.Add(this.lbl05);
            this.panel_operation_status.Controls.Add(this.lbl33);
            this.panel_operation_status.Controls.Add(this.lbl28);
            this.panel_operation_status.Controls.Add(this.lbl21);
            this.panel_operation_status.Controls.Add(this.lbl16);
            this.panel_operation_status.Controls.Add(this.lbl09);
            this.panel_operation_status.Controls.Add(this.lbl04);
            this.panel_operation_status.Controls.Add(this.lbl34);
            this.panel_operation_status.Controls.Add(this.lbl27);
            this.panel_operation_status.Controls.Add(this.lbl22);
            this.panel_operation_status.Controls.Add(this.lbl15);
            this.panel_operation_status.Controls.Add(this.lbl10);
            this.panel_operation_status.Controls.Add(this.lbl03);
            this.panel_operation_status.Controls.Add(this.lbl35);
            this.panel_operation_status.Controls.Add(this.lbl26);
            this.panel_operation_status.Controls.Add(this.lbl23);
            this.panel_operation_status.Controls.Add(this.lbl14);
            this.panel_operation_status.Controls.Add(this.lbl11);
            this.panel_operation_status.Controls.Add(this.lbl02);
            this.panel_operation_status.Controls.Add(this.lbl36);
            this.panel_operation_status.Controls.Add(this.lbl25);
            this.panel_operation_status.Controls.Add(this.lbl24);
            this.panel_operation_status.Controls.Add(this.lbl13);
            this.panel_operation_status.Controls.Add(this.lbl12);
            this.panel_operation_status.Controls.Add(this.label33);
            this.panel_operation_status.Controls.Add(this.label34);
            this.panel_operation_status.Controls.Add(this.label29);
            this.panel_operation_status.Controls.Add(this.label31);
            this.panel_operation_status.Controls.Add(this.label27);
            this.panel_operation_status.Controls.Add(this.lbl01);
            this.panel_operation_status.Controls.Add(this.label21);
            this.panel_operation_status.Controls.Add(this.lblProcess2);
            this.panel_operation_status.Controls.Add(this.lblProcess1);
            this.panel_operation_status.Controls.Add(this.lblProcess3);
            this.panel_operation_status.Controls.Add(this.lblProcess0);
            this.panel_operation_status.Controls.Add(this.lbl_Machine_Process);
            this.panel_operation_status.Location = new System.Drawing.Point(1, 766);
            this.panel_operation_status.Name = "panel_operation_status";
            this.panel_operation_status.Size = new System.Drawing.Size(312, 288);
            this.panel_operation_status.TabIndex = 30;
            this.panel_operation_status.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_operation_status_Paint);
            // 
            // lbl31
            // 
            this.lbl31.BackColor = System.Drawing.Color.Red;
            this.lbl31.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl31.ForeColor = System.Drawing.Color.White;
            this.lbl31.Location = new System.Drawing.Point(5, 259);
            this.lbl31.Name = "lbl31";
            this.lbl31.Size = new System.Drawing.Size(41, 25);
            this.lbl31.TabIndex = 187;
            this.lbl31.Text = "31";
            this.lbl31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl30
            // 
            this.lbl30.BackColor = System.Drawing.Color.Red;
            this.lbl30.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl30.ForeColor = System.Drawing.Color.White;
            this.lbl30.Location = new System.Drawing.Point(56, 259);
            this.lbl30.Name = "lbl30";
            this.lbl30.Size = new System.Drawing.Size(41, 25);
            this.lbl30.TabIndex = 186;
            this.lbl30.Text = "30";
            this.lbl30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl19
            // 
            this.lbl19.BackColor = System.Drawing.Color.Red;
            this.lbl19.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl19.ForeColor = System.Drawing.Color.White;
            this.lbl19.Location = new System.Drawing.Point(107, 257);
            this.lbl19.Name = "lbl19";
            this.lbl19.Size = new System.Drawing.Size(41, 25);
            this.lbl19.TabIndex = 185;
            this.lbl19.Text = "19";
            this.lbl19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl18
            // 
            this.lbl18.BackColor = System.Drawing.Color.Red;
            this.lbl18.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl18.ForeColor = System.Drawing.Color.White;
            this.lbl18.Location = new System.Drawing.Point(158, 257);
            this.lbl18.Name = "lbl18";
            this.lbl18.Size = new System.Drawing.Size(41, 25);
            this.lbl18.TabIndex = 184;
            this.lbl18.Text = "18";
            this.lbl18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl07
            // 
            this.lbl07.BackColor = System.Drawing.Color.Red;
            this.lbl07.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl07.ForeColor = System.Drawing.Color.White;
            this.lbl07.Location = new System.Drawing.Point(209, 257);
            this.lbl07.Name = "lbl07";
            this.lbl07.Size = new System.Drawing.Size(41, 25);
            this.lbl07.TabIndex = 183;
            this.lbl07.Text = "07";
            this.lbl07.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl06
            // 
            this.lbl06.BackColor = System.Drawing.Color.Red;
            this.lbl06.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl06.ForeColor = System.Drawing.Color.White;
            this.lbl06.Location = new System.Drawing.Point(260, 257);
            this.lbl06.Name = "lbl06";
            this.lbl06.Size = new System.Drawing.Size(41, 25);
            this.lbl06.TabIndex = 182;
            this.lbl06.Text = "06";
            this.lbl06.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl32
            // 
            this.lbl32.BackColor = System.Drawing.Color.Red;
            this.lbl32.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl32.ForeColor = System.Drawing.Color.White;
            this.lbl32.Location = new System.Drawing.Point(5, 225);
            this.lbl32.Name = "lbl32";
            this.lbl32.Size = new System.Drawing.Size(41, 25);
            this.lbl32.TabIndex = 181;
            this.lbl32.Text = "32";
            this.lbl32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl29
            // 
            this.lbl29.BackColor = System.Drawing.Color.Red;
            this.lbl29.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl29.ForeColor = System.Drawing.Color.White;
            this.lbl29.Location = new System.Drawing.Point(56, 225);
            this.lbl29.Name = "lbl29";
            this.lbl29.Size = new System.Drawing.Size(41, 25);
            this.lbl29.TabIndex = 180;
            this.lbl29.Text = "29";
            this.lbl29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl20
            // 
            this.lbl20.BackColor = System.Drawing.Color.Red;
            this.lbl20.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl20.ForeColor = System.Drawing.Color.White;
            this.lbl20.Location = new System.Drawing.Point(107, 223);
            this.lbl20.Name = "lbl20";
            this.lbl20.Size = new System.Drawing.Size(41, 25);
            this.lbl20.TabIndex = 179;
            this.lbl20.Text = "20";
            this.lbl20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl17
            // 
            this.lbl17.BackColor = System.Drawing.Color.Red;
            this.lbl17.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl17.ForeColor = System.Drawing.Color.White;
            this.lbl17.Location = new System.Drawing.Point(158, 223);
            this.lbl17.Name = "lbl17";
            this.lbl17.Size = new System.Drawing.Size(41, 25);
            this.lbl17.TabIndex = 178;
            this.lbl17.Text = "17";
            this.lbl17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl08
            // 
            this.lbl08.BackColor = System.Drawing.Color.Red;
            this.lbl08.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl08.ForeColor = System.Drawing.Color.White;
            this.lbl08.Location = new System.Drawing.Point(209, 223);
            this.lbl08.Name = "lbl08";
            this.lbl08.Size = new System.Drawing.Size(41, 25);
            this.lbl08.TabIndex = 177;
            this.lbl08.Text = "08";
            this.lbl08.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl05
            // 
            this.lbl05.BackColor = System.Drawing.Color.Red;
            this.lbl05.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl05.ForeColor = System.Drawing.Color.White;
            this.lbl05.Location = new System.Drawing.Point(260, 223);
            this.lbl05.Name = "lbl05";
            this.lbl05.Size = new System.Drawing.Size(41, 25);
            this.lbl05.TabIndex = 176;
            this.lbl05.Text = "05";
            this.lbl05.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl33
            // 
            this.lbl33.BackColor = System.Drawing.Color.Red;
            this.lbl33.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl33.ForeColor = System.Drawing.Color.White;
            this.lbl33.Location = new System.Drawing.Point(5, 191);
            this.lbl33.Name = "lbl33";
            this.lbl33.Size = new System.Drawing.Size(41, 25);
            this.lbl33.TabIndex = 175;
            this.lbl33.Text = "33";
            this.lbl33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl28
            // 
            this.lbl28.BackColor = System.Drawing.Color.Red;
            this.lbl28.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl28.ForeColor = System.Drawing.Color.White;
            this.lbl28.Location = new System.Drawing.Point(56, 191);
            this.lbl28.Name = "lbl28";
            this.lbl28.Size = new System.Drawing.Size(41, 25);
            this.lbl28.TabIndex = 174;
            this.lbl28.Text = "28";
            this.lbl28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl21
            // 
            this.lbl21.BackColor = System.Drawing.Color.Red;
            this.lbl21.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl21.ForeColor = System.Drawing.Color.White;
            this.lbl21.Location = new System.Drawing.Point(107, 189);
            this.lbl21.Name = "lbl21";
            this.lbl21.Size = new System.Drawing.Size(41, 25);
            this.lbl21.TabIndex = 173;
            this.lbl21.Text = "21";
            this.lbl21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl16
            // 
            this.lbl16.BackColor = System.Drawing.Color.Red;
            this.lbl16.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl16.ForeColor = System.Drawing.Color.White;
            this.lbl16.Location = new System.Drawing.Point(158, 189);
            this.lbl16.Name = "lbl16";
            this.lbl16.Size = new System.Drawing.Size(41, 25);
            this.lbl16.TabIndex = 172;
            this.lbl16.Text = "16";
            this.lbl16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl09
            // 
            this.lbl09.BackColor = System.Drawing.Color.Red;
            this.lbl09.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl09.ForeColor = System.Drawing.Color.White;
            this.lbl09.Location = new System.Drawing.Point(209, 189);
            this.lbl09.Name = "lbl09";
            this.lbl09.Size = new System.Drawing.Size(41, 25);
            this.lbl09.TabIndex = 171;
            this.lbl09.Text = "09";
            this.lbl09.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl04
            // 
            this.lbl04.BackColor = System.Drawing.Color.Red;
            this.lbl04.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl04.ForeColor = System.Drawing.Color.White;
            this.lbl04.Location = new System.Drawing.Point(260, 189);
            this.lbl04.Name = "lbl04";
            this.lbl04.Size = new System.Drawing.Size(41, 25);
            this.lbl04.TabIndex = 170;
            this.lbl04.Text = "04";
            this.lbl04.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl34
            // 
            this.lbl34.BackColor = System.Drawing.Color.Red;
            this.lbl34.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl34.ForeColor = System.Drawing.Color.White;
            this.lbl34.Location = new System.Drawing.Point(5, 157);
            this.lbl34.Name = "lbl34";
            this.lbl34.Size = new System.Drawing.Size(41, 25);
            this.lbl34.TabIndex = 169;
            this.lbl34.Text = "34";
            this.lbl34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl27
            // 
            this.lbl27.BackColor = System.Drawing.Color.Red;
            this.lbl27.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl27.ForeColor = System.Drawing.Color.White;
            this.lbl27.Location = new System.Drawing.Point(56, 157);
            this.lbl27.Name = "lbl27";
            this.lbl27.Size = new System.Drawing.Size(41, 25);
            this.lbl27.TabIndex = 168;
            this.lbl27.Text = "27";
            this.lbl27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl22
            // 
            this.lbl22.BackColor = System.Drawing.Color.Red;
            this.lbl22.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl22.ForeColor = System.Drawing.Color.White;
            this.lbl22.Location = new System.Drawing.Point(107, 155);
            this.lbl22.Name = "lbl22";
            this.lbl22.Size = new System.Drawing.Size(41, 25);
            this.lbl22.TabIndex = 167;
            this.lbl22.Text = "22";
            this.lbl22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl15
            // 
            this.lbl15.BackColor = System.Drawing.Color.Red;
            this.lbl15.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl15.ForeColor = System.Drawing.Color.White;
            this.lbl15.Location = new System.Drawing.Point(158, 155);
            this.lbl15.Name = "lbl15";
            this.lbl15.Size = new System.Drawing.Size(41, 25);
            this.lbl15.TabIndex = 166;
            this.lbl15.Text = "15";
            this.lbl15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl10
            // 
            this.lbl10.BackColor = System.Drawing.Color.Red;
            this.lbl10.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl10.ForeColor = System.Drawing.Color.White;
            this.lbl10.Location = new System.Drawing.Point(209, 155);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(41, 25);
            this.lbl10.TabIndex = 165;
            this.lbl10.Text = "10";
            this.lbl10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl03
            // 
            this.lbl03.BackColor = System.Drawing.Color.Red;
            this.lbl03.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl03.ForeColor = System.Drawing.Color.White;
            this.lbl03.Location = new System.Drawing.Point(260, 155);
            this.lbl03.Name = "lbl03";
            this.lbl03.Size = new System.Drawing.Size(41, 25);
            this.lbl03.TabIndex = 164;
            this.lbl03.Text = "03";
            this.lbl03.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl35
            // 
            this.lbl35.BackColor = System.Drawing.Color.Red;
            this.lbl35.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl35.ForeColor = System.Drawing.Color.White;
            this.lbl35.Location = new System.Drawing.Point(5, 123);
            this.lbl35.Name = "lbl35";
            this.lbl35.Size = new System.Drawing.Size(41, 25);
            this.lbl35.TabIndex = 163;
            this.lbl35.Text = "35";
            this.lbl35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl26
            // 
            this.lbl26.BackColor = System.Drawing.Color.Red;
            this.lbl26.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl26.ForeColor = System.Drawing.Color.White;
            this.lbl26.Location = new System.Drawing.Point(56, 123);
            this.lbl26.Name = "lbl26";
            this.lbl26.Size = new System.Drawing.Size(41, 25);
            this.lbl26.TabIndex = 162;
            this.lbl26.Text = "26";
            this.lbl26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl23
            // 
            this.lbl23.BackColor = System.Drawing.Color.Red;
            this.lbl23.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl23.ForeColor = System.Drawing.Color.White;
            this.lbl23.Location = new System.Drawing.Point(107, 121);
            this.lbl23.Name = "lbl23";
            this.lbl23.Size = new System.Drawing.Size(41, 25);
            this.lbl23.TabIndex = 161;
            this.lbl23.Text = "23";
            this.lbl23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl14
            // 
            this.lbl14.BackColor = System.Drawing.Color.Red;
            this.lbl14.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl14.ForeColor = System.Drawing.Color.White;
            this.lbl14.Location = new System.Drawing.Point(158, 121);
            this.lbl14.Name = "lbl14";
            this.lbl14.Size = new System.Drawing.Size(41, 25);
            this.lbl14.TabIndex = 160;
            this.lbl14.Text = "14";
            this.lbl14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl11
            // 
            this.lbl11.BackColor = System.Drawing.Color.Red;
            this.lbl11.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl11.ForeColor = System.Drawing.Color.White;
            this.lbl11.Location = new System.Drawing.Point(209, 121);
            this.lbl11.Name = "lbl11";
            this.lbl11.Size = new System.Drawing.Size(41, 25);
            this.lbl11.TabIndex = 159;
            this.lbl11.Text = "11";
            this.lbl11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl02
            // 
            this.lbl02.BackColor = System.Drawing.Color.Red;
            this.lbl02.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl02.ForeColor = System.Drawing.Color.White;
            this.lbl02.Location = new System.Drawing.Point(260, 121);
            this.lbl02.Name = "lbl02";
            this.lbl02.Size = new System.Drawing.Size(41, 25);
            this.lbl02.TabIndex = 158;
            this.lbl02.Text = "02";
            this.lbl02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl36
            // 
            this.lbl36.BackColor = System.Drawing.Color.Red;
            this.lbl36.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl36.ForeColor = System.Drawing.Color.White;
            this.lbl36.Location = new System.Drawing.Point(5, 89);
            this.lbl36.Name = "lbl36";
            this.lbl36.Size = new System.Drawing.Size(41, 25);
            this.lbl36.TabIndex = 157;
            this.lbl36.Text = "36";
            this.lbl36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl25
            // 
            this.lbl25.BackColor = System.Drawing.Color.Red;
            this.lbl25.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl25.ForeColor = System.Drawing.Color.White;
            this.lbl25.Location = new System.Drawing.Point(56, 89);
            this.lbl25.Name = "lbl25";
            this.lbl25.Size = new System.Drawing.Size(41, 25);
            this.lbl25.TabIndex = 156;
            this.lbl25.Text = "25";
            this.lbl25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl24
            // 
            this.lbl24.BackColor = System.Drawing.Color.Red;
            this.lbl24.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl24.ForeColor = System.Drawing.Color.White;
            this.lbl24.Location = new System.Drawing.Point(107, 87);
            this.lbl24.Name = "lbl24";
            this.lbl24.Size = new System.Drawing.Size(41, 25);
            this.lbl24.TabIndex = 155;
            this.lbl24.Text = "24";
            this.lbl24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl13
            // 
            this.lbl13.BackColor = System.Drawing.Color.Red;
            this.lbl13.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl13.ForeColor = System.Drawing.Color.White;
            this.lbl13.Location = new System.Drawing.Point(158, 87);
            this.lbl13.Name = "lbl13";
            this.lbl13.Size = new System.Drawing.Size(41, 25);
            this.lbl13.TabIndex = 154;
            this.lbl13.Text = "13";
            this.lbl13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl12
            // 
            this.lbl12.BackColor = System.Drawing.Color.Red;
            this.lbl12.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl12.ForeColor = System.Drawing.Color.White;
            this.lbl12.Location = new System.Drawing.Point(209, 87);
            this.lbl12.Name = "lbl12";
            this.lbl12.Size = new System.Drawing.Size(41, 25);
            this.lbl12.TabIndex = 153;
            this.lbl12.Text = "12";
            this.lbl12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label33
            // 
            this.label33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.label33.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.White;
            this.label33.Location = new System.Drawing.Point(63, 63);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(18, 22);
            this.label33.TabIndex = 152;
            this.label33.Text = "→";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label34
            // 
            this.label34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.label34.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.White;
            this.label34.Location = new System.Drawing.Point(63, 43);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(18, 22);
            this.label34.TabIndex = 151;
            this.label34.Text = "←";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label29
            // 
            this.label29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.label29.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.White;
            this.label29.Location = new System.Drawing.Point(144, 63);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(18, 22);
            this.label29.TabIndex = 150;
            this.label29.Text = "→";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label31
            // 
            this.label31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.label31.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.White;
            this.label31.Location = new System.Drawing.Point(144, 43);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(18, 22);
            this.label31.TabIndex = 149;
            this.label31.Text = "←";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label27
            // 
            this.label27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.label27.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(225, 62);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(18, 22);
            this.label27.TabIndex = 148;
            this.label27.Text = "→";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl01
            // 
            this.lbl01.BackColor = System.Drawing.Color.Red;
            this.lbl01.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl01.ForeColor = System.Drawing.Color.White;
            this.lbl01.Location = new System.Drawing.Point(260, 87);
            this.lbl01.Name = "lbl01";
            this.lbl01.Size = new System.Drawing.Size(41, 25);
            this.lbl01.TabIndex = 31;
            this.lbl01.Text = "01";
            this.lbl01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.label21.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(225, 42);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(18, 22);
            this.label21.TabIndex = 147;
            this.label21.Text = "←";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProcess2
            // 
            this.lblProcess2.BackColor = System.Drawing.Color.SteelBlue;
            this.lblProcess2.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblProcess2.ForeColor = System.Drawing.SystemColors.Info;
            this.lblProcess2.Location = new System.Drawing.Point(164, 44);
            this.lblProcess2.Name = "lblProcess2";
            this.lblProcess2.Size = new System.Drawing.Size(58, 39);
            this.lblProcess2.TabIndex = 32;
            this.lblProcess2.Text = "細磨";
            this.lblProcess2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbo_polish_cnt);
            this.groupBox1.Controls.Add(this.label47);
            this.groupBox1.Controls.Add(this.textBox_sample_dir);
            this.groupBox1.Controls.Add(this.btn_setup_sampledir);
            this.groupBox1.Controls.Add(this.btn_save_sample);
            this.groupBox1.Controls.Add(this.btn_load_sample);
            this.groupBox1.Location = new System.Drawing.Point(4, 538);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 133);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            // 
            // cbo_polish_cnt
            // 
            this.cbo_polish_cnt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_polish_cnt.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbo_polish_cnt.FormattingEnabled = true;
            this.cbo_polish_cnt.ItemHeight = 19;
            this.cbo_polish_cnt.Items.AddRange(new object[] {
            "第1次研磨",
            "第2次研磨",
            "第3次研磨",
            "第4次研磨"});
            this.cbo_polish_cnt.Location = new System.Drawing.Point(242, 97);
            this.cbo_polish_cnt.Name = "cbo_polish_cnt";
            this.cbo_polish_cnt.Size = new System.Drawing.Size(125, 27);
            this.cbo_polish_cnt.TabIndex = 90;
            // 
            // label47
            // 
            this.label47.BackColor = System.Drawing.Color.Gold;
            this.label47.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label47.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label47.Location = new System.Drawing.Point(4, 15);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(483, 38);
            this.label47.TabIndex = 27;
            this.label47.Text = "樣本工作目錄與存取";
            this.label47.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_sample_dir
            // 
            this.textBox_sample_dir.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_sample_dir.Location = new System.Drawing.Point(3, 59);
            this.textBox_sample_dir.Name = "textBox_sample_dir";
            this.textBox_sample_dir.Size = new System.Drawing.Size(418, 32);
            this.textBox_sample_dir.TabIndex = 28;
            // 
            // btn_setup_sampledir
            // 
            this.btn_setup_sampledir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_setup_sampledir.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.btn_setup_sampledir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_setup_sampledir.ButtonImage = null;
            this.btn_setup_sampledir.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btn_setup_sampledir.ButtonText = "選擇";
            this.btn_setup_sampledir.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btn_setup_sampledir.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btn_setup_sampledir.CornerRadius = 2;
            this.btn_setup_sampledir.Enabled = false;
            this.btn_setup_sampledir.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_setup_sampledir.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_setup_sampledir.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btn_setup_sampledir.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.btn_setup_sampledir.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_setup_sampledir.Location = new System.Drawing.Point(423, 59);
            this.btn_setup_sampledir.Margin = new System.Windows.Forms.Padding(6);
            this.btn_setup_sampledir.Name = "btn_setup_sampledir";
            this.btn_setup_sampledir.Padding = new System.Windows.Forms.Padding(3);
            this.btn_setup_sampledir.Size = new System.Drawing.Size(64, 32);
            this.btn_setup_sampledir.TabIndex = 86;
            this.btn_setup_sampledir.TextColor = System.Drawing.Color.Black;
            this.btn_setup_sampledir.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_setup_sampledir.Click += new System.EventHandler(this.Button_Load_Images_Click);
            // 
            // btn_save_sample
            // 
            this.btn_save_sample.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save_sample.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.btn_save_sample.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_save_sample.ButtonImage = null;
            this.btn_save_sample.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btn_save_sample.ButtonText = "儲存樣本";
            this.btn_save_sample.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btn_save_sample.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btn_save_sample.CornerRadius = 2;
            this.btn_save_sample.Enabled = false;
            this.btn_save_sample.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_save_sample.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_save_sample.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btn_save_sample.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.btn_save_sample.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_save_sample.Location = new System.Drawing.Point(3, 97);
            this.btn_save_sample.Margin = new System.Windows.Forms.Padding(6);
            this.btn_save_sample.Name = "btn_save_sample";
            this.btn_save_sample.Padding = new System.Windows.Forms.Padding(3);
            this.btn_save_sample.Size = new System.Drawing.Size(230, 29);
            this.btn_save_sample.TabIndex = 87;
            this.btn_save_sample.TextColor = System.Drawing.Color.Black;
            this.btn_save_sample.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btn_load_sample
            // 
            this.btn_load_sample.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_load_sample.BackgroundColor = System.Drawing.Color.Tan;
            this.btn_load_sample.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_load_sample.ButtonImage = null;
            this.btn_load_sample.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btn_load_sample.ButtonText = "載入樣本";
            this.btn_load_sample.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btn_load_sample.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btn_load_sample.CornerRadius = 2;
            this.btn_load_sample.Enabled = false;
            this.btn_load_sample.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_load_sample.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_load_sample.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btn_load_sample.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.btn_load_sample.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_load_sample.Location = new System.Drawing.Point(373, 97);
            this.btn_load_sample.Margin = new System.Windows.Forms.Padding(6);
            this.btn_load_sample.Name = "btn_load_sample";
            this.btn_load_sample.Padding = new System.Windows.Forms.Padding(3);
            this.btn_load_sample.Size = new System.Drawing.Size(114, 27);
            this.btn_load_sample.TabIndex = 88;
            this.btn_load_sample.TextColor = System.Drawing.Color.Black;
            this.btn_load_sample.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblMarkDel);
            this.panel1.Controls.Add(this.gswDelMark);
            this.panel1.Controls.Add(this.lblSplDel);
            this.panel1.Controls.Add(this.gswDelSpl);
            this.panel1.Controls.Add(this.xuiButton3);
            this.panel1.Controls.Add(this.xuiButton2);
            this.panel1.Controls.Add(this.btn_sample_mark);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.xuiButton1);
            this.panel1.Controls.Add(this.btn_Rotate_OrgImg);
            this.panel1.Controls.Add(this.label_SideSample_stat);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.Button_abandon);
            this.panel1.Controls.Add(this.textBox_sample_count);
            this.panel1.Controls.Add(this.button_reset);
            this.panel1.Controls.Add(this.button_recgon);
            this.panel1.Controls.Add(this.button_prev);
            this.panel1.Controls.Add(this.button_next);
            this.panel1.Controls.Add(this.button_side_length);
            this.panel1.Controls.Add(this.button_all_auto);
            this.panel1.Location = new System.Drawing.Point(829, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 807);
            this.panel1.TabIndex = 45;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblMarkDel
            // 
            this.lblMarkDel.BackColor = System.Drawing.Color.Orange;
            this.lblMarkDel.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMarkDel.ForeColor = System.Drawing.Color.Black;
            this.lblMarkDel.Location = new System.Drawing.Point(51, 541);
            this.lblMarkDel.Name = "lblMarkDel";
            this.lblMarkDel.Size = new System.Drawing.Size(57, 37);
            this.lblMarkDel.TabIndex = 101;
            this.lblMarkDel.Text = "現有";
            this.lblMarkDel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gswDelMark
            // 
            this.gswDelMark.BackColor = System.Drawing.Color.Transparent;
            this.gswDelMark.Enabled = false;
            this.gswDelMark.FlatAppearance.BorderSize = 0;
            this.gswDelMark.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.gswDelMark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gswDelMark.ForeColor = System.Drawing.Color.Black;
            this.gswDelMark.Image = global::PropInnerImageAnalysis.Properties.Resources.toggle_off;
            this.gswDelMark.Location = new System.Drawing.Point(10, 538);
            this.gswDelMark.Name = "gswDelMark";
            this.gswDelMark.Size = new System.Drawing.Size(38, 42);
            this.gswDelMark.TabIndex = 100;
            this.gswDelMark.UseVisualStyleBackColor = false;
            this.gswDelMark.Click += new System.EventHandler(this.gswDelMark_Click);
            // 
            // lblSplDel
            // 
            this.lblSplDel.BackColor = System.Drawing.Color.Orange;
            this.lblSplDel.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSplDel.ForeColor = System.Drawing.Color.Black;
            this.lblSplDel.Location = new System.Drawing.Point(51, 492);
            this.lblSplDel.Name = "lblSplDel";
            this.lblSplDel.Size = new System.Drawing.Size(57, 37);
            this.lblSplDel.TabIndex = 99;
            this.lblSplDel.Text = "現有";
            this.lblSplDel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gswDelSpl
            // 
            this.gswDelSpl.BackColor = System.Drawing.Color.Transparent;
            this.gswDelSpl.Enabled = false;
            this.gswDelSpl.FlatAppearance.BorderSize = 0;
            this.gswDelSpl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.gswDelSpl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gswDelSpl.ForeColor = System.Drawing.Color.Black;
            this.gswDelSpl.Image = global::PropInnerImageAnalysis.Properties.Resources.toggle_off;
            this.gswDelSpl.Location = new System.Drawing.Point(10, 489);
            this.gswDelSpl.Name = "gswDelSpl";
            this.gswDelSpl.Size = new System.Drawing.Size(38, 42);
            this.gswDelSpl.TabIndex = 98;
            this.gswDelSpl.UseVisualStyleBackColor = false;
            this.gswDelSpl.Click += new System.EventHandler(this.gswDelSpl_Click);
            // 
            // xuiButton3
            // 
            this.xuiButton3.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.xuiButton3.ButtonImage = global::PropInnerImageAnalysis.Properties.Resources.Measure;
            this.xuiButton3.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton3.ButtonText = "自由量測";
            this.xuiButton3.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.xuiButton3.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.xuiButton3.CornerRadius = 5;
            this.xuiButton3.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.xuiButton3.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton3.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.xuiButton3.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.xuiButton3.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton3.Location = new System.Drawing.Point(4, 382);
            this.xuiButton3.Name = "xuiButton3";
            this.xuiButton3.Size = new System.Drawing.Size(268, 49);
            this.xuiButton3.TabIndex = 97;
            this.xuiButton3.TextColor = System.Drawing.Color.Black;
            this.xuiButton3.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // xuiButton2
            // 
            this.xuiButton2.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.xuiButton2.ButtonImage = null;
            this.xuiButton2.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton2.ButtonText = "捨棄標示";
            this.xuiButton2.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.xuiButton2.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.xuiButton2.CornerRadius = 5;
            this.xuiButton2.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.xuiButton2.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton2.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.xuiButton2.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.xuiButton2.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton2.Location = new System.Drawing.Point(110, 538);
            this.xuiButton2.Name = "xuiButton2";
            this.xuiButton2.Size = new System.Drawing.Size(158, 44);
            this.xuiButton2.TabIndex = 96;
            this.xuiButton2.TextColor = System.Drawing.Color.Black;
            this.xuiButton2.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btn_sample_mark
            // 
            this.btn_sample_mark.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.btn_sample_mark.ButtonImage = global::PropInnerImageAnalysis.Properties.Resources.Inspect;
            this.btn_sample_mark.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btn_sample_mark.ButtonText = "樣本標示";
            this.btn_sample_mark.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.btn_sample_mark.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.btn_sample_mark.CornerRadius = 5;
            this.btn_sample_mark.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_sample_mark.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_sample_mark.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btn_sample_mark.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btn_sample_mark.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_sample_mark.Location = new System.Drawing.Point(4, 328);
            this.btn_sample_mark.Name = "btn_sample_mark";
            this.btn_sample_mark.Size = new System.Drawing.Size(268, 49);
            this.btn_sample_mark.TabIndex = 95;
            this.btn_sample_mark.TextColor = System.Drawing.Color.Black;
            this.btn_sample_mark.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // xuiButton1
            // 
            this.xuiButton1.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.xuiButton1.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton1.ButtonImage")));
            this.xuiButton1.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton1.ButtonText = "調整辨識結果";
            this.xuiButton1.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.xuiButton1.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.xuiButton1.CornerRadius = 5;
            this.xuiButton1.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.xuiButton1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton1.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.xuiButton1.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.xuiButton1.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton1.Location = new System.Drawing.Point(5, 274);
            this.xuiButton1.Name = "xuiButton1";
            this.xuiButton1.Size = new System.Drawing.Size(267, 49);
            this.xuiButton1.TabIndex = 94;
            this.xuiButton1.TextColor = System.Drawing.Color.Black;
            this.xuiButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btn_Rotate_OrgImg
            // 
            this.btn_Rotate_OrgImg.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.btn_Rotate_OrgImg.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btn_Rotate_OrgImg.ButtonImage")));
            this.btn_Rotate_OrgImg.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btn_Rotate_OrgImg.ButtonText = "旋轉原始影像";
            this.btn_Rotate_OrgImg.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.btn_Rotate_OrgImg.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.btn_Rotate_OrgImg.CornerRadius = 5;
            this.btn_Rotate_OrgImg.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Rotate_OrgImg.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Rotate_OrgImg.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btn_Rotate_OrgImg.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btn_Rotate_OrgImg.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_Rotate_OrgImg.Location = new System.Drawing.Point(5, 436);
            this.btn_Rotate_OrgImg.Name = "btn_Rotate_OrgImg";
            this.btn_Rotate_OrgImg.Size = new System.Drawing.Size(267, 49);
            this.btn_Rotate_OrgImg.TabIndex = 93;
            this.btn_Rotate_OrgImg.TextColor = System.Drawing.Color.Black;
            this.btn_Rotate_OrgImg.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // Button_abandon
            // 
            this.Button_abandon.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.Button_abandon.ButtonImage = null;
            this.Button_abandon.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.Button_abandon.ButtonText = "捨棄樣本";
            this.Button_abandon.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.Button_abandon.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.Button_abandon.CornerRadius = 5;
            this.Button_abandon.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Button_abandon.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.Button_abandon.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.Button_abandon.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.Button_abandon.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.Button_abandon.Location = new System.Drawing.Point(110, 489);
            this.Button_abandon.Name = "Button_abandon";
            this.Button_abandon.Size = new System.Drawing.Size(158, 43);
            this.Button_abandon.TabIndex = 90;
            this.Button_abandon.TextColor = System.Drawing.Color.Black;
            this.Button_abandon.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.Button_abandon.Click += new System.EventHandler(this.Button_abandon_Click);
            // 
            // button_recgon
            // 
            this.button_recgon.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.button_recgon.ButtonImage = ((System.Drawing.Image)(resources.GetObject("button_recgon.ButtonImage")));
            this.button_recgon.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.button_recgon.ButtonText = "輪廓與孔洞辨識";
            this.button_recgon.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.button_recgon.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.button_recgon.CornerRadius = 5;
            this.button_recgon.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_recgon.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.button_recgon.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.button_recgon.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.button_recgon.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.button_recgon.Location = new System.Drawing.Point(5, 173);
            this.button_recgon.Name = "button_recgon";
            this.button_recgon.Size = new System.Drawing.Size(267, 43);
            this.button_recgon.TabIndex = 33;
            this.button_recgon.TextColor = System.Drawing.Color.Black;
            this.button_recgon.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.button_recgon.Click += new System.EventHandler(this.button_recogn_Click);
            // 
            // button_prev
            // 
            this.button_prev.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.button_prev.ButtonImage = ((System.Drawing.Image)(resources.GetObject("button_prev.ButtonImage")));
            this.button_prev.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.button_prev.ButtonText = "";
            this.button_prev.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.button_prev.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.button_prev.CornerRadius = 5;
            this.button_prev.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button_prev.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.button_prev.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.button_prev.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.button_prev.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.button_prev.Location = new System.Drawing.Point(6, 634);
            this.button_prev.Name = "button_prev";
            this.button_prev.Size = new System.Drawing.Size(53, 48);
            this.button_prev.TabIndex = 34;
            this.button_prev.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.button_prev.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.button_prev.Click += new System.EventHandler(this.button_prev_Click);
            // 
            // button_next
            // 
            this.button_next.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.button_next.ButtonImage = ((System.Drawing.Image)(resources.GetObject("button_next.ButtonImage")));
            this.button_next.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.button_next.ButtonText = "";
            this.button_next.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.button_next.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.button_next.CornerRadius = 5;
            this.button_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button_next.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.button_next.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.button_next.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.button_next.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.button_next.Location = new System.Drawing.Point(217, 634);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(53, 48);
            this.button_next.TabIndex = 36;
            this.button_next.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.button_next.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // button_side_length
            // 
            this.button_side_length.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.button_side_length.ButtonImage = ((System.Drawing.Image)(resources.GetObject("button_side_length.ButtonImage")));
            this.button_side_length.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.button_side_length.ButtonText = "包面比例辨識";
            this.button_side_length.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.button_side_length.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.button_side_length.CornerRadius = 5;
            this.button_side_length.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_side_length.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.button_side_length.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.button_side_length.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.button_side_length.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.button_side_length.Location = new System.Drawing.Point(5, 221);
            this.button_side_length.Name = "button_side_length";
            this.button_side_length.Size = new System.Drawing.Size(267, 48);
            this.button_side_length.TabIndex = 37;
            this.button_side_length.TextColor = System.Drawing.Color.Black;
            this.button_side_length.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // button_all_auto
            // 
            this.button_all_auto.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.button_all_auto.ButtonImage = ((System.Drawing.Image)(resources.GetObject("button_all_auto.ButtonImage")));
            this.button_all_auto.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.button_all_auto.ButtonText = "全自動辨識";
            this.button_all_auto.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.button_all_auto.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.button_all_auto.CornerRadius = 5;
            this.button_all_auto.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_all_auto.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.button_all_auto.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.button_all_auto.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.button_all_auto.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.button_all_auto.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.button_all_auto.Location = new System.Drawing.Point(5, 124);
            this.button_all_auto.Name = "button_all_auto";
            this.button_all_auto.Size = new System.Drawing.Size(267, 44);
            this.button_all_auto.TabIndex = 38;
            this.button_all_auto.TextColor = System.Drawing.Color.Black;
            this.button_all_auto.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.button_all_auto.Click += new System.EventHandler(this.button_all_auto_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_load_parafile);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.btn_save_parafile);
            this.groupBox4.Controls.Add(this.textBox_parafile);
            this.groupBox4.Controls.Add(this.btn_setup_parafile);
            this.groupBox4.Location = new System.Drawing.Point(2, 676);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(496, 127);
            this.groupBox4.TabIndex = 89;
            this.groupBox4.TabStop = false;
            // 
            // btn_load_parafile
            // 
            this.btn_load_parafile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_load_parafile.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.btn_load_parafile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_load_parafile.ButtonImage = null;
            this.btn_load_parafile.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btn_load_parafile.ButtonText = "載入參數";
            this.btn_load_parafile.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btn_load_parafile.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btn_load_parafile.CornerRadius = 2;
            this.btn_load_parafile.Enabled = false;
            this.btn_load_parafile.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_load_parafile.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_load_parafile.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btn_load_parafile.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.btn_load_parafile.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_load_parafile.Location = new System.Drawing.Point(286, 83);
            this.btn_load_parafile.Margin = new System.Windows.Forms.Padding(6);
            this.btn_load_parafile.Name = "btn_load_parafile";
            this.btn_load_parafile.Padding = new System.Windows.Forms.Padding(3);
            this.btn_load_parafile.Size = new System.Drawing.Size(206, 41);
            this.btn_load_parafile.TabIndex = 88;
            this.btn_load_parafile.TextColor = System.Drawing.Color.Black;
            this.btn_load_parafile.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.Gold;
            this.label20.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label20.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label20.Location = new System.Drawing.Point(4, 15);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(486, 29);
            this.label20.TabIndex = 27;
            this.label20.Text = "參數檔案與存取";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_save_parafile
            // 
            this.btn_save_parafile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save_parafile.BackgroundColor = System.Drawing.Color.Peru;
            this.btn_save_parafile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_save_parafile.ButtonImage = null;
            this.btn_save_parafile.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btn_save_parafile.ButtonText = "儲存參數";
            this.btn_save_parafile.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btn_save_parafile.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btn_save_parafile.CornerRadius = 2;
            this.btn_save_parafile.Enabled = false;
            this.btn_save_parafile.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_save_parafile.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_save_parafile.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btn_save_parafile.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.btn_save_parafile.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_save_parafile.Location = new System.Drawing.Point(4, 83);
            this.btn_save_parafile.Margin = new System.Windows.Forms.Padding(6);
            this.btn_save_parafile.Name = "btn_save_parafile";
            this.btn_save_parafile.Padding = new System.Windows.Forms.Padding(3);
            this.btn_save_parafile.Size = new System.Drawing.Size(281, 41);
            this.btn_save_parafile.TabIndex = 87;
            this.btn_save_parafile.TextColor = System.Drawing.Color.Black;
            this.btn_save_parafile.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // textBox_parafile
            // 
            this.textBox_parafile.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_parafile.Location = new System.Drawing.Point(3, 47);
            this.textBox_parafile.Name = "textBox_parafile";
            this.textBox_parafile.Size = new System.Drawing.Size(420, 32);
            this.textBox_parafile.TabIndex = 28;
            // 
            // btn_setup_parafile
            // 
            this.btn_setup_parafile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_setup_parafile.BackgroundColor = System.Drawing.Color.Peru;
            this.btn_setup_parafile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_setup_parafile.ButtonImage = null;
            this.btn_setup_parafile.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btn_setup_parafile.ButtonText = "選擇";
            this.btn_setup_parafile.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btn_setup_parafile.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btn_setup_parafile.CornerRadius = 2;
            this.btn_setup_parafile.Enabled = false;
            this.btn_setup_parafile.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_setup_parafile.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_setup_parafile.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btn_setup_parafile.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.btn_setup_parafile.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_setup_parafile.Location = new System.Drawing.Point(425, 47);
            this.btn_setup_parafile.Margin = new System.Windows.Forms.Padding(6);
            this.btn_setup_parafile.Name = "btn_setup_parafile";
            this.btn_setup_parafile.Padding = new System.Windows.Forms.Padding(3);
            this.btn_setup_parafile.Size = new System.Drawing.Size(67, 33);
            this.btn_setup_parafile.TabIndex = 86;
            this.btn_setup_parafile.TextColor = System.Drawing.Color.Black;
            this.btn_setup_parafile.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Khaki;
            this.label2.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(3, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(494, 30);
            this.label2.TabIndex = 40;
            this.label2.Text = "原始影像取樣";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.picBox_Origin);
            this.panel3.Controls.Add(this.groupBox4);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Location = new System.Drawing.Point(326, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(501, 808);
            this.panel3.TabIndex = 46;
            // 
            // picBox_Origin
            // 
            this.picBox_Origin.ErrorImage = null;
            this.picBox_Origin.InitialImage = null;
            this.picBox_Origin.Location = new System.Drawing.Point(3, 37);
            this.picBox_Origin.Name = "picBox_Origin";
            this.picBox_Origin.Size = new System.Drawing.Size(500, 500);
            this.picBox_Origin.TabIndex = 34;
            this.picBox_Origin.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblResultStatus);
            this.panel2.Controls.Add(this.gswResult);
            this.panel2.Controls.Add(this.lblResult);
            this.panel2.Controls.Add(this.picBox_Result);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Location = new System.Drawing.Point(1110, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(810, 840);
            this.panel2.TabIndex = 47;
            // 
            // lblResultStatus
            // 
            this.lblResultStatus.AutoSize = true;
            this.lblResultStatus.BackColor = System.Drawing.Color.Red;
            this.lblResultStatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultStatus.ForeColor = System.Drawing.Color.White;
            this.lblResultStatus.Location = new System.Drawing.Point(765, 9);
            this.lblResultStatus.Name = "lblResultStatus";
            this.lblResultStatus.Size = new System.Drawing.Size(39, 19);
            this.lblResultStatus.TabIndex = 48;
            this.lblResultStatus.Text = "OFF";
            this.lblResultStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gswResult
            // 
            this.gswResult.BackColor = System.Drawing.Color.Transparent;
            this.gswResult.FlatAppearance.BorderSize = 0;
            this.gswResult.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.gswResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gswResult.ForeColor = System.Drawing.Color.Black;
            this.gswResult.Image = global::PropInnerImageAnalysis.Properties.Resources.toggle_off;
            this.gswResult.Location = new System.Drawing.Point(712, 3);
            this.gswResult.Name = "gswResult";
            this.gswResult.Size = new System.Drawing.Size(51, 28);
            this.gswResult.TabIndex = 47;
            this.gswResult.UseVisualStyleBackColor = false;
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.Khaki;
            this.lblResult.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblResult.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblResult.Location = new System.Drawing.Point(3, 2);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(703, 30);
            this.lblResult.TabIndex = 40;
            this.lblResult.Text = "影像辨識結果";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picBox_Result
            // 
            this.picBox_Result.ErrorImage = null;
            this.picBox_Result.InitialImage = null;
            this.picBox_Result.Location = new System.Drawing.Point(3, 35);
            this.picBox_Result.Name = "picBox_Result";
            this.picBox_Result.Size = new System.Drawing.Size(800, 800);
            this.picBox_Result.TabIndex = 34;
            this.picBox_Result.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox7);
            this.groupBox3.Controls.Add(this.textBox8);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textBox6);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtUnit_base_area);
            this.groupBox3.Controls.Add(this.txtUnit_hole_area);
            this.groupBox3.Controls.Add(this.txtUnit_hole_rad);
            this.groupBox3.Controls.Add(this.txtRatio);
            this.groupBox3.Controls.Add(this.textBox15);
            this.groupBox3.Controls.Add(this.label49);
            this.groupBox3.Controls.Add(this.txtBase_Area);
            this.groupBox3.Controls.Add(this.label48);
            this.groupBox3.Controls.Add(this.txtHole_Area);
            this.groupBox3.Controls.Add(this.label46);
            this.groupBox3.Controls.Add(this.txtHole_Rad);
            this.groupBox3.Controls.Add(this.label45);
            this.groupBox3.Controls.Add(this.panel10);
            this.groupBox3.Controls.Add(this.label44);
            this.groupBox3.Location = new System.Drawing.Point(326, 876);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(781, 183);
            this.groupBox3.TabIndex = 45;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox7.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox7.Location = new System.Drawing.Point(448, 137);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(37, 23);
            this.textBox7.TabIndex = 64;
            this.textBox7.Text = "mm²";
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox8.Location = new System.Drawing.Point(358, 133);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(88, 30);
            this.textBox8.TabIndex = 63;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(253, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 19);
            this.label6.TabIndex = 62;
            this.label6.Text = "封閉面積：";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox6.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox6.Location = new System.Drawing.Point(740, 54);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(38, 26);
            this.textBox6.TabIndex = 61;
            this.textBox6.Text = "mm";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(661, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(77, 30);
            this.textBox1.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(555, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 19);
            this.label4.TabIndex = 59;
            this.label4.Text = "像素長度：";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox5.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox5.Location = new System.Drawing.Point(199, 135);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(38, 26);
            this.textBox5.TabIndex = 58;
            this.textBox5.Text = "mm";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox4.Location = new System.Drawing.Point(106, 133);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(90, 30);
            this.textBox4.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(1, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 19);
            this.label1.TabIndex = 55;
            this.label1.Text = "兩點量測：";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox2.Location = new System.Drawing.Point(450, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(38, 26);
            this.textBox2.TabIndex = 54;
            this.textBox2.Text = "mm";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox3.Location = new System.Drawing.Point(358, 52);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(90, 30);
            this.textBox3.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(253, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 19);
            this.label5.TabIndex = 52;
            this.label5.Text = "輪廓直徑：";
            // 
            // txtUnit_base_area
            // 
            this.txtUnit_base_area.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.txtUnit_base_area.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUnit_base_area.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtUnit_base_area.ForeColor = System.Drawing.SystemColors.Window;
            this.txtUnit_base_area.Location = new System.Drawing.Point(449, 95);
            this.txtUnit_base_area.Name = "txtUnit_base_area";
            this.txtUnit_base_area.ReadOnly = true;
            this.txtUnit_base_area.Size = new System.Drawing.Size(37, 23);
            this.txtUnit_base_area.TabIndex = 51;
            this.txtUnit_base_area.Text = "mm²";
            // 
            // txtUnit_hole_area
            // 
            this.txtUnit_hole_area.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.txtUnit_hole_area.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUnit_hole_area.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtUnit_hole_area.ForeColor = System.Drawing.SystemColors.Window;
            this.txtUnit_hole_area.Location = new System.Drawing.Point(200, 93);
            this.txtUnit_hole_area.Name = "txtUnit_hole_area";
            this.txtUnit_hole_area.ReadOnly = true;
            this.txtUnit_hole_area.Size = new System.Drawing.Size(50, 26);
            this.txtUnit_hole_area.TabIndex = 50;
            this.txtUnit_hole_area.Text = "mm²";
            // 
            // txtUnit_hole_rad
            // 
            this.txtUnit_hole_rad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.txtUnit_hole_rad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUnit_hole_rad.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtUnit_hole_rad.ForeColor = System.Drawing.SystemColors.Window;
            this.txtUnit_hole_rad.Location = new System.Drawing.Point(201, 54);
            this.txtUnit_hole_rad.Name = "txtUnit_hole_rad";
            this.txtUnit_hole_rad.ReadOnly = true;
            this.txtUnit_hole_rad.Size = new System.Drawing.Size(38, 26);
            this.txtUnit_hole_rad.TabIndex = 49;
            this.txtUnit_hole_rad.Text = "mm";
            // 
            // txtRatio
            // 
            this.txtRatio.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRatio.Location = new System.Drawing.Point(661, 91);
            this.txtRatio.Name = "txtRatio";
            this.txtRatio.Size = new System.Drawing.Size(77, 30);
            this.txtRatio.TabIndex = 48;
            // 
            // textBox15
            // 
            this.textBox15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.textBox15.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox15.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox15.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox15.Location = new System.Drawing.Point(744, 95);
            this.textBox15.Name = "textBox15";
            this.textBox15.ReadOnly = true;
            this.textBox15.Size = new System.Drawing.Size(18, 23);
            this.textBox15.TabIndex = 47;
            this.textBox15.Text = "%";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label49.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label49.Location = new System.Drawing.Point(555, 97);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(114, 19);
            this.label49.TabIndex = 46;
            this.label49.Text = "基藥比率：";
            // 
            // txtBase_Area
            // 
            this.txtBase_Area.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBase_Area.Location = new System.Drawing.Point(358, 91);
            this.txtBase_Area.Name = "txtBase_Area";
            this.txtBase_Area.Size = new System.Drawing.Size(88, 30);
            this.txtBase_Area.TabIndex = 45;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label48.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label48.Location = new System.Drawing.Point(253, 97);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(114, 19);
            this.label48.TabIndex = 44;
            this.label48.Text = "基藥面積：";
            // 
            // txtHole_Area
            // 
            this.txtHole_Area.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtHole_Area.Location = new System.Drawing.Point(107, 91);
            this.txtHole_Area.Name = "txtHole_Area";
            this.txtHole_Area.Size = new System.Drawing.Size(90, 30);
            this.txtHole_Area.TabIndex = 43;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label46.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label46.Location = new System.Drawing.Point(3, 97);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(114, 19);
            this.label46.TabIndex = 42;
            this.label46.Text = "藥粒面積：";
            // 
            // txtHole_Rad
            // 
            this.txtHole_Rad.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtHole_Rad.Location = new System.Drawing.Point(108, 52);
            this.txtHole_Rad.Name = "txtHole_Rad";
            this.txtHole_Rad.Size = new System.Drawing.Size(90, 30);
            this.txtHole_Rad.TabIndex = 41;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label45.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label45.Location = new System.Drawing.Point(4, 58);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(114, 19);
            this.label45.TabIndex = 40;
            this.label45.Text = "藥粒孔徑：";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.inchBtn);
            this.panel10.Controls.Add(this.mmBtn);
            this.panel10.Controls.Add(this.textBox24);
            this.panel10.Location = new System.Drawing.Point(517, 126);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(261, 37);
            this.panel10.TabIndex = 39;
            // 
            // inchBtn
            // 
            this.inchBtn.AutoSize = true;
            this.inchBtn.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.inchBtn.Location = new System.Drawing.Point(184, 9);
            this.inchBtn.Name = "inchBtn";
            this.inchBtn.Size = new System.Drawing.Size(72, 25);
            this.inchBtn.TabIndex = 24;
            this.inchBtn.Text = "英制";
            this.inchBtn.UseVisualStyleBackColor = true;
            // 
            // mmBtn
            // 
            this.mmBtn.AutoSize = true;
            this.mmBtn.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mmBtn.Location = new System.Drawing.Point(107, 9);
            this.mmBtn.Name = "mmBtn";
            this.mmBtn.Size = new System.Drawing.Size(72, 25);
            this.mmBtn.TabIndex = 24;
            this.mmBtn.Text = "公制";
            this.mmBtn.UseVisualStyleBackColor = true;
            // 
            // textBox24
            // 
            this.textBox24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.textBox24.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox24.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox24.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBox24.Location = new System.Drawing.Point(3, 10);
            this.textBox24.Name = "textBox24";
            this.textBox24.ReadOnly = true;
            this.textBox24.Size = new System.Drawing.Size(88, 23);
            this.textBox24.TabIndex = 33;
            this.textBox24.Text = "顯示單位";
            this.textBox24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label44
            // 
            this.label44.BackColor = System.Drawing.Color.Gold;
            this.label44.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label44.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label44.Location = new System.Drawing.Point(6, 17);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(772, 29);
            this.label44.TabIndex = 27;
            this.label44.Text = "量測結果";
            this.label44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Log
            // 
            this.txt_Log.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Log.Location = new System.Drawing.Point(1110, 910);
            this.txt_Log.Multiline = true;
            this.txt_Log.Name = "txt_Log";
            this.txt_Log.Size = new System.Drawing.Size(804, 149);
            this.txt_Log.TabIndex = 48;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.textBox9);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.button5);
            this.panel4.Location = new System.Drawing.Point(1, 673);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(313, 82);
            this.panel4.TabIndex = 49;
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(284, 45);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(20, 29);
            this.textBox9.TabIndex = 49;
            this.textBox9.Text = "0";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(182, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 34);
            this.button1.TabIndex = 48;
            this.button1.Text = "再次研磨";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(182, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 34);
            this.button2.TabIndex = 47;
            this.button2.Text = "回歸取料";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(86, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 75);
            this.button3.TabIndex = 45;
            this.button3.Text = "取樣";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(3, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(61, 75);
            this.button5.TabIndex = 42;
            this.button5.Text = "連結";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(66, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 22);
            this.label8.TabIndex = 153;
            this.label8.Text = "→";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(66, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 22);
            this.label10.TabIndex = 154;
            this.label10.Text = "→";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(159, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 22);
            this.label11.TabIndex = 155;
            this.label11.Text = "→";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(158, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 22);
            this.label12.TabIndex = 156;
            this.label12.Text = "→";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Gold;
            this.label9.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label9.Location = new System.Drawing.Point(4, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 26);
            this.label9.TabIndex = 35;
            this.label9.Text = "粗磨進給mm";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.Location = new System.Drawing.Point(138, 43);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(105, 26);
            this.textBox10.TabIndex = 157;
            this.textBox10.Text = "0.01";
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(250, 43);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(61, 26);
            this.button4.TabIndex = 162;
            this.button4.Text = "寫入";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(249, 77);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(61, 26);
            this.button6.TabIndex = 165;
            this.button6.Text = "寫入";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // textBox11
            // 
            this.textBox11.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.Location = new System.Drawing.Point(137, 77);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(105, 26);
            this.textBox11.TabIndex = 164;
            this.textBox11.Text = "0.01";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Gold;
            this.label13.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label13.Location = new System.Drawing.Point(3, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 26);
            this.label13.TabIndex = 163;
            this.label13.Text = "細磨進給mm";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button7
            // 
            this.button7.Enabled = false;
            this.button7.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(249, 114);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(61, 26);
            this.button7.TabIndex = 168;
            this.button7.Text = "寫入";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // textBox12
            // 
            this.textBox12.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.Location = new System.Drawing.Point(137, 114);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(105, 26);
            this.textBox12.TabIndex = 167;
            this.textBox12.Text = "0.01";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Gold;
            this.label14.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label14.Location = new System.Drawing.Point(3, 114);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(128, 26);
            this.label14.TabIndex = 166;
            this.label14.Text = "再磨進給mm";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Mainfrm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1919, 1061);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txt_Log);
            this.Controls.Add(this.panel_operation_status);
            this.Controls.Add(this.panel_Prop_Select);
            this.Controls.Add(this.panel_Camera);
            this.Controls.Add(this.panel_title);
            this.Controls.Add(this.panel_PLC_Com);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Mainfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Mainfrm_Load);
            this.panel_title.ResumeLayout(false);
            this.panel_title.PerformLayout();
            this.panel_PLC_Com.ResumeLayout(false);
            this.panel_PLC_Com.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_fixed_threshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).EndInit();
            this.panel_Camera.ResumeLayout(false);
            this.panel_Camera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCam)).EndInit();
            this.panel_Prop_Select.ResumeLayout(false);
            this.panel_Prop_Select.PerformLayout();
            this.panel_operation_status.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Origin)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Result)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        /*private void panel5_Paint(object sender, PaintEventArgs e)
        {
            throw new NotImplementedException();
        }*/

        private void btnA2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel panel_title;
        private System.Windows.Forms.Panel panel_PLC_Com;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Button end_btn;
        private System.Windows.Forms.Button munus_btn;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Timer Timer_system;
        private System.Windows.Forms.TextBox textBox_sample_count;
        private System.Windows.Forms.RadioButton Btn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_reset;
        private Label lblComPortStatus;
        private Button gswComport;
        private Panel panel_Camera;
        private Label label22;
        private ComboBox cboComPort;
        private Panel panel_Prop_Select;
        private Label label24;
        private FolderBrowserDialog folderBrowserDialog_working_dir;
        private XanderUI.XUIButton button_recgon;
        private XanderUI.XUIButton button_next;
        private XanderUI.XUIButton button_prev;
        private XanderUI.XUIButton button_side_length;
        private XanderUI.XUIButton button_all_auto;
        private ComboBox cboProType;
        private PictureBox picBoxCam;
        private Label lblSingleGrind;
        private Label lblAuto;
        private Label lblNoGrind;
        private GroupBox groupBox2;
        private TextBox textBox_fixed_threshold;
        private TrackBar trackbar_fixed_threshold;
        private Label label85;
        private PictureBox pictureBox29;
        private XanderUI.XUIButton btn_setup_sampledir;
        private Label lbl_Machine_Process;
        private Label lblProcess0;
        private Label lblProcess3;
        private Label lblProcess1;
        private Panel panel_operation_status;
        private XanderUI.XUIButton Button_abandon;
        private Label label_SideSample_stat;
        private FolderBrowserDialog folderBrowserDialog_load;
        private TextBox textBox_Cam;
        private Button gswCam;
        private XanderUI.XUIButton btn_Rotate_OrgImg;
        private GroupBox groupBox1;
        private TextBox textBox_sample_dir;
        private Label label47;
        private Label lblProcess2;
        private Panel panel1;
        private Label label2;
        private Panel panel3;
        private PictureBox picBox_Origin;
        private Panel panel2;
        private Label lblResult;
        private PictureBox picBox_Result;
        private Label lbl01;
        private XanderUI.XUIButton xuiButton1;
        private GroupBox groupBox3;
        private TextBox txtUnit_base_area;
        private TextBox txtUnit_hole_area;
        private TextBox txtUnit_hole_rad;
        private TextBox txtRatio;
        private TextBox textBox15;
        private Label label49;
        private TextBox txtBase_Area;
        private Label label48;
        private TextBox txtHole_Area;
        private Label label46;
        private TextBox txtHole_Rad;
        private Label label45;
        private Panel panel10;
        private RadioButton inchBtn;
        private RadioButton mmBtn;
        private TextBox textBox24;
        private Label label44;
        private Label label3;
        private Label lblCamStatus;
        private XanderUI.XUIButton btn_load_sample;
        private XanderUI.XUIButton btn_save_sample;
        private GroupBox groupBox4;
        private XanderUI.XUIButton btn_load_parafile;
        private XanderUI.XUIButton btn_save_parafile;
        private Label label20;
        private XanderUI.XUIButton btn_setup_parafile;
        private TextBox textBox_parafile;
        private Label lblResultStatus;
        private Button gswResult;
        private XanderUI.XUIButton btn_sample_mark;
        private Label lbl31;
        private Label lbl30;
        private Label lbl19;
        private Label lbl18;
        private Label lbl07;
        private Label lbl06;
        private Label lbl32;
        private Label lbl29;
        private Label lbl20;
        private Label lbl17;
        private Label lbl08;
        private Label lbl05;
        private Label lbl33;
        private Label lbl28;
        private Label lbl21;
        private Label lbl16;
        private Label lbl09;
        private Label lbl04;
        private Label lbl34;
        private Label lbl27;
        private Label lbl22;
        private Label lbl15;
        private Label lbl10;
        private Label lbl03;
        private Label lbl35;
        private Label lbl26;
        private Label lbl23;
        private Label lbl14;
        private Label lbl11;
        private Label lbl02;
        private Label lbl36;
        private Label lbl25;
        private Label lbl24;
        private Label lbl13;
        private Label lbl12;
        private Label label33;
        private Label label34;
        private Label label29;
        private Label label31;
        private Label label27;
        private Label label21;
        private TextBox txt_Log;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label5;
        private ComboBox cbo_polish_cnt;
        private XanderUI.XUIButton xuiButton2;
        private XanderUI.XUIButton xuiButton3;
        private TextBox textBox7;
        private TextBox textBox8;
        private Label label6;
        private TextBox textBox6;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox5;
        private TextBox textBox4;
        private Label label1;
        private Label lblMarkDel;
        private Button gswDelMark;
        private Label lblSplDel;
        private Button gswDelSpl;
        private Button button7;
        private TextBox textBox12;
        private Label label14;
        private Button button6;
        private TextBox textBox11;
        private Label label13;
        private Button button4;
        private TextBox textBox10;
        private Label label9;
        private Panel panel4;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label8;
        private TextBox textBox9;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button5;
    }
}

