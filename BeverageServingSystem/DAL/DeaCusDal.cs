using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeverageServingSystem.Business_Logic;

namespace BeverageServingSystem.DAL
{
    class DeaCusDal
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        #region Select method for Dealer and Customer
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstring);

            DataTable dt = new DataTable();
            try
            {
                string sql = "select * from tbl_customer ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close();
            }
            return dt;

        }
        #endregion
        #region Insert Method to add details of Dealer and customer
        public bool Insert(DeaCustBLL DeaCust)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);


            try
            {
                string sql = "insert into tbl_customer(type,name,email,contact,address,added_date,added_by) Values(@type,@name,@email,@contact,@address,@added_date,@added_by)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@type", DeaCust.type);
                cmd.Parameters.AddWithValue("@name", DeaCust.name);
                cmd.Parameters.AddWithValue("@email", DeaCust.email);
                cmd.Parameters.AddWithValue("@contact", DeaCust.contact);
                cmd.Parameters.AddWithValue("@address", DeaCust.address);
                cmd.Parameters.AddWithValue("@added_date", DeaCust.added_date);
                cmd.Parameters.AddWithValue("@added_by", DeaCust.added_by);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        #endregion
        #region Update method for Dealer and Customer
        public bool update(DeaCustBLL DeaCust)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string sql = "update tbl_customer SET type=@type,name=@name,email=@email,contact=@contact,address=@address,added_date=@added_date,added_by=@added_by WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@type", DeaCust.type);
                cmd.Parameters.AddWithValue("@name", DeaCust.name);
                cmd.Parameters.AddWithValue("@email", DeaCust.email);
                cmd.Parameters.AddWithValue("@contact", DeaCust.contact);
                cmd.Parameters.AddWithValue("@address", DeaCust.address);
                cmd.Parameters.AddWithValue("@added_date", DeaCust.added_date);
                cmd.Parameters.AddWithValue("@added_by", DeaCust.added_by);
                cmd.Parameters.AddWithValue("@id", DeaCust.id);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        #endregion
        #region Delete method for Dealer and Customer
        public bool Delete(DeaCustBLL DeaCust)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "delete FROM tbl_customer WHERE id=@id";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", DeaCust.id);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }
        #endregion
        #region Search Method for Dealer and Customer
        public DataTable Search(String keywords)
        {
            SqlConnection conn = new SqlConnection(myconnstring);

            DataTable dt = new DataTable();
            try
            {
                string sql = "select * from tbl_customer WHERE id LIKE '%" + keywords + "%' OR type LIKE '%" + keywords + "%' OR name LIKE '%" + keywords + "%'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close();
            }
            return dt;

        }

        #endregion

        #region Searh Method in Dealer and Customer for Transaction Method

        public DeaCustBLL SearchDealerCustomerForTransaction(string keywords)
        {
            
            DeaCustBLL deaCust = new DeaCustBLL();
            SqlConnection conn = new SqlConnection(myconnstring);

            DataTable dataTable = new DataTable();
            try
            {
                string sql = "select name,email,contact,address from tbl_customer WHERE id LIKE '%" + keywords + "%' OR name LIKE '%" + keywords + "%' ";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                conn.Open();
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    deaCust.name = dataTable.Rows[0]["name"].ToString();
                    deaCust.email = dataTable.Rows[0]["email"].ToString();
                    deaCust.contact = dataTable.Rows[0]["contact"].ToString();
                    deaCust.address = dataTable.Rows[0]["address"].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close();
            }
            return deaCust;

        
        }
        #endregion
        #region method in Transaction to get ID of Dealer and Customer based on Name

        public DeaCustBLL GetDeaCustIDfromName(string name)
        {
            DeaCustBLL deaCust = new DeaCustBLL();
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dataTable = new DataTable();

            try
            {
                string sql = "select id from tbl_customer WHERE name ='"+name+"'";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                conn.Open();
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count>0)
                {
                    deaCust.id = int.Parse(dataTable.Rows[0]["id"].ToString());

                }
          }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close();
            }

            return deaCust;
        }
        #endregion

    }
}
