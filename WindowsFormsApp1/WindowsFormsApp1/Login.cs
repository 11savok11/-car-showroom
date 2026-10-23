using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        private bool isHandlingCheck = false;
        public Login()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (isHandlingCheck) return;
            if (radioButton1.Checked)
            {
                Caphca captchaForm = new Caphca();
                if (captchaForm.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Вы на 101% гей!");
                    radioButton1.Checked = true;
                    radioButton1.Enabled = false;
                }
                else
                {

                    isHandlingCheck = true;
                    radioButton1.Checked = false;
                    isHandlingCheck = false;
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
        }
        private void button3_Click(object sender, EventArgs e)
        {
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }
        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }
    }
}
