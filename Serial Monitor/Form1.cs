using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using ZedGraph;

namespace Serial_Monitor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bt_Send1.Enabled = false;
            bt_Send2.Enabled = false;
            bt_Send3.Enabled = false;
            bt_Send4.Enabled = false;
            bt_Send5.Enabled = false;
            bt_SendPID.Enabled = false;
            bt_Sendv1.Enabled = false;
            bt_Sendv2.Enabled = false;
            bt_Sendw1.Enabled = false;
            bt_Sendw2.Enabled = false;
            bt_8.Enabled = false;
            bt_Round.Enabled = false;
            bt_Rect.Enabled = false;
            tb_Receive.ScrollBars = ScrollBars.Both;
        }

        int portLenght = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Get all port name in PC
            string[] ports = SerialPort.GetPortNames();
            if(portLenght != ports.Length)
            {
                portLenght = ports.Length;
                cb_Com.Items.Clear();
                for(int i = 0; i < portLenght; i++)
                {
                    cb_Com.Items.Add(ports[i]);
                }
            }
        }

        private void bt_Connect_Click(object sender, EventArgs e)
        {
            if(bt_Connect.Text == "Open")
            {
                if (cb_Com.Text.Length != 0)
                {
                    sp_Serial.PortName = cb_Com.Text;
                    sp_Serial.Open();
                    bt_Connect.Text = "Close";
                    bt_Send1.Enabled = true;
                    bt_Send2.Enabled = true;
                    bt_Send3.Enabled = true;
                    bt_Send4.Enabled = true;
                    bt_Send5.Enabled = true;
                    bt_SendPID.Enabled = true;
                    bt_Sendv1.Enabled = true;
                    bt_Sendv2.Enabled = true;
                    bt_Sendw1.Enabled = true;
                    bt_Sendw2.Enabled = true;
                    bt_8.Enabled = true;
                    bt_Round.Enabled = true;
                    bt_Rect.Enabled = true;
                    pb_Connect.Image = Properties.Resources._checked;
                }
                else
                {

                }
            }
            else
            {
                //The Close() method can easily deadlock if the DataReceived event handler is currently running.
                Thread ClosePort = new Thread(new ThreadStart(CloseSerial));
                bt_Connect.Text = "Open";
                bt_Send1.Enabled = false;
                bt_Send2.Enabled = false;
                bt_Send3.Enabled = false;
                bt_Send4.Enabled = false;
                bt_Send5.Enabled = false;
                bt_SendPID.Enabled = false;
                bt_Sendv1.Enabled = false;
                bt_Sendv2.Enabled = false;
                bt_Sendw1.Enabled = false;
                bt_Sendw2.Enabled = false;
                bt_8.Enabled = false;
                bt_Round.Enabled = false;
                bt_Rect.Enabled = false;
                pb_Connect.Image = Properties.Resources.cancel;
                ClosePort.Start();
            }
        }

        private void CloseSerial()
        {
            try
            {
                sp_Serial.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt_Send1_Click(object sender, EventArgs e)
        {
            sp_Serial.WriteLine(tb_Send1.Text);
        }

        private void bt_Send2_Click(object sender, EventArgs e)
        {
            sp_Serial.WriteLine(tb_Send2.Text);
        }

        private void bt_Send3_Click(object sender, EventArgs e)
        {
            sp_Serial.WriteLine(tb_Send3.Text);
        }

        private void bt_Send4_Click(object sender, EventArgs e)
        {
            sp_Serial.WriteLine(tb_Send4.Text);
        }

        private void bt_Send5_Click(object sender, EventArgs e)
        {
            sp_Serial.WriteLine(tb_Send5.Text);
        }

        string s;
        private void onCom(object sender, SerialDataReceivedEventArgs e)
        {
            s = sp_Serial.ReadExisting();
            Thread tProcessData = new Thread(() => ProcessData(s));
            tProcessData.Start();
            ShowText(s);
        }

        private delegate void IvDisplay(string s);
        private void ShowText(string s)
        {
            if(tb_Receive.InvokeRequired)
            {
                tb_Receive.Invoke(new IvDisplay(ShowText), new object[] { s });
            }
            else
            {
                tb_Receive.AppendText(s);
            }
        }

        private string GetStringBetween2String(string src, string start, string end)
        {
            int posStart = src.IndexOf(start) + start.Length;
            int posEnd = src.IndexOf(end);
            if ((posStart >= 0) && (posEnd > posStart))
                return (src.Substring(posStart, posEnd - posStart));
            else
                return "";
        }

        double x = 0, y = 0, theta = 0;
        double dt = 0.02; //unit: sec

        private void ProcessData(string data)
        {
            string rs_string = GetStringBetween2String(data, "[", "]");

            if(rs_string != "")
            {
                string[] tokens = rs_string.Split(',');
                double v = Convert.ToDouble(tokens[0]);
                double w = Convert.ToDouble(tokens[1]);
                //Call trajectory
                x -= v * dt * Math.Cos(theta);
                y += v * dt * Math.Sin(theta);
                theta += w * dt;
                Draw_1line(x, y);

                if (tb_v.InvokeRequired)
                {
                    //tb_v.Invoke(new IvDisplay(ProcessData), new object[] { v.ToString() });
                    tb_v.Invoke((MethodInvoker)delegate { tb_v.Text = v.ToString(); });
                }
                else
                {
                    tb_v.Text = v.ToString();
                }

                if (tb_w.InvokeRequired)
                {
                    //tb_w.Invoke(new IvDisplay(ProcessData), new object[] { w.ToString() });
                    tb_w.Invoke((MethodInvoker)delegate { tb_w.Text = w.ToString(); });
                }
                else
                {
                    tb_w.Text = w.ToString();
                }

                if (tb_X.InvokeRequired)
                {
                    //tb_X.Invoke(new IvDisplay(ProcessData), new object[] { x.ToString() });
                    tb_X.Invoke((MethodInvoker)delegate { tb_X.Text = Math.Round(x,2).ToString(); });
                }
                else
                {
                    tb_X.Text = x.ToString();
                }

                if (tb_Y.InvokeRequired)
                {
                    //tb_Y.Invoke(new IvDisplay(ProcessData), new object[] { y.ToString() });
                    tb_Y.Invoke((MethodInvoker)delegate { tb_Y.Text = Math.Round(y,2).ToString(); });
                }
                else
                {
                    tb_Y.Text = y.ToString();
                }

                if (tb_Theta.InvokeRequired)
                {
                    //tb_Theta.Invoke(new IvDisplay(ProcessData), new object[] { theta.ToString() });
                    tb_Theta.Invoke((MethodInvoker)delegate { tb_Theta.Text = Math.Round(theta,2).ToString(); });
                }
                else
                {
                    tb_Theta.Text = theta.ToString();
                }
            }
        }

        private void bt_ClearGraph_Click(object sender, EventArgs e)
        {
            LineItem curve = zedGraph.GraphPane.CurveList[0] as LineItem;
            if (curve == null)
                return;

            IPointListEdit list = curve.Points as IPointListEdit;
            if (list == null)
                return;
            list.Clear();
        }

        private void bt_ResetCoor_Click(object sender, EventArgs e)
        {
            x = 0; y = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            theta = 0;
        }

        private void bt_SendPID_Click(object sender, EventArgs e)
        {
            string tmp;
            if ((tb_Kp.Text.Length != 0) && (tb_Ki.Text.Length != 0) && (tb_Kd.Text.Length != 0))
            {
                tmp = "{p," + tb_Kp + ",i," + tb_Ki + ",d," + tb_Kd + "}";
                sp_Serial.WriteLine(tmp);
            }
            else
            {
                MessageBox.Show("Have empty data");
            }
        }

        double v_pid = 0, w_pid = 0;
        private void bt_Sendv1_Click(object sender, EventArgs e)
        {
            v_pid = Convert.ToDouble(tb_v1);
            sp_Serial.WriteLine("[" + v_pid.ToString() + "," + w_pid + "]");
        }

        private void bt_Sendv2_Click(object sender, EventArgs e)
        {
            v_pid = Convert.ToDouble(tb_v2);
            sp_Serial.WriteLine("[" + v_pid.ToString() + "," + w_pid + "]");
        }

        private void bt_Sendw1_Click(object sender, EventArgs e)
        {
            w_pid = Convert.ToDouble(tb_w1);
            sp_Serial.WriteLine("[" + v_pid.ToString() + "," + w_pid + "]");
        }

        private void bt_Sendw2_Click(object sender, EventArgs e)
        {
            w_pid = Convert.ToDouble(tb_w2);
            sp_Serial.WriteLine("[" + v_pid.ToString() + "," + w_pid + "]");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Main graph
            GraphPane pane = zedGraph.GraphPane;
            pane.Title.Text = "Trajectory";
            pane.XAxis.Title.Text = "x";
            pane.YAxis.Title.Text = "y";
            pane.XAxis.Scale.Min = -5;
            pane.XAxis.Scale.Max = 5;
            pane.XAxis.Scale.MinorStep = 0.5;
            pane.XAxis.Scale.MajorStep = 1;
            pane.YAxis.Scale.Min = -5;
            pane.YAxis.Scale.Max = 5;
            pane.YAxis.Scale.MinorStep = 0.5;
            pane.YAxis.Scale.MajorStep = 1;

            zedGraph.AxisChange();

            RollingPointPairList list_model = new RollingPointPairList(60000);
            RollingPointPairList list_real = new RollingPointPairList(60000);

            LineItem curve_model = pane.AddCurve("Model", list_model, Color.Red, SymbolType.None);
            LineItem curve_real = pane.AddCurve("Real", list_real, Color.Blue, SymbolType.None);

            //v graph
            GraphPane pane_v = zg_v.GraphPane;
            pane_v.Title.Text = "Velocity";
            pane_v.XAxis.Title.Text = "Time";
            pane_v.YAxis.Title.Text = "Vel";
            pane_v.XAxis.Scale.Min = 0;
            pane_v.XAxis.Scale.Max = 10;
            pane_v.XAxis.Scale.MinorStep = 0.5;
            pane_v.XAxis.Scale.MajorStep = 1;
            pane_v.YAxis.Scale.Min = 0;
            pane_v.YAxis.Scale.Max = 1;
            pane_v.YAxis.Scale.MinorStep = 0.05;
            pane_v.YAxis.Scale.MajorStep = 0.1;

            zg_v.AxisChange();

            RollingPointPairList list_model_v = new RollingPointPairList(60000);
            RollingPointPairList list_real_v = new RollingPointPairList(60000);

            LineItem curve_model_v = pane.AddCurve("Set point", list_model_v, Color.Red, SymbolType.None);
            LineItem curve_real_v = pane.AddCurve("Current point", list_real_v, Color.Blue, SymbolType.None);

            //w graph
            GraphPane pane_w = zg_w.GraphPane;
            pane_w.Title.Text = "Rotation";
            pane_w.XAxis.Title.Text = "Time";
            pane_w.YAxis.Title.Text = "Rot";
            pane_w.XAxis.Scale.Min = 0;
            pane_w.XAxis.Scale.Max = 10;
            pane_w.XAxis.Scale.MinorStep = 0.5;
            pane_w.XAxis.Scale.MajorStep = 1;
            pane_w.YAxis.Scale.Min = 0;
            pane_w.YAxis.Scale.Max = 1;
            pane_w.YAxis.Scale.MinorStep = 0.05;
            pane_w.YAxis.Scale.MajorStep = 0.1;

            zg_w.AxisChange();

            RollingPointPairList list_model_w = new RollingPointPairList(60000);
            RollingPointPairList list_real_w = new RollingPointPairList(60000);

            LineItem curve_model_w = pane.AddCurve("Set point", list_model_w, Color.Red, SymbolType.None);
            LineItem curve_real_w = pane.AddCurve("Current point", list_real_w, Color.Blue, SymbolType.None);

            //left graph
            GraphPane pane_left = zg_left.GraphPane;
            pane_left.Title.Text = "Left Motor";
            pane_left.XAxis.Title.Text = "Time";
            pane_left.YAxis.Title.Text = "Encoder";
            pane_left.XAxis.Scale.Min = 0;
            pane_left.XAxis.Scale.Max = 10;
            pane_left.XAxis.Scale.MinorStep = 0.5;
            pane_left.XAxis.Scale.MajorStep = 1;
            pane_left.YAxis.Scale.Min = 0;
            pane_left.YAxis.Scale.Max = 1000;
            pane_left.YAxis.Scale.MinorStep = 50;
            pane_left.YAxis.Scale.MajorStep = 100;

            zg_left.AxisChange();

            RollingPointPairList list_model_left = new RollingPointPairList(60000);
            RollingPointPairList list_real_left = new RollingPointPairList(60000);

            LineItem curve_model_left = pane.AddCurve("Set point", list_model_left, Color.Red, SymbolType.None);
            LineItem curve_real_left = pane.AddCurve("Current point", list_real_left, Color.Blue, SymbolType.None);

            //right graph
            GraphPane pane_right = zg_right.GraphPane;
            pane_right.Title.Text = "Right Motor";
            pane_right.XAxis.Title.Text = "Time";
            pane_right.YAxis.Title.Text = "Rot";
            pane_right.XAxis.Scale.Min = 0;
            pane_right.XAxis.Scale.Max = 10;
            pane_right.XAxis.Scale.MinorStep = 0.5;
            pane_right.XAxis.Scale.MajorStep = 1;
            pane_right.YAxis.Scale.Min = 0;
            pane_right.YAxis.Scale.Max = 1000;
            pane_right.YAxis.Scale.MinorStep = 50;
            pane_right.YAxis.Scale.MajorStep = 100;

            zg_w.AxisChange();

            RollingPointPairList list_model_right = new RollingPointPairList(60000);
            RollingPointPairList list_real_right = new RollingPointPairList(60000);

            LineItem curve_model_right = pane.AddCurve("Set point", list_model_right, Color.Red, SymbolType.None);
            LineItem curve_real_right = pane.AddCurve("Current point", list_real_right, Color.Blue, SymbolType.None);
        }

        private void Draw_1line(double x, double y)
        {
            if (zedGraph.GraphPane.CurveList.Count <= 0)
                return;

            LineItem curve = zedGraph.GraphPane.CurveList[0] as LineItem;
            if (curve == null)
                return;

            IPointListEdit list = curve.Points as IPointListEdit;
            if (list == null)
                return;

            list.Add(x, y);

            zedGraph.Invalidate();
        }
    }
}
