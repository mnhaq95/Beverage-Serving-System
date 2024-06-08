using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class frmDeaCust : Form
    {
        public frmDeaCust()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        
        DeaCustBLL deaCustBll = new DeaCustBLL();
        DeaCusDal deaCusDal = new DeaCusDal();
        userDAL uDal = new userDAL();
        private void btnAddDeaCust_Click(object sender, EventArgs e)
        {
            string str = txtDeaCustConta.Text;
            string str1 = txtDeaCustEmail.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(str1);

            if (str == string.Empty || str1 == string.Empty)
            {
                MessageBox.Show("Your Contact or Email Field is Empty");
            }
            else
            {
                if (match.Success)
                {
                    deaCustBll.type = cmbDeaCustType.Text;
                    deaCustBll.name = txtDeaCustName.Text;
                    deaCustBll.email = txtDeaCustEmail.Text;
                    deaCustBll.contact = txtDeaCustConta.Text;
                    deaCustBll.address = TxtDeaCustAddress.Text; ;
                    deaCustBll.added_date = DateTime.Now;

                    string loggedUser = formLogin.loggedIn;
                    userBLL usr = uDal.GetIDFromUserName(loggedUser);
                    deaCustBll.added_by = usr.id;


                    bool success = deaCusDal.Insert(deaCustBll);
                    if (success == true)
                    {
                        MessageBox.Show("A dealer/customer details has been added successfully");
                        clear();
                        DataTable detable = deaCusDal.Select();
                        dgvDeaCust.DataSource = detable;
                    }
                    else
                    {
                        MessageBox.Show("Failed to add a dealer/Customer details");
                    } 
                }
                else
                {
                    MessageBox.Show("The email pattern is inaccurate");
                    clear();
                }
                
  
            }


        }
        public void clear()
        {
            txtDeaCustID.Text = "";
            txtDeaCustName.Text = "";
            txtDeaCustEmail.Text = "";
            txtDeaCustConta.Text = "";
            TxtDeaCustAddress.Text = "";
            txtSearchDeaCust.Text = "";
            

        }

        private void frmDeaCust_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtSearchDeaCust;
            DataTable detable = deaCusDal.Select();
            dgvDeaCust.DataSource = detable;
        }

        private void dgvDeaCust_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtDeaCustID.Text = dgvDeaCust.Rows[rowIndex].Cells[0].Value.ToString();
            cmbDeaCustType.Text = dgvDeaCust.Rows[rowIndex].Cells[1].Value.ToString();
            txtDeaCustName.Text = dgvDeaCust.Rows[rowIndex].Cells[2].Value.ToString();
            txtDeaCustEmail.Text = dgvDeaCust.Rows[rowIndex].Cells[3].Value.ToString();
            txtDeaCustConta.Text = dgvDeaCust.Rows[rowIndex].Cells[4].Value.ToString();
            TxtDeaCustAddress.Text = dgvDeaCust.Rows[rowIndex].Cells[5].Value.ToString();
        }

        private void btnUpdateDeaCust_Click(object sender, EventArgs e)
        {
            deaCustBll.id = int.Parse(txtDeaCustID.Text);
            deaCustBll.type = cmbDeaCustType.Text;
            deaCustBll.name = txtDeaCustName.Text;
            deaCustBll.email = txtDeaCustEmail.Text;
            deaCustBll.contact = txtDeaCustConta.Text;
            deaCustBll.address = TxtDeaCustAddress.Text; ;
            deaCustBll.added_date = DateTime.Now;

            string loggedUser = formLogin.loggedIn;
            userBLL usr = uDal.GetIDFromUserName(loggedUser);
            deaCustBll.added_by = usr.id;

            bool success = deaCusDal.update(deaCustBll);

            if (success == true)
            {
                MessageBox.Show("A dealer/customer details Updated Successfully");
                clear();
                DataTable detable = deaCusDal.Select();
                dgvDeaCust.DataSource = detable;
            }
            else
            {
                MessageBox.Show("Failed to update dealer/customer details");
            }
        }

        private void btnDeleteDeaCust_Click(object sender, EventArgs e)
        {
            deaCustBll.id = int.Parse(txtDeaCustID.Text);
            if (MessageBox.Show("                Are you sure to delete?", "Remove Dealer/Customer", MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
            {
                bool success = deaCusDal.Delete(deaCustBll);
                if (success == true)
                {
                    MessageBox.Show("A dealer or Customer details has been removed");
                    clear();
                    DataTable detable = deaCusDal.Select();
                    dgvDeaCust.DataSource = detable;
                }
                else
                {
                    MessageBox.Show("Failed to remove a dealer or Customer details");
                }    
            }

            
        }

        private void txtSearchDeaCust_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearchDeaCust.Text;

            if (keywords != null)
            {
                DataTable detable = deaCusDal.Search(keywords);
                dgvDeaCust.DataSource = detable;
            }
            else
            {
                DataTable detable = deaCusDal.Select();
                dgvDeaCust.DataSource = detable;
            }

        }

        private void dgvDeaCust_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dgvDeaCust.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                dgvDeaCust.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
            }

        }

        private void dgvDeaCust_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dgvDeaCust.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Bisque;
                dgvDeaCust.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkMagenta;
            }
        }

        private void txtDeaCustEmail_Leave(object sender, EventArgs e)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(txtDeaCustEmail.Text, pattern))
            {
                errorProviderEmail.Clear();

            }
            else
            {
                errorProviderEmail.SetError(this.txtDeaCustEmail, "Provide valid Email address, Please");
            }
        }

        private void txtDeaCustConta_Leave(object sender, EventArgs e)
        {
            string pattern = "^[0][1-9]\\d{9}$|^[1-9]\\d{9}$";
            if (Regex.IsMatch(txtDeaCustConta.Text, pattern))
            {
                errorProviderContact.Clear();

            }
            else
            {
                errorProviderContact.SetError(this.txtDeaCustConta, "Provide valid contact, Please");

            }
        }
    }
}
