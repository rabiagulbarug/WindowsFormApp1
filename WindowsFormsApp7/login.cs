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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="a"&&textBox2.Text=="1")
            {
                //MessageBox.Show("Giriş Başarılı");
                Form1 frm = new Form1();
                frm.Show();
                Hide();
            }
            else
            { 
                MessageBox.Show("Giriş Başarısız");
                textBox1.Text = String.Empty;
                textBox2.Text = String.Empty;
            }

        }
    }
}
