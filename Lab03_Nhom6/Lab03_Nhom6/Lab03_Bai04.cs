using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_Nhom6
{
    public partial class Lab03_Bai04 : Form
    {
        public Lab03_Bai04()
        {
            InitializeComponent();
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            Form server = new Server();
            server.Show();
            btnServer.Enabled = false;
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            Form client = new Client();
            client.Show();
        }
    }
}
