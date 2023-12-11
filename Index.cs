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
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
            guna2Panel4.Visible = true;
        }

        // profile
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            guna2Panel5.Visible = false;
            guna2Panel6.Visible = false;
            guna2Panel3.Visible = false;
        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            guna2Panel5.Visible = true;
            guna2Panel6.Visible = false;
            panel1.Visible = false;
        }

        //make order
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2Panel5.Visible = true;
            panel1.Visible = true;
            guna2Panel3.Visible = false;
            guna2Panel6.Visible = false;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            guna2Panel6.Visible = true;
        }
    }
}
