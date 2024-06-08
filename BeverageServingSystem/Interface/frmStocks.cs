using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeverageServingSystem.DAL;

namespace BeverageServingSystem.Interface
{
    public partial class frmStocks : Form
    {
        public frmStocks()
        {
            InitializeComponent();
        }

        categoriesDAL categoriesDal = new categoriesDAL();
        productsDAL productsDal = new productsDAL();
        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmStocks_Load(object sender, EventArgs e)
        {
            DataTable dataTable = categoriesDal.Select();
            cmbCategory.DataSource = dataTable;

            cmbCategory.DisplayMember = "title";
            cmbCategory.ValueMember = "title";

            DataTable productDataTable = productsDal.Select();
            dgvStocks.DataSource = productDataTable;
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category = cmbCategory.Text;

            DataTable dataTable = productsDal.DisplayProductsBycategories(category);
            dgvStocks.DataSource = dataTable;
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            DataTable dataTable = productsDal.Select();
            dgvStocks.DataSource = dataTable;
        }
    }
}
