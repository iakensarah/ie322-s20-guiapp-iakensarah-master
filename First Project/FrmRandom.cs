using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_Project
{
    public partial class FrmRandom : Form
    {
        Random y = new Random();

        public FrmRandom()
        {
            InitializeComponent();
        }

        private void btnRandomNumber_Click(object sender, EventArgs e)
        {
            btnRandomNumber.Text = Convert.ToString(y.Next(1, 100));
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnGanerateRandomColor_Click(object sender, EventArgs e)
        {
            int r = y.Next(0, 255);
            int g = y.Next(0, 255);
            int b = y.Next(0, 255);

            label1.Text = Convert.ToString(r) + "-" + Convert.ToString(g) + "-" + Convert.ToString(b);
            btnGanerateRandomColor.BackColor = Color.FromArgb(r, g, b);
            
        }
    }
}
