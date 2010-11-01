using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Model;

namespace FAMIS_DALL
{
    public class Product
    {
        DB db;
        public Product()
        {
            db = new DB();
        }

        public string Add(Model.Product Pd )
        {

            string str = " INSERT INTO [FAMIS].[dbo].[Product] ([name] ,[client_id]) " + Environment.NewLine;
            str += " VALUES ('" + Environment.NewLine;
            str += Pd.Name  + "'," + Environment.NewLine;
            str += Pd.Client_id + ")";

            try
            {
                SqlCommand scmd = new SqlCommand(str, db.Db());

                int iret = scmd.ExecuteNonQuery();
                return iret.ToString() + " Record successfully saved";
            }
            catch (SqlException ex)
            {
                return "Error saving the record of: " + Pd.Name.ToString() + Environment.NewLine + " Erro: " + ex.Message.ToString();
                throw;
            }
            finally
            {

            }
        }

        public string Delete(Model.Product Pd)
        {
            String str = "Delete From [Product] Where product_id = " + Pd.Product_id; 

            try
            {
                SqlCommand scmd = new SqlCommand(str, db.Db());
                int iret = scmd.ExecuteNonQuery();
                return iret.ToString() + " Record deleted successfully";
            }
            catch (SqlException ex)
            {
                return "Error deleting record : " + Pd.Name.ToString() + Environment.NewLine + " Erro: " + ex.Message.ToString();
                throw;
            }
        }

        public string Update(Model.Product Pd)
        {
            String str = " UPDATE [FAMIS].[dbo].[Product] " + Environment.NewLine;
            str += " SET " + Environment.NewLine;

            if (!string.IsNullOrEmpty(Pd.Name))
            {
                str += " [name] = '" + Pd.Name + "'" + Environment.NewLine;
            }
            str += " ,[client_id] =  " + Pd.Client_id + Environment.NewLine;

            str += " WHERE [product_id] = " + Pd.Product_id; 

            try
            {
                SqlCommand scmd = new SqlCommand(str, db.Db());
                int iret = scmd.ExecuteNonQuery();
                return iret.ToString() + " Record deleted successfully";
            }
            catch (SqlException ex)
            {
                return "Error deleting record number: " + Pd.Name.ToString() + Environment.NewLine + " Erro: " + ex.Message.ToString();
                throw;
            }
        }

        public Model.Product Select(Model.Product Pdt)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select * From [FAMIS].[dbo].[Product] Where product_id =" + Pdt.Product_id, db.Db());
                SqlDataReader dr = cmd.ExecuteReader();

                Model.Product Pd;

                Pd = new Model.Product();

                while (dr.Read())
                {

                    Pd = new Model.Product();

                    if (!dr.IsDBNull(0))
                    {
                        Pd.Product_id = dr.GetInt32(0);
                    }
                    if (!dr.IsDBNull(1))
                    {
                        Pd.Name = dr.GetString(1);
                    }
                    if (!dr.IsDBNull(1))
                    {
                        Pd.Client_id = dr.GetInt32(1);
                    }
                }

                return Pd;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Nesse caso vai retornar uma lista de objeto. Não sei se seu retorno vão ter vários, ou um por vez. Se for um por vez, não precisa usar lista.
        public List<Model.Product> Select(String pWhere)
        {

            List<Model.Product> lstProduct = new List<Model.Product>();
            Model.Product Prod;

            SqlCommand cmd = new SqlCommand("Select * From dbo.[Product] " + pWhere, db.Db());
            //SQLHelper.ExecuteReader("string de conexao", CommandType.StoredProcedure, "Procedure", null)
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    Prod = new Model.Product();

                    if (!dr.IsDBNull(0))
                    {
                        Prod.Product_id = dr.GetInt32(0);
                    }
                    if (!dr.IsDBNull(1))
                    {
                        Prod.Name = dr.GetString(1);
                    }
                    if (!dr.IsDBNull(1))
                    {
                        Prod.Client_id = dr.GetInt32(1);
                    }

                    lstProduct.Add(Prod);
                }
            }

            return lstProduct;
        }
    }
}
