namespace First_Project
{
    partial class FrmPicture
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnImageFromFile = new System.Windows.Forms.Button();
            this.btnFromResource = new System.Windows.Forms.Button();
            this.picTry = new System.Windows.Forms.PictureBox();
            this.picTry2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picTry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTry2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnImageFromFile
            // 
            this.btnImageFromFile.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnImageFromFile.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImageFromFile.Location = new System.Drawing.Point(48, 63);
            this.btnImageFromFile.Name = "btnImageFromFile";
            this.btnImageFromFile.Size = new System.Drawing.Size(189, 64);
            this.btnImageFromFile.TabIndex = 0;
            this.btnImageFromFile.Text = "Image from File";
            this.btnImageFromFile.UseVisualStyleBackColor = false;
            this.btnImageFromFile.Click += new System.EventHandler(this.btnImageFromFile_Click);
            // 
            // btnFromResource
            // 
            this.btnFromResource.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnFromResource.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFromResource.Location = new System.Drawing.Point(48, 184);
            this.btnFromResource.Name = "btnFromResource";
            this.btnFromResource.Size = new System.Drawing.Size(189, 64);
            this.btnFromResource.TabIndex = 1;
            this.btnFromResource.Text = "Image from Resource";
            this.btnFromResource.UseVisualStyleBackColor = false;
            this.btnFromResource.Click += new System.EventHandler(this.btnFromResource_Click);
            // 
            // picTry
            // 
            this.picTry.Location = new System.Drawing.Point(14, 24);
            this.picTry.Name = "picTry";
            this.picTry.Size = new System.Drawing.Size(207, 316);
            this.picTry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTry.TabIndex = 2;
            this.picTry.TabStop = false;
            // 
            // picTry2
            // 
            this.picTry2.Location = new System.Drawing.Point(241, 24);
            this.picTry2.Name = "picTry2";
            this.picTry2.Size = new System.Drawing.Size(221, 316);
            this.picTry2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTry2.TabIndex = 3;
            this.picTry2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.picTry2);
            this.groupBox1.Controls.Add(this.picTry);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(250, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 355);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Picture Boxes";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Goldenrod;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(646, 391);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(113, 47);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FrmPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnFromResource);
            this.Controls.Add(this.btnImageFromFile);
            this.Name = "FrmPicture";
            this.Text = "FrmPicture";
            this.Load += new System.EventHandler(this.FrmPicture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTry2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImageFromFile;
        private System.Windows.Forms.Button btnFromResource;
        private System.Windows.Forms.PictureBox picTry;
        private System.Windows.Forms.PictureBox picTry2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBack;
    }
}