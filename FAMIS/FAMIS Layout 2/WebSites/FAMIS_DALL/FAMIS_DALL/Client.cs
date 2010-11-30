using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Model;

namespace FAMIS_DALL
{
    public class Client
    {
        DB db;

        public Client()
        {
            db = new DB();
        }

        public string Add(Model.Client client)
        {
            string str = "Insert Into [Client](local_name, intl_name, code, active, multinational)" + Environment.NewLine;
            str += " Values('" + client.Local_name + "', '" + client.Intl_name + "', '" + client.Code + "', " + client.Active + " , " + client.Multinational + ")";

            try
            {
                SqlCommand scmd = new SqlCommand(str, db.Db());

                int iret = scmd.ExecuteNonQuery();
                return iret.ToString() + " Record successfully saved";
            }
            catch (SqlException ex)
            {
                return "Error saving the record of: " + client.Local_name + Environment.NewLine + " Erro: " + ex.Message.ToString();
                throw;
            }
        }

        public string Delete(Model.Client client)
        {
            String str = "Delete From [Client] Where client_id = " + client.Client_id;

            try
            {
                SqlCommand scmd = new SqlCommand(str, db.Db());
                int iret = scmd.ExecuteNonQuery();
                return iret.ToString() + " Record deleted successfully";
            }
            catch (SqlException ex)
            {
                return "Error deleting record : " + client.Local_name.ToString() + Environment.NewLine + " Erro: " + ex.Message.ToString();
                throw;
            }
        }

        public string Update(Model.Client client)
        {
            String str = "Update [Client] Set " + Environment.NewLine;
            if (!string.IsNullOrEmpty(client.Local_name))
            {
                str += " local_name= '" + client.Local_name + "'," + Environment.NewLine;
            }
            if (!string.IsNullOrEmpty(client.Intl_name))
            {
                str += " intl_name= '" + client.Intl_name + "'," + Environment.NewLine;
            }
            if (!string.IsNullOrEmpty(client.Code))
            {
                str += " code= '" + client.Code + "'," + Environment.NewLine;
            }

            str += " active= " + client.Active + "," + Environment.NewLine;
            str += " multinational= " + client.Multinational + Environment.NewLine;

            str += " Where client_id = " + client.Client_id;

            try
            {
                SqlCommand scmd = new SqlCommand(str, db.Db());
                int iret = scmd.ExecuteNonQuery();
                return iret.ToString() + " Record deleted successfully";
            }
            catch (SqlException ex)
            {
                return "Error deleting record number: " + client.Local_name.ToString() + Environment.NewLine + " Erro: " + ex.Message.ToString();
                throw;
            }
        }

        public Model.Client Select(Model.Client Client)
        {
            Model.Client cliente;

            try
            {
                SqlCommand cmd = new SqlCommand("Select * From dbo.[client] Where client_id= " + Client.Client_id, db.Db());
                SqlDataReader dr = cmd.ExecuteReader(); //CommandBehavior.CloseConnection

                if (dr.Read())
                {
                    cliente = new Model.Client(); 
                    cliente.Client_id = Convert.ToInt32(dr["client_id"].ToString());
                    cliente.Local_name = dr["local_name"].ToString();
                    cliente.Intl_name = dr["intl_name"].ToString();
                    cliente.Code = dr["code"].ToString();
                    cliente.Active = Convert.ToInt32(dr["active"]);
                    cliente.Multinational = Convert.ToInt32(dr["multinational"].ToString());
                    return cliente;  
                }
                else 
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }

        }

        public List<Model.Client> Select(String pWhere)
        {
            List<Model.Client> lstClient = new List<Model.Client>();
            Model.Client cli;

            try
            {
                SqlCommand cmd = new SqlCommand("Select * From dbo.[client] " + pWhere, db.Db());
                SqlDataReader dr = cmd.ExecuteReader(); //CommandBehavior.CloseConnection

                while (dr.Read())
                {
                    cli = new Model.Client();
                    cli.Client_id = Convert.ToInt32(dr["client_id"].ToString());
                    cli.Local_name = dr["local_name"].ToString();
                    cli.Intl_name = dr["intl_name"].ToString();
                    cli.Code = dr["code"].ToString();
                    cli.Active = Convert.ToInt32(dr["active"]);
                    cli.Multinational = Convert.ToInt32(dr["multinational"].ToString());
                    lstClient.Add(cli);
                }
                return lstClient;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }

        }
    }
}
