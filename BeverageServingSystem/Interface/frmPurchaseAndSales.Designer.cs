namespace BeverageServingSystem.Interface
{
    partial class frmPurchaseAndSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurchaseAndSales));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.lblTop = new System.Windows.Forms.Label();
            this.panelDeaCusT = new System.Windows.Forms.Panel();
            this.dtpBillDateDeaLCust = new System.Windows.Forms.DateTimePicker();
            this.txtAddressDeaLCust = new System.Windows.Forms.TextBox();
            this.txtContactDeaLCust = new System.Windows.Forms.TextBox();
            this.txtEmailDeaLCust = new System.Windows.Forms.TextBox();
            this.txtNameDeaLCust = new System.Windows.Forms.TextBox();
            this.txtSearchDeaLCust = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblDealerAndCustomerDetails = new System.Windows.Forms.Label();
            this.txtSearchProduct = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddPurSale = new System.Windows.Forms.Button();
            this.lblProductDetails = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblInventory = new System.Windows.Forms.Label();
            this.txtRatePurSale = new System.Windows.Forms.TextBox();
            this.txtQtyPurSale = new System.Windows.Forms.TextBox();
            this.txtInventoryPurSale = new System.Windows.Forms.TextBox();
            this.txtProductNamePurSale = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDateGridView = new System.Windows.Forms.Panel();
            this.dgvAddedProducts = new System.Windows.Forms.DataGridView();
            this.lblAddedProduct = new System.Windows.Forms.Label();
            this.pnlCalculation = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotQty = new System.Windows.Forms.Label();
            this.btnSaveTransaction = new System.Windows.Forms.Button();
            this.lblReturnAmount = new System.Windows.Forms.Label();
            this.lblPaidAmount = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.lblVat = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.txtReturnAmount = new System.Windows.Forms.TextBox();
            this.txtPaidAmount = new System.Windows.Forms.TextBox();
            this.txtGrandTotal = new System.Windows.Forms.TextBox();
            this.txtVat = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.lblCalDetails = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.panelDeaCusT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlDateGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddedProducts)).BeginInit();
            this.pnlCalculation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.pictureBoxClose);
            this.panel1.Controls.Add(this.lblTop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1021, 28);
            this.panel1.TabIndex = 3;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(990, 0);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(31, 24);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose.TabIndex = 3;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.BackColor = System.Drawing.Color.DarkCyan;
            this.lblTop.Font = new System.Drawing.Font("Segoe Marker", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop.ForeColor = System.Drawing.Color.PaleGreen;
            this.lblTop.Location = new System.Drawing.Point(438, 2);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(160, 22);
            this.lblTop.TabIndex = 0;
            this.lblTop.Text = "Purchase and Sales";
            // 
            // panelDeaCusT
            // 
            this.panelDeaCusT.Controls.Add(this.dtpBillDateDeaLCust);
            this.panelDeaCusT.Controls.Add(this.txtAddressDeaLCust);
            this.panelDeaCusT.Controls.Add(this.txtContactDeaLCust);
            this.panelDeaCusT.Controls.Add(this.txtEmailDeaLCust);
            this.panelDeaCusT.Controls.Add(this.txtNameDeaLCust);
            this.panelDeaCusT.Controls.Add(this.txtSearchDeaLCust);
            this.panelDeaCusT.Controls.Add(this.pictureBox1);
            this.panelDeaCusT.Controls.Add(this.label5);
            this.panelDeaCusT.Controls.Add(this.label4);
            this.panelDeaCusT.Controls.Add(this.label3);
            this.panelDeaCusT.Controls.Add(this.label7);
            this.panelDeaCusT.Controls.Add(this.label6);
            this.panelDeaCusT.Controls.Add(this.lblSearch);
            this.panelDeaCusT.Controls.Add(this.lblDealerAndCustomerDetails);
            this.panelDeaCusT.Location = new System.Drawing.Point(0, 28);
            this.panelDeaCusT.Name = "panelDeaCusT";
            this.panelDeaCusT.Size = new System.Drawing.Size(1021, 107);
            this.panelDeaCusT.TabIndex = 4;
            // 
            // dtpBillDateDeaLCust
            // 
            this.dtpBillDateDeaLCust.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBillDateDeaLCust.Location = new System.Drawing.Point(808, 15);
            this.dtpBillDateDeaLCust.Name = "dtpBillDateDeaLCust";
            this.dtpBillDateDeaLCust.Size = new System.Drawing.Size(191, 20);
            this.dtpBillDateDeaLCust.TabIndex = 5;
            // 
            // txtAddressDeaLCust
            // 
            this.txtAddressDeaLCust.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAddressDeaLCust.Location = new System.Drawing.Point(501, 20);
            this.txtAddressDeaLCust.Multiline = true;
            this.txtAddressDeaLCust.Name = "txtAddressDeaLCust";
            this.txtAddressDeaLCust.ReadOnly = true;
            this.txtAddressDeaLCust.Size = new System.Drawing.Size(202, 73);
            this.txtAddressDeaLCust.TabIndex = 4;
            // 
            // txtContactDeaLCust
            // 
            this.txtContactDeaLCust.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtContactDeaLCust.Location = new System.Drawing.Point(276, 70);
            this.txtContactDeaLCust.Name = "txtContactDeaLCust";
            this.txtContactDeaLCust.ReadOnly = true;
            this.txtContactDeaLCust.Size = new System.Drawing.Size(161, 23);
            this.txtContactDeaLCust.TabIndex = 4;
            // 
            // txtEmailDeaLCust
            // 
            this.txtEmailDeaLCust.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtEmailDeaLCust.Location = new System.Drawing.Point(270, 20);
            this.txtEmailDeaLCust.Name = "txtEmailDeaLCust";
            this.txtEmailDeaLCust.ReadOnly = true;
            this.txtEmailDeaLCust.Size = new System.Drawing.Size(161, 23);
            this.txtEmailDeaLCust.TabIndex = 4;
            // 
            // txtNameDeaLCust
            // 
            this.txtNameDeaLCust.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNameDeaLCust.Location = new System.Drawing.Point(52, 70);
            this.txtNameDeaLCust.Name = "txtNameDeaLCust";
            this.txtNameDeaLCust.ReadOnly = true;
            this.txtNameDeaLCust.Size = new System.Drawing.Size(161, 23);
            this.txtNameDeaLCust.TabIndex = 4;
            // 
            // txtSearchDeaLCust
            // 
            this.txtSearchDeaLCust.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSearchDeaLCust.Location = new System.Drawing.Point(56, 19);
            this.txtSearchDeaLCust.Name = "txtSearchDeaLCust";
            this.txtSearchDeaLCust.Size = new System.Drawing.Size(161, 23);
            this.txtSearchDeaLCust.TabIndex = 3;
            this.txtSearchDeaLCust.TextChanged += new System.EventHandler(this.txtSearchDeaLCust_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(734, -28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Location = new System.Drawing.Point(733, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Bill Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(225, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Contact";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(3, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.DarkCyan;
            this.label7.Location = new System.Drawing.Point(439, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Location = new System.Drawing.Point(225, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Email";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSearch.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblSearch.Location = new System.Drawing.Point(3, 20);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(47, 17);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Search";
            // 
            // lblDealerAndCustomerDetails
            // 
            this.lblDealerAndCustomerDetails.AutoSize = true;
            this.lblDealerAndCustomerDetails.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDealerAndCustomerDetails.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblDealerAndCustomerDetails.Location = new System.Drawing.Point(3, 3);
            this.lblDealerAndCustomerDetails.Name = "lblDealerAndCustomerDetails";
            this.lblDealerAndCustomerDetails.Size = new System.Drawing.Size(185, 17);
            this.lblDealerAndCustomerDetails.TabIndex = 2;
            this.lblDealerAndCustomerDetails.Text = "Dealer and Customer Details";
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.Location = new System.Drawing.Point(56, 24);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(132, 20);
            this.txtSearchProduct.TabIndex = 6;
            this.txtSearchProduct.TextChanged += new System.EventHandler(this.txtSearchProduct_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtSearchProduct);
            this.panel2.Controls.Add(this.btnAddPurSale);
            this.panel2.Controls.Add(this.lblProductDetails);
            this.panel2.Controls.Add(this.lblQty);
            this.panel2.Controls.Add(this.lblRate);
            this.panel2.Controls.Add(this.lblInventory);
            this.panel2.Controls.Add(this.txtRatePurSale);
            this.panel2.Controls.Add(this.txtQtyPurSale);
            this.panel2.Controls.Add(this.txtInventoryPurSale);
            this.panel2.Controls.Add(this.txtProductNamePurSale);
            this.panel2.Controls.Add(this.lblname);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 142);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1021, 62);
            this.panel2.TabIndex = 5;
            // 
            // btnAddPurSale
            // 
            this.btnAddPurSale.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddPurSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPurSale.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddPurSale.Location = new System.Drawing.Point(910, 14);
            this.btnAddPurSale.Name = "btnAddPurSale";
            this.btnAddPurSale.Size = new System.Drawing.Size(88, 39);
            this.btnAddPurSale.TabIndex = 6;
            this.btnAddPurSale.Text = "Add";
            this.btnAddPurSale.UseVisualStyleBackColor = false;
            this.btnAddPurSale.Click += new System.EventHandler(this.btnAddPurSale_Click);
            // 
            // lblProductDetails
            // 
            this.lblProductDetails.AutoSize = true;
            this.lblProductDetails.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProductDetails.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblProductDetails.Location = new System.Drawing.Point(3, 0);
            this.lblProductDetails.Name = "lblProductDetails";
            this.lblProductDetails.Size = new System.Drawing.Size(103, 17);
            this.lblProductDetails.TabIndex = 3;
            this.lblProductDetails.Text = "Product Details";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQty.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblQty.Location = new System.Drawing.Point(743, 23);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(28, 17);
            this.lblQty.TabIndex = 2;
            this.lblQty.Text = "Qty";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRate.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblRate.Location = new System.Drawing.Point(588, 23);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(34, 17);
            this.lblRate.TabIndex = 2;
            this.lblRate.Text = "Rate";
            // 
            // lblInventory
            // 
            this.lblInventory.AutoSize = true;
            this.lblInventory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInventory.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblInventory.Location = new System.Drawing.Point(422, 24);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(61, 17);
            this.lblInventory.TabIndex = 2;
            this.lblInventory.Text = "Inventory";
            // 
            // txtRatePurSale
            // 
            this.txtRatePurSale.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtRatePurSale.Location = new System.Drawing.Point(631, 22);
            this.txtRatePurSale.Name = "txtRatePurSale";
            this.txtRatePurSale.ReadOnly = true;
            this.txtRatePurSale.Size = new System.Drawing.Size(106, 23);
            this.txtRatePurSale.TabIndex = 4;
            // 
            // txtQtyPurSale
            // 
            this.txtQtyPurSale.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtQtyPurSale.Location = new System.Drawing.Point(777, 21);
            this.txtQtyPurSale.Name = "txtQtyPurSale";
            this.txtQtyPurSale.Size = new System.Drawing.Size(109, 23);
            this.txtQtyPurSale.TabIndex = 4;
            // 
            // txtInventoryPurSale
            // 
            this.txtInventoryPurSale.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtInventoryPurSale.Location = new System.Drawing.Point(501, 22);
            this.txtInventoryPurSale.Name = "txtInventoryPurSale";
            this.txtInventoryPurSale.ReadOnly = true;
            this.txtInventoryPurSale.Size = new System.Drawing.Size(75, 23);
            this.txtInventoryPurSale.TabIndex = 4;
            // 
            // txtProductNamePurSale
            // 
            this.txtProductNamePurSale.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtProductNamePurSale.Location = new System.Drawing.Point(246, 21);
            this.txtProductNamePurSale.Name = "txtProductNamePurSale";
            this.txtProductNamePurSale.ReadOnly = true;
            this.txtProductNamePurSale.Size = new System.Drawing.Size(170, 23);
            this.txtProductNamePurSale.TabIndex = 4;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblname.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblname.Location = new System.Drawing.Point(197, 27);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(43, 17);
            this.lblname.TabIndex = 2;
            this.lblname.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(3, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search";
            // 
            // pnlDateGridView
            // 
            this.pnlDateGridView.Controls.Add(this.dgvAddedProducts);
            this.pnlDateGridView.Controls.Add(this.lblAddedProduct);
            this.pnlDateGridView.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pnlDateGridView.Location = new System.Drawing.Point(0, 210);
            this.pnlDateGridView.Name = "pnlDateGridView";
            this.pnlDateGridView.Size = new System.Drawing.Size(527, 402);
            this.pnlDateGridView.TabIndex = 6;
            // 
            // dgvAddedProducts
            // 
            this.dgvAddedProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAddedProducts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAddedProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddedProducts.Location = new System.Drawing.Point(6, 21);
            this.dgvAddedProducts.Name = "dgvAddedProducts";
            this.dgvAddedProducts.Size = new System.Drawing.Size(514, 378);
            this.dgvAddedProducts.TabIndex = 5;
            this.dgvAddedProducts.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAddedProducts_CellMouseLeave);
            this.dgvAddedProducts.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAddedProducts_CellMouseMove);
            // 
            // lblAddedProduct
            // 
            this.lblAddedProduct.AutoSize = true;
            this.lblAddedProduct.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAddedProduct.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblAddedProduct.Location = new System.Drawing.Point(3, 0);
            this.lblAddedProduct.Name = "lblAddedProduct";
            this.lblAddedProduct.Size = new System.Drawing.Size(100, 17);
            this.lblAddedProduct.TabIndex = 4;
            this.lblAddedProduct.Text = "Added Product";
            // 
            // pnlCalculation
            // 
            this.pnlCalculation.Controls.Add(this.lblTotal);
            this.pnlCalculation.Controls.Add(this.lblTotQty);
            this.pnlCalculation.Controls.Add(this.btnSaveTransaction);
            this.pnlCalculation.Controls.Add(this.lblReturnAmount);
            this.pnlCalculation.Controls.Add(this.lblPaidAmount);
            this.pnlCalculation.Controls.Add(this.lblGrandTotal);
            this.pnlCalculation.Controls.Add(this.lblVat);
            this.pnlCalculation.Controls.Add(this.lblDiscount);
            this.pnlCalculation.Controls.Add(this.lblSubTotal);
            this.pnlCalculation.Controls.Add(this.txtReturnAmount);
            this.pnlCalculation.Controls.Add(this.txtPaidAmount);
            this.pnlCalculation.Controls.Add(this.txtGrandTotal);
            this.pnlCalculation.Controls.Add(this.txtVat);
            this.pnlCalculation.Controls.Add(this.txtDiscount);
            this.pnlCalculation.Controls.Add(this.txtSubTotal);
            this.pnlCalculation.Controls.Add(this.lblCalDetails);
            this.pnlCalculation.Location = new System.Drawing.Point(530, 211);
            this.pnlCalculation.Name = "pnlCalculation";
            this.pnlCalculation.Size = new System.Drawing.Size(491, 401);
            this.pnlCalculation.TabIndex = 7;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(61, 362);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 13);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Visible = false;
            // 
            // lblTotQty
            // 
            this.lblTotQty.AutoSize = true;
            this.lblTotQty.Location = new System.Drawing.Point(58, 304);
            this.lblTotQty.Name = "lblTotQty";
            this.lblTotQty.Size = new System.Drawing.Size(0, 13);
            this.lblTotQty.TabIndex = 7;
            this.lblTotQty.Visible = false;
            // 
            // btnSaveTransaction
            // 
            this.btnSaveTransaction.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSaveTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveTransaction.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveTransaction.Location = new System.Drawing.Point(380, 325);
            this.btnSaveTransaction.Name = "btnSaveTransaction";
            this.btnSaveTransaction.Size = new System.Drawing.Size(96, 51);
            this.btnSaveTransaction.TabIndex = 6;
            this.btnSaveTransaction.Text = "Transact";
            this.btnSaveTransaction.UseVisualStyleBackColor = false;
            this.btnSaveTransaction.Click += new System.EventHandler(this.btnSaveTransaction_Click);
            // 
            // lblReturnAmount
            // 
            this.lblReturnAmount.AutoSize = true;
            this.lblReturnAmount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblReturnAmount.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblReturnAmount.Location = new System.Drawing.Point(48, 240);
            this.lblReturnAmount.Name = "lblReturnAmount";
            this.lblReturnAmount.Size = new System.Drawing.Size(95, 17);
            this.lblReturnAmount.TabIndex = 5;
            this.lblReturnAmount.Text = "Return Amount";
            // 
            // lblPaidAmount
            // 
            this.lblPaidAmount.AutoSize = true;
            this.lblPaidAmount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPaidAmount.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblPaidAmount.Location = new System.Drawing.Point(48, 199);
            this.lblPaidAmount.Name = "lblPaidAmount";
            this.lblPaidAmount.Size = new System.Drawing.Size(82, 17);
            this.lblPaidAmount.TabIndex = 5;
            this.lblPaidAmount.Text = "Paid Amount";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGrandTotal.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblGrandTotal.Location = new System.Drawing.Point(48, 156);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(77, 17);
            this.lblGrandTotal.TabIndex = 5;
            this.lblGrandTotal.Text = "Grand Total";
            // 
            // lblVat
            // 
            this.lblVat.AutoSize = true;
            this.lblVat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVat.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblVat.Location = new System.Drawing.Point(48, 115);
            this.lblVat.Name = "lblVat";
            this.lblVat.Size = new System.Drawing.Size(46, 17);
            this.lblVat.TabIndex = 5;
            this.lblVat.Text = "Vat(%)";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDiscount.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblDiscount.Location = new System.Drawing.Point(48, 81);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(77, 17);
            this.lblDiscount.TabIndex = 5;
            this.lblDiscount.Text = "Discount(%)";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSubTotal.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblSubTotal.Location = new System.Drawing.Point(48, 35);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(63, 17);
            this.lblSubTotal.TabIndex = 5;
            this.lblSubTotal.Text = "Sub Total";
            // 
            // txtReturnAmount
            // 
            this.txtReturnAmount.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtReturnAmount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtReturnAmount.Location = new System.Drawing.Point(146, 234);
            this.txtReturnAmount.Multiline = true;
            this.txtReturnAmount.Name = "txtReturnAmount";
            this.txtReturnAmount.Size = new System.Drawing.Size(324, 32);
            this.txtReturnAmount.TabIndex = 4;
            // 
            // txtPaidAmount
            // 
            this.txtPaidAmount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPaidAmount.Location = new System.Drawing.Point(146, 193);
            this.txtPaidAmount.Name = "txtPaidAmount";
            this.txtPaidAmount.Size = new System.Drawing.Size(324, 23);
            this.txtPaidAmount.TabIndex = 4;
            this.txtPaidAmount.TextChanged += new System.EventHandler(this.txtPaidAmount_TextChanged);
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtGrandTotal.Location = new System.Drawing.Point(146, 155);
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.Size = new System.Drawing.Size(324, 23);
            this.txtGrandTotal.TabIndex = 4;
            // 
            // txtVat
            // 
            this.txtVat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtVat.Location = new System.Drawing.Point(146, 113);
            this.txtVat.Name = "txtVat";
            this.txtVat.Size = new System.Drawing.Size(324, 23);
            this.txtVat.TabIndex = 4;
            this.txtVat.TextChanged += new System.EventHandler(this.txtVat_TextChanged);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDiscount.Location = new System.Drawing.Point(146, 80);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(324, 23);
            this.txtDiscount.TabIndex = 4;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSubTotal.Location = new System.Drawing.Point(146, 29);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(324, 23);
            this.txtSubTotal.TabIndex = 4;
            this.txtSubTotal.Text = "0";
            // 
            // lblCalDetails
            // 
            this.lblCalDetails.AutoSize = true;
            this.lblCalDetails.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCalDetails.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblCalDetails.Location = new System.Drawing.Point(3, 0);
            this.lblCalDetails.Name = "lblCalDetails";
            this.lblCalDetails.Size = new System.Drawing.Size(124, 17);
            this.lblCalDetails.TabIndex = 4;
            this.lblCalDetails.Text = "Calculation Details";
            // 
            // frmPurchaseAndSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1021, 624);
            this.Controls.Add(this.pnlCalculation);
            this.Controls.Add(this.pnlDateGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelDeaCusT);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPurchaseAndSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmPurchaseAndSales_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.panelDeaCusT.ResumeLayout(false);
            this.panelDeaCusT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlDateGridView.ResumeLayout(false);
            this.pnlDateGridView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddedProducts)).EndInit();
            this.pnlCalculation.ResumeLayout(false);
            this.pnlCalculation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.Panel panelDeaCusT;
        private System.Windows.Forms.Label lblDealerAndCustomerDetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAddressDeaLCust;
        private System.Windows.Forms.TextBox txtContactDeaLCust;
        private System.Windows.Forms.TextBox txtEmailDeaLCust;
        private System.Windows.Forms.TextBox txtNameDeaLCust;
        private System.Windows.Forms.TextBox txtSearchDeaLCust;
        private System.Windows.Forms.DateTimePicker dtpBillDateDeaLCust;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblProductDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.TextBox txtInventoryPurSale;
        private System.Windows.Forms.TextBox txtProductNamePurSale;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtRatePurSale;
        private System.Windows.Forms.TextBox txtQtyPurSale;
        private System.Windows.Forms.Button btnAddPurSale;
        private System.Windows.Forms.Panel pnlDateGridView;
        private System.Windows.Forms.DataGridView dgvAddedProducts;
        private System.Windows.Forms.Label lblAddedProduct;
        private System.Windows.Forms.Panel pnlCalculation;
        private System.Windows.Forms.Label lblPaidAmount;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label lblVat;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblCalDetails;
        private System.Windows.Forms.Label lblReturnAmount;
        private System.Windows.Forms.TextBox txtReturnAmount;
        private System.Windows.Forms.TextBox txtPaidAmount;
        private System.Windows.Forms.TextBox txtGrandTotal;
        private System.Windows.Forms.TextBox txtVat;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Button btnSaveTransaction;
        private System.Windows.Forms.TextBox txtSearchProduct;
        private System.Windows.Forms.Label lblTotQty;
        private System.Windows.Forms.Label lblTotal;
    }
}