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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormZakaz af  = new FormZakaz();
            af.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Icar af = new Icar();
            af.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Retro af = new Retro();
            af.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Skidka af = new Skidka();
            af.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LadaGusarov af = new LadaGusarov();
            af.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SportGT af = new SportGT();
            af.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UrbanCross af = new UrbanCross();
            af.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DragenWagen af = new DragenWagen();
            af.Show();
            this.Hide();
        }
    }
}
