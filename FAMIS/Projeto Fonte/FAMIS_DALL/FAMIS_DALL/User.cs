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
    public class User
    {
        DB db;
        //Acesso ao banco
        //Vai criar a conexão com o SQL, pode ciar uma classe de apóio também tipo SQLHelper pra deixar a conexão etc...
        public User()
        {
            db = new DB();
        }


        //Metodo de pesquisa e popular o obejto user
        public string Add(Model.User User)
        {
            
            string str = "Insert Into [User](first_name, last_name, email, active, login, password)" + Environment.NewLine;
            str += " Values('" + User.First_name + "', '" + User.Last_name + "','" + User.Email + "', " + User.Active + " , '" + User.Login + "', '" + Criptografar(User.Password, "pink floyd") + "')";

            try
            {
                SqlCommand scmd = new SqlCommand(str, db.Db());

                int iret = scmd.ExecuteNonQuery();
                return iret.ToString() + " Record successfully saved";
            }
            catch (SqlException ex)
            {
                return "Error saving the record of: " + User.First_name + Environment.NewLine + " Erro: " + ex.Message.ToString();
                throw;
            }
            finally
            {

            }
        }

        public string Delete(Model.User User)
        {
            String str = "Delete From [User] Where user_id = " + User.User_id;

            try
            {
                SqlCommand scmd = new SqlCommand(str, db.Db());
                int iret = scmd.ExecuteNonQuery();
                return iret.ToString() + " Record deleted successfully";
            }
            catch (SqlException ex)
            {
                return "Error deleting record : " + User.First_name.ToString() + Environment.NewLine + " Erro: " + ex.Message.ToString();
                throw;
            }
        }

        public string Update(Model.User User)
        {
            String str = "Update [User] Set " + Environment.NewLine;
            if (!string.IsNullOrEmpty(User.First_name))
            {
                str += " first_name= '" + User.First_name + "'," + Environment.NewLine;
            }
            if (!string.IsNullOrEmpty(User.Last_name))
            {
                str += " last_name= '" + User.Last_name + "'," + Environment.NewLine;
            }
            if (!string.IsNullOrEmpty(User.Email))
            {
                str += " email= '" + User.Email + "'," + Environment.NewLine;
            }
            str += " active= " + User.Active + "," + Environment.NewLine;

            if (!string.IsNullOrEmpty(User.Login))
            {
                str += " login= '" + User.Login + "'," + Environment.NewLine;
            }
            if (!string.IsNullOrEmpty(User.Password))
            {
                str += " password= '" + Criptografar("pink floyd", User.Password) + "'" + Environment.NewLine;
            }
            str += " Where user_id = " + User.User_id;

            try
            {
                SqlCommand scmd = new SqlCommand(str, db.Db());
                int iret = scmd.ExecuteNonQuery();
                return iret.ToString() + " Record deleted successfully";
            }
            catch (SqlException ex)
            {
                return "Error deleting record number: " + User.User_id.ToString() + Environment.NewLine + " Erro: " + ex.Message.ToString();
                throw;
            }
        }

        public Model.User Select(Model.User User)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select * From dbo.[user] Where user_id=" + User.User_id , db.Db());
                SqlDataReader dr = cmd.ExecuteReader(); 

                while (dr.Read())
                {
                    User.User_id = Convert.ToInt32(dr["user_id"].ToString());
                    User.First_name = dr["first_name"].ToString();
                    User.Last_name = dr["last_name"].ToString();
                    User.Email = dr["email"].ToString();
                    User.Active = Convert.ToInt32(dr["active"]);
                    User.Login = dr["login"].ToString();
                    User.Password = Descriptografar(Convert.FromBase64String(dr["password"].ToString()), "pink floyd");
                }
                return User;

            }
            catch (Exception)
            {
                
                throw;
            }
        }

        //Nesse caso vai retornar uma lista de objeto. Não sei se seu retorno vão ter vários, ou um por vez. Se for um por vez, não precisa usar lista.
        public List<Model.User> Select(String pWhere)
        {

            List<Model.User> lstUsuario = new List<Model.User>();
            Model.User usuario;

            SqlCommand cmd = new SqlCommand("Select * From dbo.[User] " + pWhere, db.Db());
            //SQLHelper.ExecuteReader("string de conexao", CommandType.StoredProcedure, "Procedure", null)
            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    usuario = new Model.User();

                    //retorno do SQlDataReader
                    if (!rdr.IsDBNull(0)) //exemplo pra conferir se o retorno tem valor ou é nulo. Eu pego pelo número, da pra ser por nome também
                        usuario.User_id = rdr.GetInt32(0); 

                    if (!rdr.IsDBNull(1))
                        usuario.First_name = rdr.GetString(1);

                    if (!rdr.IsDBNull(2))
                        usuario.Last_name = rdr.GetString(2);

                    if (!rdr.IsDBNull(3))
                        usuario.Email = rdr.GetString(3);

                    if (!rdr.IsDBNull(4))
                        //usuario.Active = rdr.GetInt32(4);

                    if (!rdr.IsDBNull(5))
                        usuario.Login = rdr.GetString(5);

                    if (!rdr.IsDBNull(6))
                        //usuario.Password = Descriptografar(Convert.FromBase64String(rdr.GetString(6)), "pink floyd");
                        usuario.Password = rdr.GetString(6);

                    lstUsuario.Add(usuario);
                }
            }

            return lstUsuario;
        }

        public Model.User Validate(Model.User entity)
        {
            SqlCommand cmd = new SqlCommand("Select * From dbo.[user] Where Login='" + entity.Login + "' and Password='" + Criptografar(entity.Password, "pink floyd") + "'" , db.Db());
            SqlDataReader dr = cmd.ExecuteReader();

            if(dr.Read())
            {
                entity.User_id = Convert.ToInt32(dr["user_id"].ToString());
                entity.First_name = dr["first_name"].ToString();
                entity.Last_name = dr["last_name"].ToString();
                entity.Email = dr["email"].ToString();
                entity.Active = Convert.ToInt32(dr["active"]);
                entity.Login = dr["login"].ToString();
                entity.Password = Descriptografar(Convert.FromBase64String(dr["password"].ToString()), "pink floyd");
            }
            return entity;
        }

        #region "[Cryptografia de senha]"

        public string Criptografar(string dados, string senha)
        {
            byte[] b = Encoding.UTF8.GetBytes(dados);
            byte[] pw = Encoding.UTF8.GetBytes(senha);

            RijndaelManaged rm = new RijndaelManaged();
            PasswordDeriveBytes pdb = new PasswordDeriveBytes(senha, new MD5CryptoServiceProvider().ComputeHash(pw));
            rm.Key = pdb.GetBytes(32);
            rm.IV = pdb.GetBytes(16);
            rm.BlockSize = 128;
            rm.Padding = PaddingMode.PKCS7;
            MemoryStream ms = new MemoryStream();
            CryptoStream cryptStream = new CryptoStream(ms, rm.CreateEncryptor(rm.Key, rm.IV), CryptoStreamMode.Write);
            cryptStream.Write(b, 0, b.Length);
            cryptStream.FlushFinalBlock();

            return Convert.ToBase64String(ms.ToArray()).Trim();
        }

        public string Descriptografar(byte[] dados, string senha)
        {
            byte[] pw = Encoding.UTF8.GetBytes(senha);

            RijndaelManaged rm = new RijndaelManaged();
            PasswordDeriveBytes pdb = new PasswordDeriveBytes(senha, new MD5CryptoServiceProvider().ComputeHash(pw));
            rm.Key = pdb.GetBytes(32);
            rm.IV = pdb.GetBytes(16);
            rm.BlockSize = 128;
            rm.Padding = PaddingMode.PKCS7;

            MemoryStream ms = new MemoryStream(dados, 0, dados.Length);

            CryptoStream cryStrem = new CryptoStream(ms, rm.CreateDecryptor(rm.Key, rm.IV), CryptoStreamMode.Read);
            StreamReader sr = new StreamReader(cryStrem);

            return sr.ReadToEnd();
        }

        #endregion

    }
}
