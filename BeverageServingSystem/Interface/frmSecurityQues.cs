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

namespace BeverageServingSystem.Interface
{
    public partial class frmSecurityQues : Form
    {
        private static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        public frmSecurityQues(string email)
        {
            InitializeComponent();
            lblEmail.Text = email;
            
        }

        SqlConnection conn = new SqlConnection(myconnstring);
        private void pictureBoxLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmPass_Click(object sender, EventArgs e)
        {
            string validity1 = lblAns.Text;
            string validity2 = textlSecAnswer.Text;
            if (validity2 == validity1)
            {
                frmNewPassword frmNewPassword = new frmNewPassword(lblEmail.Text);
                this.Dispose(false);
                frmNewPassword.Show();
            }
            else
            {
                MessageBox.Show("Security Answer doesn't Match");
            }

        }


        private void lblEmail_TextChanged(object sender, EventArgs e)
        {
            string sql = "Select secq_ques,secq_ans FROM tbl_users where email=@email";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@email", lblEmail.Text);
            SqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                txtlSecQuestion.Text = dataReader.GetValue(0).ToString();
                lblAns.Text = dataReader.GetValue(1).ToString();
            }
            conn.Close();

        }


       
    }
}
