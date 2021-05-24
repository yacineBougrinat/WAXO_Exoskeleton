using System;
using System.Drawing;
using System.Windows.Forms;
using EposCmd.Net.DeviceCmdSet.Operation;
using EposCmd.Net;
using System.IO.Ports;
using System.IO;
using System.Timers;

namespace SerialEPOSuC
{
    public partial class MainWindow : Form
    {
        private DeviceManager _mConnector;
        private static Device _mEpos;
        private StateMachine _sm;
        private ProfilePositionMode _ppm;
        private CurrentMode _cm;
        private PositionMode _pm;
        private System.Timers.Timer _timerActuation;

        string[] dataCurrent = new string[9000];//420 4000ms/10ms
        string[] dataVelocity = new string[9000];
        int counter = 0;
        private static SerialPort _uCSerial = new SerialPort("COM3", 115200);
        private static SerialPort _serialArduino = new SerialPort("COM4", 115200);
        private int iLoadCell = 0;
        string[] loadCellData = new string[920];

        //Torque profiles with 300ms duration 
        short[] currentProfileL15A300 = { 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000, 1100, 1200, 1300, 1400, 1500, 1400, 1300, 1200, 1100, 1000, 900, 800, 700, 600, 500, 400, 300, 200, 100, 0 };
        short[] currentProfileL2A300 = { 133, 267, 400, 533, 667, 800, 933, 1067, 1200, 1333, 1467, 1600, 1733, 1867, 2000, 1867, 1733, 1600, 1467, 1333, 1200, 1067, 933, 800, 667, 533, 400, 267, 133, 0 };
        short[] currentProfileL3A300 = { 200, 400, 600, 800, 1000, 1200, 1400, 1600, 1800, 2000, 2200, 2400, 2600, 2800, 3000, 2800, 2600, 2400, 2200, 2000, 1800, 1600, 1400, 1200, 1000, 800, 600, 400, 200, 0 };
        short[] currentProfileL6A300 = { 400, 800, 1200, 1600, 2000, 2400, 2800, 3200, 3600, 4000, 4400, 4800, 5200, 5600, 6000, 5600, 5200, 4800, 4400, 4000, 3600, 3200, 2800, 2400, 2000, 1600, 1200, 800, 400, 0 };
        short[] currentProfileP15A300 = { 193, 373, 540, 693, 833, 960, 1073, 1173, 1260, 1333, 1393, 1440, 1473, 1493, 1500, 1493, 1473, 1440, 1393, 1333, 1260, 1173, 1073, 960, 833, 693, 540, 373, 193, 0 };
        short[] currentProfileP2A300 = { 258, 498, 720, 924, 1111, 1280, 1431, 1564, 1680, 1778, 1858, 1920, 1964, 1991, 2000, 1991, 1964, 1920, 1858, 1778, 1680, 1564, 1431, 1280, 1111, 924, 720, 498, 258, 0 };
        short[] currentProfileP3A300 = { 387, 747, 1080, 1387, 1667, 1920, 2147, 2347, 2520, 2667, 2787, 2880, 2947, 2987, 3000, 2987, 2987, 2947, 2880, 2787, 2667, 2520, 2347, 2147, 1920, 1667, 1387, 1080, 746, 0 };
        short[] currentProfileP4A300 = { 516, 996, 1440, 1849, 2222, 2560, 2862, 3129, 3360, 3556, 3716, 3840, 3929, 3982, 4000, 3982, 3929, 3840, 3716, 3556, 3360, 3129, 2862, 2560, 2222, 1849, 1440, 996, 516, 0 };
        short[] currentProfileP5A300 = { 644, 1244, 1800, 2311, 2778, 3200, 3578, 3911, 4200, 4444, 4644, 4800, 4911, 4978, 5000, 4978, 4911, 4800, 4644, 4444, 4200, 3911, 3578, 3200, 2778, 2311, 1800, 1244, 644, 0 };
        short[] currentProfileP6A300 = { 773, 1493, 2160, 2773, 3333, 2840, 4293, 4693, 5040, 5333, 5573, 5760, 5893, 5973, 5973, 6000, 5973, 5893, 5760, 5573, 5333, 5040, 4693, 4293, 3840, 3333, 2773, 2160, 1493, 773, 0 };
        short[] currentProfileP7A300 = { 902, 1742, 2520, 3236, 3889, 4480, 5009, 5476, 6222, 6502, 6720, 6876, 6969, 7000, 6969, 6876, 6720, 6502, 6222, 5880, 5476, 5009, 4480, 3889, 3236, 2520, 1742, 1742, 902, 0 };
        short[] currentProfileP8A300 = { 1031, 1991, 2880, 3698, 4444, 5120, 5724, 6258, 6720, 7111, 7431, 7680, 7858, 7964, 8000, 7964, 7858, 7680, 7431, 7111, 6720, 6258, 5724, 5120, 4444, 3698, 2880, 1991, 1031, 0 };
        short[] currentProfileP9A300 = { 1160, 2240, 3240, 4160, 5000, 5760, 6440, 7040, 7560, 8000, 8360, 8640, 8840, 8960, 9000, 8960, 8840, 8640, 8360, 8000, 7560, 7040, 6440, 5760, 5000, 4160, 3240, 2240, 1160, 0 };
        short[] currentProfileP10A300 = { 1289, 2489, 3600, 4622, 5556, 6400, 7156, 7822, 8400, 8889, 9289, 9600, 9822, 9956, 10000, 9956, 9822, 9600, 9289, 8889, 8400, 7822, 7156, 6400, 5556, 4622, 3600, 2489, 1289, 0 };

        //Torque profiles with 200ms duration
        short[] currentProfileP15A200 = { 285, 540, 765, 960, 1125, 1260, 1365, 1440, 1485, 1500, 1485, 1440, 1365, 1260, 1125, 960, 765, 540, 285, 0 };
        short[] currentProfileP2A200 = { 380, 720, 1020, 1280, 1500, 1680, 1820, 1920, 1980, 2000, 1980, 1920, 1820, 1680, 1500, 1280, 1020, 720, 380, 0 };
        short[] currentProfileP3A200 = { 570, 1080, 1530, 1920, 2250, 2520, 2730, 2880, 2970, 3000, 2970, 2880, 2730, 2520, 2250, 1920, 1530, 1080, 570, 0 };
        short[] currentProfileP4A200 = { 760, 1440, 2040, 2560, 3000, 3360, 3640, 3840, 3960, 4000, 3960, 3840, 3640, 3360, 3000, 2560, 2040, 1440, 760, 0 };
        short[] currentProfileP5A200 = { 950, 1800, 2550, 3200, 3750, 4200, 4550, 4800, 4950, 5000, 4950, 4800, 4550, 4200, 3750, 3200, 2550, 1800, 950, 0 };
        short[] currentProfileP6A200 = { 1140, 2160, 3060, 3840, 4500, 5040, 5460, 5760, 5940, 6000, 5940, 5760, 5460, 5040, 4500, 3840, 3060, 2160, 1140, 0 };
        short[] currentProfileP7A200 = { 1330, 2520, 3570, 4480, 5250, 5880, 6370, 6720, 6930, 7000, 6930, 6720, 6370, 5880, 5250, 4480, 3570, 2520, 1330, 0 };
        short[] currentProfileP8A200 = { 1520, 2880, 4080, 5120, 6000, 6720, 7280, 7680, 7920, 8000, 7920, 7680, 7280, 6720, 6000, 5120, 4080, 2880, 1520, 0 };
        short[] currentProfileP9A200 = { 1710, 3240, 4590, 5760, 6750, 7560, 8190, 8640, 8910, 9000, 8910, 8640, 8190, 7560, 6750, 5760, 4590, 3240, 1710, 0 };
        short[] currentProfileP10A200 = { 1900, 3600, 5100, 6400, 7500, 8400, 9100, 9600, 9900, 10000, 9900, 9600, 9100, 8400, 7500, 6400, 5100, 3600, 1900, 0 };

        //Torque profiles with 150ms duration
        short[] currentProfileP15A150 = { 373, 693, 960, 1173, 1333, 1440, 1493, 1493, 1440, 1333, 1173, 960, 693, 373, 0 };
        short[] currentProfileP2A150 = { 498, 924, 1280, 1564, 1778, 1920, 1991, 1991, 1920, 1778, 1564, 1280, 924, 498, 0 };
        short[] currentProfileP3A150 = { 747, 1387, 1920, 2347, 2667, 2880, 2987, 2987, 2880, 2667, 2347, 1920, 1387, 747, 0 };
        short[] currentProfileP4A150 = { 996, 1849, 2560, 3129, 3556, 3840, 3982, 3982, 3840, 3556, 3129, 2560, 1849, 996, 0 };
        short[] currentProfileP5A150 = { 1244, 2311, 3200, 3911, 4444, 4800, 4978, 4978, 4800, 4444, 3911, 3200, 2311, 1244, 0 };
        short[] currentProfileP6A150 = { 1493, 2773, 3840, 4693, 5333, 5760, 5973, 5973, 5760, 5333, 4693, 3840, 2773, 1493, 0 };
        short[] currentProfileP7A150 = { 1742, 3236, 4480, 5476, 6222, 6720, 6969, 6969, 6720, 6222, 5476, 4480, 3236, 1742, 0 };
        short[] currentProfileP8A150 = { 1991, 3698, 5120, 6258, 7111, 7680, 7964, 7964, 7680, 7111, 6258, 5120, 3698, 1991, 0 };
        short[] currentProfileP9A150 = { 2240, 4160, 5760, 7040, 8000, 8640, 8960, 8960, 8640, 8000, 7040, 5760, 4160, 2240, 0 };
        short[] currentProfileP10A150 = { 2489, 4622, 6400, 7822, 8889, 9600, 9956, 9956, 9600, 8889, 7822, 6400, 4622, 2489, 0 };

        //Torque profiles with 180ms duration
        short[] currentProfileP5A180 = { 1049, 1975, 2778, 3457, 4012, 4444, 4753, 4938, 5000, 4938, 4753, 4444, 4012, 3457, 2778, 1975, 1049, 0 };
        short[] currentProfileP6A180 = { 1259, 2370, 3333, 4148, 4815, 5333, 5704, 5926, 6000, 5926, 5704, 5333, 4815, 4148, 3333, 2370, 1259, 0 };

        //Torque profiles with 170ms duration
        //Actuation offset on 63%
        //Try elastic element
        //Mooney video

        //Torque profiles with 130ms duration
        short[] currentProfileP5A130 = { 1420, 2604, 3550, 4260, 4734, 4970, 4970, 4734, 4260, 3550, 2604, 1420, 0 };
        short[] currentProfileP6A130 = { 1704, 3124, 4260, 5112, 5680, 5964, 5964, 5680, 5112, 4260, 3124, 1704, 0 };

        //Mechanical Test Position Sinusoidal Profile
        int[] positionMecahnicalTest = { 0, 106, 424, 954, 1695, 2647, 3808, 5178, 6755, 8537, 10523, 12711, 15098, 17683, 20462, 23434, 26594, 29940, 33469, 37178, 41061, 45117, 49340, 53726, 58272, 62972, 67822, 72818, 77954, 83225, 88626, 94152, 99797, 105556, 111423, 117392, 123457, 129613, 135853, 142171, 148561, 155017, 161532, 168099, 174713, 181367, 188053, 194767, 201500, 208247, 215000, 221753, 228500, 235233, 241947, 248633, 255287, 261901, 268468, 274983, 281439, 287829, 294147, 300387, 306543, 312608, 318577, 324444, 330203, 335848, 341374, 346775, 352046, 357182, 362178, 367028, 371728, 376274, 380660, 384883, 388939, 392822, 396531, 400060, 403406, 406566, 409538, 412317, 414902, 417289, 419477, 421463, 423245, 424822, 426192, 427353, 428305, 429046, 429576, 429894, 430000, 429894, 429576, 429046, 428305, 427353, 426192, 424822, 423245, 421463, 419477, 417289, 414902, 412317, 409538, 406566, 403406, 400060, 396531, 392822, 388939, 384883, 380660, 376274, 371728, 367028, 362178, 357182, 352046, 346775, 341374, 335848, 330203, 324444, 318577, 312608, 306543, 300387, 294147, 287829, 281439, 274983, 268468, 261901, 255287, 248633, 241947, 235233, 228500, 221753, 215000, 208247, 201500, 194767,188053,181367,174713,168099,161532,155017,148561,142171,135853,129613,123457,117392,111423,105556,99797,94152,88626,83225,77954,72818,67822,62972,58272,53726,49340,45117,41061,37178,33469,29940,26594,23434,20462,17683,15098,12711,10523,8537,6755,5178,3808,2647,1695,954,424,106,0,106,424,954,1695,2647,3808,5178,6755,8537,10523,12711,15098,17683,20462,23434,26594,29940,33469,37178,41061,45117,49340,53726,58272,62972,67822,72818,77954,83225,88626,94152,99797,105556,111423,117392,123457,129613,135853,142171,148561,155017,161532,168099,174713,181367,188053,194767,201500,208247,215000,221753,228500,235233,241947,248633,255287,261901,268468,274983,281439,287829,294147,300387,306543,312608,318577,324444,330203,335848,341374,346775,352046,357182,362178,367028,371728,376274,380660,384883,388939,392822,396531,400060,403406,406566,409538,412317,414902,417289,419477,421463,423245,424822,426192,427353,428305,429046,429576,429894,430000,429894,429576,429046,428305,427353,426192,424822,423245,421463,419477,417289,414902,412317,409538,406566,403406,400060,396531,392822,388939,384883,380660,376274,371728,367028,362178,357182,352046,346775,341374,335848,330203,324444,318577,312608,306543,300387,294147,287829,281439,274983,268468,261901,255287,248633,241947,235233,228500,221753,215000,208247,201500,194767,188053,181367,174713,168099,161532,155017,148561,142171,135853,129613,123457,117392,111423,105556,99797,94152,88626,83225,77954,72818,67822,62972,58272,53726,49340,45117,41061,37178,33469,29940,26594,23434,20462,17683,15098,12711,10523,8537,6755,5178,3808,2647,1695,954,424,106,0};

        int j = -1;
        bool isSlack = false;
        int slectedCurrentProfile = 0;

        public MainWindow()
        {
            InitializeComponent();
            txtSlackPosition.Text = "0";//20 deg
            txtTightPosition.Text = "100000";//50 deg
            txtMaxPosition.Text = "200000";//360 deg
            txtProfileSpeed.Text = "6000";
            txtAcceleration.Text = "6000";
            comBoxProfile.SelectedIndex = 0;

            //txtTargetPosition.Text = "0";
            btnMove.Enabled = false;
            btnHalt.Enabled = false;
            btnEnableuC.Enabled = false;
            btnHome.Enabled = false;
            btnSetControlParamaters.Enabled = false;
            //this timer is not used, only timerCurrentProfile which was added as an element in the GUI
            //is used, it can be removed
            _timerActuation = new System.Timers.Timer(10);
            //CheckForIllegalCrossThreadCalls = false;

        }

        /***Connect/Disconnect***/
        //Connect EPOS2
        private void btnConnectEPOS_Click(object sender, EventArgs e)
        {
            try
            {
                _mConnector = new DeviceManager("EPOS2", "MAXON SERIAL V2", "USB", "USB0");
                //_mConnector = new DeviceManager("EPOS2", "MAXON_RS232", "RS232", "COM6");
                _mEpos = _mConnector.CreateDevice(1);
                lblConnectedEPOS.Text = "EPOS2 is connected";
                lblConnectedEPOS.BackColor = Color.GreenYellow;
                //txtActualPosition.Text = Convert.ToString(_mEpos.Operation.MotionInfo.GetPositionIs());
                _mEpos.Configuration.Advanced.Safety.SetMaxFollowingError(1000000);
                //Set Max acceleration
                _mEpos.Configuration.Advanced.Safety.SetMaxAcceleration(15000);
                //_mEpos.Configuration.Advanced.Motor.SetEcMotorParameter(8000, 20000, ref thermal, ref npairs);
                //_mEpos.Configuration.Advanced.Motor.GetEcMotorParameter(ref currentNominal, ref maxCurrent, ref thermal, ref npairs);
                //lblReceived.Text = maxCurrent.ToString();
            }
            catch (Exception er)
            {
                Console.WriteLine(er.Message);
            }
        }

        //Connect uC
        private void btnConnentuC_Click(object sender, EventArgs e)
        {
            try
            {
                _uCSerial.Open();
                lblConnectuC.Text = "Microntroller is Connected";
                lblConnectuC.BackColor = Color.GreenYellow;
                _uCSerial.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            }
            catch (IOException ioe)
            {
                Console.WriteLine(ioe.GetType());
            }
        }

        //Disconnect uC
        private void btnDisconnectuC_Click(object sender, EventArgs e)
        {
            try
            {
                _uCSerial.Close();
                lblConnectuC.Text = "Microcontroller is disconnected";
                //lblEnableuC.Text = "Microntroller is disabled";
                lblConnectuC.BackColor = Color.Tomato;
                //lblEnableuC.BackColor = Color.Tomato; 
            }
            catch (IOException ioe)
            {
                Console.WriteLine(ioe.GetType());
            }
        }

        //Connect with Arduino for DAQ
        private void button4_Click(object sender, EventArgs e)
        {
            _serialArduino.Open();
            _serialArduino.DataReceived += new SerialDataReceivedEventHandler(ArduinoDataReceivedHandler);
            if (_serialArduino.IsOpen)
            {
                lblAlert.Text = "Arduino Connected";
            }
        }

        /***Enable EPOS & Activate Profile Position Mode***/
        private void btnEnable_Click(object sender, EventArgs e)
        {
            try
            {
                _sm = _mEpos.Operation.StateMachine;
                lblEnableEPOS.Text = "EPOS2 is enabled";
                lblEnableEPOS.BackColor = Color.GreenYellow;
                timerActualPosition.Enabled = true;

                _ppm = _mEpos.Operation.ProfilePositionMode;
                _ppm.ActivateProfilePositionMode();
                //_ppm.SetPositionProfile(Convert.ToUInt32(txtProfileSpeed.Text), Convert.ToUInt32(txtAcceleration.Text), Convert.ToUInt32(txtAcceleration.Text));
                _ppm.SetPositionProfile(10000, 10000, 10000);
                _ppm.MoveToPosition(0, true, true);

                if (_sm.GetFaultState())
                    _sm.ClearFault();
                _sm.SetEnableState();
            }
            catch (DeviceException er)
            {
                Console.WriteLine(er.ErrorMessage);
            }
        }

        /***Disable***/
        private void btnDisableEPOS_Click(object sender, EventArgs e)
        {
            try
            {
                lblEnableEPOS.Text = "EPOS2 is disabled";
                lblEnableEPOS.BackColor = Color.Tomato;
                lblAlert.ForeColor = Color.Red;
                lblAlert.Text = "Save Data!";
                lblAlert.Font = new Font("Arial", 16,FontStyle.Bold);
                lblAlert.BackColor = Color.Yellow;

                if (_sm.GetFaultState())
                    _sm.ClearFault();
                _sm.SetDisableState();
                
            }
            catch (DeviceException er)
            {
                Console.WriteLine(er.ErrorMessage);
            }

        }

        /***Control: manual vs. autonomous selection***/
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            btnHome.Enabled = true;
            btnMove.Enabled = true;
            btnHalt.Enabled = true;
            btnSetControlParamaters.Enabled = true;
            btnEnableuC.Enabled = false;
        }

        private void radioBtnAutonomousControl_CheckedChanged(object sender, EventArgs e)
        {
            btnHome.Enabled = false;
            btnEnableuC.Enabled = true;
            btnMove.Enabled = false;
            btnHalt.Enabled = false;
            btnSetControlParamaters.Enabled = false;
        }

        /***************************************************Manual Move****************************************************/
        //Home
        private void btnHome_Click(object sender, EventArgs e)
        {
            _ppm.MoveToPosition(0, true, false);
        }

        //Set Control Paramaters
        private void btnSetControlParamaters_Click(object sender, EventArgs e)
        {
            _ppm.SetPositionProfile(Convert.ToUInt32(txtProfileSpeed.Text), Convert.ToUInt32(txtAcceleration.Text), Convert.ToUInt32(txtAcceleration.Text));
        }

        //Move
        private void btnMove_Click(object sender, EventArgs e)
        {
            _ppm.SetPositionProfile(Convert.ToUInt32(txtProfileSpeed.Text), Convert.ToUInt32(txtAcceleration.Text), Convert.ToUInt32(txtAcceleration.Text));
            _ppm.MoveToPosition(Convert.ToInt32(txtTightPosition.Text), true, true);//Tight 
            _ppm.MoveToPosition(Convert.ToInt32(txtMaxPosition.Text), true, false);//Max
            _mEpos.Operation.MotionInfo.WaitForTargetReached(100000);
            _ppm.SetPositionProfile(12000, 12000, 12000);
            _ppm.MoveToPosition(Convert.ToInt32(txtSlackPosition.Text), true, false);//Zero (slack)
        }

        //Halt
        private void btnHalt_Click(object sender, EventArgs e)
        {
            _ppm.HaltPositionMovement();
        }
        /******************************************************************************************************************/

        /***Autonomous Move***/
        //Enable 
        private void btnEnableuC_Click(object sender, EventArgs e)
        {
            try
            {
                _uCSerial.Write("s");
                //lblEnableuC.Text = "Microcontroller Communication Enabled";
                //lblEnableuC.BackColor = Color.GreenYellow;                    
            }
            catch (IOException ioe)
            {
                Console.WriteLine(ioe.GetType());
            }
        }

        /***Save Data***/
        private void btnSaveData_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllLines(@"E:\dataCurrent.txt", dataCurrent);
            System.IO.File.WriteAllLines(@"E:\dataVelocity.txt", dataVelocity);
            System.IO.File.WriteAllLines(@"E:\loadCellData.txt", loadCellData);
        }

        /***Show operational data real time***/
        /*
        private void timer1_Tick(object sender, EventArgs e)
        {
            txtTargetPosition.Text = Convert.ToString(_ppm.GetTargetPosition());
            txtActualPosition.Text = Convert.ToString(_mEpos.Operation.MotionInfo.GetPositionIs());
            txtActualTorque.Text = Convert.ToString(_mEpos.Operation.MotionInfo.GetCurrentIs());
            //dataCurrent[counter] = txtActualTorque.Text;
            counter++;
        }
        */

        //Start walking to calculate gait period
        private void btnStartGait_Click(object sender,
            EventArgs e)
        {
            _uCSerial.Write("w");
        }

        //Start actuation
        private void btnStartActutation_Click(object sender, EventArgs e)
        {
            _cm = _mEpos.Operation.CurrentMode;
            _cm.ActivateCurrentMode();
            _uCSerial.Write("p");
            _uCSerial.DiscardOutBuffer();
        }

        delegate void SetTextCallback(string text);
        public delegate void MyDelegate();

        //Serial Data Received mbed
        void ArduinoDataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            string inDataRaw = _serialArduino.ReadLine();
            loadCellData[iLoadCell] = inDataRaw;
            iLoadCell++;
        }

        //Serial Data Received mbed
        void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            string inDataRaw = _uCSerial.ReadLine();
            string[] inData = inDataRaw.Split(',');

            switch (inData[0])
            {
                case "n":
                    SetText("You can Start Walking");
                    lblUserInstruction.ForeColor = Color.Green;
                    _uCSerial.DiscardInBuffer();
                    break;

                case "g":
                    SetTextt(inData[1]);
                    _uCSerial.DiscardInBuffer();
                    break;

                case "m":
                    SetTexttt(inData[1] + " ms");
                    lblUserInstruction.ForeColor = Color.Gray;
                    _uCSerial.DiscardInBuffer();
                    break;

                case "p":
                    SetTextttt(inData[1] + " %");
                    _uCSerial.DiscardInBuffer();
                    break;
                //Todo: j = 0 without sending r from uC

                case "t":
                    _cm.SetCurrentMust(900);
                    break;

                case "i":
                    if (this.InvokeRequired)
                    {
                        BeginInvoke(new MyDelegate(delegate ()
                        {
                            timerCurrentProfile.Start();
                        }));
                    }
                    timerActualPosition.Enabled = false;
                    break;

                case "r":
                    lblPP.ForeColor = Color.Green;
                    break;

                case "l":
                    lblPP.ForeColor = Color.Gray;
                    break;

                case "a":
                    //counter++;
                    //lblDataReceived.Text = Convert.ToString(counter);
                    _ppm.SetPositionProfile(Convert.ToUInt32(txtProfileSpeed.Text), Convert.ToUInt32(txtAcceleration.Text), Convert.ToUInt32(txtAcceleration.Text));
                    _ppm.MoveToPosition(Convert.ToInt32(txtTightPosition.Text), true, true);//Tight 
                    _ppm.MoveToPosition(Convert.ToInt32(txtMaxPosition.Text), true, false);//Max
                    _mEpos.Operation.MotionInfo.WaitForTargetReached(100000);
                    _ppm.SetPositionProfile(12000, 12000, 12000);
                    _ppm.MoveToPosition(Convert.ToInt32(txtSlackPosition.Text), true, false);//Zero (slack)
                    break;

                case "o":
                    try
                    {
                        lblEnableEPOS.Text = "EPOS2 is disabled";
                        lblEnableEPOS.BackColor = Color.Tomato;
                        _sm.SetDisableState();
                    }
                    catch (DeviceException er)
                    {
                        Console.WriteLine(er.ErrorMessage);
                    }
                    break;
            }
        }

        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.lblUserInstruction.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.lblUserInstruction.Text = text;
            }
        }

        private void SetTextt(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.txtNumberCycles.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetTextt);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.txtNumberCycles.Text = text;
            }
        }

        private void SetTexttt(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.txtAveragePeriod.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetTexttt);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.txtAveragePeriod.Text = text;
            }
        }

        private void SetTextttt(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.txtPercentage.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetTextttt);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.txtPercentage.Text = text;
            }
        }

        private void btnStopActuation_Click(object sender, EventArgs e)
        {
            try
            {
                lblEnableEPOS.Text = "EPOS2 is disabled";
                lblEnableEPOS.BackColor = Color.Tomato;
                if (_sm.GetFaultState())
                    _sm.ClearFault();
                _sm.SetDisableState();
            }
            catch (DeviceException er)
            {
                Console.WriteLine(er.ErrorMessage);
            }
            _uCSerial.Write("o");
        }

        //Activate Current Mode
        private void btnCurrentMode_Click(object sender, EventArgs e)
        {
            _cm = _mEpos.Operation.CurrentMode;
            _cm.ActivateCurrentMode();
        }

        //Reset
        private void button1_Click(object sender, EventArgs e)
        {
            lblUserInstruction.ForeColor = Color.Gray;
            txtNumberCycles.Text = "";
            txtAveragePeriod.Text = "";
        }

        //Apply the seclected Torque Profile
        private void button3_Click(object sender, EventArgs e)
        {
            //_serialArduino.Write("s");
            //System.Threading.Thread.Sleep(100);
            timerCurrentProfile.Enabled = true;
            //timerActualPosition.Enabled = false;
        }

        //Enable and select current profile
        private void button2_Click(object sender, EventArgs e)
        {
            _ppm.MoveToPosition(0, true, true);
            _cm = _mEpos.Operation.CurrentMode;
            _cm.ActivateCurrentMode();

            switch (comBoxProfile.SelectedIndex)
            {
                case 0:
                    slectedCurrentProfile = 0;
                    break;
                case 1:
                    slectedCurrentProfile = 1;
                    break;
                case 2:
                    slectedCurrentProfile = 2;
                    break;
                case 3:
                    slectedCurrentProfile = 3;
                    break;
                case 4:
                    slectedCurrentProfile = 4;
                    break;
                case 5:
                    slectedCurrentProfile = 5;
                    break;
                case 6:
                    slectedCurrentProfile = 6;
                    break;
                case 7:
                    slectedCurrentProfile = 7;
                    break;
                case 8:
                    slectedCurrentProfile = 8;
                    break;
                case 9:
                    slectedCurrentProfile = 9;
                    break;
                case 10:
                    slectedCurrentProfile = 10;
                    break;
                case 11:
                    slectedCurrentProfile = 11;
                    break;
                case 12:
                    slectedCurrentProfile = 12;
                    break;
                case 13:
                    slectedCurrentProfile = 13;
                    break;
                case 14:
                    slectedCurrentProfile = 14;
                    break;
                case 15:
                    slectedCurrentProfile = 15;
                    break;
                case 16:
                    slectedCurrentProfile = 16;
                    break;
                case 17:
                    slectedCurrentProfile = 17;
                    break;
                case 18:
                    slectedCurrentProfile = 18;
                    break;
                case 19:
                    slectedCurrentProfile = 19;
                    break;
                case 20:
                    slectedCurrentProfile = 20;
                    break;
                case 21:
                    slectedCurrentProfile = 21;
                    break;
                case 22:
                    slectedCurrentProfile = 22;
                    break;
                case 23:
                    slectedCurrentProfile = 23;
                    break;
                case 24:
                    slectedCurrentProfile = 24;
                    break;
                case 25:
                    slectedCurrentProfile = 25;
                    break;
                case 26:
                    slectedCurrentProfile = 26;
                    break;
                case 27:
                    slectedCurrentProfile = 27;
                    break;
                case 28:
                    slectedCurrentProfile = 28;
                    break;
                case 29:
                    slectedCurrentProfile = 29;
                    break;
                case 30:
                    slectedCurrentProfile = 30;
                    break;
                case 31:
                    slectedCurrentProfile = 31;
                    break;
                case 32:
                    slectedCurrentProfile = 32;
                    break;
                case 33:
                    slectedCurrentProfile = 33;
                    break;
                case 34:
                    slectedCurrentProfile = 34;
                    break;
                case 35:
                    slectedCurrentProfile = 35;
                    break;
                case 36:
                    slectedCurrentProfile = 36;
                    break;
                case 37:
                    slectedCurrentProfile = 37;
                    break;
            }

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            _timerActuation.Enabled = false;
            //_uCSerial.Write("s");
        }

        private void timerCurrentProfile_Tick(object sender, EventArgs e)
        {
            j++;
            //it was j<31 but I removed the first zero in all the arrays so now 30 elemts
            if (j < 30)  
            {
                _cm.ActivateCurrentMode();
                //_serialArduino.Write("s");
                try
                {
                    switch (slectedCurrentProfile)
                    {
                        case 0:
                            _cm.SetCurrentMust(currentProfileP15A300[j]);
                            break;
                        case 1:
                            _cm.SetCurrentMust(currentProfileP2A300[j]);
                            break;
                        case 2:
                            _cm.SetCurrentMust(currentProfileP3A300[j]);
                            break;
                        case 3:
                            _cm.SetCurrentMust(currentProfileP4A300[j]);
                            break;
                        case 4:
                            _cm.SetCurrentMust(currentProfileP5A300[j]);
                            break;
                        case 5:
                            _cm.SetCurrentMust(currentProfileP6A300[j]);
                            break;
                        case 6:
                            _cm.SetCurrentMust(currentProfileP7A300[j]);
                            break;
                        case 7:
                            _cm.SetCurrentMust(currentProfileP8A300[j]);
                            break;
                        case 8:
                            _cm.SetCurrentMust(currentProfileP9A300[j]);
                            break;
                        case 9:
                            _cm.SetCurrentMust(currentProfileP10A300[j]);
                            break;
                        case 10:
                            //19=>18                                                                                                      
                            _cm.SetCurrentMust(currentProfileP15A200[j]);
                            if (j == 19) { j = 31; }
                            break;
                        case 11:
                            _cm.SetCurrentMust(currentProfileP2A200[j]);
                            if (j == 19) { j = 31; }
                            break;
                        case 12:
                            _cm.SetCurrentMust(currentProfileP3A200[j]);
                            if (j == 19) { j = 31; }
                            break;
                        case 13:
                            _cm.SetCurrentMust(currentProfileP4A200[j]);
                            if (j == 19) { j = 31; }
                            break;
                        case 14:
                            _cm.SetCurrentMust(currentProfileP5A200[j]);
                            if (j == 19) { j = 31; }
                            break;
                        case 15:
                            _cm.SetCurrentMust(currentProfileP6A200[j]);
                            if (j == 19) { j = 31; }
                            break;
                        case 16:
                            _cm.SetCurrentMust(currentProfileP7A200[j]);
                            if (j == 19) { j = 31; }
                            break;
                        case 17:
                            _cm.SetCurrentMust(currentProfileP8A200[j]);
                            if (j == 19) { j = 31; }
                            break;
                        case 18:
                            _cm.SetCurrentMust(currentProfileP9A200[j]);
                            if (j == 19) { j = 31; }
                            break;
                        case 19:
                            _cm.SetCurrentMust(currentProfileP10A200[j]);
                            if (j == 19) { j = 31; }
                            break;
                        case 20:
                            //14=>13
                            _cm.SetCurrentMust(currentProfileP15A150[j]);
                            if (j == 14) { j = 31; }
                            break;
                        case 21:
                            _cm.SetCurrentMust(currentProfileP2A150[j]);
                            if (j == 14) { j = 31; }
                            break;
                        case 22:
                            _cm.SetCurrentMust(currentProfileP3A150[j]);
                            if (j == 14) { j = 31; }
                            break;
                        case 23:
                            _cm.SetCurrentMust(currentProfileP4A150[j]);
                            if (j == 14) { j = 31; }
                            break;
                        case 24:
                            _cm.SetCurrentMust(currentProfileP5A150[j]);
                            if (j == 14) { j = 31; }
                            break;
                        case 25:
                            _cm.SetCurrentMust(currentProfileP6A150[j]);
                            if (j == 14) { j = 31; }
                            break;
                        case 26:
                            _cm.SetCurrentMust(currentProfileP7A150[j]);
                            if (j == 14) { j = 31; }
                            break;
                        case 27:
                            _cm.SetCurrentMust(currentProfileP8A150[j]);
                            if (j == 14) { j = 31; }
                            break;
                        case 28:
                            _cm.SetCurrentMust(currentProfileP9A150[j]);
                            if (j == 14) { j = 31; }
                            break;
                        case 29:
                            _cm.SetCurrentMust(currentProfileP10A150[j]);
                            if (j == 14) { j = 31; }
                            break;
                        case 30:
                            _cm.SetCurrentMust(currentProfileL15A300[j]);
                            if (j == 14) { j = 31; }
                            break;
                        case 31:
                            _cm.SetCurrentMust(currentProfileL3A300[j]);
                            if (j == 14) { j = 31; }
                            break;
                        case 32:
                            _cm.SetCurrentMust(currentProfileL6A300[j]);
                            if (j == 14) { j = 31; }
                            break;
                        case 33:
                            _cm.SetCurrentMust(currentProfileP10A150[j]);
                            if (j == 14) { j = 31; }
                            break;
                        case 34:
                            _cm.SetCurrentMust(currentProfileP5A180[j]);
                            if (j == 17) { j = 31; }
                            break;
                        case 35:
                            _cm.SetCurrentMust(currentProfileP6A180[j]);
                            if (j == 17) { j = 31; }
                            break;
                        case 36:
                            _cm.SetCurrentMust(currentProfileP5A130[j]);
                            if (j == 12) { j = 31; }
                            break;
                        case 37:
                            _cm.SetCurrentMust(currentProfileP6A130[j]);
                            if (j == 12) { j = 31; }
                            break;

                    }
                }

                catch (DeviceException er)
                {
                    Console.WriteLine(er.ErrorMessage);
                }

                dataVelocity[counter] = Convert.ToString(_mEpos.Operation.MotionInfo.GetVelocityIsAveraged());
                dataCurrent[counter] = Convert.ToString(_mEpos.Operation.MotionInfo.GetCurrentIsAveraged());
                counter++;
            }

            else
            {
                _ppm.ActivateProfilePositionMode();
                _ppm.SetPositionProfile(12000, 15000, 15000);
                _ppm.MoveToPosition(10000, true, false);//Zero (slack)
                j = -1;
                timerCurrentProfile.Enabled = false;
                //_cm.ActivateCurrentMode() not working cuz it stops the previous ppm    
            }
        }

        //unused
        private void _timerActuation_Tick(object sender, EventArgs e)
        {
            j++;
            if (j < 31)
            {
                _cm.ActivateCurrentMode();
                try
                {
                    switch (slectedCurrentProfile)
                    {
                        case 0:
                            _cm.SetCurrentMust(currentProfileP15A300[j]);
                            break;
                        case 1:
                            _cm.SetCurrentMust(currentProfileP2A300[j]);
                            break;
                        case 2:
                            _cm.SetCurrentMust(currentProfileP3A300[j]);
                            break;
                        case 3:
                            _cm.SetCurrentMust(currentProfileP4A300[j]);
                            break;
                        case 4:
                            _cm.SetCurrentMust(currentProfileP5A300[j]);
                            break;
                        case 5:
                            _cm.SetCurrentMust(currentProfileP6A300[j]);
                            break;
                        case 6:
                            _cm.SetCurrentMust(currentProfileP7A300[j]);
                            break;
                        case 7:
                            _cm.SetCurrentMust(currentProfileP8A300[j]);
                            break;
                        case 8:
                            _cm.SetCurrentMust(currentProfileP9A300[j]);
                            break;
                        case 9:
                            _cm.SetCurrentMust(currentProfileP10A300[j]);
                            break;
                        case 10:
                            _cm.SetCurrentMust(currentProfileP15A200[j]);
                            if (j == 19) { j = 31; }
                            break;
                        case 11:
                            _cm.SetCurrentMust(currentProfileP2A200[j]);
                            if (j == 19) { j = 31; }
                            break;
                        case 12:
                            _cm.SetCurrentMust(currentProfileP3A200[j]);
                            if (j == 19) { j = 31; }
                            break;
                        case 13:
                            _cm.SetCurrentMust(currentProfileP4A200[j]);
                            if (j == 19) { j = 31; }
                            break;
                        case 14:
                            _cm.SetCurrentMust(currentProfileP5A200[j]);
                            if (j == 19) { j = 31; }
                            break;
                        case 15:
                            _cm.SetCurrentMust(currentProfileP6A200[j]);
                            if (j == 19) { j = 31; }
                            break;
                        case 16:
                            _cm.SetCurrentMust(currentProfileP7A200[j]);
                            if (j == 19) { j = 31; }
                            break;
                        case 17:
                            _cm.SetCurrentMust(currentProfileP8A200[j]);
                            if (j == 19) { j = 31; }
                            break;
                        case 18:
                            _cm.SetCurrentMust(currentProfileP9A200[j]);
                            if (j == 19) { j = 31; }
                            break;
                        case 19:
                            _cm.SetCurrentMust(currentProfileP10A200[j]);
                            if (j == 19) { j = 31; }
                            break;
                        case 20:
                            _cm.SetCurrentMust(currentProfileP15A150[j]);
                            if (j == 14) { j = 31; }
                            break;
                        case 21:
                            _cm.SetCurrentMust(currentProfileP2A150[j]);
                            if (j == 14) { j = 31; }
                            break;
                        case 22:
                            _cm.SetCurrentMust(currentProfileP3A150[j]);
                            if (j == 14) { j = 31; }
                            break;
                        case 23:
                            _cm.SetCurrentMust(currentProfileP4A150[j]);
                            if (j == 14) { j = 31; }
                            break;
                        case 24:
                            _cm.SetCurrentMust(currentProfileP5A150[j]);
                            if (j == 14) { j = 31; }
                            break;
                        case 25:
                            _cm.SetCurrentMust(currentProfileP6A150[j]);
                            if (j == 14) { j = 31; }
                            break;
                        case 26:
                            _cm.SetCurrentMust(currentProfileP7A150[j]);
                            if (j == 14) { j = 31; }
                            break;
                        case 27:
                            _cm.SetCurrentMust(currentProfileP8A150[j]);
                            if (j == 14) { j = 31; }
                            break;
                        case 28:
                            _cm.SetCurrentMust(currentProfileP9A150[j]);
                            if (j == 14) { j = 31; }
                            break;
                        case 29:
                            _cm.SetCurrentMust(currentProfileP10A150[j]);
                            if (j == 14) { j = 31; }
                            break;
                        case 30:
                            _cm.SetCurrentMust(currentProfileL15A300[j]);
                            if (j == 14) { j = 31; }
                            break;
                        case 31:
                            _cm.SetCurrentMust(currentProfileL3A300[j]);
                            if (j == 14) { j = 31; }
                            break;
                        case 32:
                            _cm.SetCurrentMust(currentProfileL6A300[j]);
                            if (j == 14) { j = 31; }
                            break;
                    }
                }
                catch (DeviceException er)
                {
                    Console.WriteLine(er.ErrorMessage);
                }
            }
            else
            {
                _ppm.ActivateProfilePositionMode();
                _ppm.SetPositionProfile(12000, 12000, 12000);
                _ppm.MoveToPosition(0, true, false);//Zero (slack)
                j = 0;
                timerCurrentProfile.Enabled = false;
                //_cm.ActivateCurrentMode() not working cuz it stops the previous ppm    
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //******Mechanical Test Position Sinusoidal Profile*******//
        private void button6_Click(object sender, EventArgs e)
        {
            _pm = _mEpos.Operation.PositionMode;
            _pm.ActivatePositionMode();
            j = -1;
            counter = 0;
        }

        private void btnApplyPositionSinusoidal_Click(object sender, EventArgs e)
        {
            timerPositionSinusoidal.Enabled = true;
        }

        private void timerPositionSinusoidal_Tick(object sender, EventArgs e)
        {
            j++;
            _serialArduino.Write("s");
            if (j < 401)
            {
                try
                {
                    _pm.SetPositionMust(positionMecahnicalTest[j]);
                }
                catch (DeviceException er)
                {
                    MessageBox.Show(er.ErrorMessage);
                }
                dataVelocity[counter] = Convert.ToString(_mEpos.Operation.MotionInfo.GetVelocityIsAveraged());
                dataCurrent[counter] = Convert.ToString(_mEpos.Operation.MotionInfo.GetCurrentIsAveraged());
                counter++;
            }
            else
            {           
                System.IO.File.WriteAllLines(@"E:\dataCurrent.txt", dataCurrent);
                System.IO.File.WriteAllLines(@"E:\dataVelocity.txt", dataVelocity);
                System.IO.File.WriteAllLines(@"E:\loadCellData.txt", loadCellData);
            }

            
        }

        private void btnDisableSinusoidalProfileTimer_Click(object sender, EventArgs e)
        {
            timerPositionSinusoidal.Enabled = false;
        }
    }
}

