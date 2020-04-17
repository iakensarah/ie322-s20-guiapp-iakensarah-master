using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;          //for stream object
using System.Reflection;  //for assembly

namespace First_Project
{
    public partial class FrmPicture : Form
    {
        Assembly _assembly;  //creating an assembly object
        Stream _imageStream; //creating an imagestream object
        public FrmPicture()
        {
            InitializeComponent();
        }

        private void btnImageFromFile_Click(object sender, EventArgs e)
        {
            try
            {
                picTry.Image = Image.FromFile("C:\\Users\\Lenovo\\Desktop\\IE322\\ihDtbruw_400x400.jpg"); //relative path
            }
            catch
            {
                MessageBox.Show("Image file not found!");
            }

            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void FrmPicture_Load(object sender, EventArgs e)
        {
            _assembly = Assembly.GetExecutingAssembly(); //set the assembly object
            _imageStream = _assembly.GetManifestResourceStream("First_Project.res.A.jpg");
        }

        private void btnFromResource_Click(object sender, EventArgs e)
        {
            try
            {
                picTry2.Image = Image.FromStream(_imageStream);
            }
            catch
            {
                MessageBox.Show("Error creating image from resource!");
            }
        }
    }
}
