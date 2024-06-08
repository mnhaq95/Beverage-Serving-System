using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeverageServingSystem.Business_Logic;
using BeverageServingSystem.DAL;

namespace BeverageServingSystem.Interface
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }
        loginBll logUser = new loginBll();
        loginDAL dalUser = new loginDAL();
        public static string loggedIn;


        private void pictureBoxLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            logUser.username = txtUserName.Text.Trim();
            logUser.password = txtPassword.Text.Trim();
            logUser.user_type = cmbUserType.Text.Trim();

            bool success = dalUser.LoginCheck(logUser);

            if (success == true)
            {
                MessageBox.Show("Login Successful");
                loggedIn = logUser.username;
                switch (logUser.user_type)
                {
                    case"Admin":
                    {
                        FormAdminDashboard admin= new FormAdminDashboard();
                        admin.Show();
                        this.Hide();
                    }
                    break;

                    case "User":
                    {
                        formUserPanel user = new formUserPanel();
                        user.Show();
                        this.Hide();
                    }
                    break;
                    
                    default:
                    {

                        MessageBox.Show("Invalid User Type");
                    }
                    break;   
                }
            }
            else
            {
                MessageBox.Show("Login Failed. Please Check Username and Password");
                
            }

        }

        private void formLogin_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtUserName;
        }

        private void lblForgetPassword_Click(object sender, EventArgs e)
        {
            frmForgotPassword forgotPassword = new frmForgotPassword();
            this.Dispose(false);
            forgotPassword.Show();
        }
    }
}
