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

        public Int32 Add(Model.Employee employee)
        {
            try
            {
                SqlCommand _cmdAdd;
            #region "Atual"
                string str = "INSERT INTO [FAMIS].[dbo].[Employee] ([agency_id], [position_id], [department_id],[first_name],[last_name],[code],[date_hired],[last_version],[amount],[amount1],[date1],[amount2],[date2],[picture],[cv])" + Environment.NewLine;
                str += " VALUES (" + 
                employee.Agency_id + "," + 
                employee.Position_id + ", " +
                employee.Department_id + ", '" + 
                employee.First_name + "','" + 
                employee.Last_name + "','" +
                employee.Code + "'," +
                "convert(datetime, '" + employee.Date_hired.Year.ToString() + "-" + employee.Date_hired.Month.ToString() + "-" + employee.Date_hired.Day.ToString() + " " + employee.Date_hired.Hour.ToString("00") + ":" + employee.Date_hired.Minute.ToString("00") + ":" + employee.Date_hired.Second.ToString("00") + "')" + "," +
                "convert(datetime, '" + employee.Last_version.Year.ToString() + "-" + employee.Last_version.Month.ToString() + "-" + employee.Last_version.Day.ToString() + " " + employee.Last_version.Hour.ToString("00") + ":" + employee.Last_version.Minute.ToString("00") + ":" + employee.Last_version.Second.ToString("00") + "')" + "," + 
                employee.Amount + "," + 
                employee.Amount1 + "," +
                "convert(datetime, '" + employee.Date1.Year.ToString() + "-" + employee.Date1.Month.ToString() + "-" + employee.Date1.Day.ToString() + " " + employee.Date1.Hour.ToString("00") + ":" + employee.Date1.Minute.ToString("00") + ":" + employee.Date1.Second.ToString("00") + "')" + "," + 
                employee.Amount2 + "," +
                "convert(datetime, '" + employee.Date2.Year.ToString() + "-" + employee.Date2.Month.ToString() + "-" + employee.Date2.Day.ToString() + " " + employee.Date2.Hour.ToString("00") + ":" + employee.Date2.Minute.ToString("00") + ":" + employee.Date2.Second.ToString("00") + "')" + ",'" + 
                employee.Picture + "', '" + 
                employee.Cv + "')";
            #endregion

            _cmdAdd = new SqlCommand(str, db.Db());
            _cmdAdd.CommandType = CommandType.Text; 
            int iret = _cmdAdd.ExecuteNonQuery();
            _cmdAdd = null;
  
            str = "Select employee_id From Employee " + Environment.NewLine;
            str += " Where Position_id=" + employee.Position_id + Environment.NewLine;
            str += " and Department_id=" + employee.Department_id + Environment.NewLine;
            str += " and agency_id=" + employee.Agency_id + Environment.NewLine;
            str += " and date_hired='" + employee.Date_hired.Year.ToString() + "-" + employee.Date_hired.Month.ToString() + "-" + employee.Date_hired.Day + "'" + Environment.NewLine;      
            str += " and First_name='" + employee.First_name + "'" + Environment.NewLine;
            str += " and Last_name='" + employee.Last_name + "'";

            _cmdAdd = new SqlCommand(str, db.Db());
            _cmdAdd.CommandType = CommandType.Text;
            Int32 iId = (Int32)_cmdAdd.ExecuteScalar();
            return iId;
            }
            catch (SqlException ex)
            {
                return 0;
                //return "Error saving the record of: " + employee.First_name + Environment.NewLine + " Erro: " + ex.Message.ToString();
                throw;
            }
            finally
            {

            }
        }

        public string Delete(Model.Employee employee)
        {
            String str = "Delete From [User] Where employee_id = " + employee.Employee_id;

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
                str += " [agency_id] = " + employee.Agency_id + Environment.NewLine;
            }
            if (!string.IsNullOrEmpty(employee.Position_id.ToString()))
            {
                str += "       ,[position_id] = " + employee.Position_id + Environment.NewLine;
            }
            if (!string.IsNullOrEmpty(employee.Department_id.ToString()))
            {
                str += "       ,[department_id] = " + employee.Department_id + Environment.NewLine;
            }
            if (!string.IsNullOrEmpty(employee.First_name.ToString()))
            {
                str += "       ,[first_name] = '" + employee.First_name + "'" + Environment.NewLine;
            }
            if (!string.IsNullOrEmpty(employee.Last_name.ToString()))
            {
                str += "       ,[last_name] = '" + employee.Last_name + "'" + Environment.NewLine;
            }
            if (!string.IsNullOrEmpty(employee.Code.ToString()))
            {
                str += "       ,[code] = '" + employee.Code + "'" + Environment.NewLine;
            }
            if (!string.IsNullOrEmpty(employee.Date_hired.ToString()))
            {
                str += " ,[date_hired] = convert(datetime, '" + employee.Date_hired.Year.ToString() + "-" + employee.Date_hired.Month.ToString() + "-" + employee.Date_hired.Day.ToString() + " " + employee.Date_hired.Hour.ToString("00") + ":" + employee.Date_hired.Minute.ToString("00") + ":" + employee.Date_hired.Second.ToString("00") + "')" + Environment.NewLine;
            }
            if (!string.IsNullOrEmpty(employee.Last_version.ToString()))
            {
                str += " ,[last_version] = convert(datetime, '" + employee.Last_version.Year.ToString() + "-" + employee.Last_version.Month.ToString() + "-" + employee.Last_version.Day.ToString() + " " + employee.Last_version.Hour.ToString("00") + ":" + employee.Last_version.Minute.ToString("00") + ":" + employee.Last_version.Second.ToString("00") + "') " + Environment.NewLine;
            }
            if (!string.IsNullOrEmpty(employee.Amount.ToString()))
            {
                str += "       ,[amount] = " + employee.Amount + Environment.NewLine;
            }
            if (!string.IsNullOrEmpty(employee.Amount1.ToString()))
            {
                str += "       ,[amount1] = " + employee.Amount1 + Environment.NewLine;
            }
            if (!string.IsNullOrEmpty(employee.Date1.ToString()))
            {
                str += " ,[date1] = convert(datetime, '" + employee.Date1.Year.ToString() + "-" + employee.Date1.Month.ToString() + "-" + employee.Date1.Day.ToString() + " " + employee.Date1.Hour.ToString("00") + ":" + employee.Date1.Minute.ToString("00") + ":" + employee.Date1.Second.ToString("00") + "')" + Environment.NewLine;
            }
            if (!string.IsNullOrEmpty(employee.Amount2.ToString()))
            {
                str += "       ,[amount2] = " + employee.Amount2 + Environment.NewLine;
            }
            if (!string.IsNullOrEmpty(employee.Date2.ToString()))
            {
                str += " ,[date2] = convert(datetime, '" + employee.Date2.Year.ToString() + "-" + employee.Date2.Month.ToString() + "-" + employee.Date2.Day.ToString() + " " + employee.Date2.Hour.ToString("00") + ":" + employee.Date2.Minute.ToString("00") + ":" + employee.Date2.Second.ToString("00") + "')" + Environment.NewLine;
            }
            if (!string.IsNullOrEmpty(employee.Picture.ToString()))
            {
                str += "       ,[picture] = '" + employee.Picture + "'" + Environment.NewLine;
            }
            if (!string.IsNullOrEmpty(employee.Cv.ToString()))
            {
                str += "       ,[cv] = '" + employee.Cv + "'" + Environment.NewLine;
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
                        employee.Employee_id = dr.GetInt32(0);
                    }
                    if (!dr.IsDBNull(1))
                    {
                        employee.Agency_id = dr.GetInt32(1);
                    }
                    if (!dr.IsDBNull(2))
                    {
                        employee.Position_id = dr.GetInt32(2);
                    }
                    if (!dr.IsDBNull(3))
                    {
                        employee.Department_id = dr.GetInt32(3);
                    }
                    if (!dr.IsDBNull(4))
                    {
                        employee.First_name = dr.GetString(4);
                    }
                    if (!dr.IsDBNull(5))
                    {
                        employee.Last_name = dr.GetString(5);
                    }
                    if (!dr.IsDBNull(6))
                    {
                        employee.Code = dr.GetString(6);
                    }
                    if (!dr.IsDBNull(7))
                    {
                        employee.Date_hired = dr.GetDateTime(7);
                    }
                    if (!dr.IsDBNull(8))
                    {
                        employee.Last_version = dr.GetDateTime(8);
                    }
                    if (!dr.IsDBNull(9))
                    {
                        employee.Amount = dr.GetDecimal(9);
                    }
                    if (!dr.IsDBNull(10))
                    {
                        employee.Amount1 = dr.GetDecimal(10);
                    }
                    if (!dr.IsDBNull(11))
                    {
                        employee.Date1 = dr.GetDateTime(11);
                    }
                    if (!dr.IsDBNull(12))
                    {
                        employee.Amount2 = dr.GetDecimal(12);
                    }
                    if (!dr.IsDBNull(13))
                    {
                        employee.Date2 = dr.GetDateTime(13);
                    }
                    if (!dr.IsDBNull(14))
                    {
                        employee.Picture = dr.GetString(14);
                    }
                    if (!dr.IsDBNull(15))
                    {
                        employee.Cv = dr.GetString(15);
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

            SqlCommand cmd = new SqlCommand("Select * From Employee " + pQuery, db.Db());
            //SQLHelper.ExecuteReader("string de conexao", CommandType.StoredProcedure, "Procedure", null)
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    employee = new Model.Employee();

                    if (!dr.IsDBNull(0))
                    {
                        employee.Employee_id = dr.GetInt32(0);
                    }
                    if (!dr.IsDBNull(1))
                    {
                        employee.Agency_id = dr.GetInt32(1);
                    }
                    if (!dr.IsDBNull(2))
                    {
                        employee.Position_id = dr.GetInt32(2);
                    }
                    if (!dr.IsDBNull(3))
                    {
                        employee.Department_id = dr.GetInt32(3);
                    }
                    if (!dr.IsDBNull(4))
                    {
                        employee.First_name = dr.GetString(4);
                    }
                    if (!dr.IsDBNull(5))
                    {
                        employee.Last_name = dr.GetString(5);
                    }
                    if (!dr.IsDBNull(6))
                    {
                        employee.Code = dr.GetString(6);
                    }
                    if (!dr.IsDBNull(7))
                    {
                        employee.Date_hired  = dr.GetDateTime(7);
                    }
                    if (!dr.IsDBNull(8))
                    {
                        employee.Last_version = dr.GetDateTime(8);
                    }
                    if (!dr.IsDBNull(9))
                    {
                        employee.Amount = dr.GetDecimal(9); 
                    }
                    if (!dr.IsDBNull(10))
                    {
                        employee.Amount1 = dr.GetDecimal(10);
                    }
                    if (!dr.IsDBNull(11))
                    {
                        employee.Date1 = dr.GetDateTime(11);
                    }
                    if (!dr.IsDBNull(12))
                    {
                        employee.Amount2 = dr.GetDecimal(12);
                    }
                    if (!dr.IsDBNull(13))
                    {
                        employee.Date2 = dr.GetDateTime(13);
                    }
                    if (!dr.IsDBNull(14))
                    {
                        employee.Picture = dr.GetString(14);
                    }
                    if (!dr.IsDBNull(15))
                    {
                        employee.Cv = dr.GetString(15);
                    }

                    lstEmployee.Add(employee);
                }
            }

            return lstEmployee;
        }

        public DataView GetSelect(String pQuery)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(pQuery, db.Db());
            adapter.Fill(ds, "Employees");
            DataView dv = ds.Tables[0].DefaultView;
            return dv;
        }        
        
    }
}
