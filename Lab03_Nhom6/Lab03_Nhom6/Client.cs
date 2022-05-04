using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace Lab03_Nhom6
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }
        private TcpClient tcpClient;
        private string data;
        private const int serverPort = 8080;
        private Thread clientThread;
        private StreamReader sReader;
        private StreamWriter sWriter;
        private bool stoptcpClient = true;

        private delegate void SafeCallDelegate(string text);

        private void UpdateChatHistorySafeCall(string text)
        {
            if (tbContent.InvokeRequired)
            {
                var d = new SafeCallDelegate(UpdateChatHistorySafeCall);
                tbContent.Invoke(d, new object[] { text });
            }
            else
            {
                tbContent.Text += text + "\r\n";
            }
        }

        private void ClientReceive()
        {
            sReader = new StreamReader(tcpClient.GetStream());
            while (!stoptcpClient && tcpClient.Connected)
            {
                Application.DoEvents();
                string rcvdata = sReader.ReadLine();
                UpdateChatHistorySafeCall(rcvdata);
            }

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                stoptcpClient = false;
                tcpClient = new TcpClient();
                IPAddress serverIP = IPAddress.Parse(tbIP.Text);
                IPEndPoint endPoint = new IPEndPoint(serverIP, serverPort);

                tcpClient.Connect(endPoint);
                sWriter = new StreamWriter(tcpClient.GetStream());
                sWriter.AutoFlush = true;
                sWriter.WriteLine(tbUsername.Text);

                clientThread = new Thread(ClientReceive);
                clientThread.Start();

                tbContent.Text = "You connected to server!\r\n";
                btnConnect.Enabled = false;
                btnSend.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSend_Click_1(object sender, EventArgs e)
        {
            try
            {
                data = tbMessage.Text;
                sWriter.WriteLine(data);            
                tbMessage.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDisconnect_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Disconnected to the server!");
            this.Close();        
        }
    }
}
