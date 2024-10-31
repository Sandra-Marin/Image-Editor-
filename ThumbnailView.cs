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
    public partial class Thumbnail_View : Form
    {
        CurrentImageHandler currImgHandler;
        private Bitmap bitmap;

        public Thumbnail_View()
        {
            InitializeComponent();
            this.currImgHandler = new CurrentImageHandler();
        }
        public void SetBitmap(Bitmap bitmap)
        {
            this.bitmap = bitmap;
        }


        private void Thumbnail_View_Load(object sender, EventArgs e)
        {

            if (bitmap != null)
            {
                Image thumbnail = bitmap.GetThumbnailImage(120, 120, () => false, IntPtr.Zero);
                pictureBox1.Image = thumbnail;
                
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
