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
    public partial class FrmCheck : Form
    {
        public FrmCheck()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            String msg = "";

           if (chkCoffee.Checked == true)
            {
                msg = chkCoffee.Text;
            }
           if (chkDonut.Checked == true)
            {
                msg = msg + " " + chkDonut.Text;
            }
           if (chkBrownie.Checked == true)
            {
                msg = msg + " " + chkBrownie.Text;
            }
            //now Display the order
            if (msg.Length > 0)
            {
                MessageBox.Show(msg + " ordered.");
            }
            else //length is zero
            {
                MessageBox.Show("Nothing ordered.");
            }
                


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
