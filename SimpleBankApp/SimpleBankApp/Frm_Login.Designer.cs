
namespace SimpleBankApp
{
    partial class Frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.PicBox_Logo = new System.Windows.Forms.PictureBox();
            this.TxtBox_AccountNumber = new System.Windows.Forms.TextBox();
            this.TxtBox_PAC = new System.Windows.Forms.TextBox();
            this.Lbl_AccountNumber = new System.Windows.Forms.Label();
            this.Lbl_PAC = new System.Windows.Forms.Label();
            this.Btn_Login = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // PicBox_Logo
            // 
            this.PicBox_Logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicBox_Logo.Image = ((System.Drawing.Image)(resources.GetObject("PicBox_Logo.Image")));
            this.PicBox_Logo.Location = new System.Drawing.Point(101, -21);
            this.PicBox_Logo.Name = "PicBox_Logo";
            this.PicBox_Logo.Size = new System.Drawing.Size(611, 218);
            this.PicBox_Logo.TabIndex = 0;
            this.PicBox_Logo.TabStop = false;
            // 
            // TxtBox_AccountNumber
            // 
            this.TxtBox_AccountNumber.Location = new System.Drawing.Point(337, 255);
            this.TxtBox_AccountNumber.Name = "TxtBox_AccountNumber";
            this.TxtBox_AccountNumber.Size = new System.Drawing.Size(143, 20);
            this.TxtBox_AccountNumber.TabIndex = 1;
            // 
            // TxtBox_PAC
            // 
            this.TxtBox_PAC.Location = new System.Drawing.Point(337, 329);
            this.TxtBox_PAC.Name = "TxtBox_PAC";
            this.TxtBox_PAC.Size = new System.Drawing.Size(143, 20);
            this.TxtBox_PAC.TabIndex = 2;
            // 
            // Lbl_AccountNumber
            // 
            this.Lbl_AccountNumber.AutoSize = true;
            this.Lbl_AccountNumber.Location = new System.Drawing.Point(221, 258);
            this.Lbl_AccountNumber.Name = "Lbl_AccountNumber";
            this.Lbl_AccountNumber.Size = new System.Drawing.Size(93, 13);
            this.Lbl_AccountNumber.TabIndex = 3;
            this.Lbl_AccountNumber.Text = "Account Number :";
            // 
            // Lbl_PAC
            // 
            this.Lbl_PAC.AutoSize = true;
            this.Lbl_PAC.Location = new System.Drawing.Point(164, 332);
            this.Lbl_PAC.Name = "Lbl_PAC";
            this.Lbl_PAC.Size = new System.Drawing.Size(150, 13);
            this.Lbl_PAC.TabIndex = 4;
            this.Lbl_PAC.Text = "Personal Access Code (PAC) :";
            // 
            // Btn_Login
            // 
            this.Btn_Login.Location = new System.Drawing.Point(353, 388);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(113, 31);
            this.Btn_Login.TabIndex = 5;
            this.Btn_Login.Text = "Login";
            this.Btn_Login.UseVisualStyleBackColor = true;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.Lbl_PAC);
            this.Controls.Add(this.Lbl_AccountNumber);
            this.Controls.Add(this.TxtBox_PAC);
            this.Controls.Add(this.TxtBox_AccountNumber);
            this.Controls.Add(this.PicBox_Logo);
            this.Name = "Frm_Login";
            this.Text = "Login Page";
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicBox_Logo;
        private System.Windows.Forms.TextBox TxtBox_AccountNumber;
        private System.Windows.Forms.TextBox TxtBox_PAC;
        private System.Windows.Forms.Label Lbl_AccountNumber;
        private System.Windows.Forms.Label Lbl_PAC;
        private System.Windows.Forms.Button Btn_Login;
    }
}

