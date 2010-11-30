using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Model;

namespace FAMIS_DALL
{
    public class Timesheet
    {
        DB db;
        public Timesheet()
        {
            db = new DB();
        }

        public string Add(Model.Timesheet UApp)
        {

            string str = " INSERT INTO [FAMIS].[dbo].[Timesheet] ([Client_id] ,[project_id], [user_id], [startTime], [EndTime], [FullTime], [JobTime], [coment] ) " + Environment.NewLine;
            str += " VALUES (" + Environment.NewLine;
            str += UApp.Client_id + "," + Environment.NewLine;
            str += UApp.Project_id + "," + Environment.NewLine;
            str += UApp.User_id + ", " + Environment.NewLine;
            str += "'" + UApp.StartTime.ToString("s")  + "', " + Environment.NewLine;
            
            if (UApp.EndTime.ToString("s").Equals("0001-01-01T00:00:00"))
            {
                str += "null, " + Environment.NewLine;
            }
            else
            {
                str += "'" + UApp.EndTime.ToString("s") + "', " + Environment.NewLine;
            }
            if (UApp.FullTime.ToString("s").Equals("0001-01-01T00:00:00"))
            {
                str += "null, " + Environment.NewLine;
            }
            else
            {
                str += "'" + UApp.FullTime.ToString("s") + "', " + Environment.NewLine;
            }
            if (UApp.JobTime.ToString("s").Equals("0001-01-01T00:00:00"))
            {
                str += "null, " + Environment.NewLine;
            }
            else
            {
                str += "'" + UApp.JobTime.ToString("s") + "', " + Environment.NewLine;
            }                
            
            str += "'" + UApp.Coment + "')";

            try
            {
                SqlCommand scmd = new SqlCommand(str, db.Db());

                int iret = scmd.ExecuteNonQuery();
                return iret.ToString() + " Record successfully saved";
            }
            catch (SqlException ex)
            {
                return "Error saving the record of: " + UApp.Timesheet_id.ToString() + Environment.NewLine + " Erro: " + ex.Message.ToString();
                throw;
            }
            finally
            {

            }
        }

        public string Delete(Model.Timesheet UApp)
        {
            String str = "Delete From [Timesheet] Where Timesheet_id = " + UApp.Timesheet_id;

            try
            {
                SqlCommand scmd = new SqlCommand(str, db.Db());
                int iret = scmd.ExecuteNonQuery();
                return iret.ToString() + " Record deleted successfully";
            }
            catch (SqlException ex)
            {
                return "Error deleting record : " + UApp.Timesheet_id + Environment.NewLine + " Erro: " + ex.Message.ToString();
                throw;
            }
        }

        public string Update(Model.Timesheet UApp)
        {
            String str = " UPDATE [FAMIS].[dbo].[Timesheet] " + Environment.NewLine;
            str += " SET " + Environment.NewLine;

            if (!string.IsNullOrEmpty(UApp.Coment))
            {
                str += " [coment] = '" + UApp.Coment + "'" + Environment.NewLine;
            }
            str += " ,[client_id] =  " + UApp.Client_id + Environment.NewLine;
            str += " ,[project_id] =  " + UApp.Project_id + Environment.NewLine;
            str += " ,[user_id] =  " + UApp.User_id + Environment.NewLine;

            if (UApp.EndTime.ToString("s").Equals("0001-01-01T00:00:00"))
            {
                str += ", [endTime] = null " + Environment.NewLine;
            }
            else
            {
                str += " ,[endTime] =  '" + UApp.EndTime.ToString("s") + "'" + Environment.NewLine;
            }
            if (UApp.FullTime.ToString("s").Equals("0001-01-01T00:00:00"))
            {
                str += ", [fullTime] = null " + Environment.NewLine;
            }
            else
            {
                str += " ,[fullTime] =  '" + UApp.FullTime.ToString("s") + "'" + Environment.NewLine;
            }
            if (UApp.JobTime.ToString("s").Equals("0001-01-01T00:00:00"))
            {
                str += ", [jobTime] = null " + Environment.NewLine;
            }
            else
            {
                str += " ,[jobTime] =  '" + UApp.JobTime.ToString("s") + "'" + Environment.NewLine;
            }
            str += " WHERE [Timesheet_id] = " + UApp.Timesheet_id;

            try
            {
                SqlCommand scmd = new SqlCommand(str, db.Db());
                int iret = scmd.ExecuteNonQuery();
                return iret.ToString() + " Record deleted successfully";
            }
            catch (SqlException ex)
            {
                return "Error deleting record number: " + UApp.Timesheet_id.ToString() + Environment.NewLine + " Erro: " + ex.Message.ToString();
                throw;
            }
        }

        public Model.Timesheet Select(Model.Timesheet UserApp)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select * From [FAMIS].[dbo].[Timesheet] Where Timesheet_id =" + UserApp.Timesheet_id , db.Db());
                SqlDataReader dr = cmd.ExecuteReader();

                Model.Timesheet UApp;

                UApp = new Model.Timesheet();

                while (dr.Read())
                {

                    UApp = new Model.Timesheet();

                    if (!dr.IsDBNull(0))
                    {
                        UApp.Timesheet_id = dr.GetInt32(0);
                    }
                    if (!dr.IsDBNull(1))
                    {
                        UApp.Client_id = dr.GetInt32(1);
                    }
                    if (!dr.IsDBNull(2))
                    {
                        UApp.Project_id = dr.GetInt32(2);
                    }
                    if (!dr.IsDBNull(3))
                    {
                        UApp.User_id = dr.GetInt32(3);
                    }
                    if (!dr.IsDBNull(4))
                    {
                        UApp.StartTime = dr.GetDateTime(4);
                    }
                    if (!dr.IsDBNull(5))
                    {
                        UApp.EndTime = dr.GetDateTime(5);
                    }
                    if (!dr.IsDBNull(6))
                    {
                        UApp.FullTime = dr.GetDateTime(6);
                    }
                    if (!dr.IsDBNull(7))
                    {
                        UApp.JobTime = dr.GetDateTime(7);
                    }
                    if (!dr.IsDBNull(8))
                    {
                        UApp.Coment = dr.GetString(8);
                    }
                }

                return UApp;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Model.Timesheet SelectQuery(String _Where)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select * From [FAMIS].[dbo].[Timesheet] " + _Where, db.Db());
                SqlDataReader dr = cmd.ExecuteReader();

                Model.Timesheet UApp;

                UApp = new Model.Timesheet();

                while (dr.Read())
                {

                    UApp = new Model.Timesheet();

                    if (!dr.IsDBNull(0))
                    {
                        UApp.Timesheet_id = dr.GetInt32(0);
                    }
                    if (!dr.IsDBNull(1))
                    {
                        UApp.Client_id = dr.GetInt32(1);
                    }
                    if (!dr.IsDBNull(2))
                    {
                        UApp.Project_id = dr.GetInt32(2);
                    }
                    if (!dr.IsDBNull(3))
                    {
                        UApp.User_id = dr.GetInt32(3);
                    }
                    if (!dr.IsDBNull(4))
                    {
                        UApp.StartTime = dr.GetDateTime(4);
                    }
                    if (!dr.IsDBNull(5))
                    {
                        UApp.EndTime = dr.GetDateTime(5);
                    }
                    if (!dr.IsDBNull(6))
                    {
                        UApp.FullTime = dr.GetDateTime(6);
                    }
                    if (!dr.IsDBNull(7))
                    {
                        UApp.JobTime = dr.GetDateTime(7);
                    }
                    if (!dr.IsDBNull(8))
                    {
                        UApp.Coment = dr.GetString(8);
                    }
                }

                return UApp;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Model.Timesheet> Select(String pWhere)
        {

            List<Model.Timesheet> lstTimesheet = new List<Model.Timesheet>();
            Model.Timesheet UApp;

            SqlCommand cmd = new SqlCommand("Select * From dbo.[Timesheet] " + pWhere, db.Db());
            //SQLHelper.ExecuteReader("string de conexao", CommandType.StoredProcedure, "Procedure", null)
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    UApp = new Model.Timesheet(); 

                    if (!dr.IsDBNull(0))
                    {
                        UApp.Timesheet_id = dr.GetInt32(0);
                    }
                    if (!dr.IsDBNull(1))
                    {
                        UApp.Client_id = dr.GetInt32(1);
                    }
                    if (!dr.IsDBNull(2))
                    {
                        UApp.Project_id = dr.GetInt32(2);
                    }
                    if (!dr.IsDBNull(3))
                    {
                        UApp.User_id = dr.GetInt32(3);
                    }
                    if (!dr.IsDBNull(4))
                    {
                        UApp.StartTime = dr.GetDateTime(4);
                    }
                    if (!dr.IsDBNull(5))
                    {
                        UApp.EndTime = dr.GetDateTime(5);
                    }
                    if (!dr.IsDBNull(6))
                    {
                        UApp.FullTime = dr.GetDateTime(6);
                    }
                    if (!dr.IsDBNull(7))
                    {
                        UApp.JobTime = dr.GetDateTime(7);
                    }
                    if (!dr.IsDBNull(8))
                    {
                        UApp.Coment = dr.GetString(8);
                    }

                    lstTimesheet.Add(UApp);
                }
            }

            return lstTimesheet;
        }

        public SqlDataReader LoadDropDow()
        {
            SqlCommand cmd = new SqlCommand("Select clientProject_id, clientProject_name From ClientProject", db.Db());
            SqlDataReader dr = cmd.ExecuteReader();

            return dr;
        }

        public Model.ClientProject GetClientProjectId(int _id)
        {

            try
            {

                Model.ClientProject Cp = new ClientProject();
                SqlCommand _cmd = new SqlCommand("Select client_id, Project_id From ClientProject Where clientProject_id=" + _id, db.Db());
                SqlDataReader dr = _cmd.ExecuteReader();

                while (dr.Read())
                {
                    Cp.Client_id = dr.GetInt32(0);
                    Cp.Project_id = dr.GetInt32(1);
                }
                return Cp;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }

        }
    }
}
