namespace BeverageServingSystem
{
    partial class formUserPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formUserPanel));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.purchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAbove = new System.Windows.Forms.Label();
            this.lblHead = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAppFName = new System.Windows.Forms.Label();
            this.lbllLoggedInUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DotNetRiders = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseToolStripMenuItem,
            this.salesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(10, 5);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(932, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStripUserPanel";
            // 
            // purchaseToolStripMenuItem
            // 
            this.purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
            this.purchaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.purchaseToolStripMenuItem.Text = "Purchase";
            this.purchaseToolStripMenuItem.Click += new System.EventHandler(this.purchaseToolStripMenuItem_Click);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.salesToolStripMenuItem.Text = "Sales";
            this.salesToolStripMenuItem.Click += new System.EventHandler(this.salesToolStripMenuItem_Click);
            // 
            // lblAbove
            // 
            this.lblAbove.AutoSize = true;
            this.lblAbove.Font = new System.Drawing.Font("Ravie", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbove.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lblAbove.Location = new System.Drawing.Point(422, 217);
            this.lblAbove.Name = "lblAbove";
            this.lblAbove.Size = new System.Drawing.Size(160, 43);
            this.lblAbove.TabIndex = 11;
            this.lblAbove.Text = "Unique";
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHead.Location = new System.Drawing.Point(462, 260);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(191, 31);
            this.lblHead.TabIndex = 8;
            this.lblHead.Text = "Serving System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(462, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "Beverage";
            // 
            // lblAppFName
            // 
            this.lblAppFName.AutoSize = true;
            this.lblAppFName.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppFName.Location = new System.Drawing.Point(336, 260);
            this.lblAppFName.Name = "lblAppFName";
            this.lblAppFName.Size = new System.Drawing.Size(120, 31);
            this.lblAppFName.TabIndex = 10;
            this.lblAppFName.Text = "Beverage";
            // 
            // lbllLoggedInUser
            // 
            this.lbllLoggedInUser.AutoSize = true;
            this.lbllLoggedInUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbllLoggedInUser.ForeColor = System.Drawing.Color.Blue;
            this.lbllLoggedInUser.Location = new System.Drawing.Point(87, 41);
            this.lbllLoggedInUser.Name = "lbllLoggedInUser";
            this.lbllLoggedInUser.Size = new System.Drawing.Size(0, 20);
            this.lbllLoggedInUser.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Employee:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.DotNetRiders);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(10, 475);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 17);
            this.panel1.TabIndex = 12;
            // 
            // DotNetRiders
            // 
            this.DotNetRiders.AutoSize = true;
            this.DotNetRiders.Font = new System.Drawing.Font("Microsoft MHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DotNetRiders.ForeColor = System.Drawing.Color.Transparent;
            this.DotNetRiders.Location = new System.Drawing.Point(369, -4);
            this.DotNetRiders.Name = "DotNetRiders";
            this.DotNetRiders.Size = new System.Drawing.Size(275, 21);
            this.DotNetRiders.TabIndex = 0;
            this.DotNetRiders.Text = "Developed By @Md. Niyamul Haque";
            // 
            // formUserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 497);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblAbove);
            this.Controls.Add(this.lblHead);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAppFName);
            this.Controls.Add(this.lbllLoggedInUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formUserPanel";
            this.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Panel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formUserPanel_FormClosed);
            this.Load += new System.EventHandler(this.formUserPanel_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem purchaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.Label lblAbove;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAppFName;
        private System.Windows.Forms.Label lbllLoggedInUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label DotNetRiders;
    }
}