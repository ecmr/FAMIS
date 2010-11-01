using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.IO;
using Model;

namespace FAMIS_DALL
{
    public class Appointment
    {
        DB db;
        //Acesso ao banco
        //Vai criar a conexão com o SQL, pode ciar uma classe de apóio também tipo SQLHelper pra deixar a conexão etc...
        public Appointment()
        {
            db = new DB();
        }


 //       //Metodo de pesquisa e popular o obejto user
 //       public string Add(Model.Appointment Appointment)
 //       {

 //           string str = " INSERT INTO [FAMIS].[dbo].[Appointment] " + Environment.NewLine;
 //          str += " ([employee_id] " + Environment.NewLine;
 //          str += " ,[region_id] " + Environment.NewLine;
 //          str += " ,[country_id] " + Environment.NewLine;
 //          str += " ,[location_id] " + Environment.NewLine;
 //          str += " ,[agency_id] " + Environment.NewLine;
 //          str += " ,[client_id] " + Environment.NewLine;
 //          str += " ,[startDate] " + Environment.NewLine;
 //          str += " ,[startHour] " + Environment.NewLine;
 //          str += " ,[endDate] " + Environment.NewLine;
 //          str += " ,[endHour] " + Environment.NewLine;
 //          str += " ,[note]) " + Environment.NewLine;
 //          str += " VALUES " + Environment.NewLine;
 //          str += " (" + Appointment.Employee_id + ",> " + Environment.NewLine;
 //          str += " ," + Appointment.Region_id  + Environment.NewLine;
 //          str += " ," + Appointment.Country_id + Environment.NewLine;
 //          str += " ," + Appointment.Location_id + Environment.NewLine;
 //          str += " ," + Appointment.Agency_id  + Environment.NewLine;
 //          str += " ," + Appointment.Client_id  + Environment.NewLine;
 //          str += " ," + Appointment.StartDate  + Environment.NewLine;
 //          str += " ," + Appointment.StartHour  + Environment.NewLine;
 //          str += " ," + Appointment.EndDate  + Environment.NewLine;
 //          str += " ," + Appointment.EndHour + Environment.NewLine;
 //          str += " ," + Appointment.Note + ") ";
                
 //           try
 //           {
 //               SqlCommand scmd = new SqlCommand(str, db.Db());

 //               int iret = scmd.ExecuteNonQuery();
 //               return iret.ToString() + " Record successfully saved";
 //           }
 //           catch (SqlException ex)
 //           {
 //               return "Error saving the record of: " + Appointment.Appointment_Id + Environment.NewLine + " Erro: " + ex.Message.ToString();
 //               throw;
 //           }
 //           finally
 //           {

 //           }
 //       }

 //       public string Delete(Model.Appointment Appointment)
 //       {
 //           String str = "Delete From [User] Where Appointment_id = " + Appointment.Appointment_Id; 

 //           try
 //           {
 //               SqlCommand scmd = new SqlCommand(str, db.Db());
 //               int iret = scmd.ExecuteNonQuery();
 //               return iret.ToString() + " Record deleted successfully";
 //           }
 //           catch (SqlException ex)
 //           {
 //               return "Error deleting record : " + Appointment.Appointment_Id.ToString() + Environment.NewLine + " Erro: " + ex.Message.ToString();
 //               throw;
 //           }
 //       }

 //       public string Update(Model.Appointment Appointment)
 //       {
 ////           String str = "UPDATE [FAMIS].[dbo].[Appointment] SET " + Environment.NewLine;
 ////                   str += " [employee_id]= " + Appointment.Employee_id + "," + Environment.NewLine;
 ////                   str += " [region_id]= " + Appointment.Region_id  + "," + Environment.NewLine; 
 ////                   str += " [country_id]= " + Appointment.Country_id + "," + Environment.NewLine; 
            
 ////           str += " [location_id]= " + Appointment.Country_id + "," + Environment.NewLine; 
 ////           str += " [agency_id]= " + Appointment.Country_id + "," + Environment.NewLine; 
 ////           str += " [client_id]= " + Appointment.Country_id + "," + Environment.NewLine; 
 ////           str += " [startDate]= " + Appointment.Country_id + "," + Environment.NewLine; 
 ////           str += " [startHour]= " + Appointment.Country_id + "," + Environment.NewLine; 
 ////           str += " [endDate]= " + Appointment.Country_id + "," + Environment.NewLine; 
 ////           str += " [endHour]= " + Appointment.Country_id + "," + Environment.NewLine; 
 ////           str += " [country_id]= " + Appointment.Country_id + "," + Environment.NewLine; 

 ////     ,[] = <location_id, int,>
 ////     ,[] = <agency_id, int,>
 ////     ,[] = <client_id, int,>
 ////     ,[] = <startDate, datetime,>
 ////     ,[] = <startHour, datetime,>
 ////     ,[] = <endDate, datetime,>
 ////     ,[] = <endHour, datetime,>
 ////     ,[] = <note, ntext,>
 ////WHERE <Search Conditions,,>
                
                
                
                
 ////               "Update [User] Set " + Environment.NewLine;
 ////           if (!string.IsNullOrEmpty(User.First_name))
 ////           {
 ////               str += " first_name= '" + User.First_name + "'," + Environment.NewLine;
 ////           }
 ////           if (!string.IsNullOrEmpty(User.Last_name))
 ////           {
 ////               str += " last_name= '" + User.Last_name + "'," + Environment.NewLine;
 ////           }
 ////           if (!string.IsNullOrEmpty(User.Email))
 ////           {
 ////               str += " email= '" + User.Email + "'," + Environment.NewLine;
 ////           }
 ////           str += " active= " + User.Active + "," + Environment.NewLine;

 ////           if (!string.IsNullOrEmpty(User.Login))
 ////           {
 ////               str += " login= '" + User.Login + "'," + Environment.NewLine;
 ////           }
 ////           if (!string.IsNullOrEmpty(User.Password))
 ////           {
 ////               str += " password= '" + Criptografar("pink floyd", User.Password) + "'" + Environment.NewLine;
 ////           }
 ////           str += " Where user_id = " + User.User_id;

 ////           try
 ////           {
 ////               SqlCommand scmd = new SqlCommand(str, db.Db());
 ////               int iret = scmd.ExecuteNonQuery();
 ////               return iret.ToString() + " Record deleted successfully";
 ////           }
 ////           catch (SqlException ex)
 ////           {
 ////               return "Error deleting record number: " + User.User_id.ToString() + Environment.NewLine + " Erro: " + ex.Message.ToString();
 ////               throw;
 ////           }
 //           return "";
 //       }

 //       public Model.User Select(Model.User User)
 //       {
 //           try
 //           {
 //               SqlCommand cmd = new SqlCommand("Select * From dbo.[user] Where user_id=" + User.User_id, db.Db());
 //               SqlDataReader dr = cmd.ExecuteReader();

 //               while (dr.Read())
 //               {
 //                   User.User_id = Convert.ToInt32(dr["user_id"].ToString());
 //                   User.First_name = dr["first_name"].ToString();
 //                   User.Last_name = dr["last_name"].ToString();
 //                   User.Email = dr["email"].ToString();
 //                   User.Active = Convert.ToInt32(dr["active"]);
 //                   User.Login = dr["login"].ToString();
 //                   User.Password = Descriptografar(Convert.FromBase64String(dr["password"].ToString()), "pink floyd");
 //               }
 //               return User;

 //           }
 //           catch (Exception)
 //           {

 //               throw;
 //           }
 //       }

 //       //Nesse caso vai retornar uma lista de objeto. Não sei se seu retorno vão ter vários, ou um por vez. Se for um por vez, não precisa usar lista.
 //       public List<Model.User> Select(String pWhere)
 //       {

 //           List<Model.User> lstUsuario = new List<Model.User>();
 //           Model.User usuario;

 //           SqlCommand cmd = new SqlCommand("Select * From dbo.[User] " + pWhere, db.Db());
 //           //SQLHelper.ExecuteReader("string de conexao", CommandType.StoredProcedure, "Procedure", null)
 //           using (SqlDataReader rdr = cmd.ExecuteReader())
 //           {
 //               while (rdr.Read())
 //               {
 //                   usuario = new Model.User();

 //                   //retorno do SQlDataReader
 //                   if (!rdr.IsDBNull(0)) //exemplo pra conferir se o retorno tem valor ou é nulo. Eu pego pelo número, da pra ser por nome também
 //                       usuario.User_id = Convert.ToInt32(rdr.GetString(0).ToString());

 //                   if (!rdr.IsDBNull(1))
 //                       usuario.First_name = rdr.GetString(1);

 //                   if (!rdr.IsDBNull(2))
 //                       usuario.Last_name = rdr.GetString(2);

 //                   if (!rdr.IsDBNull(3))
 //                       usuario.Email = rdr.GetString(3);

 //                   if (!rdr.IsDBNull(4))
 //                       usuario.Active = Convert.ToInt32(rdr.GetString(4).ToString());

 //                   if (!rdr.IsDBNull(5))
 //                       usuario.Login = rdr.GetString(5);

 //                   if (!rdr.IsDBNull(6))
 //                       usuario.Password = Descriptografar(Convert.FromBase64String(rdr.GetString(6)), "pink floyd");


 //                   lstUsuario.Add(usuario);
 //               }
 //           }

 //           return lstUsuario;
 //       }

 //       public Model.User Validate(Model.User entity)
 //       {
 //           SqlCommand cmd = new SqlCommand("Select * From dbo.[user] Where Login='" + entity.Login + "' and Password='" + Criptografar(entity.Password, "pink floyd") + "'", db.Db());
 //           SqlDataReader dr = cmd.ExecuteReader();

 //           if (dr.Read())
 //           {
 //               entity.User_id = Convert.ToInt32(dr["user_id"].ToString());
 //               entity.First_name = dr["first_name"].ToString();
 //               entity.Last_name = dr["last_name"].ToString();
 //               entity.Email = dr["email"].ToString();
 //               entity.Active = Convert.ToInt32(dr["active"]);
 //               entity.Login = dr["login"].ToString();
 //               entity.Password = Descriptografar(Convert.FromBase64String(dr["password"].ToString()), "pink floyd");
 //           }
 //           return entity;
  //      }    
    }

}
