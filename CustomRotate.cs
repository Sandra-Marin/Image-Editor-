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
    public partial class CustomRotate : Form
    {
        public float RotationAngle { get; private set; }
        public CustomRotate()
        {
            InitializeComponent();
            button1.DialogResult = DialogResult.OK;
            button2.DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (float.TryParse(textBox1.Text, out float angle))
            {
                RotationAngle = angle;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Invalid angle. Please enter a valid numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public float RotateAngle
        {
            get
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                    textBox1.Text = "0";
                return Convert.ToSingle(textBox1.Text);
            }
            set { textBox1.Text = value.ToString(); }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
