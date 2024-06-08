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
    public partial class frmForgotPassword : Form
    {
        private static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        public frmForgotPassword()
        {
            InitializeComponent();
        }
        
        SqlConnection conn = new SqlConnection(myconnstring);
        private void pictureBoxLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //loginBll.username = txtUserName.Text.Trim();
            //loginBll.password = txtEmail.Text.Trim();
            //loginDal.forgetPass(loginBll);

            //if (success==true)
            //{   frmNewPassword newPassword = new frmNewPassword();
            //    this.Dispose(false);
            //    newPassword.Show();
            //}
            //else
            //{
                
            //}

            string sql = "SELECT username,email FROM tbl_users where username='" + txtUserName.Text + "' and email='" +
                         txtEmail.Text + "'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql,conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                //frmNewPassword newPassword = new frmNewPassword(txtEmail.Text);
                frmSecurityQues frmSecurityQues = new frmSecurityQues(txtEmail.Text);
                this.Dispose(false);
                //newPassword.Show();
                frmSecurityQues.Show();

            }
            else
            {
                MessageBox.Show("Please.fill the information properly and accurately");
                conn.Close();

            }
           

        }

        private void frmForgotPassword_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtUserName;
        }
    }
}
