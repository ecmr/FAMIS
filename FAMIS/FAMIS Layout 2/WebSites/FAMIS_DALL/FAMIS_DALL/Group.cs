using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Model;
  
namespace FAMIS_DALL
{
    public class Group
    {
        DB db;
        public Group()
        {
            db = new DB();
        }

        public string Add(Model.Group gp)
        {

            string str = " INSERT INTO [FAMIS].[dbo].[Group] ([name] ,[agency_id]) " + Environment.NewLine;
            str += " VALUES ('" + Environment.NewLine;
            str += gp.Name + "'," + Environment.NewLine;
            str += gp.Agency_id + ")";

            try
            {
                SqlCommand scmd = new SqlCommand(str, db.Db());

                int iret = scmd.ExecuteNonQuery();
                return iret.ToString() + " Record successfully saved";
            }
            catch (SqlException ex)
            {
                return "Error saving the record of: " + gp.Group_id.ToString() + Environment.NewLine + " Erro: " + ex.Message.ToString();
                throw;
            }
            finally
            {

            }
        }

        public string Delete(Model.Group Gp)
        {
            String str = "Delete From [Group] Where group_id = " + Gp.Group_id;

            try
            {
                SqlCommand scmd = new SqlCommand(str, db.Db());
                int iret = scmd.ExecuteNonQuery();
                return iret.ToString() + " Record deleted successfully";
            }
            catch (SqlException ex)
            {
                return "Error deleting record : " +  Gp.Group_id.ToString() + Environment.NewLine + " Erro: " + ex.Message.ToString();
                throw;
            }
        }

        public string Update(Model.Group Gp)
        {
            String str = " UPDATE [FAMIS].[dbo].[Group] " + Environment.NewLine;
            str += " SET " + Environment.NewLine;

            if (!string.IsNullOrEmpty(Gp.Name))
            {
                str += " [Name] = '" + Gp.Name + "'" + Environment.NewLine;
            }
            if (!string.IsNullOrEmpty(Gp.Agency_id.ToString()))
            {
                str += " ,[Agency_id] =  " + Gp.Agency_id + Environment.NewLine;
            }

            str += " WHERE [Group_id] = " + Gp.Group_id; 

            try
            {
                SqlCommand scmd = new SqlCommand(str, db.Db());
                int iret = scmd.ExecuteNonQuery();
                return iret.ToString() + " Record deleted successfully";
            }
            catch (SqlException ex)
            {
                return "Error deleting record number: " + Gp.Group_id.ToString() + Environment.NewLine + " Erro: " + ex.Message.ToString();
                throw;
            }
        }

        public Model.Group Select(Model.Group Group)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select * From [FAMIS].[dbo].[Group] Where group_id =" + Group.Group_id, db.Db());
                SqlDataReader dr = cmd.ExecuteReader();

                Model.Group Gp;

                Gp = new Model.Group(); 

                while (dr.Read())
                {

                    if (!dr.IsDBNull(0))
                    {
                        Gp.Name = dr.GetString(0);  
                    }
                    if (!dr.IsDBNull(1))
                    {
                        Gp.Agency_id = dr.GetInt32(1);
                    }
                }

                return Gp; 

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Nesse caso vai retornar uma lista de objeto. Não sei se seu retorno vão ter vários, ou um por vez. Se for um por vez, não precisa usar lista.
        public List<Model.Group> Select(String pWhere)
        {

            List<Model.Group> lstGroup = new List<Model.Group>();
            Model.Group Gp;

            SqlCommand cmd = new SqlCommand("Select * From dbo.[Group] " + pWhere, db.Db());
            //SQLHelper.ExecuteReader("string de conexao", CommandType.StoredProcedure, "Procedure", null)
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    Gp = new Model.Group();

                    if (!dr.IsDBNull(0))
                    {
                        Gp.Group_id = dr.GetInt32(0);
                    }
                    if (!dr.IsDBNull(1))
                    {
                        Gp.Name = dr.GetString(1);
                    }
                    if (!dr.IsDBNull(2))
                    {
                        Gp.Agency_id = dr.GetInt32(2);
                    }
                    lstGroup.Add(Gp); 
                }
            }

            return lstGroup;
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
