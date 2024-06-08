using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeverageServingSystem.Business_Logic;
using BeverageServingSystem.DAL;

namespace BeverageServingSystem.Interface
{
    public partial class frmProducts : Form
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        public frmProducts()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        categoriesDAL dalProductsCat = new categoriesDAL();
        productsBLL productsBll = new productsBLL();
        productsDAL productsDal = new productsDAL();
        userDAL uDal = new userDAL();
        private void frmProducts_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtSearchProduct;
            DataTable categoriesDt = dalProductsCat.Select();
            cmbCategoryProducts.DataSource = categoriesDt;

            
            cmbCategoryProducts.DisplayMember = "title";
            cmbCategoryProducts.ValueMember = "title";

            DataTable dt = productsDal.Select();
            dgvProducts.DataSource = dt;

            dgvProducts.Columns[5].Visible = false;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string str = txtName.Text;
            string str1 = txtRateProduct.Text;

            if (str == string.Empty || str1 == string.Empty)
            {
                MessageBox.Show("Product name or Rate is Blank");
            }
            else
            {
                SqlConnection conn = new SqlConnection(myconnstring);
                SqlCommand cmd = new SqlCommand("select * from tbl_products where name='" + txtName.Text + "'", conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                int rows = dataSet.Tables[0].Rows.Count;
                if (rows > 0)
                {
                    MessageBox.Show("Product already Exists!");

                }
                else
                {
                    productsBll.name = txtName.Text;
                    productsBll.category = cmbCategoryProducts.Text;
                    productsBll.description = txtDescriptionProduct.Text;
                    productsBll.rate = decimal.Parse(txtRateProduct.Text);
                    productsBll.qty = 0;
                    productsBll.added_date = DateTime.Now;
                    string loggedUser = formLogin.loggedIn;
                    userBLL usr = uDal.GetIDFromUserName(loggedUser);


                    productsBll.added_by = usr.id;

                    bool success = productsDal.Insert(productsBll);
                    if (success == true)
                    {
                        MessageBox.Show("A product has been inserted successfully");
                        clear();
                        DataTable detable = productsDal.Select();
                        dgvProducts.DataSource = detable;
                    }
                    else
                    {
                        MessageBox.Show("Failed to insert a new a product");
                    } 
                }

               
            }
            

             
        }
        public void clear()
        {
            txtProductID.Text = "";
            txtName.Text = "";
            txtDescriptionProduct.Text = "";
            txtRateProduct.Text = "";
            txtSearchProduct.Text = "";
            
        }

        private void dgvProducts_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtProductID.Text = dgvProducts.Rows[rowIndex].Cells[0].Value.ToString();
            txtName.Text = dgvProducts.Rows[rowIndex].Cells[1].Value.ToString();
            cmbCategoryProducts.Text = dgvProducts.Rows[rowIndex].Cells[2].Value.ToString();
            txtDescriptionProduct.Text = dgvProducts.Rows[rowIndex].Cells[3].Value.ToString();
            txtRateProduct.Text = dgvProducts.Rows[rowIndex].Cells[4].Value.ToString();
            
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            productsBll.id = int.Parse(txtProductID.Text);
            productsBll.name = txtName.Text;
            productsBll.category = cmbCategoryProducts.Text;
            productsBll.description = txtDescriptionProduct.Text;
            productsBll.rate = decimal.Parse(txtRateProduct.Text);
            productsBll.added_date = DateTime.Now;

            string loggedUser = formLogin.loggedIn;
            userBLL usr = uDal.GetIDFromUserName(loggedUser);
            productsBll.added_by = usr.id;

            bool success = productsDal.Update(productsBll);
            if (success == true)
            {
                MessageBox.Show("A product details has been updated Successfully");
                clear();
                DataTable detable = productsDal.Select();
                dgvProducts.DataSource = detable;
            }
            else
            {
                MessageBox.Show("Failed to update a product details");
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            productsBll.id = int.Parse(txtProductID.Text);
            if (MessageBox.Show("                Are you sure to delete?", "Remove Product", MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
            {
                bool success = productsDal.Delete(productsBll);
                if (success == true)
                {
                    MessageBox.Show("A product has been removed");
                    clear();
                    DataTable detable = productsDal.Select();
                    dgvProducts.DataSource = detable;
                }
                else
                {
                    MessageBox.Show("Failed to remove a product");
                }
            }
            
            


        }

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearchProduct.Text;

            if (keywords != null)
            {
                DataTable detable = productsDal.Search(keywords);
                dgvProducts.DataSource = detable;
            }
            else
            {
                DataTable detable = productsDal.Select();
                dgvProducts.DataSource = detable;
            }
        }

        private void dgvProducts_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dgvProducts.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Bisque;
                dgvProducts.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkMagenta;
            }
        }

        private void dgvProducts_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dgvProducts.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                dgvProducts.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
            }
        }

        private void frmProducts_MouseLeave(object sender, EventArgs e)
        {
            lblAvailabity.Text = string.Empty;
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (txtName.Text == string.Empty)
            {
                lblAvailabity.Text = string.Empty;
            }
            else
            {
                SqlConnection con = new SqlConnection(myconnstring);
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from tbl_products where name='" + txtName.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (int.Parse(dt.Rows[0][0].ToString()) == 0)
                {
                    lblAvailabity.Text = "Product Available";
                    this.lblAvailabity.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    lblAvailabity.Text = "Product Already Exists!";
                    this.lblAvailabity.ForeColor = System.Drawing.Color.Red;
                }
            }
        }
    }
}
