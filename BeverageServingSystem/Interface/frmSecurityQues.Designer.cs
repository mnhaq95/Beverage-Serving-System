namespace BeverageServingSystem.Interface
{
    partial class frmSecurityQues
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSecurityQues));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.textlSecAnswer = new System.Windows.Forms.TextBox();
            this.txtlSecQuestion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSecQuestion = new System.Windows.Forms.Label();
            this.pictureBoxLogin = new System.Windows.Forms.PictureBox();
            this.lblAns = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.lblAns);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.textlSecAnswer);
            this.panel1.Controls.Add(this.txtlSecQuestion);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblSecQuestion);
            this.panel1.Location = new System.Drawing.Point(72, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 365);
            this.panel1.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Gray;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSubmit.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.btnSubmit.Location = new System.Drawing.Point(162, 303);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(130, 37);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnConfirmPass_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(123, 15);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(0, 13);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Visible = false;
            this.lblEmail.TextChanged += new System.EventHandler(this.lblEmail_TextChanged);
            // 
            // textlSecAnswer
            // 
            this.textlSecAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textlSecAnswer.Location = new System.Drawing.Point(36, 222);
            this.textlSecAnswer.Name = "textlSecAnswer";
            this.textlSecAnswer.Size = new System.Drawing.Size(219, 24);
            this.textlSecAnswer.TabIndex = 11;
            // 
            // txtlSecQuestion
            // 
            this.txtlSecQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtlSecQuestion.Location = new System.Drawing.Point(36, 105);
            this.txtlSecQuestion.Name = "txtlSecQuestion";
            this.txtlSecQuestion.ReadOnly = true;
            this.txtlSecQuestion.Size = new System.Drawing.Size(394, 26);
            this.txtlSecQuestion.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Turquoise;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(33, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Security Answer";
            // 
            // lblSecQuestion
            // 
            this.lblSecQuestion.AutoSize = true;
            this.lblSecQuestion.BackColor = System.Drawing.Color.Turquoise;
            this.lblSecQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSecQuestion.Location = new System.Drawing.Point(33, 67);
            this.lblSecQuestion.Name = "lblSecQuestion";
            this.lblSecQuestion.Size = new System.Drawing.Size(125, 18);
            this.lblSecQuestion.TabIndex = 10;
            this.lblSecQuestion.Text = "Security Question";
            // 
            // pictureBoxLogin
            // 
            this.pictureBoxLogin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogin.Image")));
            this.pictureBoxLogin.Location = new System.Drawing.Point(574, -3);
            this.pictureBoxLogin.Name = "pictureBoxLogin";
            this.pictureBoxLogin.Size = new System.Drawing.Size(33, 34);
            this.pictureBoxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogin.TabIndex = 3;
            this.pictureBoxLogin.TabStop = false;
            this.pictureBoxLogin.Click += new System.EventHandler(this.pictureBoxLogin_Click);
            // 
            // lblAns
            // 
            this.lblAns.AutoSize = true;
            this.lblAns.Location = new System.Drawing.Point(370, 15);
            this.lblAns.Name = "lblAns";
            this.lblAns.Size = new System.Drawing.Size(0, 13);
            this.lblAns.TabIndex = 14;
            this.lblAns.Visible = false;
            // 
            // frmSecurityQues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(609, 506);
            this.Controls.Add(this.pictureBoxLogin);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSecurityQues";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSecurityQues";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSecQuestion;
        private System.Windows.Forms.TextBox textlSecAnswer;
        private System.Windows.Forms.TextBox txtlSecQuestion;
        private System.Windows.Forms.PictureBox pictureBoxLogin;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblAns;
    }
}