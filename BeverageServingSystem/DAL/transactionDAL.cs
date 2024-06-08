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
    class transactionDAL
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        #region Insert Transaction Method

        public bool Insert_Transaction(transactionBLL transbBll, out int transactionID)
        {
            bool isSuccess = false;
            transactionID = -1;


            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "insert into tbl_transactions(type,cust_id,grandtotal,transactions_date,tax,discount,added_by) Values(@type,@cust_id,@grandtotal,@transaction_date,@tax,@discount,@added_by); Select @@IDENTITY;";  

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@type", transbBll.type);
                cmd.Parameters.AddWithValue("@cust_id", transbBll.cust_id);
                cmd.Parameters.AddWithValue("@grandtotal", transbBll.grandtotal);
                cmd.Parameters.AddWithValue("@transaction_date", transbBll.transction_date);
                cmd.Parameters.AddWithValue("@tax", transbBll.tax);
                cmd.Parameters.AddWithValue("@discount", transbBll.discount);
                cmd.Parameters.AddWithValue("@added_by", transbBll.added_by);

                conn.Open();

                object objTran = cmd.ExecuteScalar();

                if (objTran!= null)
                {
                    transactionID = int.Parse(objTran.ToString());
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

        #region Method to Display all the Transaction

        public DataTable DisplayAllTransactions()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dataTable = new DataTable();
            try
            {
                string sql = "select * from tbl_transactions";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                conn.Open();
                adapter.Fill(dataTable);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close();
            }
            return dataTable;
        }
        #endregion
        #region Method to Display Transaction Based on Transaction Type

        public DataTable DisplayTransactionByType(string type)
        {

            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dataTable = new DataTable();
            try
            {
                
                string sql = "select * from tbl_transactions WHERE type = '"+type+"'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                
                conn.Open();
                adapter.Fill(dataTable);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close();
            }
            return dataTable;
        }
        #endregion
    }
}
