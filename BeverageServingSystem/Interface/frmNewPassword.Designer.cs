namespace BeverageServingSystem.Interface
{
    partial class frmNewPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewPassword));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnConfirmPass = new System.Windows.Forms.Button();
            this.txtConfrimPass = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pictureBoxLogin = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.btnConfirmPass);
            this.panel1.Controls.Add(this.txtConfrimPass);
            this.panel1.Controls.Add(this.txtNewPass);
            this.panel1.Controls.Add(this.lblPass);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Location = new System.Drawing.Point(50, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 363);
            this.panel1.TabIndex = 0;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(150, 240);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(0, 13);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Visible = false;
            // 
            // btnConfirmPass
            // 
            this.btnConfirmPass.BackColor = System.Drawing.Color.Gray;
            this.btnConfirmPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmPass.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnConfirmPass.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.btnConfirmPass.Location = new System.Drawing.Point(150, 274);
            this.btnConfirmPass.Name = "btnConfirmPass";
            this.btnConfirmPass.Size = new System.Drawing.Size(130, 37);
            this.btnConfirmPass.TabIndex = 12;
            this.btnConfirmPass.Text = "Confirm";
            this.btnConfirmPass.UseVisualStyleBackColor = false;
            this.btnConfirmPass.Click += new System.EventHandler(this.btnConfirmPass_Click);
            // 
            // txtConfrimPass
            // 
            this.txtConfrimPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtConfrimPass.Location = new System.Drawing.Point(150, 189);
            this.txtConfrimPass.Name = "txtConfrimPass";
            this.txtConfrimPass.PasswordChar = 'x';
            this.txtConfrimPass.Size = new System.Drawing.Size(148, 24);
            this.txtConfrimPass.TabIndex = 10;
            // 
            // txtNewPass
            // 
            this.txtNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNewPass.Location = new System.Drawing.Point(150, 81);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = 'x';
            this.txtNewPass.Size = new System.Drawing.Size(148, 24);
            this.txtNewPass.TabIndex = 11;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPass.Location = new System.Drawing.Point(147, 140);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(132, 18);
            this.lblPass.TabIndex = 8;
            this.lblPass.Text = "Confirm Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUsername.Location = new System.Drawing.Point(147, 51);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(109, 18);
            this.lblUsername.TabIndex = 9;
            this.lblUsername.Text = "New Password";
            // 
            // pictureBoxLogin
            // 
            this.pictureBoxLogin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogin.Image")));
            this.pictureBoxLogin.Location = new System.Drawing.Point(515, -1);
            this.pictureBoxLogin.Name = "pictureBoxLogin";
            this.pictureBoxLogin.Size = new System.Drawing.Size(33, 34);
            this.pictureBoxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogin.TabIndex = 3;
            this.pictureBoxLogin.TabStop = false;
            this.pictureBoxLogin.Click += new System.EventHandler(this.pictureBoxLogin_Click);
            // 
            // frmNewPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(546, 466);
            this.Controls.Add(this.pictureBoxLogin);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNewPassword";
            this.Text = "frmNewPassword";
            this.Load += new System.EventHandler(this.frmNewPassword_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxLogin;
        private System.Windows.Forms.Button btnConfirmPass;
        private System.Windows.Forms.TextBox txtConfrimPass;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblEmail;
    }
}