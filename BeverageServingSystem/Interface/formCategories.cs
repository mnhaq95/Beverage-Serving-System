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
    public partial class formCategories : Form
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        public formCategories()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        categoriesBLL catAdd = new categoriesBLL();
        categoriesDAL catDal = new categoriesDAL();
        userDAL uDal = new userDAL();
        private void btnDelete_Click(object sender, EventArgs e)
        {
            catAdd.id = int.Parse(txtCategoryID.Text);
            if (MessageBox.Show("                Are you sure to delete?", "Remove Category", MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
            {
                bool success = catDal.Delete(catAdd);

                if (success == true)
                {
                    MessageBox.Show("Category Succesfully removed");
                    clear();
                    DataTable dateTb = catDal.Select();
                    dgvCategories.DataSource = dateTb;
                }
                else
                {
                    MessageBox.Show("Failed to remove a category");
                }  
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string str = txtTitle.Text;
            

            if (str == string.Empty)
            {
                MessageBox.Show("Your Title field is Empty");
            }
            else
            {
                SqlConnection conn = new SqlConnection(myconnstring);
                SqlCommand cmd = new SqlCommand("select * from tbl_categories where title='" + txtTitle.Text + "'", conn);
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
                    catAdd.title = txtTitle.Text;
                    catAdd.description = txtDescription.Text;
                    catAdd.added_date = DateTime.Now;

                    string loggedUser = formLogin.loggedIn;
                    userBLL usr = uDal.GetIDFromUserName(loggedUser);
                    catAdd.added_by = usr.id;


                    bool success = catDal.Insert(catAdd);
                    if (success == true)
                    {
                        MessageBox.Show("A new category Successfully created");
                        clear();
                        DataTable detable = catDal.Select();
                        dgvCategories.DataSource = detable;
                    }
                    else
                    {
                        MessageBox.Show("Failed to create a new category");
                    }  
                }

               
            }
            
        }
        public void clear()
        {
            txtCategoryID.Text = "";
            txtTitle.Text = "";
            txtDescription.Text = "";
            txtSearchCat.Text = "";
            
        }

        private void formCategories_Load(object sender, EventArgs e)
        {
            
            DataTable detable = catDal.Select();
            dgvCategories.DataSource = detable;
            this.ActiveControl = txtTitle;
            
        }

        private void dgvCategories_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtCategoryID.Text = dgvCategories.Rows[rowIndex].Cells[0].Value.ToString();
            txtTitle.Text = dgvCategories.Rows[rowIndex].Cells[1].Value.ToString();
            txtDescription.Text = dgvCategories.Rows[rowIndex].Cells[2].Value.ToString();
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            catAdd.id = int.Parse(txtCategoryID.Text);
            catAdd.title = txtTitle.Text;
            catAdd.description = txtDescription.Text;
            catAdd.added_date = DateTime.Now;

            string loggedUser = formLogin.loggedIn;
            userBLL usr = uDal.GetIDFromUserName(loggedUser);
            catAdd.added_by = usr.id;

            bool success = catDal.Update(catAdd);

            if (success == true)
            {
                MessageBox.Show("Category details succesfully Updated");
                clear();
                DataTable dateTb = catDal.Select();
                dgvCategories.DataSource = dateTb;
            }
            else
            {
                MessageBox.Show("Failed to update a category details");
            }

        }

        private void txtSearchCat_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearchCat.Text;

            if (keywords != null)
            {
                DataTable detable = catDal.Search(keywords);
                dgvCategories.DataSource = detable;
            }
            else
            {
                DataTable detable = catDal.Select();
                dgvCategories.DataSource = detable;
            }
        }

        private void dgvCategories_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dgvCategories.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Bisque;
                dgvCategories.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkMagenta;
            }
        }

        private void dgvCategories_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dgvCategories.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                dgvCategories.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
            }
        }
    }
}
