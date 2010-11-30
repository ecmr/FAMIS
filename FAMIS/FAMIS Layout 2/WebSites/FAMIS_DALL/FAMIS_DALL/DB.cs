using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Diagnostics;


namespace FAMIS_DALL
{
    public class DB
    {
        String StrCon;
        SqlConnection conn;

        public DB()
        {

        }

        public SqlConnection Db()
        {
            StrCon = Properties.Settings.Default.StrCon.ToString();
            conn = new SqlConnection(StrCon);
            conn.Open();
            return conn;
        }

        
        //Fecha conexão com Banco
        public bool CloseDb()
        {
            if (null != conn)
            {
                conn.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

    }
        
 
}


