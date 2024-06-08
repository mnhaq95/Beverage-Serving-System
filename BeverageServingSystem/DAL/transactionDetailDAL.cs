using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeverageServingSystem.Business_Logic;

namespace BeverageServingSystem.DAL
{
    class transactionDetailDAL
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        #region Insert Method for Transaction Detail

        public bool InsertTransactionDetail(transactionDetailBLL transactionDetailBll)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "insert into tbl_transaction_detail(product_id,rate,qty,total,cust_id,added_date,added_by) Values(@product_id,@rate,@qty,@total,@cust_id,@added_date,@added_by)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@product_id", transactionDetailBll.product_id);
                cmd.Parameters.AddWithValue("@rate", transactionDetailBll.rate);
                cmd.Parameters.AddWithValue("@qty", transactionDetailBll.qty);
                cmd.Parameters.AddWithValue("@total", transactionDetailBll.total);
                cmd.Parameters.AddWithValue("@cust_id", transactionDetailBll.cust_id);
                cmd.Parameters.AddWithValue("@added_date", transactionDetailBll.added_date);
                cmd.Parameters.AddWithValue("@added_by", transactionDetailBll.added_by);

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
    }
}
