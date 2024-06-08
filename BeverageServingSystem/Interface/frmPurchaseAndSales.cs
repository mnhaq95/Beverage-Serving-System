using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using BeverageServingSystem.Business_Logic;
using BeverageServingSystem.DAL;
using DGVPrinterHelper;
using Microsoft.SqlServer.Server;


namespace BeverageServingSystem.Interface
{
    public partial class frmPurchaseAndSales : Form
    {
        public frmPurchaseAndSales()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private DeaCusDal dcDal = new DeaCusDal();
        private productsDAL productsDal = new productsDAL();
        private userDAL userDal = new userDAL();
        private transactionDAL transactionDal = new transactionDAL();
        private transactionDetailDAL transactionDetailDal = new transactionDetailDAL();

        private DataTable transactionDataTable = new DataTable();

        


        private void frmPurchaseAndSales_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtSearchDeaLCust;
            string type = formUserPanel.transactionType;
            lblTop.Text = type;
            transactionDataTable.Columns.Add("Product name");
            transactionDataTable.Columns.Add("Rate");
            transactionDataTable.Columns.Add("Quantity");
            transactionDataTable.Columns.Add("Total");
            
        }

        private void txtSearchDeaLCust_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearchDeaLCust.Text;

            if (keyword == "")
            {
                txtNameDeaLCust.Text = "";
                txtEmailDeaLCust.Text = "";
                txtContactDeaLCust.Text = "";
                txtAddressDeaLCust.Text = "";
                return;
            }

            DeaCustBLL dcBll = dcDal.SearchDealerCustomerForTransaction(keyword);

            txtNameDeaLCust.Text = dcBll.name;
            txtEmailDeaLCust.Text = dcBll.email;
            txtContactDeaLCust.Text = dcBll.contact;
            txtAddressDeaLCust.Text = dcBll.address;

        }


        private void btnAddPurSale_Click(object sender, EventArgs e)
        {
            string productName = txtProductNamePurSale.Text;
            decimal rate = decimal.Parse(txtRatePurSale.Text);
            decimal qty = decimal.Parse(txtQtyPurSale.Text);

            decimal total = rate*qty;

            decimal subTotal = decimal.Parse(txtSubTotal.Text);
            subTotal = subTotal + total;
            if (productName == "")
            {
                MessageBox.Show("Select the product first. Try again");
            }
            else
            {
                transactionDataTable.Rows.Add(productName, rate, qty, total);
                dgvAddedProducts.DataSource = transactionDataTable;

                dgvAddedProducts.DataSource = transactionDataTable;

                txtSubTotal.Text = subTotal.ToString();


                txtSearchProduct.Text = "";
                txtProductNamePurSale.Text = "";
                txtInventoryPurSale.Text = "";
                txtRatePurSale.Text = "0";
                txtQtyPurSale.Text = "0";
                //GrandTotalInLastRowOfGridView();
                
            }
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            string value = txtDiscount.Text;

            if (value == "")
            {
                MessageBox.Show("Please Add discount");
            }
            else
            {
                decimal subTotal = decimal.Parse(txtSubTotal.Text);
                decimal discount = decimal.Parse(txtDiscount.Text);

                decimal grandTotal = ((100 - discount)/100)*subTotal;

                txtGrandTotal.Text = grandTotal.ToString();

                
                txtGrandTotal.Text = Math.Round(double.Parse(txtGrandTotal.Text), 2).ToString();

                //double.Parse(txtGrandTotal.Text).ToString("0");
                //Double ryan;
                //Double.TryParse(txtGrandTotal.Text, out ryan);
                //txtGrandTotal.Text = ryan.ToString(".00");

            }
        }

        private void txtVat_TextChanged(object sender, EventArgs e)
        {
            string check = txtGrandTotal.Text;
            if (check == "")
            {
                MessageBox.Show("Calcuate the discount and set the Grand total first");
            }
            else
            {
                decimal previousGT = decimal.Parse(txtGrandTotal.Text);
                decimal vat = decimal.Parse(txtVat.Text);
                decimal grandTotalWithVat = ((100 + vat)/100)*previousGT;

                txtGrandTotal.Text = grandTotalWithVat.ToString();

                txtGrandTotal.Text = Math.Round(double.Parse(txtGrandTotal.Text), 0).ToString();

                
                double.Parse(txtGrandTotal.Text).ToString("0");



                //Double ryan;
                //Double.TryParse(txtGrandTotal.Text, out ryan);
                //txtGrandTotal.Text = ryan.ToString(".00");
            }
        }

        private void txtPaidAmount_TextChanged(object sender, EventArgs e)
        {
            decimal grandTotal = decimal.Parse(txtGrandTotal.Text);
            decimal paidAmount = decimal.Parse(txtPaidAmount.Text);

            decimal returnAmount = paidAmount - grandTotal;

            txtReturnAmount.Text = returnAmount.ToString();

        }

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearchProduct.Text;

            if (keyword == "")
            {
                txtProductNamePurSale.Text = "";
                txtInventoryPurSale.Text = "";
                txtRatePurSale.Text = "";
                txtQtyPurSale.Text = "";
                return;
            }

            productsBLL productsBll = productsDal.GetProductsForTranscation(keyword);

            txtProductNamePurSale.Text = productsBll.name;
            txtInventoryPurSale.Text = productsBll.qty.ToString();
            txtRatePurSale.Text = productsBll.rate.ToString();
        }

        public void GrandTotalInLastRowOfGridView()
        {
            dgvAddedProducts[0, dgvAddedProducts.Rows.Count - 1].Value = "Rate";
            dgvAddedProducts[1, dgvAddedProducts.Rows.Count - 1].Value = "Quantity";
            dgvAddedProducts[3, dgvAddedProducts.Rows.Count - 1].Value = "Total";
            dgvAddedProducts.Rows[dgvAddedProducts.Rows.Count - 1].Cells[0].Style.BackColor = Color.White;
            dgvAddedProducts.Rows[dgvAddedProducts.Rows.Count - 1].Cells[0].Style.ForeColor = Color.Brown;
            dgvAddedProducts.Rows[dgvAddedProducts.Rows.Count - 1].Cells[1].Style.BackColor = Color.White;
            dgvAddedProducts.Rows[dgvAddedProducts.Rows.Count - 1].Cells[1].Style.ForeColor = Color.Brown;
            dgvAddedProducts.Rows[dgvAddedProducts.Rows.Count - 1].Cells[2].Style.BackColor = Color.White;
            dgvAddedProducts.Rows[dgvAddedProducts.Rows.Count - 1].Cells[2].Style.ForeColor = Color.Brown;
            dgvAddedProducts.Rows[dgvAddedProducts.Rows.Count - 1].Cells[3].Style.BackColor = Color.White;
            dgvAddedProducts.Rows[dgvAddedProducts.Rows.Count - 1].Cells[3].Style.ForeColor = Color.Brown;


            decimal totalQty = 0;
            for (int a = 0; a < dgvAddedProducts.RowCount -1 ; a++)
            {
                var ValueQty = dgvAddedProducts.Rows[a].Cells[2].Value;
                if (ValueQty != DBNull.Value)
                {
                    totalQty += Convert.ToDecimal(ValueQty);
                }
                if (totalQty == 0)
                {
                    
                }
                dgvAddedProducts.Rows[dgvAddedProducts.Rows.Count - 1].Cells[2].Value = totalQty.ToString();
            }
        }

        public void TotalTo()
        {
            int A = 0;
            int B = 0;
            for (A = 0; A < dgvAddedProducts.Rows.Count; ++A)
            {
                B += Convert.ToInt32(dgvAddedProducts.Rows[A].Cells[3].Value);
                
            }
            lblTotal.Text = B.ToString();
        }



        public void TotalQty()
        {
            int A = 0;
            int B = 0;
            for (A = 0; A < dgvAddedProducts.Rows.Count; ++A)
            {
                B += Convert.ToInt32(dgvAddedProducts.Rows[A].Cells[2].Value);
                
            }
            lblTotQty.Text = B.ToString();
        }
        private void btnSaveTransaction_Click(object sender, EventArgs e)
        {

            TotalQty();
            //TotalTo();

            transactionBLL transaction = new transactionBLL();

            transaction.type = lblTop.Text;

            string deaCusName = txtNameDeaLCust.Text;
            DeaCustBLL deaCust = dcDal.GetDeaCustIDfromName(deaCusName);

            transaction.cust_id = deaCust.id;
            transaction.grandtotal = Math.Round(decimal.Parse(txtGrandTotal.Text), 2);
            transaction.transction_date = DateTime.Now;
            transaction.tax = decimal.Parse(txtVat.Text);
            transaction.discount = decimal.Parse(txtDiscount.Text);

            string userName = formLogin.loggedIn;
            userBLL userBll = userDal.GetIDFromUserName(userName);

            transaction.added_by = userBll.id;
            transaction.transactionDetails = transactionDataTable;

            
            bool success = false;

            using (TransactionScope scope = new TransactionScope())
            {
                int transactionId = -1;
                bool tranwork = transactionDal.Insert_Transaction(transaction, out transactionId);

                for (int i = 0; i < transactionDataTable.Rows.Count; i++)
                {
                    transactionDetailBLL transactionDetail = new transactionDetailBLL();
                    string productName = transactionDataTable.Rows[i][0].ToString();
                    productsBLL productsBll = productsDal.GetProductIDfromName(productName);

                    transactionDetail.product_id = productsBll.id;
                    transactionDetail.rate = decimal.Parse(transactionDataTable.Rows[i][1].ToString());
                    transactionDetail.qty = decimal.Parse(transactionDataTable.Rows[i][2].ToString());
                    transactionDetail.total = Math.Round(decimal.Parse(transactionDataTable.Rows[i][3].ToString()), 2);
                    transactionDetail.cust_id = deaCust.id;
                    transactionDetail.added_date = DateTime.Now;
                    transactionDetail.added_by = userBll.id;


                    string transactionType = lblTop.Text;
                    bool tranidea = false;
                    if (transactionType=="Purchase")
                    {
                         tranidea = productsDal.IncreaseProduct(transactionDetail.product_id, transactionDetail.qty);
                    }
                    else if (transactionType == "Sales")
                    {
                         tranidea = productsDal.DecreaseProduct(transactionDetail.product_id, transactionDetail.qty);
                    }
                    bool tranBool = transactionDetailDal.InsertTransactionDetail(transactionDetail);
                    
                    success = tranwork && tranidea && tranBool;
                }
             

               
                if (success == true)
                {
                    scope.Complete();

                    DGVPrinter printer = new DGVPrinter();

                    string time = string.Format("Date: {0}", DateTime.Now);
                    //string time = string.Format("Date: {0}, Time:{1}", DateTime.Now.Date.ToString("dd-MM-yyyy"), DateTime.Now.TimeOfDay);
                    printer.Title = "\r\n\r\n\r\n Unique Beverage System \r\n\r\n";
                    printer.SubTitle = "Name: "+txtNameDeaLCust.Text+" \r\n Phone: ****-****537 \r\n" + time;
                    //printer.SubTitleFormatFlags= StringFormatFlags.LineLimit| StringFormatFlags.NoClip;
                    printer.SubTitleSpacing = 40;
                    printer.PageNumbers = true;
                    printer.PageNumberInHeader = false;
                    printer.PorportionalColumns = true;
                    printer.HeaderCellAlignment = StringAlignment.Near;
                    printer.Footer = "Total Items: " + lblTotQty.Text + "\r\n" + "Discount: " + txtDiscount.Text + "% \r\n" + "  VAT: " + txtVat.Text + "% \r\n" + "  Grand Amount: " + txtGrandTotal.Text + "\r\n\r\n" + "Thank you for Corparating with us.";
                    printer.FooterSpacing = 40;
                    printer.PrintDataGridView(dgvAddedProducts);
                    //printer.PrintPreviewDataGridView(dgvAddedProducts);
                    

                    MessageBox.Show("Transaction is complete");
                    //dgvAddedProducts.DataSource = null;
                    
                    //dgvAddedProducts.DataSource = DBNull.Value;
                    //dgvAddedProducts.ClearSelection();
                    
                    //dgvAddedProducts.Refresh();

                    DataTable dataTable = (DataTable) dgvAddedProducts.DataSource;
                    if (dataTable != null)
                    {
                        dataTable.Clear();
                    }
                    
                    //dgvAddedProducts.Rows.Clear();
                    //dgvAddedProducts.Columns.Clear();
                    dgvAddedProducts.DataSource= string.Empty;
                    //dgvCaldet.DataSource = string.Empty;
                    lblTotQty.Text = string.Empty;
                    lblTotal.Text = string.Empty;

                    txtSearchDeaLCust.Text = "";
                    txtNameDeaLCust.Text = "";
                    txtEmailDeaLCust.Text = "";
                    txtContactDeaLCust.Text = "";
                    txtAddressDeaLCust.Text = "";
                    txtSearchProduct.Text = "";
                    txtProductNamePurSale.Text = "";
                    txtInventoryPurSale.Text = "0";
                    txtRatePurSale.Text = "0";
                    txtQtyPurSale.Text = "0";
                    txtSubTotal.Text = "0";
                    txtDiscount.Text = "0";
                    txtVat.Text = "0";
                    txtGrandTotal.Text = "0";
                    txtPaidAmount.Text = "0";
                    txtReturnAmount.Text = "0";

                }
                else
                {
                    MessageBox.Show("Transaction failed");
                }

            }
        }

        private void dgvAddedProducts_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dgvAddedProducts.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Bisque;
                dgvAddedProducts.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkMagenta;
            }
        }

        private void dgvAddedProducts_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dgvAddedProducts.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                dgvAddedProducts.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
            }
        }
    }
}

