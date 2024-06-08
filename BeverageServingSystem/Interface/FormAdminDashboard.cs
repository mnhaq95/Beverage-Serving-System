using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeverageServingSystem.Interface;

namespace BeverageServingSystem
{
    public partial class FormAdminDashboard : Form
    {
        public FormAdminDashboard()
        {
            InitializeComponent();
        }

        private void FormAdminDashboard_Load(object sender, EventArgs e)
        {
            lbllLoggedInUser.Text = formLogin.loggedIn;
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formUsers users= new formUsers();
            users.Show();
        }

        private void FormAdminDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            formLogin login = new formLogin();
            login.Show();
            this.Hide();
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCategories frmCat = new formCategories();
            frmCat.Show();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProducts frmPrd = new frmProducts();
            frmPrd.Show();

        }

        private void dealerAndCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeaCust frmDeaCust = new frmDeaCust();
            frmDeaCust.Show();
        }

        private void transictionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTransactions transactions = new frmTransactions();
            transactions.Show();
        }

        private void stocksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStocks stocks = new  frmStocks();
            stocks.Show();
        }
    }
}
