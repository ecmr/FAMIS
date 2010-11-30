using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Model;  

namespace FAMIS_DALL
{
    public class Region
    {
        DB db;
        public Region()
        {
            db = new DB();
        }

        public string Add(Model.Region region)
        {

            string str = "INSERT INTO [FAMIS].[dbo].[Region]([name]) VALUES ('" + region.Name + "')";
                    
            try
            {
                SqlCommand scmd = new SqlCommand(str, db.Db());

                int iret = scmd.ExecuteNonQuery();
                return iret.ToString() + " Record successfully saved";
            }
            catch (SqlException ex)
            {
                return "Error saving the record of: " + region.Name.ToString() + Environment.NewLine + " Erro: " + ex.Message.ToString();
                throw;
            }
            finally
            {

            }
        }

        public string Delete(Model.Region region)
        {
            String str = "Delete From [Region] Where region_id = " + region.Region_id;

            try
            {
                SqlCommand scmd = new SqlCommand(str, db.Db());
                int iret = scmd.ExecuteNonQuery();
                return iret.ToString() + " Record deleted successfully";
            }
            catch (SqlException ex)
            {
                return "Error deleting record : " + region.Name.ToString() + Environment.NewLine + " Erro: " + ex.Message.ToString();
                throw;
            }
        }

        public string Update(Model.Region region)
        {
            String str = " UPDATE [FAMIS].[dbo].[Region] " + Environment.NewLine;

            str += " SET " + Environment.NewLine;

            if (!string.IsNullOrEmpty(region.Name.ToString()))
            {
                str += " [name] = '" + region.Name + "'" + Environment.NewLine;
            }
            str += " WHERE [region_id] = " + region.Region_id; 

            try
            {
                SqlCommand scmd = new SqlCommand(str, db.Db());
                int iret = scmd.ExecuteNonQuery();
                return iret.ToString() + " Record deleted successfully";
            }
            catch (SqlException ex)
            {
                return "Error deleting record number: " + region.Name.ToString() + Environment.NewLine + " Erro: " + ex.Message.ToString();
                throw;
            }
        }

        public Model.Region Select(Model.Region reg)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select * From [FAMIS].[dbo].[Region] Where region_id =" + reg.Region_id, db.Db());
                SqlDataReader dr = cmd.ExecuteReader();

                Model.Region region = new Model.Region();  

                if (dr.Read())
                {

                    if (!dr.IsDBNull(0))
                    {
                        region.Region_id = dr.GetInt32(0); 
                    }
                    if (!dr.IsDBNull(1))
                    {
                        region.Name = dr.GetString(1); 
                    }
                }
                return region; 

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Nesse caso vai retornar uma lista de objeto. Não sei se seu retorno vão ter vários, ou um por vez. Se for um por vez, não precisa usar lista.
        public List<Model.Region> Select(String pWhere)
        {

            List<Model.Region> lstRegion = new List<Model.Region>();
            Model.Region region;

            SqlCommand cmd = new SqlCommand("Select * From dbo.[Region] " + pWhere, db.Db());

            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    region = new Model.Region();

                    if (!dr.IsDBNull(0))
                    {
                        region.Region_id = dr.GetInt32(0);
                    }
                    if (!dr.IsDBNull(1))
                    {
                        region.Name = dr.GetString(1);
                    } 
                    
                    lstRegion.Add(region);
                }
            }

            return lstRegion;
        }

    }
}
