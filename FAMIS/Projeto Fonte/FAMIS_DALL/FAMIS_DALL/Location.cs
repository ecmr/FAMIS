using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
 

namespace FAMIS_DALL
{
    public class Location
    {
        DB db;
        public Location()
        {
            db = new DB(); 
        }

        public string Add(Model.Location location)
        {

            string str = " INSERT INTO [FAMIS].[dbo].[Location] " + Environment.NewLine;
                str += " ([region_id] " + 
                      " ,[country_id] " + 
                      " ,[agency_id] " +
                      " ,[address] " + 
                      " ,[number] " +
                      " ,[city]) " + Environment.NewLine;  
                str += " VALUES (" +
                    location.Region_id + "," +
                    location.Country_id + "," +
                    location.Agency_id + ",'" +
                    location.Address + "', " +
                    location.Number + ",'" +
                    location.City + "')";

            try
            {
                SqlCommand scmd = new SqlCommand(str, db.Db());

                int iret = scmd.ExecuteNonQuery();
                return iret.ToString() + " Record successfully saved";
            }
            catch (SqlException ex)
            {
                return "Error saving the record of: " + location.Location_id.ToString() + Environment.NewLine + " Erro: " + ex.Message.ToString();
                throw;
            }
            finally
            {

            }
        }

        public string Delete(Model.Location location)
        {
            String str = "Delete From [Location] Where location_id = " + location.Location_id;

            try
            {
                SqlCommand scmd = new SqlCommand(str, db.Db());
                int iret = scmd.ExecuteNonQuery();
                return iret.ToString() + " Record deleted successfully";
            }
            catch (SqlException ex)
            {
                return "Error deleting record : " + location.Location_id.ToString() + Environment.NewLine + " Erro: " + ex.Message.ToString();
                throw;
            }
        }

        public string Update(Model.Location location)
        {
            String str = " UPDATE [FAMIS].[dbo].[Location] " + Environment.NewLine;
            str += " SET " + Environment.NewLine;

            if (!string.IsNullOrEmpty(location.Region_id.ToString()))
            {
                str += " [Region_id] = " + location.Region_id + Environment.NewLine;
            }
            if (!string.IsNullOrEmpty(location.Country_id.ToString()))
            {
                str += " ,[Country_id] =  " + location.Country_id + Environment.NewLine;
            }
            if (!string.IsNullOrEmpty(location.Agency_id.ToString()))
            {
                str += ", [Agency_id] = " + location.Agency_id + Environment.NewLine;
            }
            if (!string.IsNullOrEmpty(location.Address))
            {
                str += " ,[Address] =  '" + location.Address + "'" + Environment.NewLine;
            }
            if (!string.IsNullOrEmpty(location.Number.ToString()))
            {
                str += ", [number] = " + location.Number + Environment.NewLine;
            }
            if (!string.IsNullOrEmpty(location.City))
            {
                str += " ,[City] =  '" + location.City + "'" + Environment.NewLine;
            }
            str += " WHERE [location_id] = " + location.Location_id;  

            try
            {
                SqlCommand scmd = new SqlCommand(str, db.Db());
                int iret = scmd.ExecuteNonQuery();
                return iret.ToString() + " Record deleted successfully";
            }
            catch (SqlException ex)
            {
                return "Error deleting record number: " + location.Location_id.ToString() + Environment.NewLine + " Erro: " + ex.Message.ToString();
                throw;
            }
        }

        public Model.Location Select(Model.Location location)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select * From [FAMIS].[dbo].[Location] Where location_id =" + location.Location_id, db.Db());
                SqlDataReader dr = cmd.ExecuteReader();

                Model.Location lo;

                lo = new Model.Location(); 

                while (dr.Read())
                {
                    if (!dr.IsDBNull(0))
                    {
                        lo.Location_id = dr.GetInt32(0); 
                    }
                    if (!dr.IsDBNull(1))
                    {
                        lo.Region_id = dr.GetInt32(1); 
                    }
                    if (!dr.IsDBNull(2))
                    {
                        lo.Country_id = dr.GetInt32(2);
                    }
                    if (!dr.IsDBNull(3))
                    {
                        lo.Agency_id = dr.GetInt32(3); 
                    }
                    if (!dr.IsDBNull(4))
                    {
                        lo.Address = dr.GetString(4);
                    }
                    if (!dr.IsDBNull(5))
                    {
                        lo.Number = dr.GetInt32(5);
                    }
                    if (!dr.IsDBNull(6))
                    {
                        lo.City = dr.GetString(6);
                    }

                }
                return lo;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Nesse caso vai retornar uma lista de objeto. Não sei se seu retorno vão ter vários, ou um por vez. Se for um por vez, não precisa usar lista.
        public List<Model.Location> Select(String pWhere)
        {

            List<Model.Location> lstLocation = new List<Model.Location>();
            Model.Location lo;

            SqlCommand cmd = new SqlCommand("Select * From dbo.[Location] " + pWhere, db.Db());
            //SQLHelper.ExecuteReader("string de conexao", CommandType.StoredProcedure, "Procedure", null)
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    lo = new Model.Location();

                    lo = new Model.Location();

                    if (!dr.IsDBNull(0))
                    {
                        lo.Location_id = dr.GetInt32(0);
                    }
                    if (!dr.IsDBNull(1))
                    {
                        lo.Region_id = dr.GetInt32(1);
                    }
                    if (!dr.IsDBNull(2))
                    {
                        lo.Country_id = dr.GetInt32(2);
                    }
                    if (!dr.IsDBNull(3))
                    {
                        lo.Agency_id = dr.GetInt32(3);
                    }
                    if (!dr.IsDBNull(4))
                    {
                        lo.Address = dr.GetString(4);
                    }
                    if (!dr.IsDBNull(5))
                    {
                        lo.Number = dr.GetInt32(5);
                    }
                    if (!dr.IsDBNull(6))
                    {
                        lo.City = dr.GetString(6);
                    } 
                    lstLocation.Add(lo);
                }
            }

            return lstLocation;
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
