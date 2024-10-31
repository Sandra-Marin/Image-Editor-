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
    public partial class Contrast : Form
    {
        public static string contrast;
        CurrentImageHandler currentImgHandler;
        ImageHandler imageHandler;
        public Contrast()
        {
            InitializeComponent();
            button1.DialogResult = DialogResult.OK;
            button2.DialogResult = DialogResult.Cancel;
        }
    

        private void button1_Click(object sender, EventArgs e)
        {
            contrast = textBox1.Text;
            DialogResult = DialogResult.OK; // Set DialogResult to OK      
        }
    }
}
