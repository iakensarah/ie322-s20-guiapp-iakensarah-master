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
    public partial class frmMain : Form
    {
        string username = "Ibrahim";
        string myPassword = "1234";
           
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if(TxtUser.Text == "Ibrahim" && TxtPw.Text=="1234")
            {
                MessageBox.Show("Login Successful");
            }
            else if (TxtUser.Text!="Ibrahim")
            {
                MessageBox.Show("Incorrect username");
            }
            else
            {
                MessageBox.Show("Incorrect password");
            }
        }

        private void BtnRadio_Click(object sender, EventArgs e)
        {
            FrmRadio frm = new FrmRadio();
            frm.ShowDialog();
        }

        private void BtnCheckBox_Click(object sender, EventArgs e)
        {
            FrmCheck Frm = new FrmCheck();
            Frm.ShowDialog();
        }

        private void BtnCombo_Click(object sender, EventArgs e)
        {
            FrmCombo Frm = new FrmCombo();
            Frm.ShowDialog();
        }

        private void BtnRandom_Click(object sender, EventArgs e)
        {
            FrmRandom frm = new FrmRandom();
            frm.ShowDialog();
        }

        private void BtnRandomCom_Click(object sender, EventArgs e)
        {
            FrmRandomCombo frm = new FrmRandomCombo();
            frm.ShowDialog();
        }

        private void BtnPictureBox_Click(object sender, EventArgs e)
        {
            FrmPicture frm = new FrmPicture();
            frm.ShowDialog();
        }
    }
}
