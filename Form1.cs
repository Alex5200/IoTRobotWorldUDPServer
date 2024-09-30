using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Drawing.Printing;
using System.Globalization;

namespace IoTRobotWorldUDPServer
{
    public partial class Form1 : Form
    {
        bool Automatization = false;

        const int CMaxVisibleLogLines = 10;

        string UDPReceiveBuffer = "";

        string remoteAddress; // хост для отправки данных
        int remotePort; // порт для отправки данных
        int localPort; // локальный порт для прослушивания входящих подключений
        int currentCommanNumber = 0;
        int lastCommanNumber = 0;
        public delegate void ShowUDPMessage(string message);
        public ShowUDPMessage myDelegate;
        UdpClient udpClient; // = new UdpClient(11000);
        Thread thread;

        string[] dataForSave = {"az", "d1", "d2", "d3", "d4", "d5", "d6", "d7" };
        int d1, d2, d3, d4, d5, d6, d7, le = 0;
        float x, y, re = 0;
        int az = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Создадим делегата метода распечатки сообщения от удаленного сервера
            myDelegate = new ShowUDPMessage(ShowUDPMessageMethod);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            StopUDPClient();
        }

        private void PrintLog(string s)
        {
            // CMaxVisibleLogLines
            ReportListBox.Items.Add(s);
            while (ReportListBox.Items.Count > CMaxVisibleLogLines)
            {
                ReportListBox.Items.RemoveAt(0);
            }
            ReportListBox.SelectedIndex = ReportListBox.Items.Count - 1;
            ReportListBox.SelectedIndex = -1;
        }

        private void CheckStartStopUDPClient()
        {
            if (udpClient != null)
            {
                StartStopUDPClientButton.Text = "Stop";
                RemoteIPTextBox.Enabled = false;
                RemoteIPTextBox.BackColor = Color.LightGray;
                RemotePortTextBox.Enabled = false;
                RemotePortTextBox.BackColor = Color.LightGray;
                LocalIPTextBox.Enabled = false;
                LocalIPTextBox.BackColor = Color.LightGray;
                LocalPortTextBox.Enabled = false;
                LocalPortTextBox.BackColor = Color.LightGray;
            }
            else
            {
                StartStopUDPClientButton.Text = "Start";
                RemoteIPTextBox.Enabled = true;
                RemoteIPTextBox.BackColor = Color.White;
                RemotePortTextBox.Enabled = true;
                RemotePortTextBox.BackColor = Color.White;
                LocalIPTextBox.Enabled = true;
                LocalIPTextBox.BackColor = Color.White;
                LocalPortTextBox.Enabled = true;
                LocalPortTextBox.BackColor = Color.White;
            }
        }

        private void StopUDPClient()
        {
            if ((thread != null) && (udpClient != null))
            { 
                thread.Abort();
                udpClient.Close();
                thread = null;
                udpClient = null;
            }
            PrintLog("UDPClient stopped");
            CheckStartStopUDPClient();
        }

        private void StartUDPClient()
        {
            if (thread != null)
            {
                thread.Abort();
            }
            if (udpClient != null)
            {
                udpClient.Close();
            }

            localPort = Int32.Parse(LocalPortTextBox.Text);
            try
            {
                udpClient = new UdpClient(localPort);
                thread = new Thread(new ThreadStart(ReceiveUDPMessage));
                thread.IsBackground = true;
                thread.Start();
                PrintLog("UDPClient started");
            }
            catch
            {
                PrintLog("UDPClient's start failed");
            }
            CheckStartStopUDPClient();
        }
       
        private void StartStopUDPClientButton_Click(object sender, EventArgs e)
        {
            if (udpClient == null)
            {
                StartUDPClient();
            }
            else
            {
                StopUDPClient();
            }
        }

        private void ShowUDPMessageMethod(string message)
        {
            PrintLog("Remote >" + message);
        }

        private void ReceiveUDPMessage()
        {
            string oldError = "";
            string oldMassage = null;
            while (true)
            {
                try
                {
                    string[] valuesToChek =  textBox1.Text.Split(','); 
                    IPEndPoint remoteIPEndPoint = new IPEndPoint(IPAddress.Any, 0); // port);
                    byte[] content = udpClient.Receive(ref remoteIPEndPoint);
                    if (content.Length > 0)
                    {
                        string message = Encoding.ASCII.GetString(content);
                        string[] allMassage = message.Split(',');
                        string correctMassage = null;

                        for (int i = 0; i <= allMassage.Length; i++)
                        {
                            foreach( string values in valuesToChek)
                            {
                                if (allMassage[i].Contains("az"))
                                    az = Convert.ToInt32(allMassage[i].Split(':')[1].Trim(new Char[] { '"' }));
                                else if (allMassage[i].Contains("d1"))
                                    d1 = Convert.ToInt32(allMassage[i].Split(':')[1].Trim(new Char[] { '"' }));
                                else if (allMassage[i].Contains("d2"))
                                    d2 = Convert.ToInt32(allMassage[i].Split(':')[1].Trim(new Char[] { '"' }));
                                else if (allMassage[i].Contains("d3"))
                                    d3 = Convert.ToInt32(allMassage[i].Split(':')[1].Trim(new Char[] { '"' }));
                                else if (allMassage[i].Contains("d4"))
                                    d4 = Convert.ToInt32(allMassage[i].Split(':')[1].Trim(new Char[] { '"' }));
                                else if (allMassage[i].Contains("d5"))
                                    d5 = Convert.ToInt32(allMassage[i].Split(':')[1].Trim(new Char[] { '"' }));
                                else if (allMassage[i].Contains("d6"))
                                    d6 = Convert.ToInt32(allMassage[i].Split(':')[1].Trim(new Char[] { '"' }));
                                else if (allMassage[i].Contains("d7"))
                                    d7 = Convert.ToInt32(allMassage[i].Split(':')[1].Trim(new Char[] { '"' }));
                                else if (allMassage[i].Contains("x"))
                                    x = float.Parse(allMassage[i].Split(':')[1].Trim(new Char[] { '"' }), CultureInfo.InvariantCulture.NumberFormat);
                                else if (allMassage[i].Contains("y"))
                                    y = float.Parse(allMassage[i].Split(':')[1].Trim(new Char[] { '"' }), CultureInfo.InvariantCulture.NumberFormat);
                                else if (allMassage[i].Contains("le"))
                                    le = Convert.ToInt32(allMassage[i].Split(':')[1].Trim(new Char[] { '"' }));
                                else if (allMassage[i].Contains("t"))
                                    re = float.Parse(allMassage[i].Split(':')[1].Trim(new Char[] { '"' }));
                                

                                if (allMassage[i].Contains('n'))
                                {
                                    var getData = allMassage[i].Split(':');
                                    var commandNumber = getData[1].Trim(new Char[] { '"' });
                                    lastCommanNumber = Int32.Parse(commandNumber);
                                    currentCommanNumber = lastCommanNumber;
                                }
                                if (allMassage[i].Contains(values) )
                                {
                                    correctMassage += String.Join(" ", allMassage[i]);
                                    if (correctMassage.Length >= (textBox1.Text.Length * 1))
                                    {
                                        this.Invoke(myDelegate, new object[] { correctMassage + "\n" });
                                    }
                                }
                            }
                            

                        }
                    }
                }
                catch (Exception ex) 
                {
                    if (ex.ToString() != oldError)
                    {
                        this.Invoke(myDelegate, new object[] { ex.ToString() });
                        oldError = ex.ToString();
                    }
                }
            }
        }

        private void SendUDPMessage(string s)
        {
            if (udpClient != null)
            {
                Int32 port = Int32.Parse(RemotePortTextBox.Text); 
                IPAddress ip = IPAddress.Parse(RemoteIPTextBox.Text.Trim());
                IPEndPoint ipEndPoint = new IPEndPoint(ip,port);
                byte[] content = Encoding.ASCII.GetBytes(s);
                try
                {
                    int count = udpClient.Send(content, content.Length, ipEndPoint);
                    if (count > 0)
                    {
                        PrintLog("Message has been sent.");
                    }
                }
                catch
                {
                    PrintLog("Error occurs.");
                }

            }
        }

        private void SendUDPMessageButton_Click(object sender, EventArgs e)
        {
            string s = UDPMessageTextBox.Text;
            if (AppendLFSymbolCheckBox.Checked) { s += "\n"; };
            SendUDPMessage(s);
        }

        private void RegularUDPSendCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (RegularUDPSendCheckBox.Checked)
            {
                UDPRegularSenderTimer.Enabled = true;
            }
            else
            {
                UDPRegularSenderTimer.Enabled = false;
            }
        }

        private void UDPRegularSenderTimer_Tick(object sender, EventArgs e)
        {
            SendUDPMessage(UDPMessageTextBox.Text);
        }

        private void RemotePortTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Automatization == false)
            {
                Automatization = true;
                button1.Text = "Stop";
                button1.BackColor = Color.Red;
            }
            else
            {
                Automatization = false;
                button1.Text = "Start Automatization";
                button1.BackColor = Color.White;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        int counter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(re) + " : " + Convert.ToString(y);

            if (Automatization)
            {
                if(counter == 0)
                {
                    currentCommanNumber += 1;
                    if (y <= 6.4)
                    {
                        SendUDPMessage(@"{ ""N"":" + (currentCommanNumber) + @", ""M"":0, ""F"":80, ""B"":0, ""T"":0}" + "\n");
                        SendUDPMessage(@"{ ""N"":" + (currentCommanNumber) + @", ""M"":0, ""F"":80, ""B"":0, ""T"":0}" + "\n");
                    }
                    else
                    {
                        //SendUDPMessage(@"{ ""N"":" + (currentCommanNumber) + @", ""M"":0, ""F"":0, ""B"":0, ""T"":0}" + "\n");
                        //SendUDPMessage(@"{ ""N"":" + (currentCommanNumber) + @", ""M"":0, ""F"":0, ""B"":0, ""T"":0}" + "\n");
                        if(az < 40)
                        {
                            SendUDPMessage(@"{ ""N"":" + (currentCommanNumber) + @", ""M"":0, ""F"":0, ""B"":90, ""T"":0}" + "\n");
                            SendUDPMessage(@"{ ""N"":" + (currentCommanNumber) + @", ""M"":0, ""F"":0, ""B"":90, ""T"":0}" + "\n");
                        }
                        else if (az <= 50)
                        {
                            SendUDPMessage(@"{ ""N"":" + (currentCommanNumber) + @", ""M"":0, ""F"":0, ""B"":10, ""T"":0}" + "\n");
                            SendUDPMessage(@"{ ""N"":" + (currentCommanNumber) + @", ""M"":0, ""F"":0, ""B"":10, ""T"":0}" + "\n");
                        }
                        //else if (az > 51){
                        //    SendUDPMessage(@"{ ""N"":" + (currentCommanNumber) + @", ""M"":0, ""F"":0, ""B"":-10, ""T"":0}" + "\n");
                        //    SendUDPMessage(@"{ ""N"":" + (currentCommanNumber) + @", ""M"":0, ""F"":0, ""B"":-10, ""T"":0}" + "\n");
                        //}
                        else
                        {
                            SendUDPMessage(@"{ ""N"":" + (currentCommanNumber) + @", ""M"":0, ""F"":0, ""B"":0, ""T"":0}" + "\n");
                            SendUDPMessage(@"{ ""N"":" + (currentCommanNumber) + @", ""M"":0, ""F"":0, ""B"":0, ""T"":0}" + "\n");
                        }
                    }

                }
                //if (az >= 0 && az <= 1 )
                //{
                //    if( x <= 6.5)
                //        SendUDPMessage(@"{ ""N"":" + (currentCommanNumber += 1) + @", ""M"":0, ""F"":80, ""B"":0, ""T"":0}" + "\n");
                //        SendUDPMessage(@"{ ""N"":" + (currentCommanNumber) + @", ""M"":0, ""F"":80, ""B"":0, ""T"":0}" + "\n");
                //    else if (x <= 6.7)
                //        SendUDPMessage(@"{ ""N"":" + (currentCommanNumber += 1) + @", ""M"":0, ""F"":40, ""B"":0, ""T"":0}" + "\n");
                //        SendUDPMessage(@"{ ""N"":" + (currentCommanNumber) + @", ""M"":0, ""F"":40, ""B"":0, ""T"":0}" + "\n");
                //    else if (x >= 6.7 && x < 6.8)
                //        SendUDPMessage(@"{ ""N"":" + (currentCommanNumber += 1) + @", ""M"":0, ""F"":0, ""B"":0, ""T"":0}" + "\n");
                //        SendUDPMessage(@"{ ""N"":" + (currentCommanNumber) + @", ""M"":0, ""F"":0, ""B"":0, ""T"":0}" + "\n
                //}
                //else if ((az >= (3) && az <= (10) && !orintation)){
                //    SendUDPMessage(@"{ ""N"":" + (currentCommanNumber += 1) + @", ""M"":0, ""F"":40, ""B"":-1, ""T"":0}" + "\n");
                //    SendUDPMessage(@"{ ""N"":" + (currentCommanNumber) + @", ""M"":0, ""F"":40, ""B"":-1, ""T"":0}" + "\n");
                //}
                //else if ((az <= (358) && az >= (340) && !orintation))
                //{
                //    SendUDPMessage(@"{ ""N"":" + (currentCommanNumber += 1) + @", ""M"":0, ""F"":40, ""B"":4, ""T"":0}" + "\n");
                //    SendUDPMessage(@"{ ""N"":" + (currentCommanNumber) + @", ""M"":0, ""F"":40, ""B"":4, ""T"":0}" + "\n");
                //}
                //else if ((az <= (360/2 + 2)) && !orintation)
                //{
                //    SendUDPMessage(@"{ ""N"":" + (currentCommanNumber += 1) + @", ""M"":0, ""F"":0, ""B"":-10, ""T"":0}" + "\n");
                //    SendUDPMessage(@"{ ""N"":" + (currentCommanNumber) + @", ""M"":0, ""F"":0, ""B"":-10, ""T"":0}" + "\n");

                //}else if ((az >= (360 / 2 - 4)) && !orintation)
                //{
                //    SendUDPMessage(@"{ ""N"":" + (currentCommanNumber += 1) + @", ""M"":0, ""F"":0, ""B"":10, ""T"":0}" + "\n");
                //    SendUDPMessage(@"{ ""N"":" + (currentCommanNumber) + @", ""M"":0, ""F"":0, ""B"":10, ""T"":0}" + "\n")
                //}  
            }
        }
        private void AppendLFSymbolCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
