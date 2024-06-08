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

namespace BeverageServingSystem.Interface
{
    public partial class frmNewPassword : Form
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        public frmNewPassword(string email)
        {
            InitializeComponent();
            lblEmail.Text = email;
        }
        
        SqlConnection conn = new SqlConnection(myconnstring);
        userBLL user = new userBLL();
        private void pictureBoxLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmPass_Click(object sender, EventArgs e)
        {
            if (txtNewPass.Text==txtConfrimPass.Text)
            {
                try
                {
                    string sql = "UPDATE [tbl_users]   SET [password] = '" + txtNewPass.Text + "'  WHERE email ='" + lblEmail.Text + "'";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    
                    int passConfirm = cmd.ExecuteNonQuery();
                    if (passConfirm > 0)
                    {
                        MessageBox.Show("Password has been changed");
                        conn.Close();
                        this.Close();
                        formLogin formLogin = new formLogin();
                        formLogin.Show();

                    }                
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
               
            }
            else
            {
                 MessageBox.Show("The password does not match");
            }
        }

        private void frmNewPassword_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtNewPass;
        }
    }
}
