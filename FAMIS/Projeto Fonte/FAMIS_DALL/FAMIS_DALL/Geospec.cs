using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Model; 

namespace FAMIS_DALL
{
    public class Geospec
    {
        DB db;

        public Geospec()
        {
            db = new DB();
        }

        public string Add(Model.Geospec geo)
        {

            string str = " INSERT INTO [FAMIS].[dbo].[Geospec] ([currency],[decimal_symbol],[date_format],[region_id],[country_id])" + Environment.NewLine;
            str += " VALUES ('" +
                geo.Currency + "','" +
                geo.Decimal_symbol + "', '" +
                geo.Date_format + "'," +
                geo.Region_id + "," +
                geo.Country_id + ")";

            try
            {
                SqlCommand scmd = new SqlCommand(str, db.Db());

                int iret = scmd.ExecuteNonQuery();
                return iret.ToString() + " Record successfully saved";
            }
            catch (SqlException ex)
            {
                return "Error saving the record of: " + geo.Geospec_id + Environment.NewLine + " Erro: " + ex.Message.ToString();
                throw;
            }
            finally
            {

            }
        }

        public string Delete(Model.Geospec geo)
        {
            String str = "Delete From [Geospec] Where geospec_id = " + geo.Geospec_id;

            try
            {
                SqlCommand scmd = new SqlCommand(str, db.Db());
                int iret = scmd.ExecuteNonQuery();
                return iret.ToString() + " Record deleted successfully";
            }
            catch (SqlException ex)
            {
                return "Error deleting record : " + geo.Geospec_id.ToString() + Environment.NewLine + " Erro: " + ex.Message.ToString();
                throw;
            }
        }

        public string Update(Model.Geospec Geo)
        {
            String str = " UPDATE [FAMIS].[dbo].[Geospec] " + Environment.NewLine;
            str += " SET " + Environment.NewLine;

            if (!string.IsNullOrEmpty(Geo.Currency))
            {
                str += " [Currency] = '" + Geo.Currency + "'" + Environment.NewLine;
            }
            if (!string.IsNullOrEmpty(Geo.Decimal_symbol))
            {
                str += " ,[Decimal_symbol] =  '" + Geo.Decimal_symbol + "'" + Environment.NewLine;
            }
            if (!string.IsNullOrEmpty(Geo.Date_format.ToString()))
            {
                str += " ,[Date_format] =  '" + Geo.Date_format + "'" + Environment.NewLine;
            }
            if (!string.IsNullOrEmpty(Geo.Region_id.ToString()))
            {
                str += " ,[Region_id] =  " + Geo.Region_id + Environment.NewLine;
            }
            if (!string.IsNullOrEmpty(Geo.Country_id.ToString()))
            {
                str += " ,[Country_id] = " + Geo.Country_id + Environment.NewLine;
            }
            str += " WHERE [Geospec_id] = " + Geo.Geospec_id;

            try
            {
                SqlCommand scmd = new SqlCommand(str, db.Db());
                int iret = scmd.ExecuteNonQuery();
                return iret.ToString() + " Record deleted successfully";
            }
            catch (SqlException ex)
            {
                return "Error deleting record number: " + Geo.Geospec_id.ToString() + Environment.NewLine + " Erro: " + ex.Message.ToString();
                throw;
            }
        }

        public Model.Geospec Select(Model.Geospec Geo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select * From [FAMIS].[dbo].[Geospec] Where Geospec_id =" + Geo.Geospec_id, db.Db());
                SqlDataReader dr = cmd.ExecuteReader();

                Model.Geospec geospec;
                geospec = new Model.Geospec();
                if(dr.Read())
                {
                    if (!dr.IsDBNull(0))
                    {
                        geospec.Currency = dr.GetString(0);
                    }
                    if (!dr.IsDBNull(1))
                    {
                        geospec.Decimal_symbol = dr.GetString(1);
                    }
                    if (!dr.IsDBNull(2))
                    {
                        geospec.Date_format = dr.GetDateTime(2);
                    }
                    if (!dr.IsDBNull(3))
                    {
                        geospec.Region_id = dr.GetInt32(3);
                    }
                    if (!dr.IsDBNull(4))
                    {
                        geospec.Country_id = dr.GetInt32(4);
                    }
                }
                return geospec;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Nesse caso vai retornar uma lista de objeto. Não sei se seu retorno vão ter vários, ou um por vez. Se for um por vez, não precisa usar lista.
        public List<Model.Geospec> Select(String pWhere)
        {

            List<Model.Geospec> lstGeospec = new List<Model.Geospec>();
            Model.Geospec Geo;

            SqlCommand cmd = new SqlCommand("Select * From dbo.[Geospec] " + pWhere, db.Db());
            //SQLHelper.ExecuteReader("string de conexao", CommandType.StoredProcedure, "Procedure", null)
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    Geo = new Model.Geospec();

                    if (!dr.IsDBNull(0))
                    {
                        Geo.Geospec_id = dr.GetInt32(0); 
                    }
                    if (!dr.IsDBNull(1))
                    {
                        Geo.Currency = dr.GetString(1);
                    }
                    if (!dr.IsDBNull(2))
                    {
                        Geo.Decimal_symbol = dr.GetString(2);
                    }
                    if (!dr.IsDBNull(3))
                    {
                        Geo.Date_format = dr.GetDateTime(3);
                    }
                    if (!dr.IsDBNull(4))
                    {
                        Geo.Region_id = dr.GetInt32(4);
                    }
                    if (!dr.IsDBNull(5))
                    {
                        Geo.Country_id = dr.GetInt32(5);
                    }

                    lstGeospec.Add(Geo);
                }
            }

            return lstGeospec;
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
