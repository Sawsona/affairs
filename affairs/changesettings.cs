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
    public partial class changesettings : Form
    {
        public changesettings()
        {
            InitializeComponent();
        }

        private void changesettings_Load(object sender, EventArgs e)
        {
            username.Text = Properties.Settings.Default.username;
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.username = username.Text;
            Properties.Settings.Default.Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == Properties.Settings.Default.password)
            {
                if (textBox3.Text == textBox2.Text)
                {
                    Properties.Settings.Default.password = textBox2.Text;
                    Properties.Settings.Default.Save();
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();

                }
                else
                    label5.Visible = true;
            }
            else
                label6.Visible = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                textBox2.Focus();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                textBox3.Focus();
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                button1.PerformClick();
            }
        }
    }
}
