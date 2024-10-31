using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Processing
{
    public partial class Merge : Form
    {
        public Merge()
        {
            InitializeComponent();
        }
      
        Bitmap image1;
        Bitmap image2;
        Bitmap image3;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            this.AutoScroll = true;
            this.Invalidate();
            open.Filter = "Image Files(*.jpg; *jpeg; *.gif; *.bmp)| *.jpg; *jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                image1 = new Bitmap(open.FileName);
            }

            pictureBox1.Image = image1;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            this.AutoScroll = true;
            this.Invalidate();
            open.Filter = "Image Files(*.jpg; *jpeg; *.gif; *.bmp)| *.jpg; *jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                image2 = new Bitmap(open.FileName);
            }

            pictureBox2.Image = image2;
            pictureBox3.Image = image3;
        }

        private  void trackBar1_Scroll(object sender, EventArgs e)
        {


            int width = image1.Width;
            int height = image2.Height;
            int now = trackBar1.Value;
            Bitmap image3 = new Bitmap(width, height);

            //for (int i = 0; i < width; i++)
            //    {
            //        for (int j = 0; j < height; j++)
            //        {
            //            Color clr1 = image1.GetPixel(i, j);
            //            Color clr2 = image2.GetPixel(i, j);
            //            Color newclr = Color.FromArgb(255,
            //                (clr1.R * (100 - now) + (clr2.R * now)) / 100,
            //                (clr1.G * (100 - now) + (clr2.G * now)) / 100,
            //                (clr1.B * (100 - now) + (clr2.B * now)) / 100);
            //            image3.SetPixel(i, j, newclr);
            //        }
            //    }
            //    pictureBox3.Image = image3;

            var options = new ParallelOptions()
            {
                MaxDegreeOfParallelism = 1
            };

            for (int i = 0; i < width; i++)
            {
                Parallel.For(0, height, options, j =>
                {
                    Color clr1 = image1.GetPixel(i, j);
                    Color clr2 = image2.GetPixel(i, j);
                    Color newclr = Color.FromArgb(255,
                        (clr1.R * (100 - now) + (clr2.R * now)) / 100,
                        (clr1.G * (100 - now) + (clr2.G * now)) / 100,
                        (clr1.B * (100 - now) + (clr2.B * now)) / 100);
                    image3.SetPixel(i, j, newclr);
                });
            }


            pictureBox3.Image = image3;

        }
   
        
        private void Merge_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
          this.Close();
        }
    }
}
