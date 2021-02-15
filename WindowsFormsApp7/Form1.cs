using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //WindowState = FormWindowState.Minimized;
            if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
            else
            WindowState = FormWindowState.Maximized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double tutar = Convert.ToDouble(textBox1.Text);
            double KDV=0,toplam;
            if(radioButton1.Checked)
            {
                KDV = tutar * 0.08;
            }
            else if (radioButton2.Checked)
            {
                KDV = tutar * 0.18;
            }
            toplam = tutar + KDV;
            textBox2.Text = toplam.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
