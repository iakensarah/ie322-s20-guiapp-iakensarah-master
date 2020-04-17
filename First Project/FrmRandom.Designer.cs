namespace First_Project
{
    partial class FrmRandom
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
            this.btnGanerateRandomColor = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRandomNumber = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGanerateRandomColor
            // 
            this.btnGanerateRandomColor.BackColor = System.Drawing.Color.Lavender;
            this.btnGanerateRandomColor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGanerateRandomColor.Location = new System.Drawing.Point(134, 85);
            this.btnGanerateRandomColor.Name = "btnGanerateRandomColor";
            this.btnGanerateRandomColor.Size = new System.Drawing.Size(504, 67);
            this.btnGanerateRandomColor.TabIndex = 0;
            this.btnGanerateRandomColor.Text = "Ganerate Random Color";
            this.btnGanerateRandomColor.UseVisualStyleBackColor = false;
            this.btnGanerateRandomColor.Click += new System.EventHandler(this.btnGanerateRandomColor_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Goldenrod;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(593, 344);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(121, 50);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRandomNumber
            // 
            this.btnRandomNumber.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRandomNumber.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandomNumber.Location = new System.Drawing.Point(217, 303);
            this.btnRandomNumber.Name = "btnRandomNumber";
            this.btnRandomNumber.Size = new System.Drawing.Size(158, 54);
            this.btnRandomNumber.TabIndex = 2;
            this.btnRandomNumber.Text = "Random Number";
            this.btnRandomNumber.UseVisualStyleBackColor = false;
            this.btnRandomNumber.Click += new System.EventHandler(this.btnRandomNumber_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "r-g-b";
            // 
            // FrmRandom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRandomNumber);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnGanerateRandomColor);
            this.Name = "FrmRandom";
            this.Text = "FrmRandom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGanerateRandomColor;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRandomNumber;
        private System.Windows.Forms.Label label1;
    }
}