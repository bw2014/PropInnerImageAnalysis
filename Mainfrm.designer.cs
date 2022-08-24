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
            this.tb_threshold = new System.Windows.Forms.TrackBar();
            this.txt_threshold = new System.Windows.Forms.TextBox();
            this.label85 = new System.Windows.Forms.Label();
            this.pictureBox29 = new System.Windows.Forms.PictureBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_sample_count = new System.Windows.Forms.TextBox();
            this.Timer_system = new System.Windows.Forms.Timer(this.components);
            this.panel_Camera = new System.Windows.Forms.Panel();
            this.btn_nROI = new System.Windows.Forms.Button();
            this.btn_cROI = new System.Windows.Forms.Button();
            this.lblCamStatus = new System.Windows.Forms.Label();
            this.gswCam = new System.Windows.Forms.Button();
            this.textBox_Cam = new System.Windows.Forms.TextBox();
            this.picBoxCam = new System.Windows.Forms.PictureBox();
            this.label22 = new System.Windows.Forms.Label();
            this.panel_Prop_Select = new System.Windows.Forms.Panel();
            this.txt_feedcount03_default = new System.Windows.Forms.TextBox();
            this.txt_feedcount03 = new System.Windows.Forms.TextBox();
            this.txt_feedcount02_default = new System.Windows.Forms.TextBox();
            this.txt_feedcount02 = new System.Windows.Forms.TextBox();
            this.txt_feedcount01_default = new System.Windows.Forms.TextBox();
            this.txt_feedcount01 = new System.Windows.Forms.TextBox();
            this.btn_factory_reset = new System.Windows.Forms.Button();
            this.txt_feedrate03_default = new System.Windows.Forms.TextBox();
            this.txt_feedrate02_default = new System.Windows.Forms.TextBox();
            this.txt_feedrate01_default = new System.Windows.Forms.TextBox();
            this.btn_feed03 = new System.Windows.Forms.Button();
            this.txt_feedrate03 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_feed02 = new System.Windows.Forms.Button();
            this.txt_feedrate02 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_feed01 = new System.Windows.Forms.Button();
            this.txt_feedrate01 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
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
            this.label47 = new System.Windows.Forms.Label();
            this.txt_sample_dir = new System.Windows.Forms.TextBox();
            this.btn_select_sampledir = new XanderUI.XUIButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_save = new XanderUI.XUIButton();
            this.btn_measure = new XanderUI.XUIButton();
            this.btn_adjust = new XanderUI.XUIButton();
            this.btn_rotate = new XanderUI.XUIButton();
            this.btn_discard = new XanderUI.XUIButton();
            this.btn_contour_rec = new XanderUI.XUIButton();
            this.btn_prev = new XanderUI.XUIButton();
            this.btn_next = new XanderUI.XUIButton();
            this.btn_deter_per = new XanderUI.XUIButton();
            this.btn_auto = new XanderUI.XUIButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_save_config = new XanderUI.XUIButton();
            this.label20 = new System.Windows.Forms.Label();
            this.btn_load_config = new XanderUI.XUIButton();
            this.txt_config = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pb_temp07 = new System.Windows.Forms.PictureBox();
            this.pb_temp06 = new System.Windows.Forms.PictureBox();
            this.pb_temp05 = new System.Windows.Forms.PictureBox();
            this.pb_temp04 = new System.Windows.Forms.PictureBox();
            this.pb_temp03 = new System.Windows.Forms.PictureBox();
            this.pb_temp02 = new System.Windows.Forms.PictureBox();
            this.pb_temp01 = new System.Windows.Forms.PictureBox();
            this.ob_origin = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblResult = new System.Windows.Forms.Label();
            this.pb_result = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_enclose_area_unit = new System.Windows.Forms.TextBox();
            this.txt_enclose_area = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_pixel_length_unit = new System.Windows.Forms.TextBox();
            this.txt_pixel_len = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_2p_measure_unit = new System.Windows.Forms.TextBox();
            this.txt_2p_measure = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cont_dia_unit = new System.Windows.Forms.TextBox();
            this.txt_cont_dia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_base_area_unit = new System.Windows.Forms.TextBox();
            this.txt_area_unit = new System.Windows.Forms.TextBox();
            this.txt_hole_rad_unit = new System.Windows.Forms.TextBox();
            this.txt_base_ratio = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.txt_base_area = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.txt_area = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.txt_hole_rad = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.rad_unit_inch = new System.Windows.Forms.RadioButton();
            this.rad_unit_mm = new System.Windows.Forms.RadioButton();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_grindcount = new System.Windows.Forms.TextBox();
            this.btn_regrind = new System.Windows.Forms.Button();
            this.btn_return = new System.Windows.Forms.Button();
            this.btn_sampling = new System.Windows.Forms.Button();
            this.btn_plc_start = new System.Windows.Forms.Button();
            this.pb_rec_result01 = new System.Windows.Forms.PictureBox();
            this.pb_rec_result02 = new System.Windows.Forms.PictureBox();
            this.pb_rec_result04 = new System.Windows.Forms.PictureBox();
            this.pb_rec_result03 = new System.Windows.Forms.PictureBox();
            this.pb_rec_result06 = new System.Windows.Forms.PictureBox();
            this.pb_rec_result05 = new System.Windows.Forms.PictureBox();
            this.Blink_timer = new System.Windows.Forms.Timer(this.components);
            this.btn_offline_load = new XanderUI.XUIButton();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_offline_dir = new System.Windows.Forms.TextBox();
            this.panel_title.SuspendLayout();
            this.panel_PLC_Com.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_threshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).BeginInit();
            this.panel_Camera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCam)).BeginInit();
            this.panel_Prop_Select.SuspendLayout();
            this.panel_operation_status.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_temp07)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_temp06)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_temp05)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_temp04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_temp03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_temp02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_temp01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ob_origin)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_result)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_rec_result01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_rec_result02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_rec_result04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_rec_result03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_rec_result06)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_rec_result05)).BeginInit();
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
            this.lblSingleGrind.Location = new System.Drawing.Point(4, 34);
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
            this.lblAuto.Location = new System.Drawing.Point(101, 34);
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
            this.lblNoGrind.Location = new System.Drawing.Point(215, 34);
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
            this.groupBox2.Controls.Add(this.tb_threshold);
            this.groupBox2.Controls.Add(this.txt_threshold);
            this.groupBox2.Controls.Add(this.label85);
            this.groupBox2.Controls.Add(this.pictureBox29);
            this.groupBox2.Location = new System.Drawing.Point(2, 678);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 118);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            // 
            // tb_threshold
            // 
            this.tb_threshold.Location = new System.Drawing.Point(5, 69);
            this.tb_threshold.Maximum = 255;
            this.tb_threshold.Minimum = 1;
            this.tb_threshold.Name = "tb_threshold";
            this.tb_threshold.Size = new System.Drawing.Size(261, 45);
            this.tb_threshold.TabIndex = 83;
            this.tb_threshold.Value = 240;
            this.tb_threshold.ValueChanged += new System.EventHandler(this.trackBar_face_threshold_ValueChanged);
            // 
            // txt_threshold
            // 
            this.txt_threshold.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_threshold.Location = new System.Drawing.Point(120, 20);
            this.txt_threshold.Name = "txt_threshold";
            this.txt_threshold.Size = new System.Drawing.Size(64, 32);
            this.txt_threshold.TabIndex = 84;
            this.txt_threshold.Text = "240";
            this.txt_threshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_threshold.TextChanged += new System.EventHandler(this.textBox_face_Threshold_TextChanged);
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
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_reset.FlatAppearance.BorderSize = 0;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_reset.ForeColor = System.Drawing.Color.Black;
            this.btn_reset.Location = new System.Drawing.Point(63, 534);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_reset.Size = new System.Drawing.Size(149, 54);
            this.btn_reset.TabIndex = 32;
            this.btn_reset.Text = "辨識重置";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.label7.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.SystemColors.Info;
            this.label7.Location = new System.Drawing.Point(5, 3);
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
            this.panel_Camera.Controls.Add(this.btn_nROI);
            this.panel_Camera.Controls.Add(this.btn_cROI);
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
            // btn_nROI
            // 
            this.btn_nROI.BackColor = System.Drawing.Color.Goldenrod;
            this.btn_nROI.Enabled = false;
            this.btn_nROI.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_nROI.ForeColor = System.Drawing.Color.Black;
            this.btn_nROI.Location = new System.Drawing.Point(268, 5);
            this.btn_nROI.Name = "btn_nROI";
            this.btn_nROI.Size = new System.Drawing.Size(42, 28);
            this.btn_nROI.TabIndex = 174;
            this.btn_nROI.Text = "再";
            this.btn_nROI.UseVisualStyleBackColor = false;
            this.btn_nROI.Click += new System.EventHandler(this.btn_nROI_Click);
            // 
            // btn_cROI
            // 
            this.btn_cROI.BackColor = System.Drawing.Color.Goldenrod;
            this.btn_cROI.Enabled = false;
            this.btn_cROI.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_cROI.ForeColor = System.Drawing.Color.Black;
            this.btn_cROI.Location = new System.Drawing.Point(224, 5);
            this.btn_cROI.Name = "btn_cROI";
            this.btn_cROI.Size = new System.Drawing.Size(42, 28);
            this.btn_cROI.TabIndex = 173;
            this.btn_cROI.Text = "原";
            this.btn_cROI.UseVisualStyleBackColor = false;
            this.btn_cROI.Click += new System.EventHandler(this.btn_cROI_Click);
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
            this.gswCam.Location = new System.Drawing.Point(219, 38);
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
            this.textBox_Cam.Size = new System.Drawing.Size(220, 26);
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
            this.label22.Size = new System.Drawing.Size(215, 30);
            this.label22.TabIndex = 27;
            this.label22.Text = "相機狀態";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_Prop_Select
            // 
            this.panel_Prop_Select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.panel_Prop_Select.Controls.Add(this.txt_feedcount03_default);
            this.panel_Prop_Select.Controls.Add(this.txt_feedcount03);
            this.panel_Prop_Select.Controls.Add(this.txt_feedcount02_default);
            this.panel_Prop_Select.Controls.Add(this.txt_feedcount02);
            this.panel_Prop_Select.Controls.Add(this.txt_feedcount01_default);
            this.panel_Prop_Select.Controls.Add(this.txt_feedcount01);
            this.panel_Prop_Select.Controls.Add(this.btn_factory_reset);
            this.panel_Prop_Select.Controls.Add(this.txt_feedrate03_default);
            this.panel_Prop_Select.Controls.Add(this.txt_feedrate02_default);
            this.panel_Prop_Select.Controls.Add(this.txt_feedrate01_default);
            this.panel_Prop_Select.Controls.Add(this.btn_feed03);
            this.panel_Prop_Select.Controls.Add(this.txt_feedrate03);
            this.panel_Prop_Select.Controls.Add(this.label14);
            this.panel_Prop_Select.Controls.Add(this.btn_feed02);
            this.panel_Prop_Select.Controls.Add(this.txt_feedrate02);
            this.panel_Prop_Select.Controls.Add(this.label13);
            this.panel_Prop_Select.Controls.Add(this.btn_feed01);
            this.panel_Prop_Select.Controls.Add(this.txt_feedrate01);
            this.panel_Prop_Select.Controls.Add(this.label9);
            this.panel_Prop_Select.Controls.Add(this.cboProType);
            this.panel_Prop_Select.Controls.Add(this.label24);
            this.panel_Prop_Select.Location = new System.Drawing.Point(1, 515);
            this.panel_Prop_Select.Name = "panel_Prop_Select";
            this.panel_Prop_Select.Size = new System.Drawing.Size(313, 152);
            this.panel_Prop_Select.TabIndex = 28;
            // 
            // txt_feedcount03_default
            // 
            this.txt_feedcount03_default.BackColor = System.Drawing.Color.YellowGreen;
            this.txt_feedcount03_default.Enabled = false;
            this.txt_feedcount03_default.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_feedcount03_default.Location = new System.Drawing.Point(211, 112);
            this.txt_feedcount03_default.Name = "txt_feedcount03_default";
            this.txt_feedcount03_default.Size = new System.Drawing.Size(28, 26);
            this.txt_feedcount03_default.TabIndex = 178;
            this.txt_feedcount03_default.Text = "99";
            // 
            // txt_feedcount03
            // 
            this.txt_feedcount03.Enabled = false;
            this.txt_feedcount03.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_feedcount03.Location = new System.Drawing.Point(242, 112);
            this.txt_feedcount03.Name = "txt_feedcount03";
            this.txt_feedcount03.Size = new System.Drawing.Size(27, 26);
            this.txt_feedcount03.TabIndex = 177;
            this.txt_feedcount03.Text = "99";
            // 
            // txt_feedcount02_default
            // 
            this.txt_feedcount02_default.BackColor = System.Drawing.Color.YellowGreen;
            this.txt_feedcount02_default.Enabled = false;
            this.txt_feedcount02_default.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_feedcount02_default.Location = new System.Drawing.Point(211, 77);
            this.txt_feedcount02_default.Name = "txt_feedcount02_default";
            this.txt_feedcount02_default.Size = new System.Drawing.Size(28, 26);
            this.txt_feedcount02_default.TabIndex = 176;
            this.txt_feedcount02_default.Text = "99";
            // 
            // txt_feedcount02
            // 
            this.txt_feedcount02.Enabled = false;
            this.txt_feedcount02.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_feedcount02.Location = new System.Drawing.Point(242, 77);
            this.txt_feedcount02.Name = "txt_feedcount02";
            this.txt_feedcount02.Size = new System.Drawing.Size(27, 26);
            this.txt_feedcount02.TabIndex = 175;
            this.txt_feedcount02.Text = "99";
            // 
            // txt_feedcount01_default
            // 
            this.txt_feedcount01_default.BackColor = System.Drawing.Color.YellowGreen;
            this.txt_feedcount01_default.Enabled = false;
            this.txt_feedcount01_default.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_feedcount01_default.Location = new System.Drawing.Point(212, 43);
            this.txt_feedcount01_default.Name = "txt_feedcount01_default";
            this.txt_feedcount01_default.Size = new System.Drawing.Size(28, 26);
            this.txt_feedcount01_default.TabIndex = 174;
            this.txt_feedcount01_default.Text = "99";
            // 
            // txt_feedcount01
            // 
            this.txt_feedcount01.Enabled = false;
            this.txt_feedcount01.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_feedcount01.Location = new System.Drawing.Point(243, 43);
            this.txt_feedcount01.Name = "txt_feedcount01";
            this.txt_feedcount01.Size = new System.Drawing.Size(27, 26);
            this.txt_feedcount01.TabIndex = 173;
            this.txt_feedcount01.Text = "99";
            // 
            // btn_factory_reset
            // 
            this.btn_factory_reset.BackColor = System.Drawing.Color.Yellow;
            this.btn_factory_reset.Enabled = false;
            this.btn_factory_reset.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_factory_reset.ForeColor = System.Drawing.Color.Black;
            this.btn_factory_reset.Location = new System.Drawing.Point(3, 42);
            this.btn_factory_reset.Name = "btn_factory_reset";
            this.btn_factory_reset.Size = new System.Drawing.Size(61, 98);
            this.btn_factory_reset.TabIndex = 172;
            this.btn_factory_reset.Text = "出廠預設";
            this.btn_factory_reset.UseVisualStyleBackColor = false;
            // 
            // txt_feedrate03_default
            // 
            this.txt_feedrate03_default.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_feedrate03_default.Enabled = false;
            this.txt_feedrate03_default.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_feedrate03_default.Location = new System.Drawing.Point(127, 112);
            this.txt_feedrate03_default.Name = "txt_feedrate03_default";
            this.txt_feedrate03_default.Size = new System.Drawing.Size(39, 26);
            this.txt_feedrate03_default.TabIndex = 171;
            this.txt_feedrate03_default.Text = "0.99";
            // 
            // txt_feedrate02_default
            // 
            this.txt_feedrate02_default.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_feedrate02_default.Enabled = false;
            this.txt_feedrate02_default.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_feedrate02_default.Location = new System.Drawing.Point(127, 77);
            this.txt_feedrate02_default.Name = "txt_feedrate02_default";
            this.txt_feedrate02_default.Size = new System.Drawing.Size(39, 26);
            this.txt_feedrate02_default.TabIndex = 170;
            this.txt_feedrate02_default.Text = "0.99";
            // 
            // txt_feedrate01_default
            // 
            this.txt_feedrate01_default.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_feedrate01_default.Enabled = false;
            this.txt_feedrate01_default.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_feedrate01_default.Location = new System.Drawing.Point(127, 43);
            this.txt_feedrate01_default.Name = "txt_feedrate01_default";
            this.txt_feedrate01_default.Size = new System.Drawing.Size(40, 26);
            this.txt_feedrate01_default.TabIndex = 169;
            this.txt_feedrate01_default.Text = "0.99";
            // 
            // btn_feed03
            // 
            this.btn_feed03.Enabled = false;
            this.btn_feed03.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_feed03.ForeColor = System.Drawing.Color.Black;
            this.btn_feed03.Location = new System.Drawing.Point(272, 112);
            this.btn_feed03.Name = "btn_feed03";
            this.btn_feed03.Size = new System.Drawing.Size(35, 26);
            this.btn_feed03.TabIndex = 168;
            this.btn_feed03.Text = "寫";
            this.btn_feed03.UseVisualStyleBackColor = true;
            // 
            // txt_feedrate03
            // 
            this.txt_feedrate03.Enabled = false;
            this.txt_feedrate03.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_feedrate03.Location = new System.Drawing.Point(169, 112);
            this.txt_feedrate03.Name = "txt_feedrate03";
            this.txt_feedrate03.Size = new System.Drawing.Size(39, 26);
            this.txt_feedrate03.TabIndex = 167;
            this.txt_feedrate03.Text = "0.99";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Gold;
            this.label14.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label14.Location = new System.Drawing.Point(70, 112);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 26);
            this.label14.TabIndex = 166;
            this.label14.Text = "再磨";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_feed02
            // 
            this.btn_feed02.Enabled = false;
            this.btn_feed02.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_feed02.ForeColor = System.Drawing.Color.Black;
            this.btn_feed02.Location = new System.Drawing.Point(272, 77);
            this.btn_feed02.Name = "btn_feed02";
            this.btn_feed02.Size = new System.Drawing.Size(35, 26);
            this.btn_feed02.TabIndex = 165;
            this.btn_feed02.Text = "寫";
            this.btn_feed02.UseVisualStyleBackColor = true;
            // 
            // txt_feedrate02
            // 
            this.txt_feedrate02.Enabled = false;
            this.txt_feedrate02.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_feedrate02.Location = new System.Drawing.Point(169, 77);
            this.txt_feedrate02.Name = "txt_feedrate02";
            this.txt_feedrate02.Size = new System.Drawing.Size(39, 26);
            this.txt_feedrate02.TabIndex = 164;
            this.txt_feedrate02.Text = "0.99";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Gold;
            this.label13.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label13.Location = new System.Drawing.Point(69, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 26);
            this.label13.TabIndex = 163;
            this.label13.Text = "細磨";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_feed01
            // 
            this.btn_feed01.Enabled = false;
            this.btn_feed01.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_feed01.ForeColor = System.Drawing.Color.Black;
            this.btn_feed01.Location = new System.Drawing.Point(273, 43);
            this.btn_feed01.Name = "btn_feed01";
            this.btn_feed01.Size = new System.Drawing.Size(36, 26);
            this.btn_feed01.TabIndex = 162;
            this.btn_feed01.Text = "寫";
            this.btn_feed01.UseVisualStyleBackColor = true;
            // 
            // txt_feedrate01
            // 
            this.txt_feedrate01.Enabled = false;
            this.txt_feedrate01.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_feedrate01.Location = new System.Drawing.Point(170, 43);
            this.txt_feedrate01.Name = "txt_feedrate01";
            this.txt_feedrate01.Size = new System.Drawing.Size(39, 26);
            this.txt_feedrate01.TabIndex = 157;
            this.txt_feedrate01.Text = "0.99";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Gold;
            this.label9.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label9.Location = new System.Drawing.Point(70, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 26);
            this.label9.TabIndex = 35;
            this.label9.Text = "粗磨";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboProType
            // 
            this.cboProType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProType.Enabled = false;
            this.cboProType.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboProType.FormattingEnabled = true;
            this.cboProType.Items.AddRange(new object[] {
            "無",
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
            this.cboProType.SelectedIndexChanged += new System.EventHandler(this.cboProType_SelectedIndexChanged);
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.Color.Gold;
            this.label24.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label24.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label24.Location = new System.Drawing.Point(4, 9);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(57, 24);
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
            this.lbl_Machine_Process.Text = "機台運行：未連結";
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
            this.groupBox1.Controls.Add(this.btn_offline_load);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txt_offline_dir);
            this.groupBox1.Controls.Add(this.label47);
            this.groupBox1.Controls.Add(this.txt_sample_dir);
            this.groupBox1.Controls.Add(this.btn_select_sampledir);
            this.groupBox1.Location = new System.Drawing.Point(5, 603);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 100);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            // 
            // label47
            // 
            this.label47.BackColor = System.Drawing.Color.Gold;
            this.label47.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label47.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label47.Location = new System.Drawing.Point(4, 22);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(101, 28);
            this.label47.TabIndex = 27;
            this.label47.Text = "工作目錄";
            this.label47.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_sample_dir
            // 
            this.txt_sample_dir.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sample_dir.Location = new System.Drawing.Point(107, 21);
            this.txt_sample_dir.Name = "txt_sample_dir";
            this.txt_sample_dir.Size = new System.Drawing.Size(246, 29);
            this.txt_sample_dir.TabIndex = 28;
            // 
            // btn_select_sampledir
            // 
            this.btn_select_sampledir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_select_sampledir.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.btn_select_sampledir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_select_sampledir.ButtonImage = null;
            this.btn_select_sampledir.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btn_select_sampledir.ButtonText = "選擇";
            this.btn_select_sampledir.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btn_select_sampledir.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btn_select_sampledir.CornerRadius = 2;
            this.btn_select_sampledir.Enabled = false;
            this.btn_select_sampledir.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_select_sampledir.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_select_sampledir.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btn_select_sampledir.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.btn_select_sampledir.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_select_sampledir.Location = new System.Drawing.Point(356, 21);
            this.btn_select_sampledir.Margin = new System.Windows.Forms.Padding(6);
            this.btn_select_sampledir.Name = "btn_select_sampledir";
            this.btn_select_sampledir.Padding = new System.Windows.Forms.Padding(3);
            this.btn_select_sampledir.Size = new System.Drawing.Size(131, 29);
            this.btn_select_sampledir.TabIndex = 86;
            this.btn_select_sampledir.TextColor = System.Drawing.Color.Black;
            this.btn_select_sampledir.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_select_sampledir.Click += new System.EventHandler(this.Button_Load_Images_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.btn_measure);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.btn_adjust);
            this.panel1.Controls.Add(this.btn_rotate);
            this.panel1.Controls.Add(this.label_SideSample_stat);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btn_discard);
            this.panel1.Controls.Add(this.textBox_sample_count);
            this.panel1.Controls.Add(this.btn_reset);
            this.panel1.Controls.Add(this.btn_contour_rec);
            this.panel1.Controls.Add(this.btn_prev);
            this.panel1.Controls.Add(this.btn_next);
            this.panel1.Controls.Add(this.btn_deter_per);
            this.panel1.Controls.Add(this.btn_auto);
            this.panel1.Location = new System.Drawing.Point(829, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 801);
            this.panel1.TabIndex = 45;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_save
            // 
            this.btn_save.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.btn_save.ButtonImage = null;
            this.btn_save.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btn_save.ButtonText = "儲存樣本";
            this.btn_save.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.btn_save.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.btn_save.CornerRadius = 5;
            this.btn_save.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_save.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_save.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btn_save.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btn_save.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_save.Location = new System.Drawing.Point(4, 485);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(267, 43);
            this.btn_save.TabIndex = 98;
            this.btn_save.TextColor = System.Drawing.Color.Black;
            this.btn_save.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btn_measure
            // 
            this.btn_measure.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.btn_measure.ButtonImage = global::PropInnerImageAnalysis.Properties.Resources.Measure;
            this.btn_measure.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btn_measure.ButtonText = "自由量測";
            this.btn_measure.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.btn_measure.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.btn_measure.CornerRadius = 5;
            this.btn_measure.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_measure.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_measure.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btn_measure.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btn_measure.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_measure.Location = new System.Drawing.Point(4, 327);
            this.btn_measure.Name = "btn_measure";
            this.btn_measure.Size = new System.Drawing.Size(268, 49);
            this.btn_measure.TabIndex = 97;
            this.btn_measure.TextColor = System.Drawing.Color.Black;
            this.btn_measure.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btn_adjust
            // 
            this.btn_adjust.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.btn_adjust.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btn_adjust.ButtonImage")));
            this.btn_adjust.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btn_adjust.ButtonText = "調整辨識結果";
            this.btn_adjust.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.btn_adjust.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.btn_adjust.CornerRadius = 5;
            this.btn_adjust.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_adjust.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_adjust.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btn_adjust.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btn_adjust.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_adjust.Location = new System.Drawing.Point(5, 274);
            this.btn_adjust.Name = "btn_adjust";
            this.btn_adjust.Size = new System.Drawing.Size(267, 49);
            this.btn_adjust.TabIndex = 94;
            this.btn_adjust.TextColor = System.Drawing.Color.Black;
            this.btn_adjust.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btn_rotate
            // 
            this.btn_rotate.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.btn_rotate.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btn_rotate.ButtonImage")));
            this.btn_rotate.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btn_rotate.ButtonText = "旋轉原始影像";
            this.btn_rotate.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.btn_rotate.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.btn_rotate.CornerRadius = 5;
            this.btn_rotate.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_rotate.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_rotate.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btn_rotate.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btn_rotate.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_rotate.Location = new System.Drawing.Point(5, 381);
            this.btn_rotate.Name = "btn_rotate";
            this.btn_rotate.Size = new System.Drawing.Size(267, 49);
            this.btn_rotate.TabIndex = 93;
            this.btn_rotate.TextColor = System.Drawing.Color.Black;
            this.btn_rotate.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btn_discard
            // 
            this.btn_discard.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.btn_discard.ButtonImage = null;
            this.btn_discard.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btn_discard.ButtonText = "捨棄樣本";
            this.btn_discard.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.btn_discard.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.btn_discard.CornerRadius = 5;
            this.btn_discard.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_discard.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_discard.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btn_discard.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btn_discard.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_discard.Location = new System.Drawing.Point(5, 436);
            this.btn_discard.Name = "btn_discard";
            this.btn_discard.Size = new System.Drawing.Size(267, 43);
            this.btn_discard.TabIndex = 90;
            this.btn_discard.TextColor = System.Drawing.Color.Black;
            this.btn_discard.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_discard.Click += new System.EventHandler(this.Button_abandon_Click);
            // 
            // btn_contour_rec
            // 
            this.btn_contour_rec.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.btn_contour_rec.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btn_contour_rec.ButtonImage")));
            this.btn_contour_rec.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btn_contour_rec.ButtonText = "輪廓與孔洞辨識";
            this.btn_contour_rec.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.btn_contour_rec.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.btn_contour_rec.CornerRadius = 5;
            this.btn_contour_rec.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_contour_rec.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_contour_rec.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btn_contour_rec.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btn_contour_rec.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_contour_rec.Location = new System.Drawing.Point(5, 173);
            this.btn_contour_rec.Name = "btn_contour_rec";
            this.btn_contour_rec.Size = new System.Drawing.Size(267, 43);
            this.btn_contour_rec.TabIndex = 33;
            this.btn_contour_rec.TextColor = System.Drawing.Color.Black;
            this.btn_contour_rec.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_contour_rec.Click += new System.EventHandler(this.button_recogn_Click);
            // 
            // btn_prev
            // 
            this.btn_prev.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.btn_prev.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btn_prev.ButtonImage")));
            this.btn_prev.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btn_prev.ButtonText = "";
            this.btn_prev.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.btn_prev.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.btn_prev.CornerRadius = 5;
            this.btn_prev.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn_prev.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_prev.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btn_prev.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btn_prev.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_prev.Location = new System.Drawing.Point(4, 534);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(53, 54);
            this.btn_prev.TabIndex = 34;
            this.btn_prev.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btn_prev.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_prev.Click += new System.EventHandler(this.button_prev_Click);
            // 
            // btn_next
            // 
            this.btn_next.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.btn_next.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btn_next.ButtonImage")));
            this.btn_next.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btn_next.ButtonText = "";
            this.btn_next.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.btn_next.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.btn_next.CornerRadius = 5;
            this.btn_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn_next.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_next.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btn_next.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btn_next.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_next.Location = new System.Drawing.Point(218, 534);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(53, 54);
            this.btn_next.TabIndex = 36;
            this.btn_next.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btn_next.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // btn_deter_per
            // 
            this.btn_deter_per.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.btn_deter_per.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btn_deter_per.ButtonImage")));
            this.btn_deter_per.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btn_deter_per.ButtonText = "包面比例辨識";
            this.btn_deter_per.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.btn_deter_per.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.btn_deter_per.CornerRadius = 5;
            this.btn_deter_per.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_deter_per.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_deter_per.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btn_deter_per.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btn_deter_per.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_deter_per.Location = new System.Drawing.Point(5, 221);
            this.btn_deter_per.Name = "btn_deter_per";
            this.btn_deter_per.Size = new System.Drawing.Size(267, 48);
            this.btn_deter_per.TabIndex = 37;
            this.btn_deter_per.TextColor = System.Drawing.Color.Black;
            this.btn_deter_per.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btn_auto
            // 
            this.btn_auto.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.btn_auto.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btn_auto.ButtonImage")));
            this.btn_auto.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btn_auto.ButtonText = "全自動辨識";
            this.btn_auto.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.btn_auto.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.btn_auto.CornerRadius = 5;
            this.btn_auto.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_auto.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_auto.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btn_auto.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btn_auto.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_auto.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.btn_auto.Location = new System.Drawing.Point(5, 124);
            this.btn_auto.Name = "btn_auto";
            this.btn_auto.Size = new System.Drawing.Size(267, 44);
            this.btn_auto.TabIndex = 38;
            this.btn_auto.TextColor = System.Drawing.Color.Black;
            this.btn_auto.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_auto.Click += new System.EventHandler(this.button_all_auto_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_save_config);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.btn_load_config);
            this.groupBox4.Controls.Add(this.txt_config);
            this.groupBox4.Location = new System.Drawing.Point(3, 707);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(496, 94);
            this.groupBox4.TabIndex = 89;
            this.groupBox4.TabStop = false;
            // 
            // btn_save_config
            // 
            this.btn_save_config.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save_config.BackgroundColor = System.Drawing.Color.Peru;
            this.btn_save_config.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_save_config.ButtonImage = null;
            this.btn_save_config.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btn_save_config.ButtonText = "儲存";
            this.btn_save_config.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btn_save_config.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btn_save_config.CornerRadius = 2;
            this.btn_save_config.Enabled = false;
            this.btn_save_config.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_save_config.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_save_config.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btn_save_config.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.btn_save_config.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_save_config.Location = new System.Drawing.Point(423, 50);
            this.btn_save_config.Margin = new System.Windows.Forms.Padding(6);
            this.btn_save_config.Name = "btn_save_config";
            this.btn_save_config.Padding = new System.Windows.Forms.Padding(3);
            this.btn_save_config.Size = new System.Drawing.Size(67, 35);
            this.btn_save_config.TabIndex = 87;
            this.btn_save_config.TextColor = System.Drawing.Color.Black;
            this.btn_save_config.Vertical_Alignment = System.Drawing.StringAlignment.Center;
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
            this.label20.Text = "系統參數檔案";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_load_config
            // 
            this.btn_load_config.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_load_config.BackgroundColor = System.Drawing.Color.Peru;
            this.btn_load_config.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_load_config.ButtonImage = null;
            this.btn_load_config.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btn_load_config.ButtonText = "載入";
            this.btn_load_config.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btn_load_config.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btn_load_config.CornerRadius = 2;
            this.btn_load_config.Enabled = false;
            this.btn_load_config.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_load_config.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_load_config.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btn_load_config.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.btn_load_config.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_load_config.Location = new System.Drawing.Point(351, 50);
            this.btn_load_config.Margin = new System.Windows.Forms.Padding(6);
            this.btn_load_config.Name = "btn_load_config";
            this.btn_load_config.Padding = new System.Windows.Forms.Padding(3);
            this.btn_load_config.Size = new System.Drawing.Size(67, 35);
            this.btn_load_config.TabIndex = 86;
            this.btn_load_config.TextColor = System.Drawing.Color.Black;
            this.btn_load_config.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_load_config.Click += new System.EventHandler(this.btn_load_config_Click);
            // 
            // txt_config
            // 
            this.txt_config.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_config.Enabled = false;
            this.txt_config.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_config.Location = new System.Drawing.Point(5, 51);
            this.txt_config.Name = "txt_config";
            this.txt_config.Size = new System.Drawing.Size(339, 32);
            this.txt_config.TabIndex = 28;
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
            this.label2.Text = "原始取樣影像";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pb_temp07);
            this.panel3.Controls.Add(this.pb_temp06);
            this.panel3.Controls.Add(this.pb_temp05);
            this.panel3.Controls.Add(this.pb_temp04);
            this.panel3.Controls.Add(this.pb_temp03);
            this.panel3.Controls.Add(this.pb_temp02);
            this.panel3.Controls.Add(this.pb_temp01);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.ob_origin);
            this.panel3.Controls.Add(this.groupBox4);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Location = new System.Drawing.Point(326, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(501, 808);
            this.panel3.TabIndex = 46;
            // 
            // pb_temp07
            // 
            this.pb_temp07.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_temp07.ErrorImage = null;
            this.pb_temp07.InitialImage = null;
            this.pb_temp07.Location = new System.Drawing.Point(432, 543);
            this.pb_temp07.Name = "pb_temp07";
            this.pb_temp07.Size = new System.Drawing.Size(60, 60);
            this.pb_temp07.TabIndex = 96;
            this.pb_temp07.TabStop = false;
            // 
            // pb_temp06
            // 
            this.pb_temp06.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_temp06.ErrorImage = null;
            this.pb_temp06.InitialImage = null;
            this.pb_temp06.Location = new System.Drawing.Point(361, 543);
            this.pb_temp06.Name = "pb_temp06";
            this.pb_temp06.Size = new System.Drawing.Size(60, 60);
            this.pb_temp06.TabIndex = 95;
            this.pb_temp06.TabStop = false;
            // 
            // pb_temp05
            // 
            this.pb_temp05.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_temp05.ErrorImage = null;
            this.pb_temp05.InitialImage = null;
            this.pb_temp05.Location = new System.Drawing.Point(290, 543);
            this.pb_temp05.Name = "pb_temp05";
            this.pb_temp05.Size = new System.Drawing.Size(60, 60);
            this.pb_temp05.TabIndex = 94;
            this.pb_temp05.TabStop = false;
            // 
            // pb_temp04
            // 
            this.pb_temp04.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_temp04.ErrorImage = null;
            this.pb_temp04.InitialImage = null;
            this.pb_temp04.Location = new System.Drawing.Point(219, 543);
            this.pb_temp04.Name = "pb_temp04";
            this.pb_temp04.Size = new System.Drawing.Size(60, 60);
            this.pb_temp04.TabIndex = 93;
            this.pb_temp04.TabStop = false;
            // 
            // pb_temp03
            // 
            this.pb_temp03.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_temp03.ErrorImage = null;
            this.pb_temp03.InitialImage = null;
            this.pb_temp03.Location = new System.Drawing.Point(148, 543);
            this.pb_temp03.Name = "pb_temp03";
            this.pb_temp03.Size = new System.Drawing.Size(60, 60);
            this.pb_temp03.TabIndex = 92;
            this.pb_temp03.TabStop = false;
            // 
            // pb_temp02
            // 
            this.pb_temp02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_temp02.ErrorImage = null;
            this.pb_temp02.InitialImage = null;
            this.pb_temp02.Location = new System.Drawing.Point(77, 543);
            this.pb_temp02.Name = "pb_temp02";
            this.pb_temp02.Size = new System.Drawing.Size(60, 60);
            this.pb_temp02.TabIndex = 91;
            this.pb_temp02.TabStop = false;
            // 
            // pb_temp01
            // 
            this.pb_temp01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_temp01.ErrorImage = null;
            this.pb_temp01.InitialImage = null;
            this.pb_temp01.Location = new System.Drawing.Point(6, 543);
            this.pb_temp01.Name = "pb_temp01";
            this.pb_temp01.Size = new System.Drawing.Size(60, 60);
            this.pb_temp01.TabIndex = 90;
            this.pb_temp01.TabStop = false;
            // 
            // ob_origin
            // 
            this.ob_origin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ob_origin.ErrorImage = null;
            this.ob_origin.InitialImage = null;
            this.ob_origin.Location = new System.Drawing.Point(0, 37);
            this.ob_origin.Name = "ob_origin";
            this.ob_origin.Size = new System.Drawing.Size(500, 500);
            this.ob_origin.TabIndex = 34;
            this.ob_origin.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblResult);
            this.panel2.Controls.Add(this.pb_result);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Location = new System.Drawing.Point(1110, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(810, 834);
            this.panel2.TabIndex = 47;
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.Khaki;
            this.lblResult.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblResult.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblResult.Location = new System.Drawing.Point(3, 2);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(800, 30);
            this.lblResult.TabIndex = 40;
            this.lblResult.Text = "影像辨識結果";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb_result
            // 
            this.pb_result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_result.ErrorImage = null;
            this.pb_result.InitialImage = null;
            this.pb_result.Location = new System.Drawing.Point(3, 34);
            this.pb_result.Name = "pb_result";
            this.pb_result.Size = new System.Drawing.Size(800, 800);
            this.pb_result.TabIndex = 34;
            this.pb_result.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_enclose_area_unit);
            this.groupBox3.Controls.Add(this.txt_enclose_area);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txt_pixel_length_unit);
            this.groupBox3.Controls.Add(this.txt_pixel_len);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txt_2p_measure_unit);
            this.groupBox3.Controls.Add(this.txt_2p_measure);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txt_cont_dia_unit);
            this.groupBox3.Controls.Add(this.txt_cont_dia);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txt_base_area_unit);
            this.groupBox3.Controls.Add(this.txt_area_unit);
            this.groupBox3.Controls.Add(this.txt_hole_rad_unit);
            this.groupBox3.Controls.Add(this.txt_base_ratio);
            this.groupBox3.Controls.Add(this.textBox15);
            this.groupBox3.Controls.Add(this.label49);
            this.groupBox3.Controls.Add(this.txt_base_area);
            this.groupBox3.Controls.Add(this.label48);
            this.groupBox3.Controls.Add(this.txt_area);
            this.groupBox3.Controls.Add(this.label46);
            this.groupBox3.Controls.Add(this.txt_hole_rad);
            this.groupBox3.Controls.Add(this.label45);
            this.groupBox3.Controls.Add(this.panel10);
            this.groupBox3.Controls.Add(this.label44);
            this.groupBox3.Location = new System.Drawing.Point(326, 864);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(781, 190);
            this.groupBox3.TabIndex = 45;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // txt_enclose_area_unit
            // 
            this.txt_enclose_area_unit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.txt_enclose_area_unit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_enclose_area_unit.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_enclose_area_unit.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_enclose_area_unit.Location = new System.Drawing.Point(448, 137);
            this.txt_enclose_area_unit.Name = "txt_enclose_area_unit";
            this.txt_enclose_area_unit.ReadOnly = true;
            this.txt_enclose_area_unit.Size = new System.Drawing.Size(37, 23);
            this.txt_enclose_area_unit.TabIndex = 64;
            this.txt_enclose_area_unit.Text = "mm²";
            // 
            // txt_enclose_area
            // 
            this.txt_enclose_area.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_enclose_area.Location = new System.Drawing.Point(358, 133);
            this.txt_enclose_area.Name = "txt_enclose_area";
            this.txt_enclose_area.Size = new System.Drawing.Size(88, 30);
            this.txt_enclose_area.TabIndex = 63;
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
            // txt_pixel_length_unit
            // 
            this.txt_pixel_length_unit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.txt_pixel_length_unit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pixel_length_unit.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_pixel_length_unit.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_pixel_length_unit.Location = new System.Drawing.Point(740, 54);
            this.txt_pixel_length_unit.Name = "txt_pixel_length_unit";
            this.txt_pixel_length_unit.ReadOnly = true;
            this.txt_pixel_length_unit.Size = new System.Drawing.Size(38, 26);
            this.txt_pixel_length_unit.TabIndex = 61;
            this.txt_pixel_length_unit.Text = "mm";
            // 
            // txt_pixel_len
            // 
            this.txt_pixel_len.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_pixel_len.Location = new System.Drawing.Point(661, 52);
            this.txt_pixel_len.Name = "txt_pixel_len";
            this.txt_pixel_len.Size = new System.Drawing.Size(77, 30);
            this.txt_pixel_len.TabIndex = 60;
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
            // txt_2p_measure_unit
            // 
            this.txt_2p_measure_unit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.txt_2p_measure_unit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_2p_measure_unit.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_2p_measure_unit.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_2p_measure_unit.Location = new System.Drawing.Point(199, 135);
            this.txt_2p_measure_unit.Name = "txt_2p_measure_unit";
            this.txt_2p_measure_unit.ReadOnly = true;
            this.txt_2p_measure_unit.Size = new System.Drawing.Size(38, 26);
            this.txt_2p_measure_unit.TabIndex = 58;
            this.txt_2p_measure_unit.Text = "mm";
            // 
            // txt_2p_measure
            // 
            this.txt_2p_measure.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_2p_measure.Location = new System.Drawing.Point(106, 133);
            this.txt_2p_measure.Name = "txt_2p_measure";
            this.txt_2p_measure.Size = new System.Drawing.Size(90, 30);
            this.txt_2p_measure.TabIndex = 56;
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
            // txt_cont_dia_unit
            // 
            this.txt_cont_dia_unit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.txt_cont_dia_unit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cont_dia_unit.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_cont_dia_unit.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_cont_dia_unit.Location = new System.Drawing.Point(450, 54);
            this.txt_cont_dia_unit.Name = "txt_cont_dia_unit";
            this.txt_cont_dia_unit.ReadOnly = true;
            this.txt_cont_dia_unit.Size = new System.Drawing.Size(38, 26);
            this.txt_cont_dia_unit.TabIndex = 54;
            this.txt_cont_dia_unit.Text = "mm";
            // 
            // txt_cont_dia
            // 
            this.txt_cont_dia.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_cont_dia.Location = new System.Drawing.Point(358, 52);
            this.txt_cont_dia.Name = "txt_cont_dia";
            this.txt_cont_dia.Size = new System.Drawing.Size(90, 30);
            this.txt_cont_dia.TabIndex = 53;
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
            // txt_base_area_unit
            // 
            this.txt_base_area_unit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.txt_base_area_unit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_base_area_unit.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_base_area_unit.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_base_area_unit.Location = new System.Drawing.Point(449, 95);
            this.txt_base_area_unit.Name = "txt_base_area_unit";
            this.txt_base_area_unit.ReadOnly = true;
            this.txt_base_area_unit.Size = new System.Drawing.Size(37, 23);
            this.txt_base_area_unit.TabIndex = 51;
            this.txt_base_area_unit.Text = "mm²";
            // 
            // txt_area_unit
            // 
            this.txt_area_unit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.txt_area_unit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_area_unit.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_area_unit.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_area_unit.Location = new System.Drawing.Point(200, 93);
            this.txt_area_unit.Name = "txt_area_unit";
            this.txt_area_unit.ReadOnly = true;
            this.txt_area_unit.Size = new System.Drawing.Size(50, 26);
            this.txt_area_unit.TabIndex = 50;
            this.txt_area_unit.Text = "mm²";
            // 
            // txt_hole_rad_unit
            // 
            this.txt_hole_rad_unit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.txt_hole_rad_unit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_hole_rad_unit.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_hole_rad_unit.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_hole_rad_unit.Location = new System.Drawing.Point(201, 54);
            this.txt_hole_rad_unit.Name = "txt_hole_rad_unit";
            this.txt_hole_rad_unit.ReadOnly = true;
            this.txt_hole_rad_unit.Size = new System.Drawing.Size(38, 26);
            this.txt_hole_rad_unit.TabIndex = 49;
            this.txt_hole_rad_unit.Text = "mm";
            // 
            // txt_base_ratio
            // 
            this.txt_base_ratio.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_base_ratio.Location = new System.Drawing.Point(661, 91);
            this.txt_base_ratio.Name = "txt_base_ratio";
            this.txt_base_ratio.Size = new System.Drawing.Size(77, 30);
            this.txt_base_ratio.TabIndex = 48;
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
            // txt_base_area
            // 
            this.txt_base_area.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_base_area.Location = new System.Drawing.Point(358, 91);
            this.txt_base_area.Name = "txt_base_area";
            this.txt_base_area.Size = new System.Drawing.Size(88, 30);
            this.txt_base_area.TabIndex = 45;
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
            // txt_area
            // 
            this.txt_area.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_area.Location = new System.Drawing.Point(107, 91);
            this.txt_area.Name = "txt_area";
            this.txt_area.Size = new System.Drawing.Size(90, 30);
            this.txt_area.TabIndex = 43;
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
            // txt_hole_rad
            // 
            this.txt_hole_rad.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_hole_rad.Location = new System.Drawing.Point(108, 52);
            this.txt_hole_rad.Name = "txt_hole_rad";
            this.txt_hole_rad.Size = new System.Drawing.Size(90, 30);
            this.txt_hole_rad.TabIndex = 41;
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
            this.panel10.Controls.Add(this.rad_unit_inch);
            this.panel10.Controls.Add(this.rad_unit_mm);
            this.panel10.Controls.Add(this.textBox24);
            this.panel10.Location = new System.Drawing.Point(517, 126);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(261, 37);
            this.panel10.TabIndex = 39;
            // 
            // rad_unit_inch
            // 
            this.rad_unit_inch.AutoSize = true;
            this.rad_unit_inch.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rad_unit_inch.Location = new System.Drawing.Point(184, 9);
            this.rad_unit_inch.Name = "rad_unit_inch";
            this.rad_unit_inch.Size = new System.Drawing.Size(72, 25);
            this.rad_unit_inch.TabIndex = 24;
            this.rad_unit_inch.Text = "英制";
            this.rad_unit_inch.UseVisualStyleBackColor = true;
            // 
            // rad_unit_mm
            // 
            this.rad_unit_mm.AutoSize = true;
            this.rad_unit_mm.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rad_unit_mm.Location = new System.Drawing.Point(107, 9);
            this.rad_unit_mm.Name = "rad_unit_mm";
            this.rad_unit_mm.Size = new System.Drawing.Size(72, 25);
            this.rad_unit_mm.TabIndex = 24;
            this.rad_unit_mm.Text = "公制";
            this.rad_unit_mm.UseVisualStyleBackColor = true;
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.txt_grindcount);
            this.panel4.Controls.Add(this.btn_regrind);
            this.panel4.Controls.Add(this.btn_return);
            this.panel4.Controls.Add(this.btn_sampling);
            this.panel4.Controls.Add(this.btn_plc_start);
            this.panel4.Location = new System.Drawing.Point(1, 673);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(313, 82);
            this.panel4.TabIndex = 49;
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
            // txt_grindcount
            // 
            this.txt_grindcount.Enabled = false;
            this.txt_grindcount.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_grindcount.Location = new System.Drawing.Point(285, 44);
            this.txt_grindcount.Name = "txt_grindcount";
            this.txt_grindcount.Size = new System.Drawing.Size(20, 29);
            this.txt_grindcount.TabIndex = 49;
            this.txt_grindcount.Text = "0";
            // 
            // btn_regrind
            // 
            this.btn_regrind.BackColor = System.Drawing.Color.Silver;
            this.btn_regrind.Enabled = false;
            this.btn_regrind.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_regrind.ForeColor = System.Drawing.Color.Black;
            this.btn_regrind.Location = new System.Drawing.Point(182, 42);
            this.btn_regrind.Name = "btn_regrind";
            this.btn_regrind.Size = new System.Drawing.Size(127, 34);
            this.btn_regrind.TabIndex = 48;
            this.btn_regrind.Text = "再次研磨";
            this.btn_regrind.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_regrind.UseVisualStyleBackColor = false;
            this.btn_regrind.Click += new System.EventHandler(this.btn_regrind_Click);
            // 
            // btn_return
            // 
            this.btn_return.BackColor = System.Drawing.Color.Silver;
            this.btn_return.Enabled = false;
            this.btn_return.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_return.ForeColor = System.Drawing.Color.Black;
            this.btn_return.Location = new System.Drawing.Point(182, 3);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(127, 34);
            this.btn_return.TabIndex = 47;
            this.btn_return.Text = "回歸取料";
            this.btn_return.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_return.UseVisualStyleBackColor = false;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // btn_sampling
            // 
            this.btn_sampling.BackColor = System.Drawing.Color.Silver;
            this.btn_sampling.Enabled = false;
            this.btn_sampling.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_sampling.ForeColor = System.Drawing.Color.Black;
            this.btn_sampling.Location = new System.Drawing.Point(86, 3);
            this.btn_sampling.Name = "btn_sampling";
            this.btn_sampling.Size = new System.Drawing.Size(69, 75);
            this.btn_sampling.TabIndex = 45;
            this.btn_sampling.Text = "取樣";
            this.btn_sampling.UseVisualStyleBackColor = false;
            this.btn_sampling.Click += new System.EventHandler(this.btn_sampling_Click);
            // 
            // btn_plc_start
            // 
            this.btn_plc_start.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_plc_start.Enabled = false;
            this.btn_plc_start.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_plc_start.ForeColor = System.Drawing.Color.Black;
            this.btn_plc_start.Location = new System.Drawing.Point(3, 3);
            this.btn_plc_start.Name = "btn_plc_start";
            this.btn_plc_start.Size = new System.Drawing.Size(61, 75);
            this.btn_plc_start.TabIndex = 42;
            this.btn_plc_start.Text = "開始";
            this.btn_plc_start.UseVisualStyleBackColor = false;
            this.btn_plc_start.Click += new System.EventHandler(this.btn_plc_start_Click);
            // 
            // pb_rec_result01
            // 
            this.pb_rec_result01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_rec_result01.ErrorImage = null;
            this.pb_rec_result01.InitialImage = null;
            this.pb_rec_result01.Location = new System.Drawing.Point(1112, 911);
            this.pb_rec_result01.Name = "pb_rec_result01";
            this.pb_rec_result01.Size = new System.Drawing.Size(120, 120);
            this.pb_rec_result01.TabIndex = 96;
            this.pb_rec_result01.TabStop = false;
            // 
            // pb_rec_result02
            // 
            this.pb_rec_result02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_rec_result02.ErrorImage = null;
            this.pb_rec_result02.InitialImage = null;
            this.pb_rec_result02.Location = new System.Drawing.Point(1248, 911);
            this.pb_rec_result02.Name = "pb_rec_result02";
            this.pb_rec_result02.Size = new System.Drawing.Size(120, 120);
            this.pb_rec_result02.TabIndex = 97;
            this.pb_rec_result02.TabStop = false;
            // 
            // pb_rec_result04
            // 
            this.pb_rec_result04.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_rec_result04.ErrorImage = null;
            this.pb_rec_result04.InitialImage = null;
            this.pb_rec_result04.Location = new System.Drawing.Point(1520, 911);
            this.pb_rec_result04.Name = "pb_rec_result04";
            this.pb_rec_result04.Size = new System.Drawing.Size(120, 120);
            this.pb_rec_result04.TabIndex = 99;
            this.pb_rec_result04.TabStop = false;
            // 
            // pb_rec_result03
            // 
            this.pb_rec_result03.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_rec_result03.ErrorImage = null;
            this.pb_rec_result03.InitialImage = null;
            this.pb_rec_result03.Location = new System.Drawing.Point(1384, 911);
            this.pb_rec_result03.Name = "pb_rec_result03";
            this.pb_rec_result03.Size = new System.Drawing.Size(120, 120);
            this.pb_rec_result03.TabIndex = 98;
            this.pb_rec_result03.TabStop = false;
            // 
            // pb_rec_result06
            // 
            this.pb_rec_result06.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_rec_result06.ErrorImage = null;
            this.pb_rec_result06.InitialImage = null;
            this.pb_rec_result06.Location = new System.Drawing.Point(1792, 911);
            this.pb_rec_result06.Name = "pb_rec_result06";
            this.pb_rec_result06.Size = new System.Drawing.Size(120, 120);
            this.pb_rec_result06.TabIndex = 101;
            this.pb_rec_result06.TabStop = false;
            // 
            // pb_rec_result05
            // 
            this.pb_rec_result05.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_rec_result05.ErrorImage = null;
            this.pb_rec_result05.InitialImage = null;
            this.pb_rec_result05.Location = new System.Drawing.Point(1656, 911);
            this.pb_rec_result05.Name = "pb_rec_result05";
            this.pb_rec_result05.Size = new System.Drawing.Size(120, 120);
            this.pb_rec_result05.TabIndex = 100;
            this.pb_rec_result05.TabStop = false;
            // 
            // Blink_timer
            // 
            this.Blink_timer.Enabled = true;
            this.Blink_timer.Tick += new System.EventHandler(this.Blink_timer_Tick);
            // 
            // btn_offline_load
            // 
            this.btn_offline_load.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_offline_load.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.btn_offline_load.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_offline_load.ButtonImage = null;
            this.btn_offline_load.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btn_offline_load.ButtonText = "載入";
            this.btn_offline_load.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btn_offline_load.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btn_offline_load.CornerRadius = 2;
            this.btn_offline_load.Enabled = false;
            this.btn_offline_load.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_offline_load.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_offline_load.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btn_offline_load.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.btn_offline_load.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_offline_load.Location = new System.Drawing.Point(356, 61);
            this.btn_offline_load.Margin = new System.Windows.Forms.Padding(6);
            this.btn_offline_load.Name = "btn_offline_load";
            this.btn_offline_load.Padding = new System.Windows.Forms.Padding(3);
            this.btn_offline_load.Size = new System.Drawing.Size(131, 29);
            this.btn_offline_load.TabIndex = 91;
            this.btn_offline_load.TextColor = System.Drawing.Color.Black;
            this.btn_offline_load.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Gold;
            this.label15.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label15.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label15.Location = new System.Drawing.Point(4, 62);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 28);
            this.label15.TabIndex = 88;
            this.label15.Text = "離線樣本";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_offline_dir
            // 
            this.txt_offline_dir.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_offline_dir.Location = new System.Drawing.Point(107, 61);
            this.txt_offline_dir.Name = "txt_offline_dir";
            this.txt_offline_dir.Size = new System.Drawing.Size(246, 29);
            this.txt_offline_dir.TabIndex = 89;
            // 
            // Mainfrm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1919, 1061);
            this.Controls.Add(this.pb_rec_result06);
            this.Controls.Add(this.pb_rec_result05);
            this.Controls.Add(this.pb_rec_result04);
            this.Controls.Add(this.pb_rec_result03);
            this.Controls.Add(this.pb_rec_result02);
            this.Controls.Add(this.pb_rec_result01);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel2);
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
            ((System.ComponentModel.ISupportInitialize)(this.tb_threshold)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.pb_temp07)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_temp06)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_temp05)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_temp04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_temp03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_temp02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_temp01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ob_origin)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_result)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_rec_result01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_rec_result02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_rec_result04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_rec_result03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_rec_result06)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_rec_result05)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button btn_reset;
        private Label lblComPortStatus;
        private Button gswComport;
        private Panel panel_Camera;
        private Label label22;
        private ComboBox cboComPort;
        private Panel panel_Prop_Select;
        private Label label24;
        private FolderBrowserDialog folderBrowserDialog_working_dir;
        private XanderUI.XUIButton btn_contour_rec;
        private XanderUI.XUIButton btn_next;
        private XanderUI.XUIButton btn_prev;
        private XanderUI.XUIButton btn_deter_per;
        private XanderUI.XUIButton btn_auto;
        private ComboBox cboProType;
        private PictureBox picBoxCam;
        private Label lblSingleGrind;
        private Label lblAuto;
        private Label lblNoGrind;
        private GroupBox groupBox2;
        private TextBox txt_threshold;
        private TrackBar tb_threshold;
        private Label label85;
        private PictureBox pictureBox29;
        private XanderUI.XUIButton btn_select_sampledir;
        private Label lbl_Machine_Process;
        private Label lblProcess0;
        private Label lblProcess3;
        private Label lblProcess1;
        private Panel panel_operation_status;
        private XanderUI.XUIButton btn_discard;
        private Label label_SideSample_stat;
        private FolderBrowserDialog folderBrowserDialog_load;
        private TextBox textBox_Cam;
        private Button gswCam;
        private XanderUI.XUIButton btn_rotate;
        private GroupBox groupBox1;
        private TextBox txt_sample_dir;
        private Label label47;
        private Label lblProcess2;
        private Panel panel1;
        private Label label2;
        private Panel panel3;
        private PictureBox ob_origin;
        private Panel panel2;
        private PictureBox pb_result;
        private Label lbl01;
        private XanderUI.XUIButton btn_adjust;
        private GroupBox groupBox3;
        private TextBox txt_base_area_unit;
        private TextBox txt_area_unit;
        private TextBox txt_hole_rad_unit;
        private TextBox txt_base_ratio;
        private TextBox textBox15;
        private Label label49;
        private TextBox txt_base_area;
        private Label label48;
        private TextBox txt_area;
        private Label label46;
        private TextBox txt_hole_rad;
        private Label label45;
        private Panel panel10;
        private RadioButton rad_unit_inch;
        private RadioButton rad_unit_mm;
        private TextBox textBox24;
        private Label label44;
        private Label label3;
        private Label lblCamStatus;
        private GroupBox groupBox4;
        private Label label20;
        private XanderUI.XUIButton btn_load_config;
        private TextBox txt_config;
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
        private TextBox txt_cont_dia_unit;
        private TextBox txt_cont_dia;
        private Label label5;
        private XanderUI.XUIButton btn_measure;
        private TextBox txt_enclose_area_unit;
        private TextBox txt_enclose_area;
        private Label label6;
        private TextBox txt_pixel_length_unit;
        private TextBox txt_pixel_len;
        private Label label4;
        private TextBox txt_2p_measure_unit;
        private TextBox txt_2p_measure;
        private Label label1;
        private Button btn_feed03;
        private TextBox txt_feedrate03;
        private Label label14;
        private Button btn_feed02;
        private TextBox txt_feedrate02;
        private Label label13;
        private Button btn_feed01;
        private TextBox txt_feedrate01;
        private Label label9;
        private Panel panel4;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label8;
        private TextBox txt_grindcount;
        private Button btn_regrind;
        private Button btn_return;
        private Button btn_sampling;
        private Button btn_plc_start;
        private XanderUI.XUIButton btn_save;
        private XanderUI.XUIButton btn_save_config;
        private PictureBox pb_temp04;
        private PictureBox pb_temp03;
        private PictureBox pb_temp02;
        private PictureBox pb_temp01;
        private Label lblResult;
        private PictureBox pb_rec_result01;
        private PictureBox pb_rec_result02;
        private PictureBox pb_rec_result04;
        private PictureBox pb_rec_result03;
        private PictureBox pb_rec_result06;
        private PictureBox pb_rec_result05;
        private TextBox txt_feedrate03_default;
        private TextBox txt_feedrate02_default;
        private TextBox txt_feedrate01_default;
        private PictureBox pb_temp07;
        private PictureBox pb_temp06;
        private PictureBox pb_temp05;
        private Button btn_factory_reset;
        private TextBox txt_feedcount03_default;
        private TextBox txt_feedcount03;
        private TextBox txt_feedcount02_default;
        private TextBox txt_feedcount02;
        private TextBox txt_feedcount01_default;
        private TextBox txt_feedcount01;
        private Timer Blink_timer;
        private Button btn_nROI;
        private Button btn_cROI;
        private XanderUI.XUIButton btn_offline_load;
        private Label label15;
        private TextBox txt_offline_dir;
    }
}

