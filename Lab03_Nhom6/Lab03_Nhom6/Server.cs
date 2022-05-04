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
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }

        private Thread listenThread;
        private TcpListener tcpListener;
        private bool stopChatServer = true;
        private readonly int _serverPort = 8080;
        private Dictionary<string, TcpClient> dict = new Dictionary<string, TcpClient>();

        public void Listen()
        {
            try
            {
                tcpListener = new TcpListener(new IPEndPoint(IPAddress.Any, _serverPort));
                tcpListener.Start();

                while (!stopChatServer)
                {
                    TcpClient _client = tcpListener.AcceptTcpClient();
                    StreamReader sReader = new StreamReader(_client.GetStream());
                    StreamWriter sWriter = new StreamWriter(_client.GetStream());
                    sWriter.AutoFlush = true;
                    string username = sReader.ReadLine();

                    if (username == null)
                        sWriter.WriteLine("Please enter a username!");
                    else if (!dict.ContainsKey(username))
                    {
                        Thread clientThread = new Thread(() => ClientReceive(username, _client));
                        dict.Add(username, _client);
                        clientThread.Start();

                    }
                    else
                        sWriter.WriteLine("Username already exists!");

                }
            }
            catch (SocketException socketException)
            {
                MessageBox.Show(socketException.Message);
            }

        }

        private delegate void SafeCallDelegete(string text);
        private void UpdateChatHistorySafeCall(string text)
        {
            if (tbContent.InvokeRequired)
            {
                var d = new SafeCallDelegete(UpdateChatHistorySafeCall);
                tbContent.Invoke(d, new object[] { text });
            }
            else
            {
                if (text[text.Length - 1] == '\n')
                    tbContent.Text += text;
                else
                    tbContent.Text += text + "\r\n";
            }
        }

        public void ClientReceive(string username, TcpClient tcpClient)
        {
            StreamReader streamReader = new StreamReader(tcpClient.GetStream());
            while (!stopChatServer)
            {
                Application.DoEvents();
                string message = streamReader.ReadLine();
                string formattedMessage = $"{username }: {message}";

                foreach (TcpClient otherClient in dict.Values)
                {
                    StreamWriter streamWriter = new StreamWriter(otherClient.GetStream());
                    streamWriter.WriteLine(formattedMessage);
                    streamWriter.AutoFlush = true;
                }
                UpdateChatHistorySafeCall(formattedMessage);
            }
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            if (stopChatServer)
            {
                stopChatServer = false;
                listenThread = new Thread(new ThreadStart(Listen));
                listenThread.Start();
                tbContent.Text = "Listening from clients...\r\n";
                btnListen.Text = @"Stop";
            }
            else
            {
                stopChatServer = true;
                tcpListener.Stop();
                listenThread = null;
                btnListen.Text = @"Listen";
            }
        }
        private void btClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
