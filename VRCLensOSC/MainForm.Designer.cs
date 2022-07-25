namespace VRCLensOSC
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.sldZoom = new System.Windows.Forms.TrackBar();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.lbZoomPer = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lbZoomLen = new System.Windows.Forms.Label();
            this.stepZoom = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbEV = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.stepEV = new System.Windows.Forms.NumericUpDown();
            this.btnEVp = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEVm = new System.Windows.Forms.Button();
            this.sldEV = new System.Windows.Forms.TrackBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbApF = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbApPer = new System.Windows.Forms.Label();
            this.stepAp = new System.Windows.Forms.NumericUpDown();
            this.btnApGreat = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnApShallow = new System.Windows.Forms.Button();
            this.sldAp = new System.Windows.Forms.TrackBar();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.lbFocus = new System.Windows.Forms.Label();
            this.stepFocus = new System.Windows.Forms.NumericUpDown();
            this.btnFocusFur = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.btnFocusClo = new System.Windows.Forms.Button();
            this.sldFocus = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.stepMoveH = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.btnDroneForward = new System.Windows.Forms.Button();
            this.btnDroneLeft = new System.Windows.Forms.Button();
            this.btnDroneBackward = new System.Windows.Forms.Button();
            this.btnDroneRight = new System.Windows.Forms.Button();
            this.btnDroneHold = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.stepMoveV = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDroneSwitch = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPortrait = new System.Windows.Forms.Button();
            this.btnOIS = new System.Windows.Forms.Button();
            this.btnDoF = new System.Windows.Forms.Button();
            this.btnEnable = new System.Windows.Forms.Button();
            this.btnDrop = new System.Windows.Forms.Button();
            this.btnTrackself = new System.Windows.Forms.Button();
            this.btnDC = new System.Windows.Forms.Button();
            this.btnHandRotate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.stepRotV = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.btnDroneRotUp = new System.Windows.Forms.Button();
            this.btnDroneRotLeft = new System.Windows.Forms.Button();
            this.btnDroneRotDown = new System.Windows.Forms.Button();
            this.btnDroneRotRight = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.stepRotH = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDroneRotHold = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnShortkey = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.Port = new System.Windows.Forms.NumericUpDown();
            this.IPAddr = new System.Windows.Forms.TextBox();
            this.TimerZoomIn = new System.Windows.Forms.Timer(this.components);
            this.TimerZoomOut = new System.Windows.Forms.Timer(this.components);
            this.TimerEVm = new System.Windows.Forms.Timer(this.components);
            this.TimerEVp = new System.Windows.Forms.Timer(this.components);
            this.TimerApShallow = new System.Windows.Forms.Timer(this.components);
            this.TimerApGrea = new System.Windows.Forms.Timer(this.components);
            this.TimerFocusClo = new System.Windows.Forms.Timer(this.components);
            this.TimerFocusFur = new System.Windows.Forms.Timer(this.components);
            this.oscListener = new System.ComponentModel.BackgroundWorker();
            this.lbVer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sldZoom)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepZoom)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepEV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sldEV)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepAp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sldAp)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepFocus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sldFocus)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepMoveH)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepMoveV)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepRotV)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepRotH)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Port)).BeginInit();
            this.SuspendLayout();
            // 
            // sldZoom
            // 
            this.sldZoom.Location = new System.Drawing.Point(166, 7);
            this.sldZoom.Maximum = 1000;
            this.sldZoom.Name = "sldZoom";
            this.sldZoom.Size = new System.Drawing.Size(324, 45);
            this.sldZoom.TabIndex = 0;
            this.sldZoom.TabStop = false;
            this.sldZoom.Value = 250;
            this.sldZoom.Scroll += new System.EventHandler(this.sldZoom_Scroll);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Location = new System.Drawing.Point(84, 3);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(83, 49);
            this.btnZoomOut.TabIndex = 1;
            this.btnZoomOut.Text = "Zoom Out\n( - )";
            this.btnZoomOut.UseVisualStyleBackColor = true;
            this.btnZoomOut.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnZoomOut_MouseDown);
            this.btnZoomOut.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnZoomOut_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F);
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zoom";
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Location = new System.Drawing.Point(540, 3);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(84, 49);
            this.btnZoomIn.TabIndex = 3;
            this.btnZoomIn.Text = "Zoom In\n( + )";
            this.btnZoomIn.UseVisualStyleBackColor = true;
            this.btnZoomIn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnZoomIn_MouseDown);
            this.btnZoomIn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnZoomIn_MouseUp);
            // 
            // lbZoomPer
            // 
            this.lbZoomPer.AutoSize = true;
            this.lbZoomPer.Location = new System.Drawing.Point(487, 12);
            this.lbZoomPer.Name = "lbZoomPer";
            this.lbZoomPer.Size = new System.Drawing.Size(27, 12);
            this.lbZoomPer.TabIndex = 4;
            this.lbZoomPer.Text = "25%";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.lbZoomLen);
            this.panel.Controls.Add(this.stepZoom);
            this.panel.Controls.Add(this.btnZoomIn);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.lbZoomPer);
            this.panel.Controls.Add(this.btnZoomOut);
            this.panel.Controls.Add(this.sldZoom);
            this.panel.Location = new System.Drawing.Point(12, 54);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(737, 55);
            this.panel.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(630, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "Strength";
            // 
            // lbZoomLen
            // 
            this.lbZoomLen.AutoSize = true;
            this.lbZoomLen.Location = new System.Drawing.Point(487, 31);
            this.lbZoomLen.Name = "lbZoomLen";
            this.lbZoomLen.Size = new System.Drawing.Size(37, 12);
            this.lbZoomLen.TabIndex = 8;
            this.lbZoomLen.Text = "- mm";
            // 
            // stepZoom
            // 
            this.stepZoom.Location = new System.Drawing.Point(690, 17);
            this.stepZoom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stepZoom.Name = "stepZoom";
            this.stepZoom.Size = new System.Drawing.Size(41, 21);
            this.stepZoom.TabIndex = 7;
            this.stepZoom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbEV);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.stepEV);
            this.panel2.Controls.Add(this.btnEVp);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btnEVm);
            this.panel2.Controls.Add(this.sldEV);
            this.panel2.Location = new System.Drawing.Point(12, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(737, 55);
            this.panel2.TabIndex = 10;
            // 
            // lbEV
            // 
            this.lbEV.AutoSize = true;
            this.lbEV.Location = new System.Drawing.Point(487, 21);
            this.lbEV.Name = "lbEV";
            this.lbEV.Size = new System.Drawing.Size(27, 12);
            this.lbEV.TabIndex = 10;
            this.lbEV.Text = "50%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(630, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "Strength";
            // 
            // stepEV
            // 
            this.stepEV.Location = new System.Drawing.Point(690, 17);
            this.stepEV.Name = "stepEV";
            this.stepEV.Size = new System.Drawing.Size(41, 21);
            this.stepEV.TabIndex = 7;
            this.stepEV.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnEVp
            // 
            this.btnEVp.Location = new System.Drawing.Point(540, 3);
            this.btnEVp.Name = "btnEVp";
            this.btnEVp.Size = new System.Drawing.Size(84, 49);
            this.btnEVp.TabIndex = 3;
            this.btnEVp.Text = "EV +\n( ] )";
            this.btnEVp.UseVisualStyleBackColor = true;
            this.btnEVp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnEVp_MouseDown);
            this.btnEVp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnEVp_MouseUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 12F);
            this.label7.Location = new System.Drawing.Point(3, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Exposure";
            // 
            // btnEVm
            // 
            this.btnEVm.Location = new System.Drawing.Point(84, 3);
            this.btnEVm.Name = "btnEVm";
            this.btnEVm.Size = new System.Drawing.Size(83, 49);
            this.btnEVm.TabIndex = 1;
            this.btnEVm.Text = "EV -\n( [ )";
            this.btnEVm.UseVisualStyleBackColor = true;
            this.btnEVm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnEVm_MouseDown);
            this.btnEVm.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnEVm_MouseUp);
            // 
            // sldEV
            // 
            this.sldEV.Location = new System.Drawing.Point(166, 7);
            this.sldEV.Maximum = 1000;
            this.sldEV.Name = "sldEV";
            this.sldEV.Size = new System.Drawing.Size(324, 45);
            this.sldEV.TabIndex = 0;
            this.sldEV.TabStop = false;
            this.sldEV.Value = 500;
            this.sldEV.Scroll += new System.EventHandler(this.sldEV_Scroll);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbApF);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.lbApPer);
            this.panel3.Controls.Add(this.stepAp);
            this.panel3.Controls.Add(this.btnApGreat);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.btnApShallow);
            this.panel3.Controls.Add(this.sldAp);
            this.panel3.Location = new System.Drawing.Point(12, 170);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(737, 55);
            this.panel3.TabIndex = 10;
            // 
            // lbApF
            // 
            this.lbApF.AutoSize = true;
            this.lbApF.Location = new System.Drawing.Point(487, 29);
            this.lbApF.Name = "lbApF";
            this.lbApF.Size = new System.Drawing.Size(18, 12);
            this.lbApF.TabIndex = 10;
            this.lbApF.Text = "-F";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(630, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 12);
            this.label9.TabIndex = 9;
            this.label9.Text = "Strength";
            // 
            // lbApPer
            // 
            this.lbApPer.AutoSize = true;
            this.lbApPer.Location = new System.Drawing.Point(487, 11);
            this.lbApPer.Name = "lbApPer";
            this.lbApPer.Size = new System.Drawing.Size(21, 12);
            this.lbApPer.TabIndex = 8;
            this.lbApPer.Text = "0%";
            // 
            // stepAp
            // 
            this.stepAp.Location = new System.Drawing.Point(690, 17);
            this.stepAp.Name = "stepAp";
            this.stepAp.Size = new System.Drawing.Size(41, 21);
            this.stepAp.TabIndex = 7;
            this.stepAp.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnApGreat
            // 
            this.btnApGreat.Location = new System.Drawing.Point(540, 3);
            this.btnApGreat.Name = "btnApGreat";
            this.btnApGreat.Size = new System.Drawing.Size(84, 49);
            this.btnApGreat.TabIndex = 3;
            this.btnApGreat.Text = "Greatest\n( \' )";
            this.btnApGreat.UseVisualStyleBackColor = true;
            this.btnApGreat.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnApGreat_MouseDown);
            this.btnApGreat.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnApGreat_MouseUp);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("굴림", 12F);
            this.label11.Location = new System.Drawing.Point(3, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "Aperture";
            // 
            // btnApShallow
            // 
            this.btnApShallow.Location = new System.Drawing.Point(84, 3);
            this.btnApShallow.Name = "btnApShallow";
            this.btnApShallow.Size = new System.Drawing.Size(83, 49);
            this.btnApShallow.TabIndex = 1;
            this.btnApShallow.Text = "Shallow\n( ; )";
            this.btnApShallow.UseVisualStyleBackColor = true;
            this.btnApShallow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnApShallow_MouseDown);
            this.btnApShallow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnApShallow_MouseUp);
            // 
            // sldAp
            // 
            this.sldAp.Location = new System.Drawing.Point(166, 7);
            this.sldAp.Maximum = 1000;
            this.sldAp.Name = "sldAp";
            this.sldAp.Size = new System.Drawing.Size(324, 45);
            this.sldAp.TabIndex = 0;
            this.sldAp.TabStop = false;
            this.sldAp.Scroll += new System.EventHandler(this.sldAp_Scroll);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.lbFocus);
            this.panel4.Controls.Add(this.stepFocus);
            this.panel4.Controls.Add(this.btnFocusFur);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.btnFocusClo);
            this.panel4.Controls.Add(this.sldFocus);
            this.panel4.Location = new System.Drawing.Point(12, 228);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(737, 55);
            this.panel4.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(630, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 12);
            this.label13.TabIndex = 9;
            this.label13.Text = "Strength";
            // 
            // lbFocus
            // 
            this.lbFocus.AutoSize = true;
            this.lbFocus.Location = new System.Drawing.Point(487, 21);
            this.lbFocus.Name = "lbFocus";
            this.lbFocus.Size = new System.Drawing.Size(21, 12);
            this.lbFocus.TabIndex = 8;
            this.lbFocus.Text = "0%";
            // 
            // stepFocus
            // 
            this.stepFocus.Location = new System.Drawing.Point(690, 17);
            this.stepFocus.Name = "stepFocus";
            this.stepFocus.Size = new System.Drawing.Size(41, 21);
            this.stepFocus.TabIndex = 7;
            this.stepFocus.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnFocusFur
            // 
            this.btnFocusFur.Location = new System.Drawing.Point(540, 3);
            this.btnFocusFur.Name = "btnFocusFur";
            this.btnFocusFur.Size = new System.Drawing.Size(84, 49);
            this.btnFocusFur.TabIndex = 3;
            this.btnFocusFur.Text = "Further\n( / )";
            this.btnFocusFur.UseVisualStyleBackColor = true;
            this.btnFocusFur.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnFocusFur_MouseDown);
            this.btnFocusFur.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnFocusFur_MouseUp);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("굴림", 12F);
            this.label15.Location = new System.Drawing.Point(3, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 16);
            this.label15.TabIndex = 2;
            this.label15.Text = "Focus";
            // 
            // btnFocusClo
            // 
            this.btnFocusClo.Location = new System.Drawing.Point(84, 3);
            this.btnFocusClo.Name = "btnFocusClo";
            this.btnFocusClo.Size = new System.Drawing.Size(83, 49);
            this.btnFocusClo.TabIndex = 1;
            this.btnFocusClo.Text = "Closer\n( . )";
            this.btnFocusClo.UseVisualStyleBackColor = true;
            this.btnFocusClo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnFocusClo_MouseDown);
            this.btnFocusClo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnFocusClo_MouseUp);
            // 
            // sldFocus
            // 
            this.sldFocus.Location = new System.Drawing.Point(166, 7);
            this.sldFocus.Maximum = 1000;
            this.sldFocus.Name = "sldFocus";
            this.sldFocus.Size = new System.Drawing.Size(324, 45);
            this.sldFocus.TabIndex = 0;
            this.sldFocus.TabStop = false;
            this.sldFocus.Scroll += new System.EventHandler(this.sldFocus_Scroll);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnDroneForward, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDroneLeft, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDroneBackward, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnDroneRight, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDroneHold, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDroneSwitch, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(229, 175);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.stepMoveH);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(3, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(70, 52);
            this.panel1.TabIndex = 12;
            // 
            // stepMoveH
            // 
            this.stepMoveH.DecimalPlaces = 2;
            this.stepMoveH.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.stepMoveH.Location = new System.Drawing.Point(2, 26);
            this.stepMoveH.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stepMoveH.Name = "stepMoveH";
            this.stepMoveH.Size = new System.Drawing.Size(68, 21);
            this.stepMoveH.TabIndex = 1;
            this.stepMoveH.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "Left/Right";
            // 
            // btnDroneForward
            // 
            this.btnDroneForward.Location = new System.Drawing.Point(79, 3);
            this.btnDroneForward.Name = "btnDroneForward";
            this.btnDroneForward.Size = new System.Drawing.Size(70, 52);
            this.btnDroneForward.TabIndex = 6;
            this.btnDroneForward.Text = "Foward\n( T )";
            this.btnDroneForward.UseVisualStyleBackColor = true;
            this.btnDroneForward.Click += new System.EventHandler(this.btnDroneForward_Click);
            // 
            // btnDroneLeft
            // 
            this.btnDroneLeft.Location = new System.Drawing.Point(3, 61);
            this.btnDroneLeft.Name = "btnDroneLeft";
            this.btnDroneLeft.Size = new System.Drawing.Size(70, 52);
            this.btnDroneLeft.TabIndex = 7;
            this.btnDroneLeft.Text = "Left\n( F )";
            this.btnDroneLeft.UseVisualStyleBackColor = true;
            this.btnDroneLeft.Click += new System.EventHandler(this.btnDroneLeft_Click);
            // 
            // btnDroneBackward
            // 
            this.btnDroneBackward.Location = new System.Drawing.Point(79, 119);
            this.btnDroneBackward.Name = "btnDroneBackward";
            this.btnDroneBackward.Size = new System.Drawing.Size(70, 53);
            this.btnDroneBackward.TabIndex = 8;
            this.btnDroneBackward.Text = "Backward\n( G )";
            this.btnDroneBackward.UseVisualStyleBackColor = true;
            this.btnDroneBackward.Click += new System.EventHandler(this.BtnDroneBackward_Click);
            // 
            // btnDroneRight
            // 
            this.btnDroneRight.Location = new System.Drawing.Point(155, 61);
            this.btnDroneRight.Name = "btnDroneRight";
            this.btnDroneRight.Size = new System.Drawing.Size(71, 52);
            this.btnDroneRight.TabIndex = 9;
            this.btnDroneRight.Text = "Right\n( H )";
            this.btnDroneRight.UseVisualStyleBackColor = true;
            this.btnDroneRight.Click += new System.EventHandler(this.btnDroneRight_Click);
            // 
            // btnDroneHold
            // 
            this.btnDroneHold.Location = new System.Drawing.Point(79, 61);
            this.btnDroneHold.Name = "btnDroneHold";
            this.btnDroneHold.Size = new System.Drawing.Size(70, 52);
            this.btnDroneHold.TabIndex = 12;
            this.btnDroneHold.Text = "Stop";
            this.btnDroneHold.UseVisualStyleBackColor = true;
            this.btnDroneHold.Click += new System.EventHandler(this.btnDroneHold_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.stepMoveV);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(70, 52);
            this.panel5.TabIndex = 11;
            // 
            // stepMoveV
            // 
            this.stepMoveV.DecimalPlaces = 2;
            this.stepMoveV.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.stepMoveV.Location = new System.Drawing.Point(2, 24);
            this.stepMoveV.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stepMoveV.Name = "stepMoveV";
            this.stepMoveV.Size = new System.Drawing.Size(68, 21);
            this.stepMoveV.TabIndex = 1;
            this.stepMoveV.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "Fo/Back";
            // 
            // btnDroneSwitch
            // 
            this.btnDroneSwitch.Location = new System.Drawing.Point(155, 3);
            this.btnDroneSwitch.Name = "btnDroneSwitch";
            this.btnDroneSwitch.Size = new System.Drawing.Size(71, 52);
            this.btnDroneSwitch.TabIndex = 13;
            this.btnDroneSwitch.Text = "Switch\n( Y )";
            this.btnDroneSwitch.UseVisualStyleBackColor = true;
            this.btnDroneSwitch.Click += new System.EventHandler(this.btnDroneSwitch_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.btnPortrait, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnOIS, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnDoF, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnEnable, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnDrop, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnTrackself, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnDC, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnHandRotate, 2, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(494, 286);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(255, 198);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // btnPortrait
            // 
            this.btnPortrait.Location = new System.Drawing.Point(192, 3);
            this.btnPortrait.Name = "btnPortrait";
            this.btnPortrait.Size = new System.Drawing.Size(57, 43);
            this.btnPortrait.TabIndex = 3;
            this.btnPortrait.Text = "Portrait";
            this.btnPortrait.UseVisualStyleBackColor = true;
            this.btnPortrait.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnPortrait_MouseDown);
            this.btnPortrait.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnPortrait_MouseUp);
            // 
            // btnOIS
            // 
            this.btnOIS.Location = new System.Drawing.Point(129, 3);
            this.btnOIS.Name = "btnOIS";
            this.btnOIS.Size = new System.Drawing.Size(57, 43);
            this.btnOIS.TabIndex = 2;
            this.btnOIS.Text = "OIS";
            this.btnOIS.UseVisualStyleBackColor = true;
            this.btnOIS.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnOIS_MouseDown);
            this.btnOIS.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnOIS_MouseUp);
            // 
            // btnDoF
            // 
            this.btnDoF.Location = new System.Drawing.Point(66, 3);
            this.btnDoF.Name = "btnDoF";
            this.btnDoF.Size = new System.Drawing.Size(57, 43);
            this.btnDoF.TabIndex = 1;
            this.btnDoF.Text = "DoF";
            this.btnDoF.UseVisualStyleBackColor = true;
            this.btnDoF.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnDoF_MouseDown);
            this.btnDoF.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnDoF_MouseUp);
            // 
            // btnEnable
            // 
            this.btnEnable.Location = new System.Drawing.Point(3, 3);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(57, 43);
            this.btnEnable.TabIndex = 0;
            this.btnEnable.Text = "Enable";
            this.btnEnable.UseVisualStyleBackColor = true;
            this.btnEnable.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnEnable_MouseDown);
            this.btnEnable.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnEnable_MouseUp);
            // 
            // btnDrop
            // 
            this.btnDrop.Location = new System.Drawing.Point(3, 101);
            this.btnDrop.Name = "btnDrop";
            this.btnDrop.Size = new System.Drawing.Size(57, 43);
            this.btnDrop.TabIndex = 4;
            this.btnDrop.Text = "Drop";
            this.btnDrop.UseVisualStyleBackColor = true;
            this.btnDrop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnDrop_MouseDown);
            this.btnDrop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnDrop_MouseUp);
            // 
            // btnTrackself
            // 
            this.btnTrackself.Location = new System.Drawing.Point(66, 101);
            this.btnTrackself.Name = "btnTrackself";
            this.btnTrackself.Size = new System.Drawing.Size(57, 43);
            this.btnTrackself.TabIndex = 5;
            this.btnTrackself.Text = "Track Self";
            this.btnTrackself.UseVisualStyleBackColor = true;
            this.btnTrackself.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnTrackself_MouseDown);
            this.btnTrackself.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnTrackself_MouseUp);
            // 
            // btnDC
            // 
            this.btnDC.Location = new System.Drawing.Point(3, 52);
            this.btnDC.Name = "btnDC";
            this.btnDC.Size = new System.Drawing.Size(57, 43);
            this.btnDC.TabIndex = 6;
            this.btnDC.Text = "Movie Mode";
            this.btnDC.UseVisualStyleBackColor = true;
            this.btnDC.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnDC_MouseDown);
            this.btnDC.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnDC_MouseUp);
            // 
            // btnHandRotate
            // 
            this.btnHandRotate.Location = new System.Drawing.Point(129, 101);
            this.btnHandRotate.Name = "btnHandRotate";
            this.btnHandRotate.Size = new System.Drawing.Size(57, 43);
            this.btnHandRotate.TabIndex = 7;
            this.btnHandRotate.Text = "Hand Rotate";
            this.btnHandRotate.UseVisualStyleBackColor = true;
            this.btnHandRotate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnHandRotate_MouseDown);
            this.btnHandRotate.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnHandRotate_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 286);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 198);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Drone Move";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Location = new System.Drawing.Point(252, 286);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 198);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Drone Rotate";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Controls.Add(this.panel7, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnDroneRotUp, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnDroneRotLeft, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnDroneRotDown, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnDroneRotRight, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel6, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnDroneRotHold, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 18);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(229, 175);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.stepRotV);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(70, 52);
            this.panel7.TabIndex = 12;
            // 
            // stepRotV
            // 
            this.stepRotV.DecimalPlaces = 2;
            this.stepRotV.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.stepRotV.Location = new System.Drawing.Point(2, 24);
            this.stepRotV.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stepRotV.Name = "stepRotV";
            this.stepRotV.Size = new System.Drawing.Size(68, 21);
            this.stepRotV.TabIndex = 1;
            this.stepRotV.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 12);
            this.label12.TabIndex = 0;
            this.label12.Text = "Up/Down";
            // 
            // btnDroneRotUp
            // 
            this.btnDroneRotUp.Location = new System.Drawing.Point(79, 3);
            this.btnDroneRotUp.Name = "btnDroneRotUp";
            this.btnDroneRotUp.Size = new System.Drawing.Size(70, 52);
            this.btnDroneRotUp.TabIndex = 6;
            this.btnDroneRotUp.Text = "Up\n( ↑ )";
            this.btnDroneRotUp.UseVisualStyleBackColor = true;
            this.btnDroneRotUp.Click += new System.EventHandler(this.btnDroneRotUp_Click);
            // 
            // btnDroneRotLeft
            // 
            this.btnDroneRotLeft.Location = new System.Drawing.Point(3, 61);
            this.btnDroneRotLeft.Name = "btnDroneRotLeft";
            this.btnDroneRotLeft.Size = new System.Drawing.Size(70, 52);
            this.btnDroneRotLeft.TabIndex = 7;
            this.btnDroneRotLeft.Text = "Left\n( ← )";
            this.btnDroneRotLeft.UseVisualStyleBackColor = true;
            this.btnDroneRotLeft.Click += new System.EventHandler(this.btnDroneRotLeft_Click);
            // 
            // btnDroneRotDown
            // 
            this.btnDroneRotDown.Location = new System.Drawing.Point(79, 119);
            this.btnDroneRotDown.Name = "btnDroneRotDown";
            this.btnDroneRotDown.Size = new System.Drawing.Size(70, 53);
            this.btnDroneRotDown.TabIndex = 8;
            this.btnDroneRotDown.Text = "Down\n( ↓ )";
            this.btnDroneRotDown.UseVisualStyleBackColor = true;
            this.btnDroneRotDown.Click += new System.EventHandler(this.btnDroneRotDown_Click);
            // 
            // btnDroneRotRight
            // 
            this.btnDroneRotRight.Location = new System.Drawing.Point(155, 61);
            this.btnDroneRotRight.Name = "btnDroneRotRight";
            this.btnDroneRotRight.Size = new System.Drawing.Size(71, 52);
            this.btnDroneRotRight.TabIndex = 9;
            this.btnDroneRotRight.Text = "Right\n( → )";
            this.btnDroneRotRight.UseVisualStyleBackColor = true;
            this.btnDroneRotRight.Click += new System.EventHandler(this.btnDroneRotRight_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.stepRotH);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(3, 119);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(70, 53);
            this.panel6.TabIndex = 11;
            // 
            // stepRotH
            // 
            this.stepRotH.DecimalPlaces = 2;
            this.stepRotH.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.stepRotH.Location = new System.Drawing.Point(2, 26);
            this.stepRotH.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stepRotH.Name = "stepRotH";
            this.stepRotH.Size = new System.Drawing.Size(68, 21);
            this.stepRotH.TabIndex = 1;
            this.stepRotH.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "Left/Right";
            // 
            // btnDroneRotHold
            // 
            this.btnDroneRotHold.Location = new System.Drawing.Point(79, 61);
            this.btnDroneRotHold.Name = "btnDroneRotHold";
            this.btnDroneRotHold.Size = new System.Drawing.Size(70, 52);
            this.btnDroneRotHold.TabIndex = 13;
            this.btnDroneRotHold.Text = "Stop";
            this.btnDroneRotHold.UseVisualStyleBackColor = true;
            this.btnDroneRotHold.Click += new System.EventHandler(this.btnDroneRotHold_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnShortkey);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnConnect);
            this.groupBox3.Controls.Add(this.Port);
            this.groupBox3.Controls.Add(this.IPAddr);
            this.groupBox3.Location = new System.Drawing.Point(12, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(737, 45);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            // 
            // btnShortkey
            // 
            this.btnShortkey.Location = new System.Drawing.Point(290, 13);
            this.btnShortkey.Name = "btnShortkey";
            this.btnShortkey.Size = new System.Drawing.Size(116, 23);
            this.btnShortkey.TabIndex = 4;
            this.btnShortkey.Text = "Enable Shortkey";
            this.btnShortkey.UseVisualStyleBackColor = true;
            this.btnShortkey.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(591, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Developed By :  Arizen  \nForEstu";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(199, 13);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(85, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // Port
            // 
            this.Port.Location = new System.Drawing.Point(118, 15);
            this.Port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Port.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(75, 21);
            this.Port.TabIndex = 1;
            this.Port.Value = new decimal(new int[] {
            9000,
            0,
            0,
            0});
            // 
            // IPAddr
            // 
            this.IPAddr.Location = new System.Drawing.Point(7, 15);
            this.IPAddr.Name = "IPAddr";
            this.IPAddr.Size = new System.Drawing.Size(100, 21);
            this.IPAddr.TabIndex = 0;
            this.IPAddr.Text = "127.0.0.1";
            // 
            // TimerZoomIn
            // 
            this.TimerZoomIn.Interval = 10;
            this.TimerZoomIn.Tick += new System.EventHandler(this.TimerZoomIn_Tick);
            // 
            // TimerZoomOut
            // 
            this.TimerZoomOut.Interval = 10;
            this.TimerZoomOut.Tick += new System.EventHandler(this.TimerZoomOut_Tick);
            // 
            // TimerEVm
            // 
            this.TimerEVm.Interval = 10;
            this.TimerEVm.Tick += new System.EventHandler(this.TimerEVm_Tick);
            // 
            // TimerEVp
            // 
            this.TimerEVp.Interval = 10;
            this.TimerEVp.Tick += new System.EventHandler(this.TimerEVp_Tick);
            // 
            // TimerApShallow
            // 
            this.TimerApShallow.Interval = 10;
            this.TimerApShallow.Tick += new System.EventHandler(this.TimerApShallow_Tick);
            // 
            // TimerApGrea
            // 
            this.TimerApGrea.Interval = 10;
            this.TimerApGrea.Tick += new System.EventHandler(this.TimerApGrea_Tick);
            // 
            // TimerFocusClo
            // 
            this.TimerFocusClo.Interval = 10;
            this.TimerFocusClo.Tick += new System.EventHandler(this.TimerFocusClo_Tick);
            // 
            // TimerFocusFur
            // 
            this.TimerFocusFur.Interval = 10;
            this.TimerFocusFur.Tick += new System.EventHandler(this.TimerFocusFur_Tick);
            // 
            // lbVer
            // 
            this.lbVer.AutoSize = true;
            this.lbVer.Location = new System.Drawing.Point(694, 473);
            this.lbVer.Name = "lbVer";
            this.lbVer.Size = new System.Drawing.Size(65, 12);
            this.lbVer.TabIndex = 5;
            this.lbVer.Text = "Ver. 1.0.7b";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 489);
            this.Controls.Add(this.lbVer);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "VRCLensOSC";
            ((System.ComponentModel.ISupportInitialize)(this.sldZoom)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepZoom)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepEV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sldEV)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepAp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sldAp)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepFocus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sldFocus)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepMoveH)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepMoveV)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepRotV)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepRotH)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Port)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar sldZoom;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.Label lbZoomPer;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbZoomLen;
        private System.Windows.Forms.NumericUpDown stepZoom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown stepEV;
        private System.Windows.Forms.Button btnEVp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEVm;
        private System.Windows.Forms.TrackBar sldEV;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbApPer;
        private System.Windows.Forms.NumericUpDown stepAp;
        private System.Windows.Forms.Button btnApGreat;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnApShallow;
        private System.Windows.Forms.TrackBar sldAp;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbFocus;
        private System.Windows.Forms.NumericUpDown stepFocus;
        private System.Windows.Forms.Button btnFocusFur;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnFocusClo;
        private System.Windows.Forms.TrackBar sldFocus;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnDroneForward;
        private System.Windows.Forms.Button btnDroneLeft;
        private System.Windows.Forms.Button btnDroneBackward;
        private System.Windows.Forms.Button btnDroneRight;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.NumericUpDown stepMoveV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnDrop;
        private System.Windows.Forms.Button btnPortrait;
        private System.Windows.Forms.Button btnOIS;
        private System.Windows.Forms.Button btnDoF;
        private System.Windows.Forms.Button btnEnable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnDroneRotUp;
        private System.Windows.Forms.Button btnDroneRotLeft;
        private System.Windows.Forms.Button btnDroneRotDown;
        private System.Windows.Forms.Button btnDroneRotRight;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.NumericUpDown stepRotH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbEV;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.NumericUpDown Port;
        private System.Windows.Forms.TextBox IPAddr;
        private System.Windows.Forms.Button btnTrackself;
        private System.Windows.Forms.Timer TimerZoomIn;
        private System.Windows.Forms.Timer TimerZoomOut;
        private System.Windows.Forms.Timer TimerEVm;
        private System.Windows.Forms.Timer TimerEVp;
        private System.Windows.Forms.Timer TimerApShallow;
        private System.Windows.Forms.Timer TimerApGrea;
        private System.Windows.Forms.Timer TimerFocusClo;
        private System.Windows.Forms.Timer TimerFocusFur;
        private System.Windows.Forms.Label lbApF;
        private System.Windows.Forms.Button btnDroneHold;
        private System.Windows.Forms.Button btnDroneRotHold;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnShortkey;
        private System.Windows.Forms.Button btnDC;
        private System.ComponentModel.BackgroundWorker oscListener;
        private System.Windows.Forms.Label lbVer;
        private System.Windows.Forms.Button btnHandRotate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown stepMoveH;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.NumericUpDown stepRotV;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnDroneSwitch;
    }
}

