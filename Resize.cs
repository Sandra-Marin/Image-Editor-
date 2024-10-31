using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Processing
{
/*    public partial class Resize : Form
    {
        public int HeightValue { get; private set; }
        public int WidthValue { get; private set; }

       public Resize()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int height) && int.TryParse(textBox2.Text, out int width))
            {
                HeightValue = height;
                WidthValue = width;
                DialogResult = DialogResult.OK; // Set DialogResult to OK      
            }
            else
            {
                MessageBox.Show("Please enter valid integer values for height and width.");
            }
        }
    }*/
    public partial class Resize : Form
    {
        public int HeightValue { get; private set; }
        public int WidthValue { get; private set; }

        public Resize()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int height) && int.TryParse(textBox2.Text, out int width))
            {
                HeightValue = height;
                WidthValue = width;
                DialogResult = DialogResult.OK; // Set DialogResult to OK      
            }
            else
            {
                MessageBox.Show("Please enter valid integer values for height and width.");
            }
        }
    }

}

