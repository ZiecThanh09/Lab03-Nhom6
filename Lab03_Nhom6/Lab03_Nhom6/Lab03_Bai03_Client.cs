using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Lab03_Nhom6
{
    public partial class Lab03_Bai03_Client : Form
    {
        TcpClient tcpClient;
        IPEndPoint ipepClient;
        NetworkStream networkStream;

        public Lab03_Bai03_Client()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            tcpClient = new TcpClient();
            try
            {
                IPAddress address = IPAddress.Parse(tbIPAddress.Text.ToString());
                ipepClient = new IPEndPoint(address, int.Parse(tbPort.Text));
                tcpClient.Connect(ipepClient);
                networkStream = tcpClient.GetStream();
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đúng địa chỉ IP và số cổng", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (tbMessage.Text == "quit\n")
            {
                Byte[] data = Encoding.UTF8.GetBytes(tbMessage.Text);
                networkStream.Write(data, 0, data.Length);
                networkStream.Close();
                tcpClient.Close();
            }
            else
            {
                Byte[] data = Encoding.UTF8.GetBytes(tbMessage.Text);
                networkStream.Write(data, 0, data.Length);
                tbMessage.Clear();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (tcpClient.Connected)
            {
                networkStream.Close();
                tcpClient.Close();
                MessageBox.Show("Closed Connection!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else Close();
        }
    }
}
