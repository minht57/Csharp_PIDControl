namespace Serial_Monitor
{
    partial class Form1
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
            this.tbctl_Serial = new System.Windows.Forms.TabControl();
            this.tp_Connect = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pb_Connect = new System.Windows.Forms.PictureBox();
            this.bt_Connect = new System.Windows.Forms.Button();
            this.cb_StopBit = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_Parity = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_DataSize = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_Baud = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Com = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_Receive = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_Send5 = new System.Windows.Forms.Button();
            this.bt_Send4 = new System.Windows.Forms.Button();
            this.bt_Send3 = new System.Windows.Forms.Button();
            this.bt_Send2 = new System.Windows.Forms.Button();
            this.tb_Send1 = new System.Windows.Forms.TextBox();
            this.tb_Send2 = new System.Windows.Forms.TextBox();
            this.bt_Send1 = new System.Windows.Forms.Button();
            this.tb_Send5 = new System.Windows.Forms.TextBox();
            this.tb_Send3 = new System.Windows.Forms.TextBox();
            this.tb_Send4 = new System.Windows.Forms.TextBox();
            this.tp_Draw = new System.Windows.Forms.TabPage();
            this.bt_8 = new System.Windows.Forms.Button();
            this.bt_Round = new System.Windows.Forms.Button();
            this.tb_w = new System.Windows.Forms.TextBox();
            this.tb_v = new System.Windows.Forms.TextBox();
            this.tb_Theta = new System.Windows.Forms.TextBox();
            this.tb_Y = new System.Windows.Forms.TextBox();
            this.tb_X = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bt_Rect = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_ResetCoor = new System.Windows.Forms.Button();
            this.bt_ClearGraph = new System.Windows.Forms.Button();
            this.zedGraph = new ZedGraph.ZedGraphControl();
            this.tp_PID = new System.Windows.Forms.TabPage();
            this.bt_Sendw2 = new System.Windows.Forms.Button();
            this.tb_w2 = new System.Windows.Forms.TextBox();
            this.bt_Sendw1 = new System.Windows.Forms.Button();
            this.tb_w1 = new System.Windows.Forms.TextBox();
            this.bt_Sendv2 = new System.Windows.Forms.Button();
            this.tb_v2 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.bt_Sendv1 = new System.Windows.Forms.Button();
            this.bt_SendPID = new System.Windows.Forms.Button();
            this.tb_v1 = new System.Windows.Forms.TextBox();
            this.lbX = new System.Windows.Forms.Label();
            this.tb_Kd = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_Ki = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_Kp = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.zg_left = new ZedGraph.ZedGraphControl();
            this.zg_v = new ZedGraph.ZedGraphControl();
            this.zg_right = new ZedGraph.ZedGraphControl();
            this.zg_w = new ZedGraph.ZedGraphControl();
            this.tp_Info = new System.Windows.Forms.TabPage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sp_Serial = new System.IO.Ports.SerialPort(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tbctl_Serial.SuspendLayout();
            this.tp_Connect.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Connect)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tp_Draw.SuspendLayout();
            this.tp_PID.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbctl_Serial
            // 
            this.tbctl_Serial.Controls.Add(this.tp_Connect);
            this.tbctl_Serial.Controls.Add(this.tp_Draw);
            this.tbctl_Serial.Controls.Add(this.tp_PID);
            this.tbctl_Serial.Controls.Add(this.tp_Info);
            this.tbctl_Serial.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbctl_Serial.Location = new System.Drawing.Point(2, 3);
            this.tbctl_Serial.Name = "tbctl_Serial";
            this.tbctl_Serial.SelectedIndex = 0;
            this.tbctl_Serial.Size = new System.Drawing.Size(775, 435);
            this.tbctl_Serial.TabIndex = 0;
            this.tbctl_Serial.TabStop = false;
            // 
            // tp_Connect
            // 
            this.tp_Connect.Controls.Add(this.groupBox3);
            this.tp_Connect.Controls.Add(this.groupBox2);
            this.tp_Connect.Controls.Add(this.groupBox1);
            this.tp_Connect.Location = new System.Drawing.Point(4, 22);
            this.tp_Connect.Name = "tp_Connect";
            this.tp_Connect.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Connect.Size = new System.Drawing.Size(767, 409);
            this.tp_Connect.TabIndex = 0;
            this.tp_Connect.Text = "Connect";
            this.tp_Connect.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pb_Connect);
            this.groupBox3.Controls.Add(this.bt_Connect);
            this.groupBox3.Controls.Add(this.cb_StopBit);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cb_Parity);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.cb_DataSize);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cb_Baud);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cb_Com);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(607, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(154, 396);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Serial";
            // 
            // pb_Connect
            // 
            this.pb_Connect.Image = global::Serial_Monitor.Properties.Resources.cancel;
            this.pb_Connect.Location = new System.Drawing.Point(24, 334);
            this.pb_Connect.Name = "pb_Connect";
            this.pb_Connect.Size = new System.Drawing.Size(111, 56);
            this.pb_Connect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Connect.TabIndex = 11;
            this.pb_Connect.TabStop = false;
            // 
            // bt_Connect
            // 
            this.bt_Connect.Location = new System.Drawing.Point(24, 289);
            this.bt_Connect.Name = "bt_Connect";
            this.bt_Connect.Size = new System.Drawing.Size(111, 39);
            this.bt_Connect.TabIndex = 10;
            this.bt_Connect.Text = "Open";
            this.bt_Connect.UseVisualStyleBackColor = true;
            this.bt_Connect.Click += new System.EventHandler(this.bt_Connect_Click);
            // 
            // cb_StopBit
            // 
            this.cb_StopBit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_StopBit.FormattingEnabled = true;
            this.cb_StopBit.Location = new System.Drawing.Point(10, 242);
            this.cb_StopBit.Name = "cb_StopBit";
            this.cb_StopBit.Size = new System.Drawing.Size(138, 24);
            this.cb_StopBit.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Stop bit";
            // 
            // cb_Parity
            // 
            this.cb_Parity.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Parity.FormattingEnabled = true;
            this.cb_Parity.Location = new System.Drawing.Point(10, 193);
            this.cb_Parity.Name = "cb_Parity";
            this.cb_Parity.Size = new System.Drawing.Size(138, 24);
            this.cb_Parity.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Parity";
            // 
            // cb_DataSize
            // 
            this.cb_DataSize.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_DataSize.FormattingEnabled = true;
            this.cb_DataSize.Location = new System.Drawing.Point(10, 144);
            this.cb_DataSize.Name = "cb_DataSize";
            this.cb_DataSize.Size = new System.Drawing.Size(138, 24);
            this.cb_DataSize.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data size";
            // 
            // cb_Baud
            // 
            this.cb_Baud.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Baud.FormattingEnabled = true;
            this.cb_Baud.Location = new System.Drawing.Point(10, 95);
            this.cb_Baud.Name = "cb_Baud";
            this.cb_Baud.Size = new System.Drawing.Size(138, 24);
            this.cb_Baud.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Baudrate";
            // 
            // cb_Com
            // 
            this.cb_Com.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Com.FormattingEnabled = true;
            this.cb_Com.Location = new System.Drawing.Point(10, 46);
            this.cb_Com.Name = "cb_Com";
            this.cb_Com.Size = new System.Drawing.Size(138, 24);
            this.cb_Com.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_Receive);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 397);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Received Data";
            // 
            // tb_Receive
            // 
            this.tb_Receive.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Receive.Location = new System.Drawing.Point(6, 22);
            this.tb_Receive.Multiline = true;
            this.tb_Receive.Name = "tb_Receive";
            this.tb_Receive.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_Receive.Size = new System.Drawing.Size(240, 368);
            this.tb_Receive.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_Send5);
            this.groupBox1.Controls.Add(this.bt_Send4);
            this.groupBox1.Controls.Add(this.bt_Send3);
            this.groupBox1.Controls.Add(this.bt_Send2);
            this.groupBox1.Controls.Add(this.tb_Send1);
            this.groupBox1.Controls.Add(this.tb_Send2);
            this.groupBox1.Controls.Add(this.bt_Send1);
            this.groupBox1.Controls.Add(this.tb_Send5);
            this.groupBox1.Controls.Add(this.tb_Send3);
            this.groupBox1.Controls.Add(this.tb_Send4);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(264, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 398);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Send";
            // 
            // bt_Send5
            // 
            this.bt_Send5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Send5.Location = new System.Drawing.Point(252, 250);
            this.bt_Send5.Name = "bt_Send5";
            this.bt_Send5.Size = new System.Drawing.Size(75, 26);
            this.bt_Send5.TabIndex = 12;
            this.bt_Send5.Text = "Send";
            this.bt_Send5.UseVisualStyleBackColor = true;
            this.bt_Send5.Click += new System.EventHandler(this.bt_Send5_Click);
            // 
            // bt_Send4
            // 
            this.bt_Send4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Send4.Location = new System.Drawing.Point(252, 121);
            this.bt_Send4.Name = "bt_Send4";
            this.bt_Send4.Size = new System.Drawing.Size(75, 26);
            this.bt_Send4.TabIndex = 11;
            this.bt_Send4.Text = "Send";
            this.bt_Send4.UseVisualStyleBackColor = true;
            this.bt_Send4.Click += new System.EventHandler(this.bt_Send4_Click);
            // 
            // bt_Send3
            // 
            this.bt_Send3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Send3.Location = new System.Drawing.Point(252, 89);
            this.bt_Send3.Name = "bt_Send3";
            this.bt_Send3.Size = new System.Drawing.Size(75, 26);
            this.bt_Send3.TabIndex = 10;
            this.bt_Send3.Text = "Send";
            this.bt_Send3.UseVisualStyleBackColor = true;
            this.bt_Send3.Click += new System.EventHandler(this.bt_Send3_Click);
            // 
            // bt_Send2
            // 
            this.bt_Send2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Send2.Location = new System.Drawing.Point(252, 57);
            this.bt_Send2.Name = "bt_Send2";
            this.bt_Send2.Size = new System.Drawing.Size(75, 26);
            this.bt_Send2.TabIndex = 9;
            this.bt_Send2.Text = "Send";
            this.bt_Send2.UseVisualStyleBackColor = true;
            this.bt_Send2.Click += new System.EventHandler(this.bt_Send2_Click);
            // 
            // tb_Send1
            // 
            this.tb_Send1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Send1.Location = new System.Drawing.Point(6, 25);
            this.tb_Send1.Name = "tb_Send1";
            this.tb_Send1.Size = new System.Drawing.Size(240, 22);
            this.tb_Send1.TabIndex = 3;
            // 
            // tb_Send2
            // 
            this.tb_Send2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Send2.Location = new System.Drawing.Point(6, 57);
            this.tb_Send2.Name = "tb_Send2";
            this.tb_Send2.Size = new System.Drawing.Size(240, 22);
            this.tb_Send2.TabIndex = 4;
            // 
            // bt_Send1
            // 
            this.bt_Send1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Send1.Location = new System.Drawing.Point(252, 22);
            this.bt_Send1.Name = "bt_Send1";
            this.bt_Send1.Size = new System.Drawing.Size(75, 26);
            this.bt_Send1.TabIndex = 8;
            this.bt_Send1.Text = "Send";
            this.bt_Send1.UseVisualStyleBackColor = true;
            this.bt_Send1.Click += new System.EventHandler(this.bt_Send1_Click);
            // 
            // tb_Send5
            // 
            this.tb_Send5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Send5.Location = new System.Drawing.Point(6, 153);
            this.tb_Send5.Multiline = true;
            this.tb_Send5.Name = "tb_Send5";
            this.tb_Send5.Size = new System.Drawing.Size(240, 237);
            this.tb_Send5.TabIndex = 7;
            // 
            // tb_Send3
            // 
            this.tb_Send3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Send3.Location = new System.Drawing.Point(6, 89);
            this.tb_Send3.Name = "tb_Send3";
            this.tb_Send3.Size = new System.Drawing.Size(240, 22);
            this.tb_Send3.TabIndex = 5;
            // 
            // tb_Send4
            // 
            this.tb_Send4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Send4.Location = new System.Drawing.Point(6, 121);
            this.tb_Send4.Name = "tb_Send4";
            this.tb_Send4.Size = new System.Drawing.Size(240, 22);
            this.tb_Send4.TabIndex = 6;
            // 
            // tp_Draw
            // 
            this.tp_Draw.Controls.Add(this.bt_8);
            this.tp_Draw.Controls.Add(this.bt_Round);
            this.tp_Draw.Controls.Add(this.tb_w);
            this.tp_Draw.Controls.Add(this.tb_v);
            this.tp_Draw.Controls.Add(this.tb_Theta);
            this.tp_Draw.Controls.Add(this.tb_Y);
            this.tp_Draw.Controls.Add(this.tb_X);
            this.tp_Draw.Controls.Add(this.label10);
            this.tp_Draw.Controls.Add(this.label9);
            this.tp_Draw.Controls.Add(this.label8);
            this.tp_Draw.Controls.Add(this.label7);
            this.tp_Draw.Controls.Add(this.label6);
            this.tp_Draw.Controls.Add(this.bt_Rect);
            this.tp_Draw.Controls.Add(this.button1);
            this.tp_Draw.Controls.Add(this.bt_ResetCoor);
            this.tp_Draw.Controls.Add(this.bt_ClearGraph);
            this.tp_Draw.Controls.Add(this.zedGraph);
            this.tp_Draw.Location = new System.Drawing.Point(4, 22);
            this.tp_Draw.Name = "tp_Draw";
            this.tp_Draw.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Draw.Size = new System.Drawing.Size(767, 409);
            this.tp_Draw.TabIndex = 1;
            this.tp_Draw.Text = "Draw";
            this.tp_Draw.UseVisualStyleBackColor = true;
            // 
            // bt_8
            // 
            this.bt_8.Location = new System.Drawing.Point(611, 132);
            this.bt_8.Name = "bt_8";
            this.bt_8.Size = new System.Drawing.Size(150, 57);
            this.bt_8.TabIndex = 19;
            this.bt_8.UseVisualStyleBackColor = true;
            // 
            // bt_Round
            // 
            this.bt_Round.Location = new System.Drawing.Point(611, 69);
            this.bt_Round.Name = "bt_Round";
            this.bt_Round.Size = new System.Drawing.Size(150, 57);
            this.bt_Round.TabIndex = 18;
            this.bt_Round.UseVisualStyleBackColor = true;
            // 
            // tb_w
            // 
            this.tb_w.Location = new System.Drawing.Point(689, 293);
            this.tb_w.Name = "tb_w";
            this.tb_w.Size = new System.Drawing.Size(72, 20);
            this.tb_w.TabIndex = 17;
            // 
            // tb_v
            // 
            this.tb_v.Location = new System.Drawing.Point(611, 293);
            this.tb_v.Name = "tb_v";
            this.tb_v.Size = new System.Drawing.Size(72, 20);
            this.tb_v.TabIndex = 16;
            // 
            // tb_Theta
            // 
            this.tb_Theta.Location = new System.Drawing.Point(611, 251);
            this.tb_Theta.Name = "tb_Theta";
            this.tb_Theta.Size = new System.Drawing.Size(70, 20);
            this.tb_Theta.TabIndex = 15;
            // 
            // tb_Y
            // 
            this.tb_Y.Location = new System.Drawing.Point(689, 209);
            this.tb_Y.Name = "tb_Y";
            this.tb_Y.Size = new System.Drawing.Size(70, 20);
            this.tb_Y.TabIndex = 14;
            // 
            // tb_X
            // 
            this.tb_X.Location = new System.Drawing.Point(611, 209);
            this.tb_X.Name = "tb_X";
            this.tb_X.Size = new System.Drawing.Size(72, 20);
            this.tb_X.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(611, 232);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "Theta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(686, 274);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "w";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(611, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "v";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(686, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(611, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "X";
            // 
            // bt_Rect
            // 
            this.bt_Rect.Location = new System.Drawing.Point(611, 6);
            this.bt_Rect.Name = "bt_Rect";
            this.bt_Rect.Size = new System.Drawing.Size(150, 57);
            this.bt_Rect.TabIndex = 4;
            this.bt_Rect.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(689, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Reset Theta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_ResetCoor
            // 
            this.bt_ResetCoor.Location = new System.Drawing.Point(611, 359);
            this.bt_ResetCoor.Name = "bt_ResetCoor";
            this.bt_ResetCoor.Size = new System.Drawing.Size(72, 34);
            this.bt_ResetCoor.TabIndex = 2;
            this.bt_ResetCoor.Text = "Reset XY";
            this.bt_ResetCoor.UseVisualStyleBackColor = true;
            this.bt_ResetCoor.Click += new System.EventHandler(this.bt_ResetCoor_Click);
            // 
            // bt_ClearGraph
            // 
            this.bt_ClearGraph.Location = new System.Drawing.Point(689, 319);
            this.bt_ClearGraph.Name = "bt_ClearGraph";
            this.bt_ClearGraph.Size = new System.Drawing.Size(72, 34);
            this.bt_ClearGraph.TabIndex = 1;
            this.bt_ClearGraph.Text = "Clear";
            this.bt_ClearGraph.UseVisualStyleBackColor = true;
            this.bt_ClearGraph.Click += new System.EventHandler(this.bt_ClearGraph_Click);
            // 
            // zedGraph
            // 
            this.zedGraph.Location = new System.Drawing.Point(6, 6);
            this.zedGraph.Name = "zedGraph";
            this.zedGraph.ScrollGrace = 0D;
            this.zedGraph.ScrollMaxX = 0D;
            this.zedGraph.ScrollMaxY = 0D;
            this.zedGraph.ScrollMaxY2 = 0D;
            this.zedGraph.ScrollMinX = 0D;
            this.zedGraph.ScrollMinY = 0D;
            this.zedGraph.ScrollMinY2 = 0D;
            this.zedGraph.Size = new System.Drawing.Size(599, 397);
            this.zedGraph.TabIndex = 0;
            // 
            // tp_PID
            // 
            this.tp_PID.Controls.Add(this.bt_Sendw2);
            this.tp_PID.Controls.Add(this.tb_w2);
            this.tp_PID.Controls.Add(this.bt_Sendw1);
            this.tp_PID.Controls.Add(this.tb_w1);
            this.tp_PID.Controls.Add(this.bt_Sendv2);
            this.tp_PID.Controls.Add(this.tb_v2);
            this.tp_PID.Controls.Add(this.label15);
            this.tp_PID.Controls.Add(this.bt_Sendv1);
            this.tp_PID.Controls.Add(this.bt_SendPID);
            this.tp_PID.Controls.Add(this.tb_v1);
            this.tp_PID.Controls.Add(this.lbX);
            this.tp_PID.Controls.Add(this.tb_Kd);
            this.tp_PID.Controls.Add(this.label13);
            this.tp_PID.Controls.Add(this.tb_Ki);
            this.tp_PID.Controls.Add(this.label12);
            this.tp_PID.Controls.Add(this.tb_Kp);
            this.tp_PID.Controls.Add(this.label11);
            this.tp_PID.Controls.Add(this.zg_left);
            this.tp_PID.Controls.Add(this.zg_v);
            this.tp_PID.Controls.Add(this.zg_right);
            this.tp_PID.Controls.Add(this.zg_w);
            this.tp_PID.Location = new System.Drawing.Point(4, 22);
            this.tp_PID.Name = "tp_PID";
            this.tp_PID.Padding = new System.Windows.Forms.Padding(3);
            this.tp_PID.Size = new System.Drawing.Size(767, 409);
            this.tp_PID.TabIndex = 3;
            this.tp_PID.Text = "PID Control";
            this.tp_PID.UseVisualStyleBackColor = true;
            // 
            // bt_Sendw2
            // 
            this.bt_Sendw2.Location = new System.Drawing.Point(346, 381);
            this.bt_Sendw2.Name = "bt_Sendw2";
            this.bt_Sendw2.Size = new System.Drawing.Size(75, 23);
            this.bt_Sendw2.TabIndex = 31;
            this.bt_Sendw2.Text = "Send";
            this.bt_Sendw2.UseVisualStyleBackColor = true;
            this.bt_Sendw2.Click += new System.EventHandler(this.bt_Sendw2_Click);
            // 
            // tb_w2
            // 
            this.tb_w2.Location = new System.Drawing.Point(346, 355);
            this.tb_w2.Name = "tb_w2";
            this.tb_w2.Size = new System.Drawing.Size(75, 20);
            this.tb_w2.TabIndex = 30;
            // 
            // bt_Sendw1
            // 
            this.bt_Sendw1.Location = new System.Drawing.Point(346, 326);
            this.bt_Sendw1.Name = "bt_Sendw1";
            this.bt_Sendw1.Size = new System.Drawing.Size(75, 23);
            this.bt_Sendw1.TabIndex = 29;
            this.bt_Sendw1.Text = "Send";
            this.bt_Sendw1.UseVisualStyleBackColor = true;
            this.bt_Sendw1.Click += new System.EventHandler(this.bt_Sendw1_Click);
            // 
            // tb_w1
            // 
            this.tb_w1.Location = new System.Drawing.Point(346, 300);
            this.tb_w1.Name = "tb_w1";
            this.tb_w1.Size = new System.Drawing.Size(75, 20);
            this.tb_w1.TabIndex = 28;
            // 
            // bt_Sendv2
            // 
            this.bt_Sendv2.Location = new System.Drawing.Point(346, 255);
            this.bt_Sendv2.Name = "bt_Sendv2";
            this.bt_Sendv2.Size = new System.Drawing.Size(75, 23);
            this.bt_Sendv2.TabIndex = 27;
            this.bt_Sendv2.Text = "Send";
            this.bt_Sendv2.UseVisualStyleBackColor = true;
            this.bt_Sendv2.Click += new System.EventHandler(this.bt_Sendv2_Click);
            // 
            // tb_v2
            // 
            this.tb_v2.Location = new System.Drawing.Point(346, 229);
            this.tb_v2.Name = "tb_v2";
            this.tb_v2.Size = new System.Drawing.Size(75, 20);
            this.tb_v2.TabIndex = 26;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(346, 281);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 16);
            this.label15.TabIndex = 25;
            this.label15.Text = "w";
            // 
            // bt_Sendv1
            // 
            this.bt_Sendv1.Location = new System.Drawing.Point(346, 200);
            this.bt_Sendv1.Name = "bt_Sendv1";
            this.bt_Sendv1.Size = new System.Drawing.Size(75, 23);
            this.bt_Sendv1.TabIndex = 24;
            this.bt_Sendv1.Text = "Send";
            this.bt_Sendv1.UseVisualStyleBackColor = true;
            this.bt_Sendv1.Click += new System.EventHandler(this.bt_Sendv1_Click);
            // 
            // bt_SendPID
            // 
            this.bt_SendPID.Location = new System.Drawing.Point(346, 129);
            this.bt_SendPID.Name = "bt_SendPID";
            this.bt_SendPID.Size = new System.Drawing.Size(75, 23);
            this.bt_SendPID.TabIndex = 22;
            this.bt_SendPID.Text = "Send";
            this.bt_SendPID.UseVisualStyleBackColor = true;
            this.bt_SendPID.Click += new System.EventHandler(this.bt_SendPID_Click);
            // 
            // tb_v1
            // 
            this.tb_v1.Location = new System.Drawing.Point(346, 174);
            this.tb_v1.Name = "tb_v1";
            this.tb_v1.Size = new System.Drawing.Size(75, 20);
            this.tb_v1.TabIndex = 21;
            // 
            // lbX
            // 
            this.lbX.AutoSize = true;
            this.lbX.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbX.Location = new System.Drawing.Point(346, 155);
            this.lbX.Name = "lbX";
            this.lbX.Size = new System.Drawing.Size(13, 16);
            this.lbX.TabIndex = 20;
            this.lbX.Text = "v";
            // 
            // tb_Kd
            // 
            this.tb_Kd.Location = new System.Drawing.Point(346, 103);
            this.tb_Kd.Name = "tb_Kd";
            this.tb_Kd.Size = new System.Drawing.Size(75, 20);
            this.tb_Kd.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(346, 84);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 16);
            this.label13.TabIndex = 18;
            this.label13.Text = "Kd";
            // 
            // tb_Ki
            // 
            this.tb_Ki.Location = new System.Drawing.Point(346, 61);
            this.tb_Ki.Name = "tb_Ki";
            this.tb_Ki.Size = new System.Drawing.Size(75, 20);
            this.tb_Ki.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(346, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 16);
            this.label12.TabIndex = 16;
            this.label12.Text = "Ki";
            // 
            // tb_Kp
            // 
            this.tb_Kp.Location = new System.Drawing.Point(346, 19);
            this.tb_Kp.Name = "tb_Kp";
            this.tb_Kp.Size = new System.Drawing.Size(75, 20);
            this.tb_Kp.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(346, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 16);
            this.label11.TabIndex = 14;
            this.label11.Text = "Kp";
            // 
            // zg_left
            // 
            this.zg_left.Location = new System.Drawing.Point(427, 6);
            this.zg_left.Name = "zg_left";
            this.zg_left.ScrollGrace = 0D;
            this.zg_left.ScrollMaxX = 0D;
            this.zg_left.ScrollMaxY = 0D;
            this.zg_left.ScrollMaxY2 = 0D;
            this.zg_left.ScrollMinX = 0D;
            this.zg_left.ScrollMinY = 0D;
            this.zg_left.ScrollMinY2 = 0D;
            this.zg_left.Size = new System.Drawing.Size(334, 198);
            this.zg_left.TabIndex = 3;
            // 
            // zg_v
            // 
            this.zg_v.Location = new System.Drawing.Point(6, 6);
            this.zg_v.Name = "zg_v";
            this.zg_v.ScrollGrace = 0D;
            this.zg_v.ScrollMaxX = 0D;
            this.zg_v.ScrollMaxY = 0D;
            this.zg_v.ScrollMaxY2 = 0D;
            this.zg_v.ScrollMinX = 0D;
            this.zg_v.ScrollMinY = 0D;
            this.zg_v.ScrollMinY2 = 0D;
            this.zg_v.Size = new System.Drawing.Size(334, 198);
            this.zg_v.TabIndex = 2;
            // 
            // zg_right
            // 
            this.zg_right.Location = new System.Drawing.Point(427, 210);
            this.zg_right.Name = "zg_right";
            this.zg_right.ScrollGrace = 0D;
            this.zg_right.ScrollMaxX = 0D;
            this.zg_right.ScrollMaxY = 0D;
            this.zg_right.ScrollMaxY2 = 0D;
            this.zg_right.ScrollMinX = 0D;
            this.zg_right.ScrollMinY = 0D;
            this.zg_right.ScrollMinY2 = 0D;
            this.zg_right.Size = new System.Drawing.Size(334, 194);
            this.zg_right.TabIndex = 1;
            // 
            // zg_w
            // 
            this.zg_w.Location = new System.Drawing.Point(6, 210);
            this.zg_w.Name = "zg_w";
            this.zg_w.ScrollGrace = 0D;
            this.zg_w.ScrollMaxX = 0D;
            this.zg_w.ScrollMaxY = 0D;
            this.zg_w.ScrollMaxY2 = 0D;
            this.zg_w.ScrollMinX = 0D;
            this.zg_w.ScrollMinY = 0D;
            this.zg_w.ScrollMinY2 = 0D;
            this.zg_w.Size = new System.Drawing.Size(334, 194);
            this.zg_w.TabIndex = 0;
            // 
            // tp_Info
            // 
            this.tp_Info.Location = new System.Drawing.Point(4, 22);
            this.tp_Info.Name = "tp_Info";
            this.tp_Info.Size = new System.Drawing.Size(767, 409);
            this.tp_Info.TabIndex = 2;
            this.tp_Info.Text = "Info";
            this.tp_Info.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // sp_Serial
            // 
            this.sp_Serial.BaudRate = 115200;
            this.sp_Serial.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.onCom);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(779, 441);
            this.Controls.Add(this.tbctl_Serial);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serial";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tbctl_Serial.ResumeLayout(false);
            this.tp_Connect.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Connect)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tp_Draw.ResumeLayout(false);
            this.tp_Draw.PerformLayout();
            this.tp_PID.ResumeLayout(false);
            this.tp_PID.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tp_Connect;
        private System.Windows.Forms.TabPage tp_Draw;
        private System.Windows.Forms.TabPage tp_Info;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pb_Connect;
        private System.Windows.Forms.Button bt_Connect;
        private System.Windows.Forms.ComboBox cb_StopBit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_Parity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_DataSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_Baud;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Com;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_Receive;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_Send5;
        private System.Windows.Forms.Button bt_Send4;
        private System.Windows.Forms.Button bt_Send3;
        private System.Windows.Forms.Button bt_Send2;
        private System.Windows.Forms.TextBox tb_Send1;
        private System.Windows.Forms.TextBox tb_Send2;
        private System.Windows.Forms.Button bt_Send1;
        private System.Windows.Forms.TextBox tb_Send5;
        private System.Windows.Forms.TextBox tb_Send3;
        private System.Windows.Forms.TextBox tb_Send4;
        public System.Windows.Forms.TabControl tbctl_Serial;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort sp_Serial;
        private ZedGraph.ZedGraphControl zedGraph;
        private System.Windows.Forms.Button bt_ClearGraph;
        private System.Windows.Forms.Button bt_ResetCoor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_8;
        private System.Windows.Forms.Button bt_Round;
        private System.Windows.Forms.TextBox tb_w;
        private System.Windows.Forms.TextBox tb_v;
        private System.Windows.Forms.TextBox tb_Theta;
        private System.Windows.Forms.TextBox tb_Y;
        private System.Windows.Forms.TextBox tb_X;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bt_Rect;
        private System.Windows.Forms.TabPage tp_PID;
        private System.Windows.Forms.Button bt_Sendw2;
        private System.Windows.Forms.TextBox tb_w2;
        private System.Windows.Forms.Button bt_Sendw1;
        private System.Windows.Forms.TextBox tb_w1;
        private System.Windows.Forms.Button bt_Sendv2;
        private System.Windows.Forms.TextBox tb_v2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button bt_Sendv1;
        private System.Windows.Forms.Button bt_SendPID;
        private System.Windows.Forms.TextBox tb_v1;
        private System.Windows.Forms.Label lbX;
        private System.Windows.Forms.TextBox tb_Kd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_Ki;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_Kp;
        private System.Windows.Forms.Label label11;
        private ZedGraph.ZedGraphControl zg_left;
        private ZedGraph.ZedGraphControl zg_v;
        private ZedGraph.ZedGraphControl zg_right;
        private ZedGraph.ZedGraphControl zg_w;
        private System.Windows.Forms.Timer timer2;
    }
}

