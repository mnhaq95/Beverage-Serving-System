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
    class categoriesDAL
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

#region Select Method

        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dateable = new DataTable();
            
            try
            {
                string sql = "select * from tbl_categories ";

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();

                adapter.Fill(dateable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close();
            }
            return dateable;
        }

#endregion
#region Insert New Category

        public bool Insert(categoriesBLL Catbll)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql =
                    "insert into tbl_categories(title,description,added_date,added_by) VALUES (@title,@description,@added_date,@added_by)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@title", Catbll.title);
                cmd.Parameters.AddWithValue("@description", Catbll.description);
                cmd.Parameters.AddWithValue("@added_date", Catbll.added_date);
                cmd.Parameters.AddWithValue("@added_by", Catbll.added_by);

                conn.Open();
                
                int rows = cmd.ExecuteNonQuery();

                if (rows >0)
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
#region Update Method

        public bool Update(categoriesBLL Catbll)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "update tbl_categories SET title=@title,description=@description,added_date=@added_date,added_by=@added_by WHERE id=@id";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@title", Catbll.title);
                cmd.Parameters.AddWithValue("@description", Catbll.description);
                cmd.Parameters.AddWithValue("@added_date", Catbll.added_date);
                cmd.Parameters.AddWithValue("@added_by", Catbll.added_by);
                cmd.Parameters.AddWithValue("@id", Catbll.id);

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
#region Delete Category Method

        public bool Delete(categoriesBLL Catbll)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "delete from tbl_categories WHERE id=@id";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", Catbll.id);

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
#region Search Category Method
        public DataTable Search(String keywords)
        {
            SqlConnection conn = new SqlConnection(myconnstring);

            DataTable dt = new DataTable();
            try
            {
                string sql = "select * from tbl_categories WHERE id LIKE '%" + keywords + "%' OR title LIKE '%" + keywords + "%' OR description LIKE '%" + keywords + "%'";
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
    }
}
