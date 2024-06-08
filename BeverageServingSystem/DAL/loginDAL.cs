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
    internal class loginDAL
    {
        private static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        public bool LoginCheck(loginBll log)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);

            try

            {
                string sql =
                    "select * from tbl_users WHERE username=@username AND password=@password AND user_type=@user_type";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@username", log.username);
                cmd.Parameters.AddWithValue("@password", log.password);
                cmd.Parameters.AddWithValue("@user_type", log.user_type);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
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
#region Forgot Password

        //public bool forgetPass(loginBll forgetpasswordBll)
        //{
        //    bool isSuccess = false;
        //    SqlConnection conn = new SqlConnection(myconnstring);

        //    try
        //    {
        //        string sql = "select * from tbl_users WHERE username=@username AND email=@email";
        //        SqlCommand cmd = new SqlCommand(sql, conn);

        //        cmd.Parameters.AddWithValue("@username", forgetpasswordBll.username);
        //        cmd.Parameters.AddWithValue("@email", forgetpasswordBll.email);
        //        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //        DataTable dt = new DataTable();
        //        adapter.Fill(dt);
        //        if (dt.Rows.Count > 0)
        //        {
        //            isSuccess = true;
        //        }
        //        else
        //        {
        //            isSuccess = false;
        //        }

        //        string sql = "select * from tbl_users WHERE username=@username AND email=@email";
        //        SqlCommand cmd = new SqlCommand(sql, conn);
        //        cmd.Parameters.AddWithValue("@username", forgetpasswordBll.username);
        //        cmd.Parameters.AddWithValue("@email", forgetpasswordBll.email);
        //        SqlDataReader dr = cmd.ExecuteReader();

                
                

        //    }
        //    catch (Exception ex
        //        )
        //    {

        //        MessageBox.Show(ex.Message);
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //    return isSuccess;

      //  }
#endregion
    }
}

