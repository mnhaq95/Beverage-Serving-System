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
    public partial class frmTransactions : Form
    {
        public frmTransactions()
        {
            InitializeComponent();
        }
        transactionDAL transaction = new transactionDAL();
        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmTransactions_Load(object sender, EventArgs e)
        {
            DataTable dataTable = transaction.DisplayAllTransactions();
            dgvTransaction.DataSource = dataTable;
        }

        private void cmbTransactionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = cmbTransactionType.Text;

            DataTable dataTable = transaction.DisplayTransactionByType(type);
            dgvTransaction.DataSource = dataTable;


        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            DataTable dataTable = transaction.DisplayAllTransactions();
            dgvTransaction.DataSource = dataTable;
            cmbTransactionType.Text = string.Empty;
        }

        }
 }
