using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace takım
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTakim1_Click(object sender, EventArgs e)
        {
            btnTakim1.BackColor = Color.Blue;
            btnTakim1.ForeColor = Color.Yellow;
            lblTakim.Text = "fenerbahçe";
        }

        private void btnTakim2_Click(object sender, EventArgs e)
        {
            btnTakim2.BackColor = Color.Yellow;
            btnTakim2.ForeColor = Color.Black;
            lblTakim.Text = "galatasaray";
        }

        private void btnTakim3_Click(object sender, EventArgs e)
        {
            btnTakim3.BackColor = Color.Black;
            btnTakim3.ForeColor = Color.White;
            lblTakim.Text = "beşiktaş";
        }

        private void btnTakim4_Click(object sender, EventArgs e)
        {
            btnTakim4.BackColor = Color.Red;
            btnTakim4.ForeColor = Color.Black;
            lblTakim.Text = "bursaspor";
        }
    }
}
