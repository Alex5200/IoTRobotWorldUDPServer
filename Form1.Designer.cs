namespace IoTRobotWorldUDPServer
{
    partial class Form
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button button1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RemoteIPTextBox = new System.Windows.Forms.TextBox();
            this.RemotePortTextBox = new System.Windows.Forms.TextBox();
            this.LocalPortTextBox = new System.Windows.Forms.TextBox();
            this.LocalIPTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.UDPMessageTextBox = new System.Windows.Forms.TextBox();
            this.SendUDPMessageButton = new System.Windows.Forms.Button();
            this.ReportListBox = new System.Windows.Forms.ListBox();
            this.StartStopUDPClientButton = new System.Windows.Forms.Button();
            this.UDPRegularSenderTimer = new System.Windows.Forms.Timer(this.components);
            this.RegularUDPSendCheckBox = new System.Windows.Forms.CheckBox();
            this.AppendLFSymbolCheckBox = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.d_0 = new System.Windows.Forms.TextBox();
            this.d_1 = new System.Windows.Forms.TextBox();
            this.d_3 = new System.Windows.Forms.TextBox();
            this.d_2 = new System.Windows.Forms.TextBox();
            this.d_7 = new System.Windows.Forms.TextBox();
            this.d_6 = new System.Windows.Forms.TextBox();
            this.d_5 = new System.Windows.Forms.TextBox();
            this.d_4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Remote IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Remote Port";
            // 
            // RemoteIPTextBox
            // 
            this.RemoteIPTextBox.Location = new System.Drawing.Point(108, 9);
            this.RemoteIPTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RemoteIPTextBox.Name = "RemoteIPTextBox";
            this.RemoteIPTextBox.Size = new System.Drawing.Size(148, 26);
            this.RemoteIPTextBox.TabIndex = 2;
            this.RemoteIPTextBox.Text = "127.0.0.1";
            // 
            // RemotePortTextBox
            // 
            this.RemotePortTextBox.Location = new System.Drawing.Point(108, 58);
            this.RemotePortTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RemotePortTextBox.Name = "RemotePortTextBox";
            this.RemotePortTextBox.Size = new System.Drawing.Size(148, 26);
            this.RemotePortTextBox.TabIndex = 3;
            this.RemotePortTextBox.Text = "8888";
            this.RemotePortTextBox.TextChanged += new System.EventHandler(this.RemotePortTextBox_TextChanged);
            // 
            // LocalPortTextBox
            // 
            this.LocalPortTextBox.Location = new System.Drawing.Point(360, 58);
            this.LocalPortTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LocalPortTextBox.Name = "LocalPortTextBox";
            this.LocalPortTextBox.Size = new System.Drawing.Size(148, 26);
            this.LocalPortTextBox.TabIndex = 7;
            this.LocalPortTextBox.Text = "7777";
            // 
            // LocalIPTextBox
            // 
            this.LocalIPTextBox.Location = new System.Drawing.Point(360, 9);
            this.LocalIPTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LocalIPTextBox.Name = "LocalIPTextBox";
            this.LocalIPTextBox.Size = new System.Drawing.Size(148, 26);
            this.LocalIPTextBox.TabIndex = 6;
            this.LocalIPTextBox.Text = "127.0.0.1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Local Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Local IP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 146);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Message";
            // 
            // UDPMessageTextBox
            // 
            this.UDPMessageTextBox.Location = new System.Drawing.Point(105, 146);
            this.UDPMessageTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UDPMessageTextBox.Name = "UDPMessageTextBox";
            this.UDPMessageTextBox.Size = new System.Drawing.Size(372, 26);
            this.UDPMessageTextBox.TabIndex = 9;
            this.UDPMessageTextBox.Text = "{\"N\":1, \"M\":0, \"F\":50, \"B\":10, \"T\":0}";
            // 
            // SendUDPMessageButton
            // 
            this.SendUDPMessageButton.Location = new System.Drawing.Point(105, 180);
            this.SendUDPMessageButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SendUDPMessageButton.Name = "SendUDPMessageButton";
            this.SendUDPMessageButton.Size = new System.Drawing.Size(112, 43);
            this.SendUDPMessageButton.TabIndex = 10;
            this.SendUDPMessageButton.Text = "Send";
            this.SendUDPMessageButton.UseVisualStyleBackColor = true;
            this.SendUDPMessageButton.Click += new System.EventHandler(this.SendUDPMessageButton_Click);
            // 
            // ReportListBox
            // 
            this.ReportListBox.FormattingEnabled = true;
            this.ReportListBox.ItemHeight = 20;
            this.ReportListBox.Location = new System.Drawing.Point(24, 232);
            this.ReportListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ReportListBox.Name = "ReportListBox";
            this.ReportListBox.ScrollAlwaysVisible = true;
            this.ReportListBox.Size = new System.Drawing.Size(564, 184);
            this.ReportListBox.TabIndex = 11;
            // 
            // StartStopUDPClientButton
            // 
            this.StartStopUDPClientButton.Location = new System.Drawing.Point(520, 17);
            this.StartStopUDPClientButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StartStopUDPClientButton.Name = "StartStopUDPClientButton";
            this.StartStopUDPClientButton.Size = new System.Drawing.Size(81, 65);
            this.StartStopUDPClientButton.TabIndex = 12;
            this.StartStopUDPClientButton.Text = "Start";
            this.StartStopUDPClientButton.UseVisualStyleBackColor = true;
            this.StartStopUDPClientButton.Click += new System.EventHandler(this.StartStopUDPClientButton_Click);
            // 
            // UDPRegularSenderTimer
            // 
            this.UDPRegularSenderTimer.Interval = 1000;
            this.UDPRegularSenderTimer.Tick += new System.EventHandler(this.UDPRegularSenderTimer_Tick);
            // 
            // RegularUDPSendCheckBox
            // 
            this.RegularUDPSendCheckBox.AutoSize = true;
            this.RegularUDPSendCheckBox.Location = new System.Drawing.Point(291, 197);
            this.RegularUDPSendCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RegularUDPSendCheckBox.Name = "RegularUDPSendCheckBox";
            this.RegularUDPSendCheckBox.Size = new System.Drawing.Size(199, 24);
            this.RegularUDPSendCheckBox.TabIndex = 13;
            this.RegularUDPSendCheckBox.Text = "Send message regular ";
            this.RegularUDPSendCheckBox.UseVisualStyleBackColor = true;
            this.RegularUDPSendCheckBox.CheckedChanged += new System.EventHandler(this.RegularUDPSendCheckBox_CheckedChanged);
            // 
            // AppendLFSymbolCheckBox
            // 
            this.AppendLFSymbolCheckBox.AutoSize = true;
            this.AppendLFSymbolCheckBox.Checked = true;
            this.AppendLFSymbolCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AppendLFSymbolCheckBox.Location = new System.Drawing.Point(486, 149);
            this.AppendLFSymbolCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AppendLFSymbolCheckBox.Name = "AppendLFSymbolCheckBox";
            this.AppendLFSymbolCheckBox.Size = new System.Drawing.Size(114, 24);
            this.AppendLFSymbolCheckBox.TabIndex = 14;
            this.AppendLFSymbolCheckBox.Text = "Append LF";
            this.AppendLFSymbolCheckBox.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 102);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(372, 26);
            this.textBox1.TabIndex = 17;
            this.textBox1.Text = " d1,d2,d3";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 106);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Filter Input";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // d_0
            // 
            this.d_0.Location = new System.Drawing.Point(638, 17);
            this.d_0.Name = "d_0";
            this.d_0.Size = new System.Drawing.Size(100, 26);
            this.d_0.TabIndex = 18;
            // 
            // d_1
            // 
            this.d_1.Location = new System.Drawing.Point(638, 55);
            this.d_1.Name = "d_1";
            this.d_1.Size = new System.Drawing.Size(100, 26);
            this.d_1.TabIndex = 19;
            // 
            // d_3
            // 
            this.d_3.Location = new System.Drawing.Point(638, 138);
            this.d_3.Name = "d_3";
            this.d_3.Size = new System.Drawing.Size(100, 26);
            this.d_3.TabIndex = 21;
            // 
            // d_2
            // 
            this.d_2.Location = new System.Drawing.Point(638, 100);
            this.d_2.Name = "d_2";
            this.d_2.Size = new System.Drawing.Size(100, 26);
            this.d_2.TabIndex = 20;
            // 
            // d_7
            // 
            this.d_7.Location = new System.Drawing.Point(638, 302);
            this.d_7.Name = "d_7";
            this.d_7.Size = new System.Drawing.Size(100, 26);
            this.d_7.TabIndex = 25;
            // 
            // d_6
            // 
            this.d_6.Location = new System.Drawing.Point(638, 263);
            this.d_6.Name = "d_6";
            this.d_6.Size = new System.Drawing.Size(100, 26);
            this.d_6.TabIndex = 24;
            // 
            // d_5
            // 
            this.d_5.Location = new System.Drawing.Point(638, 218);
            this.d_5.Name = "d_5";
            this.d_5.Size = new System.Drawing.Size(100, 26);
            this.d_5.TabIndex = 23;
            // 
            // d_4
            // 
            this.d_4.Location = new System.Drawing.Point(638, 180);
            this.d_4.Name = "d_4";
            this.d_4.Size = new System.Drawing.Size(100, 26);
            this.d_4.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(624, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Статус захвата";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(628, 354);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(122, 33);
            button1.TabIndex = 27;
            button1.UseVisualStyleBackColor = true;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 437);
            this.Controls.Add(button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.d_7);
            this.Controls.Add(this.d_6);
            this.Controls.Add(this.d_5);
            this.Controls.Add(this.d_4);
            this.Controls.Add(this.d_3);
            this.Controls.Add(this.d_2);
            this.Controls.Add(this.d_1);
            this.Controls.Add(this.d_0);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AppendLFSymbolCheckBox);
            this.Controls.Add(this.RegularUDPSendCheckBox);
            this.Controls.Add(this.StartStopUDPClientButton);
            this.Controls.Add(this.ReportListBox);
            this.Controls.Add(this.SendUDPMessageButton);
            this.Controls.Add(this.UDPMessageTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LocalPortTextBox);
            this.Controls.Add(this.LocalIPTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RemotePortTextBox);
            this.Controls.Add(this.RemoteIPTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form";
            this.Text = "IoTRobotWorldUDPServer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RemoteIPTextBox;
        private System.Windows.Forms.TextBox RemotePortTextBox;
        private System.Windows.Forms.TextBox LocalPortTextBox;
        private System.Windows.Forms.TextBox LocalIPTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox UDPMessageTextBox;
        private System.Windows.Forms.Button SendUDPMessageButton;
        private System.Windows.Forms.ListBox ReportListBox;
        private System.Windows.Forms.Button StartStopUDPClientButton;
        private System.Windows.Forms.Timer UDPRegularSenderTimer;
        private System.Windows.Forms.CheckBox RegularUDPSendCheckBox;
        private System.Windows.Forms.CheckBox AppendLFSymbolCheckBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox d_0;
        private System.Windows.Forms.TextBox d_3;
        private System.Windows.Forms.TextBox d_2;
        private System.Windows.Forms.TextBox d_7;
        private System.Windows.Forms.TextBox d_6;
        private System.Windows.Forms.TextBox d_5;
        private System.Windows.Forms.TextBox d_4;
        private System.Windows.Forms.TextBox d_1;
        private System.Windows.Forms.Label label7;
    }
}

