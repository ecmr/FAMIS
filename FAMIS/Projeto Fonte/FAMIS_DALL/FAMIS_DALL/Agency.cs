using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data.SqlClient;

namespace FAMIS_DALL
{
    public class Agency
    {
        DB db;

        public Agency()
        {
            db = new DB();
        }

        public string Add(Model.Agency agency)
        {

            string str = "Insert Into [Agency](name)" + Environment.NewLine;
            str += " Values('" + agency.Name + "')";

            try
            {
                SqlCommand scmd = new SqlCommand(str, db.Db());

                int iret = scmd.ExecuteNonQuery();
                return iret.ToString() + " Record successfully saved";
            }
            catch (SqlException ex)
            {
                return "Error saving the record of: " + agency.Name.ToString() + Environment.NewLine + " Erro: " + ex.Message.ToString();
                throw;
            }
            finally
            {

            }
        }

        public string Delete(Model.Agency agency)
        {
            String str = "Delete From [Agency] Where agency_id = " + agency.Agency_id;

            try
            {
                SqlCommand scmd = new SqlCommand(str, db.Db());
                int iret = scmd.ExecuteNonQuery();
                return iret.ToString() + " Record deleted successfully";
            }
            catch (SqlException ex)
            {
                return "Error deleting record : " + agency.Name.ToString() + Environment.NewLine + " Erro: " + ex.Message.ToString();
                throw;
            }
        }

        public string Update(Model.Agency agency)
        {
            String str = "Update [Agency] Set " + Environment.NewLine;
            if (!string.IsNullOrEmpty(agency.Name))
            {
                str += " Name= '" + agency.Name + "' " + Environment.NewLine;
            }

            str += " Where agency_id = " + agency.Agency_id;

            try
            {
                SqlCommand scmd = new SqlCommand(str, db.Db());
                int iret = scmd.ExecuteNonQuery();
                return iret.ToString() + " Record deleted successfully";
            }
            catch (SqlException ex)
            {
                return "Error deleting record number: " + agency.Name + Environment.NewLine + " Erro: " + ex.Message.ToString();
                throw;
            }
        }

        public Model.Agency Select(Model.Agency agency)
        {
            Model.Agency ag;

            try
            {
                SqlCommand cmd = new SqlCommand("Select * From dbo.[Agency] Where agency_id=" + agency.Agency_id, db.Db());
                
                using(SqlDataReader dr = cmd.ExecuteReader())
                {
                    ag = new Model.Agency();

                    if (dr.Read())
                    {
                        if (!dr.IsDBNull(0))
                            ag.Agency_id = dr.GetInt32(0);
                        if (!dr.IsDBNull(1))
                            ag.Name = dr.GetString(1); 
                    }
                    return ag;
                }
            }
            catch (Exception)
            {
                return null; 
            }
        }

        //Nesse caso vai retornar uma lista de objeto. Não sei se seu retorno vão ter vários, ou um por vez. Se for um por vez, não precisa usar lista.
        public List<Model.Agency> Select(String pWhere)
        {

            List<Model.Agency> lstAgency = new List<Model.Agency>();
            Model.Agency Ag;

            SqlCommand cmd = new SqlCommand("Select * From dbo.[Agency] " + pWhere, db.Db());
            //SQLHelper.ExecuteReader("string de conexao", CommandType.StoredProcedure, "Procedure", null)
            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    Ag = new Model.Agency(); 

                    //retorno do SQlDataReader
                    if (!rdr.IsDBNull(0)) //exemplo pra conferir se o retorno tem valor ou é nulo. Eu pego pelo número, da pra ser por nome também
                        Ag.Agency_id = rdr.GetInt32(0); 

                    if (!rdr.IsDBNull(1))
                        Ag.Name = rdr.GetString(1);

                    lstAgency.Add(Ag);
                }
            }

            return lstAgency;
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
