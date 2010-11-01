using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data.SqlClient;

namespace FAMIS_DALL
{
    public class Country
    {
        DB db;

        public Country()
        {
            db = new DB(); 
        }

        public string Add(Model.Country country)
        {

            string str = "INSERT INTO [FAMIS].[dbo].[Country] ([region_id] ,[name]) VALUES (" + Environment.NewLine;
            str += country.Region_id + ", '" + country.Name + "')";   

            try
            {
                SqlCommand scmd = new SqlCommand(str, db.Db());

                int iret = scmd.ExecuteNonQuery();
                return iret.ToString() + " Record successfully saved";
            }
            catch (SqlException ex)
            {
                return "Error saving the record of: " + country.Name.ToString() + Environment.NewLine + " Erro: " + ex.Message.ToString();
                throw;
            }
            finally
            {

            }
        }

        public string Delete(Model.Country country)
        {
            String str = "Delete From [Country] Where country_id = " + country.Country_id;

            try
            {
                SqlCommand scmd = new SqlCommand(str, db.Db());
                int iret = scmd.ExecuteNonQuery();
                return iret.ToString() + " Record deleted successfully";
            }
            catch (SqlException ex)
            {
                return "Error deleting record : " + country.Name.ToString() + Environment.NewLine + " Erro: " + ex.Message.ToString();
                throw;
            }
        }

        public string Update(Model.Country country)
        {
            String str = "Update [Country] Set " + Environment.NewLine;
            if (!string.IsNullOrEmpty(country.Region_id.ToString()))
            {
                str += " region_id= " + country.Region_id + "," + Environment.NewLine;
            }
            if (!string.IsNullOrEmpty(country.Name))
            {
                str += " name= '" + country.Name + "'" + Environment.NewLine;
            }
            str += " Where country_id = " + country.Country_id;
            try
            {
                SqlCommand scmd = new SqlCommand(str, db.Db());
                int iret = scmd.ExecuteNonQuery();
                return iret.ToString() + " Record deleted successfully";
            }
            catch (SqlException ex)
            {
                return "Error deleting record number: " + country.Name.ToString() + Environment.NewLine + " Erro: " + ex.Message.ToString();
                throw;
            }
        }

        public Model.Country Select(Model.Country country)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select * From dbo.[Country] Where country_id=" + country.Country_id, db.Db());
                SqlDataReader dr = cmd.ExecuteReader();

                Model.Country co = new Model.Country();

                if (dr.Read())
                {
                    co.Country_id = dr.GetInt32(0);
                    co.Region_id = dr.GetInt32(1);
                    co.Name = dr.GetString(2); 
                }
                return co;

            }
            catch (Exception)
            {

                throw;
            }
        }

        //Nesse caso vai retornar uma lista de objeto. Não sei se seu retorno vão ter vários, ou um por vez. Se for um por vez, não precisa usar lista.
        public List<Model.Country> Select(String pWhere)
        {

            List<Model.Country> lstCountry = new List<Model.Country>();
            Model.Country country;

            SqlCommand cmd = new SqlCommand("Select * From dbo.[Country] " + pWhere, db.Db());
            //SQLHelper.ExecuteReader("string de conexao", CommandType.StoredProcedure, "Procedure", null)
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    country = new Model.Country(); 

                    //retorno do SQlDataReader
                    if (!dr.IsDBNull(0)) //exemplo pra conferir se o retorno tem valor ou é nulo. Eu pego pelo número, da pra ser por nome também
                        country.Country_id = dr.GetInt32(0);

                    if (!dr.IsDBNull(1))
                        country.Region_id = dr.GetInt32(1);

                    if (!dr.IsDBNull(2))
                        country.Name = dr.GetString(2);  

                    lstCountry.Add(country);
                }
            }

            return lstCountry;
        }

        public SqlDataReader GetSelect(String pQuery)
        {
            SqlDataReader dr;

            try
            {
                SqlCommand cmd = new SqlCommand(pQuery, db.Db());
                dr = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro: " + ex.Message.ToString());
            }
            return dr;
        }


    }
}
