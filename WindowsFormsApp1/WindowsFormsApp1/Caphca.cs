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
    public partial class Caphca : Form
    {
        private string text = String.Empty;
        private Bitmap CreateImage(int Width, int Height)
        {
            Random rnd = new Random();
            Bitmap result = new Bitmap(Width, Height);
            int Xpos = rnd.Next(0, Width - 50);
            int Ypos = rnd.Next(15, Height - 15);
            Brush[] colors = { Brushes.Black,
                               Brushes.Red,
                               Brushes.RoyalBlue,
                               Brushes.Green };
            using (Graphics g = Graphics.FromImage(result))
            {
                g.Clear(Color.Gray);
                text = String.Empty;
                string ALF = "1234567890QWERTYUIOPASDFGHJKLZXCVBNM";
                for (int i = 0; i < 5; ++i)
                    text += ALF[rnd.Next(ALF.Length)];
                g.DrawString(text,
                             new Font("Arial", 15),
                             colors[rnd.Next(colors.Length)],
                             new PointF(Xpos, Ypos));
                g.DrawLine(Pens.Black,
                           new Point(0, 0),
                           new Point(Width - 1, Height - 1));
                g.DrawLine(Pens.Black,
                           new Point(0, Height - 1),
                           new Point(Width - 1, 0));
            }
            for (int i = 0; i < Width; ++i)
                for (int j = 0; j < Height; ++j)
                    if (rnd.Next() % 20 == 0)
                        result.SetPixel(i, j, Color.White);
            return result;
        }
        public Caphca()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToUpper() == this.text)
            {
                MessageBox.Show("Верно!");
                this.DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("САСИ)00)))0)");
                textBox1.Clear();
                pictureBox1.Image = this.CreateImage(pictureBox1.Width, pictureBox1.Height);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = this.CreateImage(pictureBox1.Width, pictureBox1.Height);
        }

        private void Caphca_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = this.CreateImage(pictureBox1.Width, pictureBox1.Height);
        }
    }
}
