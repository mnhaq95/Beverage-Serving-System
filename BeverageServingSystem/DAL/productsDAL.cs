using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeverageServingSystem.Business_Logic;

namespace BeverageServingSystem.DAL
{
    internal class productsDAL
    {
        private static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        #region Select method for products

        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                string sql = "select * from tbl_products ";
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

        #region Method to Insert Product in Database

        public bool Insert(productsBLL products)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql =
                    "insert into tbl_products(name,category,description,rate,qty,added_date,added_by) Values(@name,@category,@description,@rate,@qty,@added_date,@added_by)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@name", products.name);
                cmd.Parameters.AddWithValue("@category", products.category);
                cmd.Parameters.AddWithValue("@description", products.description);
                cmd.Parameters.AddWithValue("@rate", products.rate);
                cmd.Parameters.AddWithValue("@qty", products.qty);
                cmd.Parameters.AddWithValue("@added_date", products.added_date);
                cmd.Parameters.AddWithValue("@added_by", products.added_by);

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

        #region Method to Update Product in Databse

        public bool Update(productsBLL products)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {

                string sql =
                    "update tbl_products SET name=@name,category=@category,description=@description,rate=@rate,added_date=@added_date,added_by=@added_by WHERE id=@id";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@name", products.name);
                cmd.Parameters.AddWithValue("@category", products.category);
                cmd.Parameters.AddWithValue("@description", products.description);
                cmd.Parameters.AddWithValue("@rate", products.rate);
                cmd.Parameters.AddWithValue("@added_date", products.added_date);
                cmd.Parameters.AddWithValue("@added_by", products.added_by);
                cmd.Parameters.AddWithValue("@id", products.id);

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

        #region Method to delete product from Database

        public bool Delete(productsBLL products)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            bool isSuccess = false;
            try
            {

                string sql = "delete from tbl_products where id=@id ";
                SqlCommand cmd = new SqlCommand(sql, conn);


                cmd.Parameters.AddWithValue("@id", products.id);

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

        #region Method to search product from Database

        public DataTable Search(String keywords)
        {
            SqlConnection conn = new SqlConnection(myconnstring);

            DataTable dt = new DataTable();
            try
            {
                string sql = "select * from tbl_products WHERE id LIKE '%" + keywords + "%' OR name LIKE '%" + keywords +
                             "%' OR category LIKE '%" + keywords + "%' ";
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

        #region Method to search product in Transaction

        public productsBLL GetProductsForTranscation(string keywords)
        {
            productsBLL productsBll = new productsBLL();
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dataTable = new DataTable();
            try
            {
                string sql = "select name,rate,qty FROM tbl_products WHERE id LIKE '%" + keywords + "%' OR name LIKE '%" +
                             keywords + "%' ";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                conn.Open();
                adapter.Fill(dataTable);


                if (dataTable.Rows.Count > 0)
                {
                    productsBll.name = dataTable.Rows[0]["name"].ToString();
                    productsBll.rate = decimal.Parse(dataTable.Rows[0]["rate"].ToString());
                    productsBll.qty = decimal.Parse(dataTable.Rows[0]["qty"].ToString());
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

            return productsBll;
        }

        #endregion

        #region Method to fetch product id based on product Name

        public productsBLL GetProductIDfromName(string productName)
        {
            productsBLL productsBll = new productsBLL();
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dataTable = new DataTable();

            try
            {
                string sql = "select id from tbl_products WHERE name ='" + productName + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                conn.Open();
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    productsBll.id = int.Parse(dataTable.Rows[0]["id"].ToString());

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

            return productsBll;
        }

        #endregion

        #region Display Products based on categories

        public DataTable DisplayProductsBycategories(string category)
        {
            SqlConnection conn = new SqlConnection(myconnstring);

            DataTable dataTable = new DataTable();
            try
            {
                string sql = "select * from tbl_products WHERE category ='" + category + "' ";
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

         #region Method to recieve current quantity from database based on product ID

        public decimal GetProductQty(int ProductID)
        {
            SqlConnection conn = new SqlConnection(myconnstring);

            decimal qty = 0;
            DataTable dt = new DataTable();
            try
            {
                string sql = "select qty from tbl_products WHERE id ="+ProductID;
                SqlCommand cmd = new SqlCommand(sql,conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
                if (dt.Rows.Count>0)
                {
                    qty = decimal.Parse(dt.Rows[0]["qty"].ToString());
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
            return qty;
        }
        #endregion

        #region Method to update quantity

        public bool UpdateQuantity(int ProductID, decimal Qty)
        {
            bool succes = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "update tbl_products SET qty=@qty WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("qty",Qty);
                cmd.Parameters.AddWithValue("id", ProductID);
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    succes = true;
                }
                else
                {
                    succes = false;
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
            return succes;
        }
        #endregion

        #region Method to increase product

        public bool IncreaseProduct(int ProductID, decimal IncreaseQty)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                decimal currentyQty = GetProductQty(ProductID);

                decimal NewQty = currentyQty + IncreaseQty;

                success = UpdateQuantity(ProductID, NewQty);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return success;
        }

        #endregion

        #region Method to decrease product

        public bool DecreaseProduct(int ProductID, decimal qty)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                decimal currentyQty = GetProductQty(ProductID);

                decimal NewQty = currentyQty - qty;

                success = UpdateQuantity(ProductID, NewQty);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return success;
            return success;
        }

        #endregion
    }
}



