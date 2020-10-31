using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server_Tsaqif_109
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOn_Click(object sender, EventArgs e)
        {
            label2.Text = "Server On";
            label3.Text = "Klik OFF untuk Mematikan Server";
            buttonOn.Enabled = false;
            buttonOff.Enabled = true;

        }

        private void buttonOff_Click(object sender, EventArgs e)
        {
            label2.Text = "Server Off";
            label3.Text = "Klik ON untuk Menghidupkan Server";
            buttonOn.Enabled = true;
            buttonOff.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonOn.Enabled = true;
            buttonOff.Enabled = false;
        }
    }
}
