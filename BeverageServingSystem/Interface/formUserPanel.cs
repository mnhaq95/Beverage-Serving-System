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
    public partial class formUserPanel : Form
    {
        public formUserPanel()
        {
            InitializeComponent();
        }

        public static string transactionType;
        private void formUserPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            formLogin login = new formLogin();
            login.Show();
            this.Hide();
        }

        private void formUserPanel_Load(object sender, EventArgs e)
        {
            lbllLoggedInUser.Text = formLogin.loggedIn;
        }

        private void dealerAndCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeaCust frmDeaCust = new frmDeaCust();
            frmDeaCust.Show();
        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            transactionType = "Purchase";
            frmPurchaseAndSales purchase =  new frmPurchaseAndSales();
            purchase.Show();
            
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            transactionType = "Sales";
            frmPurchaseAndSales sales = new frmPurchaseAndSales();
            sales.Show();
            
        }

        private void stocksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStocks stocks = new frmStocks();
            stocks.Show();
        }
    }
}
