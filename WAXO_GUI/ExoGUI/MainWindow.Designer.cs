namespace SerialEPOSuC
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.btnEnable = new System.Windows.Forms.Button();
            this.btnConnectEPOS = new System.Windows.Forms.Button();
            this.grpboxConnection = new System.Windows.Forms.GroupBox();
            this.lblConnectuC = new System.Windows.Forms.Label();
            this.lblEnableEPOS = new System.Windows.Forms.Label();
            this.lblConnectedEPOS = new System.Windows.Forms.Label();
            this.grpboxControlParameters = new System.Windows.Forms.GroupBox();
            this.btnCurrentMode = new System.Windows.Forms.Button();
            this.txtAcceleration = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProfileSpeed = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSlackPosition = new System.Windows.Forms.TextBox();
            this.txtMaxPosition = new System.Windows.Forms.TextBox();
            this.txtTightPosition = new System.Windows.Forms.TextBox();
            this.btnSetControlParamaters = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.radioBtnManualConrol = new System.Windows.Forms.RadioButton();
            this.radioBtnAutonomousControl = new System.Windows.Forms.RadioButton();
            this.btnHalt = new System.Windows.Forms.Button();
            this.btnEnableuC = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnConnentuC = new System.Windows.Forms.Button();
            this.timerActualPosition = new System.Windows.Forms.Timer(this.components);
            this.btnDisableEPOS = new System.Windows.Forms.Button();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.btnDisconnectuC = new System.Windows.Forms.Button();
            this.lblDataReceived = new System.Windows.Forms.Label();
            this.lblAlert = new System.Windows.Forms.Label();
            this.grpboxGaitCyclePeriod = new System.Windows.Forms.GroupBox();
            this.btnStartGait = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtAveragePeriod = new System.Windows.Forms.TextBox();
            this.txtNumberCycles = new System.Windows.Forms.TextBox();
            this.grpboxPercentage = new System.Windows.Forms.GroupBox();
            this.btnStopActuation = new System.Windows.Forms.Button();
            this.btnStartActutation = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtPercentage = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnConnectDAQ = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPP = new System.Windows.Forms.Label();
            this.lblUserInstruction = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnApplyProfile = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comBoxProfile = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.timerCurrentProfile = new System.Windows.Forms.Timer(this.components);
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnDisableSinusoidalProfileTimer = new System.Windows.Forms.Button();
            this.btnApplyPositionSinusoidal = new System.Windows.Forms.Button();
            this.btnActivatePositionMode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timerPositionSinusoidal = new System.Windows.Forms.Timer(this.components);
            this.grpboxConnection.SuspendLayout();
            this.grpboxControlParameters.SuspendLayout();
            this.grpboxGaitCyclePeriod.SuspendLayout();
            this.grpboxPercentage.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEnable
            // 
            this.btnEnable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnable.Location = new System.Drawing.Point(11, 62);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(120, 32);
            this.btnEnable.TabIndex = 0;
            this.btnEnable.Text = "Enable";
            this.btnEnable.UseVisualStyleBackColor = true;
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // btnConnectEPOS
            // 
            this.btnConnectEPOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectEPOS.Location = new System.Drawing.Point(11, 24);
            this.btnConnectEPOS.Name = "btnConnectEPOS";
            this.btnConnectEPOS.Size = new System.Drawing.Size(120, 32);
            this.btnConnectEPOS.TabIndex = 0;
            this.btnConnectEPOS.Text = "Connect";
            this.btnConnectEPOS.UseVisualStyleBackColor = true;
            this.btnConnectEPOS.Click += new System.EventHandler(this.btnConnectEPOS_Click);
            // 
            // grpboxConnection
            // 
            this.grpboxConnection.Controls.Add(this.lblConnectuC);
            this.grpboxConnection.Controls.Add(this.lblEnableEPOS);
            this.grpboxConnection.Controls.Add(this.lblConnectedEPOS);
            this.grpboxConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxConnection.Location = new System.Drawing.Point(12, 12);
            this.grpboxConnection.Name = "grpboxConnection";
            this.grpboxConnection.Size = new System.Drawing.Size(308, 140);
            this.grpboxConnection.TabIndex = 1;
            this.grpboxConnection.TabStop = false;
            this.grpboxConnection.Text = "Connection state";
            // 
            // lblConnectuC
            // 
            this.lblConnectuC.AutoSize = true;
            this.lblConnectuC.BackColor = System.Drawing.Color.Tomato;
            this.lblConnectuC.Location = new System.Drawing.Point(6, 66);
            this.lblConnectuC.Name = "lblConnectuC";
            this.lblConnectuC.Size = new System.Drawing.Size(218, 20);
            this.lblConnectuC.TabIndex = 0;
            this.lblConnectuC.Text = "Microcontroller not connected";
            // 
            // lblEnableEPOS
            // 
            this.lblEnableEPOS.AutoSize = true;
            this.lblEnableEPOS.BackColor = System.Drawing.Color.Tomato;
            this.lblEnableEPOS.Location = new System.Drawing.Point(6, 104);
            this.lblEnableEPOS.Name = "lblEnableEPOS";
            this.lblEnableEPOS.Size = new System.Drawing.Size(150, 20);
            this.lblEnableEPOS.TabIndex = 0;
            this.lblEnableEPOS.Text = "EPOS2 not enabled";
            // 
            // lblConnectedEPOS
            // 
            this.lblConnectedEPOS.AutoSize = true;
            this.lblConnectedEPOS.BackColor = System.Drawing.Color.Tomato;
            this.lblConnectedEPOS.Location = new System.Drawing.Point(6, 30);
            this.lblConnectedEPOS.Name = "lblConnectedEPOS";
            this.lblConnectedEPOS.Size = new System.Drawing.Size(168, 20);
            this.lblConnectedEPOS.TabIndex = 0;
            this.lblConnectedEPOS.Text = "EPOS2 not connected";
            // 
            // grpboxControlParameters
            // 
            this.grpboxControlParameters.Controls.Add(this.btnCurrentMode);
            this.grpboxControlParameters.Controls.Add(this.txtAcceleration);
            this.grpboxControlParameters.Controls.Add(this.label8);
            this.grpboxControlParameters.Controls.Add(this.txtProfileSpeed);
            this.grpboxControlParameters.Controls.Add(this.label7);
            this.grpboxControlParameters.Controls.Add(this.txtSlackPosition);
            this.grpboxControlParameters.Controls.Add(this.txtMaxPosition);
            this.grpboxControlParameters.Controls.Add(this.txtTightPosition);
            this.grpboxControlParameters.Controls.Add(this.btnSetControlParamaters);
            this.grpboxControlParameters.Controls.Add(this.label6);
            this.grpboxControlParameters.Controls.Add(this.label10);
            this.grpboxControlParameters.Controls.Add(this.label4);
            this.grpboxControlParameters.Controls.Add(this.btnHome);
            this.grpboxControlParameters.Controls.Add(this.radioBtnManualConrol);
            this.grpboxControlParameters.Controls.Add(this.radioBtnAutonomousControl);
            this.grpboxControlParameters.Controls.Add(this.btnHalt);
            this.grpboxControlParameters.Controls.Add(this.btnEnableuC);
            this.grpboxControlParameters.Controls.Add(this.btnMove);
            this.grpboxControlParameters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxControlParameters.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpboxControlParameters.Location = new System.Drawing.Point(616, 158);
            this.grpboxControlParameters.Name = "grpboxControlParameters";
            this.grpboxControlParameters.Size = new System.Drawing.Size(264, 373);
            this.grpboxControlParameters.TabIndex = 2;
            this.grpboxControlParameters.TabStop = false;
            this.grpboxControlParameters.Text = "Position Control Parameters";
            // 
            // btnCurrentMode
            // 
            this.btnCurrentMode.Location = new System.Drawing.Point(137, 321);
            this.btnCurrentMode.Name = "btnCurrentMode";
            this.btnCurrentMode.Size = new System.Drawing.Size(120, 32);
            this.btnCurrentMode.TabIndex = 19;
            this.btnCurrentMode.Text = "Current Mode";
            this.btnCurrentMode.UseVisualStyleBackColor = true;
            this.btnCurrentMode.Click += new System.EventHandler(this.btnCurrentMode_Click);
            // 
            // txtAcceleration
            // 
            this.txtAcceleration.Location = new System.Drawing.Point(153, 153);
            this.txtAcceleration.Name = "txtAcceleration";
            this.txtAcceleration.Size = new System.Drawing.Size(100, 26);
            this.txtAcceleration.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Acceleration";
            // 
            // txtProfileSpeed
            // 
            this.txtProfileSpeed.Location = new System.Drawing.Point(153, 121);
            this.txtProfileSpeed.Name = "txtProfileSpeed";
            this.txtProfileSpeed.Size = new System.Drawing.Size(100, 26);
            this.txtProfileSpeed.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Profile Speed";
            // 
            // txtSlackPosition
            // 
            this.txtSlackPosition.Location = new System.Drawing.Point(153, 25);
            this.txtSlackPosition.Name = "txtSlackPosition";
            this.txtSlackPosition.Size = new System.Drawing.Size(100, 26);
            this.txtSlackPosition.TabIndex = 8;
            // 
            // txtMaxPosition
            // 
            this.txtMaxPosition.Location = new System.Drawing.Point(153, 89);
            this.txtMaxPosition.Name = "txtMaxPosition";
            this.txtMaxPosition.Size = new System.Drawing.Size(100, 26);
            this.txtMaxPosition.TabIndex = 13;
            // 
            // txtTightPosition
            // 
            this.txtTightPosition.Location = new System.Drawing.Point(153, 57);
            this.txtTightPosition.Name = "txtTightPosition";
            this.txtTightPosition.Size = new System.Drawing.Size(100, 26);
            this.txtTightPosition.TabIndex = 6;
            // 
            // btnSetControlParamaters
            // 
            this.btnSetControlParamaters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetControlParamaters.Location = new System.Drawing.Point(137, 217);
            this.btnSetControlParamaters.Name = "btnSetControlParamaters";
            this.btnSetControlParamaters.Size = new System.Drawing.Size(120, 32);
            this.btnSetControlParamaters.TabIndex = 11;
            this.btnSetControlParamaters.Text = "Set Parameters";
            this.btnSetControlParamaters.UseVisualStyleBackColor = true;
            this.btnSetControlParamaters.Click += new System.EventHandler(this.btnSetControlParamaters_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Slack Position";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Max. position";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tight position";
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(11, 217);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(120, 32);
            this.btnHome.TabIndex = 8;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // radioBtnManualConrol
            // 
            this.radioBtnManualConrol.AutoSize = true;
            this.radioBtnManualConrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnManualConrol.Location = new System.Drawing.Point(11, 187);
            this.radioBtnManualConrol.Name = "radioBtnManualConrol";
            this.radioBtnManualConrol.Size = new System.Drawing.Size(131, 24);
            this.radioBtnManualConrol.TabIndex = 7;
            this.radioBtnManualConrol.TabStop = true;
            this.radioBtnManualConrol.Text = "Manual control";
            this.radioBtnManualConrol.UseVisualStyleBackColor = true;
            this.radioBtnManualConrol.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioBtnAutonomousControl
            // 
            this.radioBtnAutonomousControl.AutoSize = true;
            this.radioBtnAutonomousControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnAutonomousControl.Location = new System.Drawing.Point(11, 291);
            this.radioBtnAutonomousControl.Name = "radioBtnAutonomousControl";
            this.radioBtnAutonomousControl.Size = new System.Drawing.Size(170, 24);
            this.radioBtnAutonomousControl.TabIndex = 7;
            this.radioBtnAutonomousControl.TabStop = true;
            this.radioBtnAutonomousControl.Text = "Autonomous control";
            this.radioBtnAutonomousControl.UseVisualStyleBackColor = true;
            this.radioBtnAutonomousControl.CheckedChanged += new System.EventHandler(this.radioBtnAutonomousControl_CheckedChanged);
            // 
            // btnHalt
            // 
            this.btnHalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHalt.Location = new System.Drawing.Point(137, 255);
            this.btnHalt.Name = "btnHalt";
            this.btnHalt.Size = new System.Drawing.Size(120, 32);
            this.btnHalt.TabIndex = 5;
            this.btnHalt.Text = "Halt";
            this.btnHalt.UseVisualStyleBackColor = true;
            this.btnHalt.Click += new System.EventHandler(this.btnHalt_Click);
            // 
            // btnEnableuC
            // 
            this.btnEnableuC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnableuC.Location = new System.Drawing.Point(11, 321);
            this.btnEnableuC.Name = "btnEnableuC";
            this.btnEnableuC.Size = new System.Drawing.Size(120, 32);
            this.btnEnableuC.TabIndex = 5;
            this.btnEnableuC.Text = "Enable";
            this.btnEnableuC.UseVisualStyleBackColor = true;
            this.btnEnableuC.Click += new System.EventHandler(this.btnEnableuC_Click);
            // 
            // btnMove
            // 
            this.btnMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMove.Location = new System.Drawing.Point(11, 255);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(120, 32);
            this.btnMove.TabIndex = 5;
            this.btnMove.Text = "Move";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnConnentuC
            // 
            this.btnConnentuC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnentuC.Location = new System.Drawing.Point(6, 24);
            this.btnConnentuC.Name = "btnConnentuC";
            this.btnConnentuC.Size = new System.Drawing.Size(120, 32);
            this.btnConnentuC.TabIndex = 4;
            this.btnConnentuC.Text = "Connect";
            this.btnConnentuC.UseVisualStyleBackColor = true;
            this.btnConnentuC.Click += new System.EventHandler(this.btnConnentuC_Click);
            // 
            // timerActualPosition
            // 
            this.timerActualPosition.Interval = 10;
            // 
            // btnDisableEPOS
            // 
            this.btnDisableEPOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisableEPOS.Location = new System.Drawing.Point(11, 100);
            this.btnDisableEPOS.Name = "btnDisableEPOS";
            this.btnDisableEPOS.Size = new System.Drawing.Size(120, 32);
            this.btnDisableEPOS.TabIndex = 9;
            this.btnDisableEPOS.Text = "Disable";
            this.btnDisableEPOS.UseVisualStyleBackColor = true;
            this.btnDisableEPOS.Click += new System.EventHandler(this.btnDisableEPOS_Click);
            // 
            // btnSaveData
            // 
            this.btnSaveData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveData.Location = new System.Drawing.Point(7, 65);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(120, 32);
            this.btnSaveData.TabIndex = 10;
            this.btnSaveData.Text = "Save Data";
            this.btnSaveData.UseVisualStyleBackColor = true;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // btnDisconnectuC
            // 
            this.btnDisconnectuC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnectuC.Location = new System.Drawing.Point(6, 65);
            this.btnDisconnectuC.Name = "btnDisconnectuC";
            this.btnDisconnectuC.Size = new System.Drawing.Size(120, 32);
            this.btnDisconnectuC.TabIndex = 12;
            this.btnDisconnectuC.Text = "Disconnect";
            this.btnDisconnectuC.UseVisualStyleBackColor = true;
            this.btnDisconnectuC.Click += new System.EventHandler(this.btnDisconnectuC_Click);
            // 
            // lblDataReceived
            // 
            this.lblDataReceived.AutoSize = true;
            this.lblDataReceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataReceived.Location = new System.Drawing.Point(470, 601);
            this.lblDataReceived.Name = "lblDataReceived";
            this.lblDataReceived.Size = new System.Drawing.Size(0, 20);
            this.lblDataReceived.TabIndex = 16;
            // 
            // lblAlert
            // 
            this.lblAlert.AutoSize = true;
            this.lblAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlert.Location = new System.Drawing.Point(6, 108);
            this.lblAlert.Name = "lblAlert";
            this.lblAlert.Size = new System.Drawing.Size(42, 20);
            this.lblAlert.TabIndex = 17;
            this.lblAlert.Text = "Alert";
            // 
            // grpboxGaitCyclePeriod
            // 
            this.grpboxGaitCyclePeriod.Controls.Add(this.btnStartGait);
            this.grpboxGaitCyclePeriod.Controls.Add(this.label14);
            this.grpboxGaitCyclePeriod.Controls.Add(this.label13);
            this.grpboxGaitCyclePeriod.Controls.Add(this.txtAveragePeriod);
            this.grpboxGaitCyclePeriod.Controls.Add(this.txtNumberCycles);
            this.grpboxGaitCyclePeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxGaitCyclePeriod.Location = new System.Drawing.Point(12, 249);
            this.grpboxGaitCyclePeriod.Name = "grpboxGaitCyclePeriod";
            this.grpboxGaitCyclePeriod.Size = new System.Drawing.Size(308, 137);
            this.grpboxGaitCyclePeriod.TabIndex = 18;
            this.grpboxGaitCyclePeriod.TabStop = false;
            this.grpboxGaitCyclePeriod.Text = "Gait Cycle Period";
            // 
            // btnStartGait
            // 
            this.btnStartGait.Location = new System.Drawing.Point(80, 94);
            this.btnStartGait.Name = "btnStartGait";
            this.btnStartGait.Size = new System.Drawing.Size(112, 32);
            this.btnStartGait.TabIndex = 9;
            this.btnStartGait.Text = "Start";
            this.btnStartGait.UseVisualStyleBackColor = true;
            this.btnStartGait.Click += new System.EventHandler(this.btnStartGait_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 57);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(163, 20);
            this.label14.TabIndex = 2;
            this.label14.Text = "Average cycles period";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(186, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "Number of cycles passed";
            // 
            // txtAveragePeriod
            // 
            this.txtAveragePeriod.Location = new System.Drawing.Point(198, 57);
            this.txtAveragePeriod.Name = "txtAveragePeriod";
            this.txtAveragePeriod.Size = new System.Drawing.Size(100, 26);
            this.txtAveragePeriod.TabIndex = 8;
            this.txtAveragePeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNumberCycles
            // 
            this.txtNumberCycles.Location = new System.Drawing.Point(198, 22);
            this.txtNumberCycles.Name = "txtNumberCycles";
            this.txtNumberCycles.Size = new System.Drawing.Size(100, 26);
            this.txtNumberCycles.TabIndex = 8;
            this.txtNumberCycles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpboxPercentage
            // 
            this.grpboxPercentage.Controls.Add(this.btnStopActuation);
            this.grpboxPercentage.Controls.Add(this.btnStartActutation);
            this.grpboxPercentage.Controls.Add(this.label11);
            this.grpboxPercentage.Controls.Add(this.label15);
            this.grpboxPercentage.Controls.Add(this.label16);
            this.grpboxPercentage.Controls.Add(this.textBox3);
            this.grpboxPercentage.Controls.Add(this.txtPercentage);
            this.grpboxPercentage.Controls.Add(this.textBox1);
            this.grpboxPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxPercentage.Location = new System.Drawing.Point(12, 392);
            this.grpboxPercentage.Name = "grpboxPercentage";
            this.grpboxPercentage.Size = new System.Drawing.Size(308, 168);
            this.grpboxPercentage.TabIndex = 18;
            this.grpboxPercentage.TabStop = false;
            this.grpboxPercentage.Text = "Motor Actuaction Percentage";
            // 
            // btnStopActuation
            // 
            this.btnStopActuation.Location = new System.Drawing.Point(158, 125);
            this.btnStopActuation.Name = "btnStopActuation";
            this.btnStopActuation.Size = new System.Drawing.Size(120, 32);
            this.btnStopActuation.TabIndex = 10;
            this.btnStopActuation.Text = "Stop";
            this.btnStopActuation.UseVisualStyleBackColor = true;
            this.btnStopActuation.Click += new System.EventHandler(this.btnStopActuation_Click);
            // 
            // btnStartActutation
            // 
            this.btnStartActutation.Location = new System.Drawing.Point(22, 125);
            this.btnStartActutation.Name = "btnStartActutation";
            this.btnStartActutation.Size = new System.Drawing.Size(120, 32);
            this.btnStartActutation.TabIndex = 9;
            this.btnStartActutation.Text = "Start";
            this.btnStartActutation.UseVisualStyleBackColor = true;
            this.btnStartActutation.Click += new System.EventHandler(this.btnStartActutation_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(170, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Cable tightening timing";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 95);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(166, 20);
            this.label15.TabIndex = 2;
            this.label15.Text = "Motor actuation timing";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(124, 20);
            this.label16.TabIndex = 2;
            this.label16.Text = "Gait percentage";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(198, 92);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 26);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = " 43 %";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPercentage
            // 
            this.txtPercentage.Location = new System.Drawing.Point(198, 25);
            this.txtPercentage.Name = "txtPercentage";
            this.txtPercentage.Size = new System.Drawing.Size(100, 26);
            this.txtPercentage.TabIndex = 8;
            this.txtPercentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(198, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "30 %";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnConnectEPOS);
            this.groupBox3.Controls.Add(this.btnEnable);
            this.groupBox3.Controls.Add(this.btnDisableEPOS);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(344, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(142, 140);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "EPOS2";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnConnectDAQ);
            this.groupBox4.Controls.Add(this.btnConnentuC);
            this.groupBox4.Controls.Add(this.btnDisconnectuC);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(492, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(134, 140);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Microcontroller";
            // 
            // btnConnectDAQ
            // 
            this.btnConnectDAQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectDAQ.Location = new System.Drawing.Point(6, 102);
            this.btnConnectDAQ.Name = "btnConnectDAQ";
            this.btnConnectDAQ.Size = new System.Drawing.Size(120, 32);
            this.btnConnectDAQ.TabIndex = 13;
            this.btnConnectDAQ.Text = "Connect DAQ";
            this.btnConnectDAQ.UseVisualStyleBackColor = true;
            this.btnConnectDAQ.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPP);
            this.groupBox1.Controls.Add(this.lblUserInstruction);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 85);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Instructions for user ";
            // 
            // lblPP
            // 
            this.lblPP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPP.AutoSize = true;
            this.lblPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPP.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblPP.Location = new System.Drawing.Point(50, 54);
            this.lblPP.Name = "lblPP";
            this.lblPP.Size = new System.Drawing.Size(192, 20);
            this.lblPP.TabIndex = 2;
            this.lblPP.Text = "Powered Plantarflexion";
            // 
            // lblUserInstruction
            // 
            this.lblUserInstruction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserInstruction.AutoSize = true;
            this.lblUserInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserInstruction.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblUserInstruction.Location = new System.Drawing.Point(55, 25);
            this.lblUserInstruction.Name = "lblUserInstruction";
            this.lblUserInstruction.Size = new System.Drawing.Size(181, 20);
            this.lblUserInstruction.TabIndex = 2;
            this.lblUserInstruction.Text = "You can start walking";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(7, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 32);
            this.button1.TabIndex = 19;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.btnApplyProfile);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.comBoxProfile);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(344, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 211);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current Control ";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(69, 167);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 32);
            this.button3.TabIndex = 4;
            this.button3.Text = "Disable";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // btnApplyProfile
            // 
            this.btnApplyProfile.Location = new System.Drawing.Point(69, 129);
            this.btnApplyProfile.Name = "btnApplyProfile";
            this.btnApplyProfile.Size = new System.Drawing.Size(114, 32);
            this.btnApplyProfile.TabIndex = 3;
            this.btnApplyProfile.Text = "Apply";
            this.btnApplyProfile.UseVisualStyleBackColor = true;
            this.btnApplyProfile.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(69, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "Enable";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comBoxProfile
            // 
            this.comBoxProfile.Items.AddRange(new object[] {
            "1.5A par = 7.9 N.m in 300 ms",
            "2A par = 10.5 N.m in 300 ms",
            "3A par = 15.7 N.m in 300 ms",
            "4A par = 21.0 N.m in 300 ms",
            "5A par = 26.3 N.m in 300 ms",
            "6A par = 31.5 N.m in 300 ms",
            "7A par = 36.8 N.m in 300 ms",
            "8A par = 42.1 N.m in 300 ms",
            "9A par = 47.3 N.m in 300 ms",
            "10A par = 52.6 N.m in 300 ms",
            "1.5A par = 7.9 N.m in 200 ms",
            "2A par = 10.5 N.m in 200 ms",
            "3A par = 15.7 N.m in 200 ms",
            "4A par = 21.0 N.m in 200 ms",
            "5A par = 26.3 N.m in 200 ms",
            "6A par = 31.5 N.m in 200 ms",
            "7A par = 36.8 N.m in 200 ms",
            "8A par = 42.1 N.m in 200 ms",
            "9A par = 47.3 N.m in 200 ms",
            "10A par = 52.6 N.m in 200 ms",
            "1.5A par = 7.9 N.m in 150 ms",
            "2A par = 10.5 N.m in 150 ms",
            "3A par = 15.7 N.m in 150 ms",
            "4A par = 21.0 N.m in 150 ms",
            "5A par = 26.3 N.m in 150 ms",
            "6A par = 31.5 N.m in 150 ms",
            "7A par = 36.8 N.m in 150 ms",
            "8A par = 42.1 N.m in 150 ms",
            "9A par = 47.3 N.m in 150 ms",
            "10A par = 52.6 N.m in 150 ms",
            "1.5A linear = 7.9 N.m in 300 ms",
            "2A linear = 10.5 N.m in 300 ms",
            "3A linear = 15.8 N.m in 300 ms",
            "6A linear = 31.6 N.m in 300 ms",
            "5A par = 26.3 N.m in 180 ms",
            "6A par = 31.5 N.m in 180 ms",
            "5A par = 26.3 N.m in 130 ms",
            "6A par = 31.5 N.m in 130 ms"});
            this.comBoxProfile.Location = new System.Drawing.Point(10, 52);
            this.comBoxProfile.Name = "comBoxProfile";
            this.comBoxProfile.Size = new System.Drawing.Size(233, 28);
            this.comBoxProfile.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Torque profile";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.btnSaveData);
            this.groupBox5.Controls.Add(this.lblAlert);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(637, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(136, 140);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "General";
            // 
            // timerCurrentProfile
            // 
            this.timerCurrentProfile.Interval = 10;
            this.timerCurrentProfile.Tick += new System.EventHandler(this.timerCurrentProfile_Tick);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnDisableSinusoidalProfileTimer);
            this.groupBox6.Controls.Add(this.btnApplyPositionSinusoidal);
            this.groupBox6.Controls.Add(this.btnActivatePositionMode);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(344, 381);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(249, 168);
            this.groupBox6.TabIndex = 22;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Mecahnical Test Profile";
            // 
            // btnDisableSinusoidalProfileTimer
            // 
            this.btnDisableSinusoidalProfileTimer.Location = new System.Drawing.Point(69, 130);
            this.btnDisableSinusoidalProfileTimer.Name = "btnDisableSinusoidalProfileTimer";
            this.btnDisableSinusoidalProfileTimer.Size = new System.Drawing.Size(114, 32);
            this.btnDisableSinusoidalProfileTimer.TabIndex = 4;
            this.btnDisableSinusoidalProfileTimer.Text = "Disable";
            this.btnDisableSinusoidalProfileTimer.UseVisualStyleBackColor = true;
            this.btnDisableSinusoidalProfileTimer.Click += new System.EventHandler(this.btnDisableSinusoidalProfileTimer_Click);
            // 
            // btnApplyPositionSinusoidal
            // 
            this.btnApplyPositionSinusoidal.Location = new System.Drawing.Point(69, 90);
            this.btnApplyPositionSinusoidal.Name = "btnApplyPositionSinusoidal";
            this.btnApplyPositionSinusoidal.Size = new System.Drawing.Size(114, 32);
            this.btnApplyPositionSinusoidal.TabIndex = 3;
            this.btnApplyPositionSinusoidal.Text = "Apply";
            this.btnApplyPositionSinusoidal.UseVisualStyleBackColor = true;
            this.btnApplyPositionSinusoidal.Click += new System.EventHandler(this.btnApplyPositionSinusoidal_Click);
            // 
            // btnActivatePositionMode
            // 
            this.btnActivatePositionMode.Location = new System.Drawing.Point(69, 52);
            this.btnActivatePositionMode.Name = "btnActivatePositionMode";
            this.btnActivatePositionMode.Size = new System.Drawing.Size(114, 32);
            this.btnActivatePositionMode.TabIndex = 3;
            this.btnActivatePositionMode.Text = "Enable";
            this.btnActivatePositionMode.UseVisualStyleBackColor = true;
            this.btnActivatePositionMode.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Position Sinusoidal 0.5 Hz 90°";
            // 
            // timerPositionSinusoidal
            // 
            this.timerPositionSinusoidal.Interval = 10;
            this.timerPositionSinusoidal.Tick += new System.EventHandler(this.timerPositionSinusoidal_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 572);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpboxControlParameters);
            this.Controls.Add(this.grpboxPercentage);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpboxGaitCyclePeriod);
            this.Controls.Add(this.lblDataReceived);
            this.Controls.Add(this.grpboxConnection);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpboxConnection.ResumeLayout(false);
            this.grpboxConnection.PerformLayout();
            this.grpboxControlParameters.ResumeLayout(false);
            this.grpboxControlParameters.PerformLayout();
            this.grpboxGaitCyclePeriod.ResumeLayout(false);
            this.grpboxGaitCyclePeriod.PerformLayout();
            this.grpboxPercentage.ResumeLayout(false);
            this.grpboxPercentage.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnable;
        private System.Windows.Forms.Button btnConnectEPOS;
        private System.Windows.Forms.GroupBox grpboxConnection;
        private System.Windows.Forms.GroupBox grpboxControlParameters;
        private System.Windows.Forms.TextBox txtAcceleration;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtProfileSpeed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSlackPosition;
        private System.Windows.Forms.TextBox txtMaxPosition;
        private System.Windows.Forms.TextBox txtTightPosition;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConnentuC;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnHalt;
        private System.Windows.Forms.Button btnEnableuC;
        private System.Windows.Forms.RadioButton radioBtnManualConrol;
        private System.Windows.Forms.RadioButton radioBtnAutonomousControl;
        private System.Windows.Forms.Label lblConnectuC;
        private System.Windows.Forms.Label lblConnectedEPOS;
        private System.Windows.Forms.Label lblEnableEPOS;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Timer timerActualPosition;
        private System.Windows.Forms.Button btnDisableEPOS;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.Button btnSetControlParamaters;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnDisconnectuC;
        private System.Windows.Forms.Label lblDataReceived;
        private System.Windows.Forms.Label lblAlert;
        private System.Windows.Forms.GroupBox grpboxGaitCyclePeriod;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtAveragePeriod;
        private System.Windows.Forms.TextBox txtNumberCycles;
        private System.Windows.Forms.GroupBox grpboxPercentage;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtPercentage;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnStartGait;
        private System.Windows.Forms.Button btnStopActuation;
        private System.Windows.Forms.Button btnStartActutation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblUserInstruction;
        private System.Windows.Forms.Button btnCurrentMode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comBoxProfile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnApplyProfile;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timerCurrentProfile;
        private System.Windows.Forms.Label lblPP;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnConnectDAQ;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnDisableSinusoidalProfileTimer;
        private System.Windows.Forms.Button btnApplyPositionSinusoidal;
        private System.Windows.Forms.Button btnActivatePositionMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerPositionSinusoidal;
    }
}

