using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Model;
  
namespace FAMIS_DALL
{
    public class Position
    {
        DB db;
        public Position()
        {
            db = new DB();
        }

        public string Add(Model.Position Pos)
        {

            string str = " INSERT INTO [FAMIS].[dbo].[Position] " +
                   " ([code] " +
                   " ,[department_id] " +
                   " ,[name] " +
                   " ,[salary_research]) " +
                   " VALUES ('" +
                   Pos.Code + "', " +
                   Pos.Department_id + ", '" +
                   Pos.Name + "', " +
                   Pos.Salary_research + ")";
                    
            try
            {
                SqlCommand scmd = new SqlCommand(str, db.Db());

                int iret = scmd.ExecuteNonQuery();
                return iret.ToString() + " Record successfully saved";
            }
            catch (SqlException ex)
            {
                return "Error saving the record of: " + Pos.Name.ToString() + Environment.NewLine + " Erro: " + ex.Message.ToString();
                throw;
            }
            finally
            {

            }
        }

        public string Delete(Model.Position Pos)
        {
            String str = "Delete From [Position] Where position_id = " + Pos.Position_id;

            try
            {
                SqlCommand scmd = new SqlCommand(str, db.Db());
                int iret = scmd.ExecuteNonQuery();
                return iret.ToString() + " Record deleted successfully";
            }
            catch (SqlException ex)
            {
                return "Error deleting record : " + Pos.Name.ToString() + Environment.NewLine + " Erro: " + ex.Message.ToString();
                throw;
            }
        }

        public string Update(Model.Position Pos)
        {
            String str = " UPDATE [FAMIS].[dbo].[Position] " + Environment.NewLine;

            str += " SET " + Environment.NewLine;

            if (!string.IsNullOrEmpty(Pos.Code.ToString()))
            {
                str += " [code] = '" + Pos.Code + "'" + Environment.NewLine;
            }
            if (!string.IsNullOrEmpty(Pos.Name.ToString()))
            {
                str += ",[Name] = '" + Pos.Name + "'" + Environment.NewLine;
            }
            if (!string.IsNullOrEmpty(Pos.Department_id.ToString()))
            {
                str += " ,[Department_id] =  " + Pos.Department_id + Environment.NewLine;
            }
            if (!string.IsNullOrEmpty(Pos.Salary_research.ToString()))
            {
                str += " ,[Salary_research] =  " + Pos.Salary_research  + Environment.NewLine;
            }

            str += " WHERE [Position_id] = " + Pos.Position_id;

            try
            {
                SqlCommand scmd = new SqlCommand(str, db.Db());
                int iret = scmd.ExecuteNonQuery();
                return iret.ToString() + " Record deleted successfully";
            }
            catch (SqlException ex)
            {
                return "Error deleting record number: " + Pos.Name.ToString() + Environment.NewLine + " Erro: " + ex.Message.ToString();
                throw;
            }
        }

        public Model.Position Select(Model.Position Pos)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select * From [FAMIS].[dbo].[Position] Where Position_id =" + Pos.Position_id, db.Db());
                SqlDataReader dr = cmd.ExecuteReader();

                Model.Position position = new Model.Position(); 

                if (dr.Read())
                {
                    if (!dr.IsDBNull(0))
                    {
                        position.Position_id = dr.GetInt32(0); 
                    }
                    if (!dr.IsDBNull(1))
                    {
                        position.Code = dr.GetString(1); 
                    }
                    if (!dr.IsDBNull(2))
                    {
                        position.Department_id = dr.GetInt32(2);
                    }
                    if (!dr.IsDBNull(3))
                    {
                        position.Name = dr.GetString(2);
                    }
                    if (!dr.IsDBNull(4))
                    {
                        position.Salary_research = dr.GetDecimal(4); 
                    }
                }
                return position; 

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Nesse caso vai retornar uma lista de objeto. Não sei se seu retorno vão ter vários, ou um por vez. Se for um por vez, não precisa usar lista.
        public List<Model.Position> Select(String pWhere)
        {

            List<Model.Position> lstPosition = new List<Model.Position>();
            Model.Position position;

            SqlCommand cmd = new SqlCommand("Select * From dbo.[Position] " + pWhere, db.Db());

            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    position = new Model.Position();

                    if (!dr.IsDBNull(0))
                    {
                        position.Position_id = dr.GetInt32(0);
                    }
                    if (!dr.IsDBNull(1))
                    {
                        position.Code = dr.GetString(1);
                    }
                    if (!dr.IsDBNull(2))
                    {
                        position.Department_id = dr.GetInt32(2);
                    }
                    if (!dr.IsDBNull(3))
                    {
                        position.Name = dr.GetString(3);
                    }
                    if (!dr.IsDBNull(4))
                    {
                        position.Salary_research = dr.GetDecimal(4);
                    } 
                    
                    lstPosition.Add(position);
                }
            }

            return lstPosition;
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
