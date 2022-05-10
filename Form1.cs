using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ddos_Panel_For_Leak.to
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedButton1_Click(object sender, EventArgs e)
        {
            string whitelist = new System.Net.WebClient() { Proxy = null }.DownloadString("https://pastebin.com/0YPMcxVH");
            if (whitelist.Contains(TextBox1.Text))
            {
                MessageBox.Show("Welcome!");
                Form2 frm2 = new Form2();
                frm2.Show();
                this.Hide();
            }
        }   

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
