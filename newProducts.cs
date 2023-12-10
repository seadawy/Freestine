using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Freestine
{
    public partial class newProducts : Form
    {
        public newProducts()
        {
            InitializeComponent();
        }

        private void gunaLabel4_Click(object sender, EventArgs e)
        {

        }

        private void newProducts_Load(object sender, EventArgs e)
        {

        }

        private void Upload_img_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg; *.png; *.bmp)|*.jpg; *.png; *.bmp|All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Display the selected image in the PictureBox
                    guna2PictureBox1.ImageLocation = openFileDialog.FileName;
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
