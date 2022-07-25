using System;
using System.ComponentModel;
using System.Net;
using System.Windows.Forms;
using Gma.System.MouseKeyHook;
using Rug.Osc;

namespace VRCLensOSC
{
    public partial class MainForm : Form
    {
        private OscSender osc;
        private OscReceiver oscr;
        private IKeyboardMouseEvents gh;

        public bool IsConnected = false;
        private int DroneKey = 1;
        private int DroneRotKey = 1;
        private float DroneV_final = 0f;
        private float DroneH_final = 0f;
        private bool DroneSwitch = false;

        public MainForm()
        {
            InitializeComponent();
            osc = new OscSender(IPAddress.Parse("127.0.0.1"), 0, 9000);
            oscListener.DoWork += new DoWorkEventHandler(OSCRECEIVE);
        }
        ~MainForm()
        {
            gh.KeyDown -= GlobalKeyDown;
            gh.KeyUp -= GlobalKeyUp;
            gh.Dispose();
        }

        public void OSCRECEIVE(object sender, DoWorkEventArgs e)
        {
            string[] packet;
            
            while(oscr.State != OscSocketState.Closed)
            {
                if (oscr.State == OscSocketState.Connected)
                {
                    packet = oscr.Receive().ToString().Split(',');
                    switch (packet[0])
                    {
                        case "/avatar/parameters/VRCLZoomRadial":
                            if (sldZoom.InvokeRequired) sldZoom.Invoke((MethodInvoker)delegate { sldZoom.Value = (int)(float.Parse(packet[1].Trim().Replace("f", "")) * 1000); });
                            else sldZoom.Value = (int)(float.Parse(packet[1].Trim().Replace("f", "")) * 1000);
                            if (lbZoomPer.InvokeRequired) lbZoomPer.Invoke((MethodInvoker)delegate { lbZoomPer.Text = (int)(sldZoom.Value * 0.1f) + "%"; });
                            else lbZoomPer.Text = (int)(sldZoom.Value * 0.1f) + "%";
                            break;
                        case "/avatar/parameters/VRCLExposureRadial":
                            if (sldEV.InvokeRequired) sldEV.Invoke((MethodInvoker)delegate { sldEV.Value = (int)(float.Parse(packet[1].Trim().Replace("f", "")) * 1000); });
                            else sldEV.Value = (int)(float.Parse(packet[1].Trim().Replace("f", "")) * 1000);
                            if (lbEV.InvokeRequired) lbEV.Invoke((MethodInvoker)delegate { lbEV.Text = (int)(sldEV.Value * 0.1f) + "%"; });
                            else lbEV.Text = (int)(sldEV.Value * 0.1f) + "%";
                            break;
                        case "/avatar/parameters/VRCLApertureRadial":
                            if (sldAp.InvokeRequired) sldAp.Invoke((MethodInvoker)delegate { sldAp.Value = (int)(float.Parse(packet[1].Trim().Replace("f", "")) * 1000); });
                            else sldAp.Value = (int)(float.Parse(packet[1].Trim().Replace("f", "")) * 1000);
                            if (lbApPer.InvokeRequired) lbApPer.Invoke((MethodInvoker)delegate { lbApPer.Text = (int)(sldAp.Value * 0.1f) + "%"; });
                            else lbApPer.Text = (int)(sldAp.Value * 0.1f) + "%";
                            break;
                        case "/avatar/parameters/VRCLFocusRadial":
                            if (sldFocus.InvokeRequired) sldZoom.Invoke((MethodInvoker)delegate { sldFocus.Value = (int)(float.Parse(packet[1].Trim().Replace("f", "")) * 1000); });
                            else sldFocus.Value = (int)(float.Parse(packet[1].Trim().Replace("f", "")) * 1000);
                            if (lbFocus.InvokeRequired) lbFocus.Invoke((MethodInvoker)delegate { lbFocus.Text = (int)(sldFocus.Value * 0.1f) + "%"; });
                            else lbFocus.Text = (int)(sldFocus.Value * 0.1f) + "%";
                            break;
                    }
                }
            }
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (this.btnConnect.Text == "Connect")
            {
                if (Connect())
                {
                    this.IPAddr.Enabled = false;
                    this.Port.Enabled = false;
                    this.btnConnect.Text = "Disconnect";
                    IsConnected = true;
                }
            }
            else
            {
                osc.Close();
                oscr.Close();
                this.IPAddr.Enabled = true;
                this.Port.Enabled = true;
                this.btnConnect.Text = "Connect";
                IsConnected = false;
            }
        }
        
        private bool Connect()
        {
            try
            {
                IPAddress addr = IPAddress.Parse(this.IPAddr.Text);
                int port = (int)this.Port.Value;
                if (osc != null)
                {
                    osc.Close();
                    osc = new OscSender(addr, 0, port);
                    osc.Connect();

                    oscr = new OscReceiver(9001);
                    oscr.Connect();
                    oscListener.RunWorkerAsync();
                }

                return true;
            }
            catch (FormatException e)
            {
                MessageBox.Show("Please Enter Correct IP Address", "Wrong IP Address");
                Console.WriteLine(e.Message);
                return false;
            }
        }
        //------------------------------------------------------------------------------------
        private void SwitchDrone()
        {
            if (DroneSwitch)
            {
                osc.Send(new OscMessage("/avatar/parameters/VRCLDroneSwitch", 0));
                DroneSwitch = false;
            }
            else
            {
                osc.Send(new OscMessage("/avatar/parameters/VRCLDroneSwitch", 6));
                DroneSwitch = true;
            }
        }
        //------------------------------------------------------------------------------------
        private void AssignHotKey()
        {
            gh = Hook.GlobalEvents();

            gh.KeyDown += GlobalKeyDown;
            gh.KeyUp += GlobalKeyUp;
        }

        void GlobalKeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.OemMinus: TimerZoomOut.Enabled = true; btnZoomOut.Enabled = false; break;
                case Keys.Oemplus: TimerZoomIn.Enabled = true; btnZoomIn.Enabled = false; break;
                case Keys.OemOpenBrackets: TimerEVm.Enabled = true; btnEVm.Enabled = false; break;
                case Keys.Oem6: TimerEVp.Enabled = true; btnEVp.Enabled = false; break;
                case Keys.Oem1: TimerApShallow.Enabled = true; btnApShallow.Enabled = false; break;
                case Keys.Oem7: TimerApGrea.Enabled = true; btnApGreat.Enabled = false; break;
                case Keys.OemPeriod: TimerFocusClo.Enabled = true; btnFocusClo.Enabled = false; break;
                case Keys.OemQuestion: TimerFocusFur.Enabled = true; btnFocusFur.Enabled = false; break;
                case Keys.T:
                    osc.Send(new OscMessage("/avatar/parameters/VRCFaceBlendV", (float)stepMoveV.Value));
                    if (DroneKey % (int)e.KeyCode != 0) DroneKey *= (int)e.KeyCode;
                    if (DroneKey != 1) UseDrone(212, true);
                    break;
                case Keys.F:
                    osc.Send(new OscMessage("/avatar/parameters/VRCFaceBlendH", -(float)stepMoveH.Value));
                    if (DroneKey % (int)e.KeyCode != 0) DroneKey *= (int)e.KeyCode;
                    if (DroneKey != 1) UseDrone(212, true);
                    break;
                case Keys.G:
                    osc.Send(new OscMessage("/avatar/parameters/VRCFaceBlendV", -(float)stepMoveV.Value));
                    if (DroneKey % (int)e.KeyCode != 0) DroneKey *= (int)e.KeyCode;
                    if (DroneKey != 1) UseDrone(212, true);
                    break;
                case Keys.H:
                    osc.Send(new OscMessage("/avatar/parameters/VRCFaceBlendH", (float)stepMoveH.Value));
                    if (DroneKey % (int)e.KeyCode != 0) DroneKey *= (int)e.KeyCode;
                    if (DroneKey != 1) UseDrone(212, true);
                    break;
                case Keys.Up:
                    osc.Send(new OscMessage("/avatar/parameters/VRCFaceBlendV", (float)stepRotV.Value));
                    if (DroneRotKey % (int)e.KeyCode != 0) DroneRotKey *= (int)e.KeyCode;
                    if (DroneRotKey != 1) UseDrone(213, true);
                    break;
                case Keys.Left:
                    osc.Send(new OscMessage("/avatar/parameters/VRCFaceBlendH", -(float)stepRotH.Value));
                    if (DroneRotKey % (int)e.KeyCode != 0) DroneRotKey *= (int)e.KeyCode;
                    if (DroneRotKey != 1) UseDrone(213, true);
                    break;
                case Keys.Down:
                    osc.Send(new OscMessage("/avatar/parameters/VRCFaceBlendV", -(float)stepRotV.Value));
                    if (DroneRotKey % (int)e.KeyCode != 0) DroneRotKey *= (int)e.KeyCode;
                    if (DroneRotKey != 1) UseDrone(213, true);
                    break;
                case Keys.Right:
                    osc.Send(new OscMessage("/avatar/parameters/VRCFaceBlendH", (float)stepRotH.Value));
                    if (DroneRotKey % (int)e.KeyCode != 0) DroneRotKey *= (int)e.KeyCode;
                    if (DroneRotKey != 1) UseDrone(213, true);
                    break;
                case Keys.Y:
                    if(btnDroneSwitch.Enabled)
                    {
                        btnDroneSwitch.Enabled = false;
                        SwitchDrone();
                    }
                    break;
            }
        }

        private void GlobalKeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.OemMinus: TimerZoomOut.Enabled = false; btnZoomOut.Enabled = true; break;
                case Keys.Oemplus: TimerZoomIn.Enabled = false; btnZoomIn.Enabled = true; break;
                case Keys.OemOpenBrackets: TimerEVm.Enabled = false; btnEVm.Enabled = true; break;
                case Keys.Oem6: TimerEVp.Enabled = false; btnEVp.Enabled = true; break;
                case Keys.Oem1: TimerApShallow.Enabled = false; btnApShallow.Enabled = true; break;
                case Keys.Oem7: TimerApGrea.Enabled = false; btnApGreat.Enabled = true; break;
                case Keys.OemPeriod: TimerFocusClo.Enabled = false; btnFocusClo.Enabled = true; break;
                case Keys.OemQuestion: TimerFocusFur.Enabled = false; btnFocusFur.Enabled = true; break;
                case Keys.T:
                    if (DroneKey % (int)e.KeyCode == 0)
                    {
                        DroneKey /= (int)e.KeyCode;
                        osc.Send(new OscMessage("/avatar/parameters/VRCFaceBlendV", 0f));
                    }
                    if (DroneKey == 1) UseDrone(212, false);
                    break;
                case Keys.F:
                    if (DroneKey % (int)e.KeyCode == 0)
                    {
                        DroneKey /= (int)e.KeyCode;
                        osc.Send(new OscMessage("/avatar/parameters/VRCFaceBlendH", 0f));
                    }
                    if (DroneKey == 1) UseDrone(212, false);
                    break;
                case Keys.G:
                    if (DroneKey % (int)e.KeyCode == 0)
                    {
                        DroneKey /= (int)e.KeyCode;
                        osc.Send(new OscMessage("/avatar/parameters/VRCFaceBlendV", 0f));
                    }
                    if (DroneKey == 1) UseDrone(212, false);
                    break;
                case Keys.H:
                    if (DroneKey % (int)e.KeyCode == 0)
                    {
                        DroneKey /= (int)e.KeyCode;
                        osc.Send(new OscMessage("/avatar/parameters/VRCFaceBlendH", 0f));
                    }
                    if (DroneKey == 1) UseDrone(212, false);
                    break;
                case Keys.Up:
                    if (DroneRotKey % (int)e.KeyCode == 0)
                    {
                        DroneRotKey /= (int)e.KeyCode;
                        osc.Send(new OscMessage("/avatar/parameters/VRCFaceBlendV", 0f));
                    }
                    if (DroneRotKey == 1) UseDrone(213, false);
                    break;
                case Keys.Left:
                    if (DroneRotKey % (int)e.KeyCode == 0)
                    {
                        DroneRotKey /= (int)e.KeyCode;
                        osc.Send(new OscMessage("/avatar/parameters/VRCFaceBlendH", 0f));
                    }
                    if (DroneRotKey == 1) UseDrone(213, false);
                    break;
                case Keys.Down:
                    if (DroneRotKey % (int)e.KeyCode == 0)
                    {
                        DroneRotKey /= (int)e.KeyCode;
                        osc.Send(new OscMessage("/avatar/parameters/VRCFaceBlendV", 0f));
                    }
                    if (DroneRotKey == 1) UseDrone(213, false);
                    break;
                case Keys.Right:
                    if (DroneRotKey % (int)e.KeyCode == 0)
                    {
                        DroneRotKey /= (int)e.KeyCode;
                        osc.Send(new OscMessage("/avatar/parameters/VRCFaceBlendH", 0f));
                    }
                    if (DroneRotKey == 1) UseDrone(213, false);
                    break;
                case Keys.Y:
                    btnDroneSwitch.Enabled = true;
                    break;
            }
        }

        private void UseDrone(int t, bool b)
        {
            //t = 212, 213
            b = !b;

            osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", (b) ? 0:t));

            btnDroneForward.Enabled = b;
            btnDroneBackward.Enabled = b;
            btnDroneHold.Enabled = b;
            btnDroneLeft.Enabled = b;
            btnDroneRight.Enabled = b;
            btnDroneRotUp.Enabled = b;
            btnDroneRotDown.Enabled = b;
            btnDroneRotHold.Enabled = b;
            btnDroneRotLeft.Enabled = b;
            btnDroneRotRight.Enabled = b;
        }

        private void OSCZoom()
        {
            this.lbZoomPer.Text = ((int)(this.sldZoom.Value * 0.1f)).ToString() + "%";
            osc.Send(new OscMessage("/avatar/parameters/VRCLZoomRadial", this.sldZoom.Value * 0.001f));
        }

        private void OSCEV()
        {
            this.lbEV.Text = ((int)(this.sldEV.Value * 0.1f)).ToString() + "%";
            osc.Send(new OscMessage("/avatar/parameters/VRCLExposureRadial", this.sldEV.Value * 0.001f));
        }

        private void OSCAp()
        {
            this.lbApPer.Text = ((int)(this.sldAp.Value * 0.1f)).ToString() + "%";
            osc.Send(new OscMessage("/avatar/parameters/VRCLApertureRadial", this.sldAp.Value * 0.001f));

        }

        private void OSCFocus()
        {
            this.lbFocus.Text = ((int)(this.sldFocus.Value * 0.1f)).ToString() + "%";
            osc.Send(new OscMessage("/avatar/parameters/VRCLFocusRadial", this.sldFocus.Value * 0.001f));
        }


        //------------------------------------------------------------------------------------

        private void sldZoom_Scroll(object sender, EventArgs e)
        {
            OSCZoom();
        }

        private void TimerZoomOut_Tick(object sender, EventArgs e)
        {
            if (this.sldZoom.Value - (int)this.stepZoom.Value < 0) this.sldZoom.Value = 0;
            else this.sldZoom.Value -= (int)this.stepZoom.Value;
            OSCZoom();
        }

        private void btnZoomOut_MouseDown(object sender, MouseEventArgs e)
        {
            this.TimerZoomOut.Enabled = true;
        }

        private void btnZoomOut_MouseUp(object sender, MouseEventArgs e)
        {
            this.TimerZoomOut.Enabled = false;
        }
        private void TimerZoomIn_Tick(object sender, EventArgs e)
        {
            if (this.sldZoom.Value + (int)this.stepZoom.Value > 1000) this.sldZoom.Value = 1000;
            else this.sldZoom.Value += (int)this.stepZoom.Value;
            OSCZoom();
        }

        private void btnZoomIn_MouseDown(object sender, MouseEventArgs e)
        {
            this.TimerZoomIn.Enabled = true;
        }

        private void btnZoomIn_MouseUp(object sender, MouseEventArgs e)
        {
            this.TimerZoomIn.Enabled = false;
        }
        //------------------------------------------------------------------------------------

        private void sldEV_Scroll(object sender, EventArgs e)
        {
            OSCEV();
        }

        private void TimerEVm_Tick(object sender, EventArgs e)
        {
            if (this.sldEV.Value - (int)this.stepEV.Value < 0) this.sldEV.Value = 0;
            else this.sldEV.Value -= (int)this.stepEV.Value;
            OSCEV();
        }

        private void btnEVm_MouseDown(object sender, MouseEventArgs e)
        {
            this.TimerEVm.Enabled = true;
        }

        private void btnEVm_MouseUp(object sender, MouseEventArgs e)
        {
            this.TimerEVm.Enabled = false;
        }

        private void TimerEVp_Tick(object sender, EventArgs e)
        {
            if (this.sldEV.Value + (int)this.stepEV.Value > 1000) this.sldEV.Value = 1000;
            else this.sldEV.Value += (int)this.stepEV.Value;
            OSCEV();
        }

        private void btnEVp_MouseDown(object sender, MouseEventArgs e)
        {
            this.TimerEVp.Enabled = true;
        }

        private void btnEVp_MouseUp(object sender, MouseEventArgs e)
        {
            this.TimerEVp.Enabled = false;
        }

        //------------------------------------------------------------------------------------
        private void sldAp_Scroll(object sender, EventArgs e)
        {
            OSCAp();
        }

        private void TimerApShallow_Tick(object sender, EventArgs e)
        {
            if (this.sldAp.Value - (int)this.stepAp.Value < 0) this.sldAp.Value = 0;
            else this.sldAp.Value -= (int)this.stepAp.Value;
            OSCAp();
        }

        private void btnApShallow_MouseDown(object sender, MouseEventArgs e)
        {
            this.TimerApShallow.Enabled = true;
        }

        private void btnApShallow_MouseUp(object sender, MouseEventArgs e)
        {
            this.TimerApShallow.Enabled = false;
        }

        private void TimerApGrea_Tick(object sender, EventArgs e)
        {
            if (this.sldAp.Value + (int)this.stepAp.Value > 1000) this.sldAp.Value = 1000;
            else this.sldAp.Value += (int)this.stepAp.Value;
            OSCAp();
        }

        private void btnApGreat_MouseDown(object sender, MouseEventArgs e)
        {
            this.TimerApGrea.Enabled = true;
        }

        private void btnApGreat_MouseUp(object sender, MouseEventArgs e)
        {
            this.TimerApGrea.Enabled = false;
        }
        //------------------------------------------------------------------------------------
        private void sldFocus_Scroll(object sender, EventArgs e)
        {
            OSCFocus();
        }

        private void TimerFocusClo_Tick(object sender, EventArgs e)
        {
            if (this.sldFocus.Value - (int)this.stepFocus.Value < 0) this.sldFocus.Value = 0;
            else this.sldFocus.Value -= (int)this.stepFocus.Value;
            OSCFocus();
        }

        private void btnFocusClo_MouseDown(object sender, MouseEventArgs e)
        {
            this.TimerFocusClo.Enabled = true;
        }

        private void btnFocusClo_MouseUp(object sender, MouseEventArgs e)
        {
            this.TimerFocusClo.Enabled = false;
        }

        private void TimerFocusFur_Tick(object sender, EventArgs e)
        {
            if (this.sldFocus.Value + (int)this.stepFocus.Value > 1000) this.sldFocus.Value = 1000;
            else this.sldFocus.Value += (int)this.stepFocus.Value;
            OSCFocus();
        }

        private void btnFocusFur_MouseDown(object sender, MouseEventArgs e)
        {
            this.TimerFocusFur.Enabled = true;
        }

        private void btnFocusFur_MouseUp(object sender, MouseEventArgs e)
        {
            this.TimerFocusFur.Enabled = false;
        }
        //------------------------------------------------------------------------------------
                        
        private void btnEnable_MouseDown(object sender, MouseEventArgs e)
        {
            osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 254));
        }

        private void btnEnable_MouseUp(object sender, MouseEventArgs e)
        {
            osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 0));
        }
        //------------------------------------------------------------------------------------

        private void btnDoF_MouseDown(object sender, MouseEventArgs e)
        {
            osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 11));
        }

        private void btnDoF_MouseUp(object sender, MouseEventArgs e)
        {
            osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 0));
        }
        //------------------------------------------------------------------------------------

        private void btnOIS_MouseDown(object sender, MouseEventArgs e)
        {
            osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 14));
        }

        private void btnOIS_MouseUp(object sender, MouseEventArgs e)
        {
            osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 0));
        }
        //------------------------------------------------------------------------------------

        private void btnPortrait_MouseDown(object sender, MouseEventArgs e)
        {
            osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 222));
        }

        private void btnPortrait_MouseUp(object sender, MouseEventArgs e)
        {
            osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 0));
        }
        //------------------------------------------------------------------------------------
        private void btnDrop_MouseDown(object sender, MouseEventArgs e)
        {
            osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 251));
        }

        private void btnDrop_MouseUp(object sender, MouseEventArgs e)
        {
            osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 0));
        }
        //------------------------------------------------------------------------------------
        private void btnTrackself_MouseDown(object sender, MouseEventArgs e)
        {
            osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 241));
        }

        private void btnTrackself_MouseUp(object sender, MouseEventArgs e)
        {
            osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 0));
        }


        //------------------------------------------------------------------------------------
        private void btnDC_MouseDown(object sender, MouseEventArgs e)
        {
            osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 224));
        }

        private void btnDC_MouseUp(object sender, MouseEventArgs e)
        {
            osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 0));
        }
        //------------------------------------------------------------------------------------
        private void btnHandRotate_MouseDown(object sender, MouseEventArgs e)
        {
            osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 250));
        }

        private void btnHandRotate_MouseUp(object sender, MouseEventArgs e)
        {
            osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 0));
        }
        //------------------------------------------------------------------------------------

        private void btnDroneForward_Click(object sender, EventArgs e)
        {
            osc.Send(new OscMessage("/avatar/parameters/VRCFaceBlendV", (float)stepMoveV.Value));
            osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 212));
        }

        private void BtnDroneBackward_Click(object sender, EventArgs e)
        {
            osc.Send(new OscMessage("/avatar/parameters/VRCFaceBlendV", -(float)stepMoveV.Value));
            osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 212));
        }
        private void btnDroneHold_Click(object sender, EventArgs e)
        {
            osc.Send(new OscMessage("/avatar/parameters/VRCFaceBlendV", 0f));
            osc.Send(new OscMessage("/avatar/parameters/VRCFaceBlendH", 0f));
            osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 0));
        }

        private void btnDroneLeft_Click(object sender, EventArgs e)
        {
            osc.Send(new OscMessage("/avatar/parameters/VRCFaceBlendH", -(float)stepMoveH.Value));
            osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 212));
        }

        private void btnDroneRight_Click(object sender, EventArgs e)
        {
            osc.Send(new OscMessage("/avatar/parameters/VRCFaceBlendH", (float)stepMoveH.Value));
            osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 212));
        }

        private void btnDroneRotUp_Click(object sender, EventArgs e)
        {
            osc.Send(new OscMessage("/avatar/parameters/VRCFaceBlendV", (float)stepRotV.Value));
            osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 213));
        }

        private void btnDroneRotDown_Click(object sender, EventArgs e)
        {
            osc.Send(new OscMessage("/avatar/parameters/VRCFaceBlendV", -(float)stepRotV.Value));
            osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 213));
        }

        private void btnDroneRotHold_Click(object sender, EventArgs e)
        {
            osc.Send(new OscMessage("/avatar/parameters/VRCFaceBlendV", 0f));
            osc.Send(new OscMessage("/avatar/parameters/VRCFaceBlendH", 0f));
            osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 0));
        }

        private void btnDroneRotLeft_Click(object sender, EventArgs e)
        {
            osc.Send(new OscMessage("/avatar/parameters/VRCFaceBlendH", -(float)stepRotH.Value));
            osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 213));
        }

        private void btnDroneRotRight_Click(object sender, EventArgs e)
        {
            osc.Send(new OscMessage("/avatar/parameters/VRCFaceBlendH", (float)stepRotH.Value));
            osc.Send(new OscMessage("/avatar/parameters/VRCLFeatureToggle", 213));
        }
        //------------------------------------------------------------------------------------

        private void button1_Click(object sender, EventArgs e)
        {
            if(btnShortkey.Text == "Enable Shortkey")
            {
                AssignHotKey();
                btnShortkey.Text = "Disable Shortkey";
            }
            else
            {
                gh.KeyDown -= GlobalKeyDown;
                gh.KeyUp -= GlobalKeyUp;
                gh.Dispose();

                btnShortkey.Text = "Enable Shortkey";
            }
        }
        private void btnDroneSwitch_Click(object sender, EventArgs e)
        {
            SwitchDrone();
        }
    }
}
