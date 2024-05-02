using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace affairs
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text==Properties.Settings.Default.username && textBox2.Text== Properties.Settings.Default.password)
            {
                this.Visible = false;
            }
            else if(textBox1.Text != Properties.Settings.Default.username && textBox2.Text != Properties.Settings.Default.password)
            {
                textBox1.Clear();
                textBox2.Clear();
                MessageBox.Show("المعلومات غير متطابقه");
            }
            else if (textBox2.Text != Properties.Settings.Default.password)
            {
                textBox2.Clear();
                MessageBox.Show("كلمه مرور خاطئه");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
            }
        }
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
    }
}
