using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data.SqlClient;
using System.Data;

namespace FAMIS_DALL
{
    public class Employee
    {
        DB db;
        public Employee()
        {
            db = new DB();
        }

        public string Add(Model.Employee employee)
        {
            try
            {
                #region ["Param"]
                //SqlCommand _cmdAdd = new SqlCommand("sp_Employee", db.Db());
                //_cmdAdd.CommandType = CommandType.StoredProcedure;   

                //SqlParameter[] param = new SqlParameter[10];

                //param[0] = new SqlParameter("@Param0", SqlDbType.Int);
                //param[0].Direction = ParameterDirection.Input;
                //param[0].Value = employee.Agency_id; 
                //_cmdAdd.Parameters.Add(param[0]);

                //param[1] = new SqlParameter("@Param1", SqlDbType.Int);
                //param[1].Direction = ParameterDirection.Input;
                //param[1].Value = employee.Position_id; 
                //_cmdAdd.Parameters.Add(param[1]);

                //param[2] = new SqlParameter("@Param2", SqlDbType.VarChar);
                //param[2].Direction = ParameterDirection.Input;
                //param[2].Value = employee.First_name.ToString();  
                //_cmdAdd.Parameters.Add(param[2]);

                //param[3] = new SqlParameter("@Param3", SqlDbType.VarChar);
                //param[3].Direction = ParameterDirection.Input;
                //param[3].Value = employee.Last_name; 
                //_cmdAdd.Parameters.Add(param[3]);

                //param[4] = new SqlParameter("@Param4", SqlDbType.VarChar);
                //param[4].Direction = ParameterDirection.Input;
                //param[4].Value = employee.Code; 
                //_cmdAdd.Parameters.Add(param[4]);

                //param[5] = new SqlParameter("@Param5", SqlDbType.DateTime);
                //param[5].Direction = ParameterDirection.Input;
                //param[5].Value = employee.Date_hired; 
                //_cmdAdd.Parameters.Add(param[5]);

                //param[6] = new SqlParameter("@Param6", SqlDbType.DateTime);
                //param[6].Direction = ParameterDirection.Input;
                //param[6].Value = employee.Last_version;  
                //_cmdAdd.Parameters.Add(param[6]);

                //param[7] = new SqlParameter("@Param7", SqlDbType.Decimal);
                //param[7].Direction = ParameterDirection.Input;
                //param[7].Value = employee.Salary; 
                //_cmdAdd.Parameters.Add(param[7]);

                #region ["Imagem old"]
                //************************************
                //************************************
                //////System.Drawing.Image _Image;
                //////_Image = employee.Picture; 
                //////// Convert image to memory stream
                //////System.IO.MemoryStream _MemoryStream = new System.IO.MemoryStream();
                //////_Image.Save(_MemoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                
                //param[8] = new SqlParameter("@Param8", SqlDbType.Image);
                //param[8].Direction = ParameterDirection.Input;
                //param[8].Value = _MemoryStream.ToArray();  
                //_cmdAdd.Parameters.Add(param[8]);
                ////************************************
                ////************************************
                #endregion

                //param[9] = new SqlParameter("@Param9", SqlDbType.Image);
                //param[9].Direction = ParameterDirection.Input;
                //param[9].Value = employee.Cv; 
                //_cmdAdd.Parameters.Add(param[9]);
                #endregion

                string sCv = "";
                    if (employee.Cv != 0)
                    {
                        sCv = employee.Cv.ToString(); 
                    }
                    else
                    {
                        sCv = "null";
                    }

                #region "antigo"
                    string str = "INSERT INTO [FAMIS].[dbo].[Employee] ([agency_id],[position_id],[first_name],[last_name],[code],[date_hired],[last_version],[salary],[picture],[cv])" + Environment.NewLine;
                    str += " VALUES (" + employee.Agency_id + "," + employee.Position_id + ", '" +
                    employee.First_name + "','" +
                    employee.Last_name + "','" +
                    employee.Code + "'," +
                    "convert(datetime, '" + employee.Date_hired.Year.ToString() + "-" + employee.Date_hired.Month.ToString() + "-" + employee.Date_hired.Day.ToString() + " " + employee.Date_hired.Hour.ToString("00") + ":" + employee.Date_hired.Minute.ToString("00") + ":" + employee.Date_hired.Second.ToString("00") + "')" + "," +
                    "convert(datetime, '" + employee.Last_version.Year.ToString() + "-" + employee.Last_version.Month.ToString() + "-" + employee.Last_version.Day.ToString() + " " + employee.Last_version.Hour.ToString("00") + ":" + employee.Last_version.Minute.ToString("00") + ":" + employee.Last_version.Second.ToString("00") + "')" + "," +
                    //employee.Last_version + "', " +
                    employee.Salary + ", '" +
                    employee.Picture + "', " + sCv + ")";

                    
                #endregion

            SqlCommand _cmdAdd = new SqlCommand(str, db.Db());
            _cmdAdd.CommandType = CommandType.Text; 

                int iret = _cmdAdd.ExecuteNonQuery();
                return iret.ToString() + " Record successfully saved";
            }
            catch (SqlException ex)
            {
                return "Error saving the record of: " + employee.First_name + Environment.NewLine + " Erro: " + ex.Message.ToString();
                throw;
            }
            finally
            {

            }
        }

        public string Delete(Model.Employee employee)
        {
            String str = "Delete From [Employee] Where employee_id = " + employee.Employee_id;

            try
            {
                SqlCommand scmd = new SqlCommand(str, db.Db());
                int iret = scmd.ExecuteNonQuery();
                return iret.ToString() + " Record deleted successfully";
            }
            catch (SqlException ex)
            {
                return "Error deleting record : " + employee.First_name.ToString() + Environment.NewLine + " Erro: " + ex.Message.ToString();
                throw;
            }
        }

        public string Update(Model.Employee employee)
        {
            String str = " UPDATE [FAMIS].[dbo].[Employee] " + Environment.NewLine;
                   str += " SET " + Environment.NewLine;

                   if (!string.IsNullOrEmpty(employee.Position_id.ToString()))
                   {
                       str += " [position_id] = " + employee.Position_id + Environment.NewLine;
                   }
                   if (!string.IsNullOrEmpty(employee.First_name))
                   {
                       str += " ,[first_name] =  '" + employee.First_name + "'" + Environment.NewLine;
                   }
                   if (!string.IsNullOrEmpty(employee.Last_name))
                   {
                       str += " ,[last_name] =  '" + employee.Last_name + "'" + Environment.NewLine;
                   }
                   if (!string.IsNullOrEmpty(employee.Last_name))
                   {
                       str += " ,[code] =  '" + employee.Code + "'" + Environment.NewLine;
                   }
                   if (!string.IsNullOrEmpty(employee.Date_hired.ToString()))
                   {
                       str += " ,[date_hired] = '" + employee.Date_hired + "'" + Environment.NewLine;
                   }
                   if (!string.IsNullOrEmpty(employee.Last_version.ToString()))
                   {
                       str += " ,[last_version] = '" + employee.Last_version + "'" + Environment.NewLine;
                   }
                   if (!string.IsNullOrEmpty(employee.Salary.ToString()))
                   {
                       str += " ,[salary] =  " + employee.Salary + Environment.NewLine;
                   }
                   if (!string.IsNullOrEmpty(employee.Picture.ToString()))
                   {
                       str += " ,[picture] = '" + employee.Picture + "'" + Environment.NewLine;
                   }
                   if (!string.IsNullOrEmpty(employee.Cv.ToString()))
                   {
                       str += " ,[cv] =  '" + employee.Cv + "'" + Environment.NewLine;
                   }

                   str += " WHERE [employee_id] = " + employee.Employee_id; 

            try
            {
                SqlCommand scmd = new SqlCommand(str, db.Db());
                int iret = scmd.ExecuteNonQuery();
                return iret.ToString() + " Record deleted successfully";
            }
            catch (SqlException ex)
            {
                return "Error deleting record number: " + employee.First_name.ToString() + Environment.NewLine + " Erro: " + ex.Message.ToString();
                throw;
            }
        }

        public Model.Employee Select(Model.Employee employee)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select * From [FAMIS].[dbo].[Employee] Where employee_id =" + employee.Employee_id, db.Db());
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    if (!dr.IsDBNull(0))
                    {
                        employee.Agency_id = dr.GetInt32(0);
                    }
                    if (!dr.IsDBNull(1))
                    {
                        employee.Employee_id = dr.GetInt32(1);
                    }
                    if (!dr.IsDBNull(2))
                    {
                        employee.Position_id = dr.GetInt32(2);
                    }
                    if (!dr.IsDBNull(3))
                    {
                        employee.First_name = dr.GetString(3);
                    }
                    if (!dr.IsDBNull(4))
                    {
                        employee.Code = dr.GetString(4);
                    }
                    if (!dr.IsDBNull(5))
                    {
                        employee.Date_hired = dr.GetDateTime(5);
                    }
                    if (!dr.IsDBNull(6))
                    {
                        employee.Last_version = dr.GetDateTime(6);
                    }
                    if (!dr.IsDBNull(7))
                    {
                        employee.Salary = dr.GetDecimal(7);
                    }
                    if (!dr.IsDBNull(8))
                    {
                        employee.Picture = dr.GetString(8);
                    }
                    if (!dr.IsDBNull(9))
                    {
                        //employee.Cv = dr.GetByte(9);
                    }
                }
                return employee;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Nesse caso vai retornar uma lista de objeto. Não sei se seu retorno vão ter vários, ou um por vez. Se for um por vez, não precisa usar lista.
        public List<Model.Employee> Select(String pQuery)
        {

            List<Model.Employee> lstEmployee = new List<Model.Employee>();
            Model.Employee employee;
            string sQuery = " SELECT [agency_id] ";
            sQuery += " ,[employee_id] ";
            //sQuery += " ,[user_id] ";
            sQuery += " ,[position_id] ";
            sQuery += " ,[first_name] ";
            sQuery += " ,[last_name] ";
            sQuery += " ,[code] ";
            sQuery += " ,[date_hired] ";
            sQuery += " ,[last_version] ";
            //sQuery += " ,[salary] ";
            sQuery += " ,[picture] ";
            sQuery += " ,[cv] ";
            sQuery += " FROM [FAMIS].[dbo].[Employee]";

            SqlCommand cmd = new SqlCommand(sQuery + pQuery, db.Db());
            //SQLHelper.ExecuteReader("string de conexao", CommandType.StoredProcedure, "Procedure", null)
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    employee = new Model.Employee();
                    
                    if (!dr.IsDBNull(0))
                    {
                        employee.Agency_id = dr.GetInt32(0);
                    }
                    if (!dr.IsDBNull(1))
                    {
                        employee.Employee_id = dr.GetInt32(1);
                    }
                    if (!dr.IsDBNull(2))
                    {
                        employee.Position_id = dr.GetInt32(2);
                    }
                    if (!dr.IsDBNull(3))
                    {
                        employee.First_name = dr.GetString(3);
                    }
                    if (!dr.IsDBNull(4))
                    {
                        employee.Last_name = dr.GetString(4);
                    }
                    if (!dr.IsDBNull(5))
                    {
                        employee.Code = dr.GetString(5);
                    }
                    if (!dr.IsDBNull(6))
                    {
                        employee.Date_hired = dr.GetDateTime(6);
                    }
                    if (!dr.IsDBNull(7))
                    {
                        employee.Last_version = dr.GetDateTime(7);
                    }
                    if (!dr.IsDBNull(8))
                    {
                        //employee.Salary = dr.GetDecimal(8);
                    }
                    if (!dr.IsDBNull(9))
                    {
                        employee.Picture = dr.GetString(9);
                    }
                    //if (!dr.IsDBNull(10))
                    //{
                    //    //employee.Cv = dr.GetByte(10);
                    //}

                    lstEmployee.Add(employee);
                }
            }

            return lstEmployee;
        }

    }
}
