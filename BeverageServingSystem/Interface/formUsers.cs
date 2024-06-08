using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeverageServingSystem.Business_Logic;
using BeverageServingSystem.DAL;

namespace BeverageServingSystem.Interface
{
    public partial class formUsers : Form
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        public formUsers()
        {
            InitializeComponent();
        }

        private userBLL userAdd = new userBLL();
        private userDAL userDal = new userDAL();

        

        private void formUsers_Load(object sender, EventArgs e)
        {
            lbllLoggedInUser.Text = formLogin.loggedIn;
            DataTable dataTable = userDal.Select();
            dataGridViewUsers.DataSource = dataTable;

            //Hide columns in datagridview
            dataGridViewUsers.Columns[13].Visible = false;
            dataGridViewUsers.Columns[14].Visible = false;

        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
      

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //string pattern =
            //"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\\.[A-Z]{2,}$";
            //const string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)" + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
            string str = txtUserName.Text;
            string str1 = txtEmail.Text;
            string str2 = cmbSecqQues.Text;
            string str3 = txtSearchUser.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(str1);

            if (str == string.Empty || str1 == string.Empty)
            {
                MessageBox.Show("Your UserName or Email Field is Empty");
            }
            else
            {
                SqlConnection conn = new SqlConnection(myconnstring);
                SqlCommand cmd = new SqlCommand("select * from tbl_users where username='" + txtUserName.Text + "'", conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                //userAdd.username = txtUserName.Text;
                //bool success = userDal.RecordExist(userAdd);
                int rows = dataSet.Tables[0].Rows.Count;
                if (rows > 0)
                {
                    MessageBox.Show("UserName already Exists!");
                    
                }
                //if (success == true)
                //{
                //    MessageBox.Show("UserName already Exists!");
                //    clear();
                //}
                else
                {
                    if (str2 == string.Empty || str3 == string.Empty)
                    {
                        MessageBox.Show("Please, fill up the security answers properly");
                    }
                    else
                    {
                        if (match.Success)
                        {
                            userAdd.first_name = txtFirstName.Text;
                            userAdd.last_name = txtLastName.Text;
                            userAdd.email = txtEmail.Text;
                            userAdd.username = txtUserName.Text;
                            userAdd.password = txtPassword.Text;
                            userAdd.contact = txtContact.Text;
                            userAdd.address = txtAddress.Text;
                            userAdd.gender = cmbGender.Text;
                            userAdd.user_type = cmbUserType.Text;
                            userAdd.branch = txtBranch.Text;
                            userAdd.added_date = DateTime.Now;
                            string loggedUser = formLogin.loggedIn;
                            userBLL usr = userDal.GetIDFromUserName(loggedUser);
                            userAdd.added_by = usr.id;
                            userAdd.secq_ques = cmbSecqQues.Text;
                            userAdd.secq_ans = txtSecqAns.Text;
                            //userAdd.added_by = 1;

                            bool success1 = userDal.Insert(userAdd);
                            if (success1 == true)
                            {
                                MessageBox.Show("A User Successfully created");
                                clear();
                            }
                            else
                            {
                                MessageBox.Show("Failed to create a new User");
                            }

                            DataTable dataTable = userDal.Select();
                            dataGridViewUsers.DataSource = dataTable;
                        }
                        else
                        {

                            MessageBox.Show("The email pattern is inaccurate");

                        }
                    }
                    
                    
                }
                
            }
            

        }


        private void clear()
        {
            txtUserName.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
            cmbGender.Text = "";
            cmbUserType.Text = "";
            txtEmail.Text = "";
            txtBranch.Text = "";
            cmbSecqQues.Text = "";
            txtSecqAns.Text = "";


        }

        private void dataGridViewUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtUserID.Text = dataGridViewUsers.Rows[rowIndex].Cells[0].Value.ToString();
            txtFirstName.Text = dataGridViewUsers.Rows[rowIndex].Cells[1].Value.ToString();
            txtLastName.Text = dataGridViewUsers.Rows[rowIndex].Cells[2].Value.ToString();
            txtEmail.Text = dataGridViewUsers.Rows[rowIndex].Cells[3].Value.ToString();
            txtUserName.Text = dataGridViewUsers.Rows[rowIndex].Cells[4].Value.ToString();
            //txtPassword.Text = dataGridViewUsers.Rows[rowIndex].Cells[5].Value.ToString();
            txtContact.Text = dataGridViewUsers.Rows[rowIndex].Cells[6].Value.ToString();
            txtAddress.Text = dataGridViewUsers.Rows[rowIndex].Cells[7].Value.ToString();
            cmbGender.Text = dataGridViewUsers.Rows[rowIndex].Cells[8].Value.ToString();
            cmbUserType.Text = dataGridViewUsers.Rows[rowIndex].Cells[9].Value.ToString();
            txtBranch.Text = dataGridViewUsers.Rows[rowIndex].Cells[12].Value.ToString();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string str = txtUserName.Text;
            string str1 = txtEmail.Text;
            string passfield = txtPassword.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(str1);

            if (str == string.Empty || str1 == string.Empty)
            {
                MessageBox.Show("Your UserName or Email Field is Empty");
            }
            else
            {
                //SqlConnection conn = new SqlConnection(myconnstring);
                //SqlCommand cmd = new SqlCommand("select * from tbl_users where username='" + txtUserName.Text + "'",
                //    conn);
                //SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                //DataSet dataSet = new DataSet();
                //dataAdapter.Fill(dataSet);

                //int rows = dataSet.Tables[0].Rows.Count;
                //if (rows > 0)
                //{
                //    MessageBox.Show("UserName already Exists!");
                //    clear();
                //}
                if (passfield != string.Empty)
                {
                    MessageBox.Show("User Password can't be changed");
                }
                else
                {
                    if (match.Success)
                    {
                        userAdd.id = Convert.ToInt32(txtUserID.Text);
                        userAdd.first_name = txtFirstName.Text;
                        userAdd.last_name = txtLastName.Text;
                        userAdd.email = txtEmail.Text;
                        userAdd.username = txtUserName.Text;
                        //userAdd.password = txtPassword.Text;
                        userAdd.contact = txtContact.Text;
                        userAdd.address = txtAddress.Text;
                        userAdd.gender = cmbGender.Text;
                        userAdd.branch = txtBranch.Text;
                        userAdd.user_type = cmbUserType.Text;
                        userAdd.added_date = DateTime.Now;
                        userAdd.added_by = 1;


                        bool success = userDal.update(userAdd);

                        if (success == true)
                        {
                            MessageBox.Show("User succesfully updated");
                        }
                        else
                        {
                            MessageBox.Show("Failed To update a user");
                        }
                        DataTable dataTable = userDal.Select();
                        dataGridViewUsers.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("The email pattern is inaccurate");
                    }
                
                }
                   

            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            userAdd.id = Convert.ToInt32(txtUserID.Text);

            string str3 = "Admin";
            if (txtUserName.Text == lbllLoggedInUser.Text)
            {
                MessageBox.Show("User couldn't removed");
            }
            else
            {
                if (cmbUserType.Text == str3)
                {
                    MessageBox.Show("Admin unable to delete");
                }
                else
                {
                    if (MessageBox.Show("                Are you sure to delete?", "Remove User",
                        MessageBoxButtons.YesNo) ==
                    DialogResult.Yes)
                    {
                        bool success = userDal.Delete(userAdd);
                        if (success == true)
                        {
                            MessageBox.Show("User Succesfully removed");
                        }
                        else
                        {
                            MessageBox.Show("Failed To remove a user");
                        }
                        DataTable dataTable = userDal.Select();
                        dataGridViewUsers.DataSource = dataTable;
                    }
                    
                }
                

                  
            }

            
        }

        private void txtSearchUser_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearchUser.Text;

            if (keywords != null)
            {
                DataTable detable = userDal.Search(keywords);
                dataGridViewUsers.DataSource = detable;
            }
            else
            {
                DataTable detable = userDal.Select();
                dataGridViewUsers.DataSource = detable;
            }

        }



        private void txtEmail_Leave(object sender, EventArgs e)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(txtEmail.Text, pattern))
            {
                errorProviderEmail.Clear();

            }
            else
            {
                errorProviderEmail.SetError(this.txtEmail, "Provide valid Email address, Please");
            }
        }

        private void txtContact_Leave(object sender, EventArgs e)
        {
            string pattern = "^[0][1-9]\\d{9}$|^[1-9]\\d{9}$";
            if (Regex.IsMatch(txtContact.Text, pattern))
            {
                errorProviderContact.Clear();

            }
            else
            {
                errorProviderContact.SetError(this.txtContact, "Provide valid contact, Please");

            }
        }

        private void dataGridViewUsers_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dataGridViewUsers.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Bisque;
                dataGridViewUsers.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkMagenta;
            }
        }

        private void dataGridViewUsers_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dataGridViewUsers.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                dataGridViewUsers.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
            }
        }

        private void txtUserName_MouseLeave(object sender, EventArgs e)
        {
            lblAvailabity.Text = string.Empty;
            
        }

        private void formUsers_MouseLeave(object sender, EventArgs e)
        {
            lblAvailabity.Text = string.Empty;
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtUserName.Text == string.Empty)
            {
                lblAvailabity.Text = string.Empty;
            }
            else
            {
                SqlConnection con = new SqlConnection(myconnstring);
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from tbl_users where username='" + txtUserName.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (int.Parse(dt.Rows[0][0].ToString()) == 0)
                {
                    lblAvailabity.Text = "UserName Available";
                    //lblAvailabity.Text = txtName.Text + "Available";
                    this.lblAvailabity.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    lblAvailabity.Text = "UserName Already exists!";
                    //lblAvailabity.Text = txtName.Text + " Already Exists!";
                    this.lblAvailabity.ForeColor = System.Drawing.Color.Red;
                }

            }

        }

        private void dataGridViewUsers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 5 && e.Value != null)
            {
                e.Value = new string('*', e.Value.ToString().Length);

            }
        }

        
    }
}


