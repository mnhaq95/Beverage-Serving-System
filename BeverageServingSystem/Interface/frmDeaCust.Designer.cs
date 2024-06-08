namespace BeverageServingSystem.Interface
{
    partial class frmDeaCust
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeaCust));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.labelDeaCust = new System.Windows.Forms.Label();
            this.lblDealCustID = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblDeaCustName = new System.Windows.Forms.Label();
            this.lblDeaCusEmail = new System.Windows.Forms.Label();
            this.lblDeaCusCont = new System.Windows.Forms.Label();
            this.lblAdd = new System.Windows.Forms.Label();
            this.txtDeaCustID = new System.Windows.Forms.TextBox();
            this.cmbDeaCustType = new System.Windows.Forms.ComboBox();
            this.txtDeaCustName = new System.Windows.Forms.TextBox();
            this.txtDeaCustEmail = new System.Windows.Forms.TextBox();
            this.txtDeaCustConta = new System.Windows.Forms.TextBox();
            this.TxtDeaCustAddress = new System.Windows.Forms.TextBox();
            this.btnDeleteDeaCust = new System.Windows.Forms.Button();
            this.btnUpdateDeaCust = new System.Windows.Forms.Button();
            this.btnAddDeaCust = new System.Windows.Forms.Button();
            this.dgvDeaCust = new System.Windows.Forms.DataGridView();
            this.txtSearchDeaCust = new System.Windows.Forms.TextBox();
            this.lblSearchDeaCUst = new System.Windows.Forms.Label();
            this.errorProviderEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderContact = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeaCust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderContact)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.pictureBoxClose);
            this.panel1.Controls.Add(this.labelDeaCust);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(922, 28);
            this.panel1.TabIndex = 2;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(891, 0);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(31, 24);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose.TabIndex = 3;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // labelDeaCust
            // 
            this.labelDeaCust.AutoSize = true;
            this.labelDeaCust.BackColor = System.Drawing.Color.DarkCyan;
            this.labelDeaCust.Font = new System.Drawing.Font("Segoe Marker", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeaCust.ForeColor = System.Drawing.Color.PaleGreen;
            this.labelDeaCust.Location = new System.Drawing.Point(330, 0);
            this.labelDeaCust.Name = "labelDeaCust";
            this.labelDeaCust.Size = new System.Drawing.Size(190, 22);
            this.labelDeaCust.TabIndex = 1;
            this.labelDeaCust.Text = "Dealers and Customers";
            // 
            // lblDealCustID
            // 
            this.lblDealCustID.AutoSize = true;
            this.lblDealCustID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDealCustID.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblDealCustID.Location = new System.Drawing.Point(12, 40);
            this.lblDealCustID.Name = "lblDealCustID";
            this.lblDealCustID.Size = new System.Drawing.Size(87, 20);
            this.lblDealCustID.TabIndex = 7;
            this.lblDealCustID.Text = "DealCust ID";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblType.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblType.Location = new System.Drawing.Point(12, 82);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(41, 20);
            this.lblType.TabIndex = 8;
            this.lblType.Text = "Type";
            // 
            // lblDeaCustName
            // 
            this.lblDeaCustName.AutoSize = true;
            this.lblDeaCustName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDeaCustName.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblDeaCustName.Location = new System.Drawing.Point(12, 121);
            this.lblDeaCustName.Name = "lblDeaCustName";
            this.lblDeaCustName.Size = new System.Drawing.Size(49, 20);
            this.lblDeaCustName.TabIndex = 9;
            this.lblDeaCustName.Text = "Name";
            // 
            // lblDeaCusEmail
            // 
            this.lblDeaCusEmail.AutoSize = true;
            this.lblDeaCusEmail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDeaCusEmail.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblDeaCusEmail.Location = new System.Drawing.Point(12, 157);
            this.lblDeaCusEmail.Name = "lblDeaCusEmail";
            this.lblDeaCusEmail.Size = new System.Drawing.Size(46, 20);
            this.lblDeaCusEmail.TabIndex = 10;
            this.lblDeaCusEmail.Text = "Email";
            // 
            // lblDeaCusCont
            // 
            this.lblDeaCusCont.AutoSize = true;
            this.lblDeaCusCont.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDeaCusCont.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblDeaCusCont.Location = new System.Drawing.Point(12, 196);
            this.lblDeaCusCont.Name = "lblDeaCusCont";
            this.lblDeaCusCont.Size = new System.Drawing.Size(60, 20);
            this.lblDeaCusCont.TabIndex = 11;
            this.lblDeaCusCont.Text = "Contact";
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAdd.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblAdd.Location = new System.Drawing.Point(12, 234);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(62, 20);
            this.lblAdd.TabIndex = 12;
            this.lblAdd.Text = "Address";
            // 
            // txtDeaCustID
            // 
            this.txtDeaCustID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDeaCustID.Location = new System.Drawing.Point(105, 41);
            this.txtDeaCustID.Name = "txtDeaCustID";
            this.txtDeaCustID.ReadOnly = true;
            this.txtDeaCustID.Size = new System.Drawing.Size(227, 23);
            this.txtDeaCustID.TabIndex = 4;
            // 
            // cmbDeaCustType
            // 
            this.cmbDeaCustType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDeaCustType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbDeaCustType.FormattingEnabled = true;
            this.cmbDeaCustType.Items.AddRange(new object[] {
            "Dealer",
            "Customer"});
            this.cmbDeaCustType.Location = new System.Drawing.Point(105, 83);
            this.cmbDeaCustType.Name = "cmbDeaCustType";
            this.cmbDeaCustType.Size = new System.Drawing.Size(227, 23);
            this.cmbDeaCustType.TabIndex = 0;
            // 
            // txtDeaCustName
            // 
            this.txtDeaCustName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDeaCustName.Location = new System.Drawing.Point(105, 121);
            this.txtDeaCustName.Name = "txtDeaCustName";
            this.txtDeaCustName.Size = new System.Drawing.Size(227, 23);
            this.txtDeaCustName.TabIndex = 1;
            // 
            // txtDeaCustEmail
            // 
            this.txtDeaCustEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDeaCustEmail.Location = new System.Drawing.Point(105, 158);
            this.txtDeaCustEmail.Name = "txtDeaCustEmail";
            this.txtDeaCustEmail.Size = new System.Drawing.Size(227, 23);
            this.txtDeaCustEmail.TabIndex = 2;
            this.txtDeaCustEmail.Leave += new System.EventHandler(this.txtDeaCustEmail_Leave);
            // 
            // txtDeaCustConta
            // 
            this.txtDeaCustConta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDeaCustConta.Location = new System.Drawing.Point(105, 196);
            this.txtDeaCustConta.Name = "txtDeaCustConta";
            this.txtDeaCustConta.Size = new System.Drawing.Size(227, 23);
            this.txtDeaCustConta.TabIndex = 3;
            this.txtDeaCustConta.Leave += new System.EventHandler(this.txtDeaCustConta_Leave);
            // 
            // TxtDeaCustAddress
            // 
            this.TxtDeaCustAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtDeaCustAddress.Location = new System.Drawing.Point(105, 235);
            this.TxtDeaCustAddress.Multiline = true;
            this.TxtDeaCustAddress.Name = "TxtDeaCustAddress";
            this.TxtDeaCustAddress.Size = new System.Drawing.Size(227, 193);
            this.TxtDeaCustAddress.TabIndex = 4;
            // 
            // btnDeleteDeaCust
            // 
            this.btnDeleteDeaCust.BackColor = System.Drawing.Color.Crimson;
            this.btnDeleteDeaCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDeaCust.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteDeaCust.Location = new System.Drawing.Point(506, 455);
            this.btnDeleteDeaCust.Name = "btnDeleteDeaCust";
            this.btnDeleteDeaCust.Size = new System.Drawing.Size(88, 39);
            this.btnDeleteDeaCust.TabIndex = 12;
            this.btnDeleteDeaCust.Text = "Delete";
            this.btnDeleteDeaCust.UseVisualStyleBackColor = false;
            this.btnDeleteDeaCust.Click += new System.EventHandler(this.btnDeleteDeaCust_Click);
            // 
            // btnUpdateDeaCust
            // 
            this.btnUpdateDeaCust.BackColor = System.Drawing.Color.DarkGreen;
            this.btnUpdateDeaCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateDeaCust.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdateDeaCust.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdateDeaCust.Location = new System.Drawing.Point(359, 455);
            this.btnUpdateDeaCust.Name = "btnUpdateDeaCust";
            this.btnUpdateDeaCust.Size = new System.Drawing.Size(88, 39);
            this.btnUpdateDeaCust.TabIndex = 13;
            this.btnUpdateDeaCust.Text = "Update";
            this.btnUpdateDeaCust.UseVisualStyleBackColor = false;
            this.btnUpdateDeaCust.Click += new System.EventHandler(this.btnUpdateDeaCust_Click);
            // 
            // btnAddDeaCust
            // 
            this.btnAddDeaCust.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddDeaCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDeaCust.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddDeaCust.Location = new System.Drawing.Point(209, 455);
            this.btnAddDeaCust.Name = "btnAddDeaCust";
            this.btnAddDeaCust.Size = new System.Drawing.Size(88, 39);
            this.btnAddDeaCust.TabIndex = 5;
            this.btnAddDeaCust.Text = "Add";
            this.btnAddDeaCust.UseVisualStyleBackColor = false;
            this.btnAddDeaCust.Click += new System.EventHandler(this.btnAddDeaCust_Click);
            // 
            // dgvDeaCust
            // 
            this.dgvDeaCust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeaCust.Location = new System.Drawing.Point(403, 83);
            this.dgvDeaCust.Name = "dgvDeaCust";
            this.dgvDeaCust.Size = new System.Drawing.Size(507, 345);
            this.dgvDeaCust.TabIndex = 15;
            this.dgvDeaCust.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeaCust_CellMouseLeave);
            this.dgvDeaCust.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDeaCust_CellMouseMove);
            this.dgvDeaCust.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDeaCust_RowHeaderMouseClick);
            // 
            // txtSearchDeaCust
            // 
            this.txtSearchDeaCust.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSearchDeaCust.Location = new System.Drawing.Point(458, 41);
            this.txtSearchDeaCust.Name = "txtSearchDeaCust";
            this.txtSearchDeaCust.Size = new System.Drawing.Size(452, 23);
            this.txtSearchDeaCust.TabIndex = 6;
            this.txtSearchDeaCust.TextChanged += new System.EventHandler(this.txtSearchDeaCust_TextChanged);
            // 
            // lblSearchDeaCUst
            // 
            this.lblSearchDeaCUst.AutoSize = true;
            this.lblSearchDeaCUst.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSearchDeaCUst.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblSearchDeaCUst.Location = new System.Drawing.Point(383, 40);
            this.lblSearchDeaCUst.Name = "lblSearchDeaCUst";
            this.lblSearchDeaCUst.Size = new System.Drawing.Size(53, 20);
            this.lblSearchDeaCUst.TabIndex = 16;
            this.lblSearchDeaCUst.Text = "Search";
            // 
            // errorProviderEmail
            // 
            this.errorProviderEmail.ContainerControl = this;
            // 
            // errorProviderContact
            // 
            this.errorProviderContact.ContainerControl = this;
            // 
            // frmDeaCust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(922, 549);
            this.Controls.Add(this.txtSearchDeaCust);
            this.Controls.Add(this.lblSearchDeaCUst);
            this.Controls.Add(this.dgvDeaCust);
            this.Controls.Add(this.btnDeleteDeaCust);
            this.Controls.Add(this.btnUpdateDeaCust);
            this.Controls.Add(this.btnAddDeaCust);
            this.Controls.Add(this.TxtDeaCustAddress);
            this.Controls.Add(this.txtDeaCustConta);
            this.Controls.Add(this.txtDeaCustEmail);
            this.Controls.Add(this.txtDeaCustName);
            this.Controls.Add(this.cmbDeaCustType);
            this.Controls.Add(this.txtDeaCustID);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.lblDeaCusCont);
            this.Controls.Add(this.lblDeaCusEmail);
            this.Controls.Add(this.lblDeaCustName);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblDealCustID);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDeaCust";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDeaCust";
            this.Load += new System.EventHandler(this.frmDeaCust_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeaCust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderContact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label labelDeaCust;
        private System.Windows.Forms.Label lblDealCustID;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblDeaCustName;
        private System.Windows.Forms.Label lblDeaCusEmail;
        private System.Windows.Forms.Label lblDeaCusCont;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.TextBox txtDeaCustID;
        private System.Windows.Forms.ComboBox cmbDeaCustType;
        private System.Windows.Forms.TextBox txtDeaCustName;
        private System.Windows.Forms.TextBox txtDeaCustEmail;
        private System.Windows.Forms.TextBox txtDeaCustConta;
        private System.Windows.Forms.TextBox TxtDeaCustAddress;
        private System.Windows.Forms.Button btnDeleteDeaCust;
        private System.Windows.Forms.Button btnUpdateDeaCust;
        private System.Windows.Forms.Button btnAddDeaCust;
        private System.Windows.Forms.DataGridView dgvDeaCust;
        private System.Windows.Forms.TextBox txtSearchDeaCust;
        private System.Windows.Forms.Label lblSearchDeaCUst;
        private System.Windows.Forms.ErrorProvider errorProviderEmail;
        private System.Windows.Forms.ErrorProvider errorProviderContact;
    }
}