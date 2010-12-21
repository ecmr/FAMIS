using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data;
using System.Data.SqlClient;

 
namespace FAMIS_DALL
{
    public class Department
    {
        DB db;
        public Department()
        {
            db = new DB();
        }

        public string Add(Model.Department Department)
        {

            string str = " INSERT INTO [FAMIS].[dbo].[Department] ([Code], [name]) " + Environment.NewLine;
            str += " VALUES (" + Department.Code + ",'" + Department.Name + "')";

            try
            {
                SqlCommand scmd = new SqlCommand(str, db.Db());

                int iret = scmd.ExecuteNonQuery();
                return iret.ToString() + " Record successfully saved";
            }
            catch (SqlException ex)
            {
                return "Error saving the record of: " + Department.Name.ToString() + Environment.NewLine + " Erro: " + ex.Message.ToString();
                throw;
            }
            finally
            {

            }
        }

        public string Delete(Model.Department Department)
        {
            String str = "Delete From [Department] Where department_id = " + Department.Department_id;

            try
            {
                SqlCommand scmd = new SqlCommand(str, db.Db());
                int iret = scmd.ExecuteNonQuery();
                return iret.ToString() + " Record deleted successfully";
            }
            catch (SqlException ex)
            {
                return "Error deleting record : " + Department.Name.ToString() + Environment.NewLine + " Erro: " + ex.Message.ToString();
                throw;
            }
        }

        public string Update(Model.Department Department)
        {
            String str = " UPDATE [FAMIS].[dbo].[Department] " + Environment.NewLine;
            str += " SET " + Environment.NewLine;

            if (!string.IsNullOrEmpty(Department.Name))
            {
                str += " [Name] = '" + Department.Name + "'" + Environment.NewLine;
            }
            if (!string.IsNullOrEmpty(Department.Code.ToString()))
            {
                str += ", [Code] = " + Department.Code + Environment.NewLine;
            }

            str += " WHERE [Department_id] = " + Department.Department_id; 

            try
            {
                SqlCommand scmd = new SqlCommand(str, db.Db());
                int iret = scmd.ExecuteNonQuery();
                return iret.ToString() + " Record deleted successfully";
            }
            catch (SqlException ex)
            {
                return "Error deleting record number: " + Department.Name.ToString() + Environment.NewLine + " Erro: " + ex.Message.ToString();
                throw;
            }
        }

        public Model.Department Select(Model.Department Dep)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select * From [FAMIS].[dbo].[Department] Where Department_id =" + Dep.Department_id, db.Db());
                SqlDataReader dr = cmd.ExecuteReader();

                Model.Department Department;

                Department = new Model.Department(); 

                while (dr.Read())
                {

                    if (!dr.IsDBNull(0))
                    {
                        Department.Department_id = dr.GetInt32(0); 
                    }
                    if (!dr.IsDBNull(1))
                    {
                        Department.Code = dr.GetInt32(1);
                    }
                    if (!dr.IsDBNull(2))
                    {
                        Department.Name = dr.GetString(2);
                    }
                }

                return Department; 

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Nesse caso vai retornar uma lista de objeto. Não sei se seu retorno vão ter vários, ou um por vez. Se for um por vez, não precisa usar lista.
        public List<Model.Department> Select(String pWhere)
        {

            List<Model.Department> lstDepartment = new List<Model.Department>();
            Model.Department Department;

            SqlCommand cmd = new SqlCommand("Select * From dbo.[Department] " + pWhere, db.Db());
            //SQLHelper.ExecuteReader("string de conexao", CommandType.StoredProcedure, "Procedure", null)
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    Department = new Model.Department();

                    if (!dr.IsDBNull(0))
                    {
                        Department.Department_id = dr.GetInt32(0);
                    }
                    if (!dr.IsDBNull(1))
                    {
                        Department.Code = dr.GetInt32(1);
                    }
                    if (!dr.IsDBNull(2))
                    {
                        Department.Name = dr.GetString(2);
                    }

                    lstDepartment.Add(Department); 
                }
            }

            return lstDepartment;
        }
    }
}
