using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using FAMIS_BLL;
using System.Data.SqlClient;
   
namespace FAMIS_BLL
{
    public class Agency
    {
        private FAMIS_DALL.Agency _Agency;

        public Agency()
        {
            if (_Agency == null)
            {
                _Agency = new FAMIS_DALL.Agency(); 
            }
        }

        public string Add(Model.Agency Agency)
        {
            return _Agency.Add(Agency);
        }

        public string Update(Model.Agency Agency)
        {
            return _Agency.Update(Agency);
        }

        public string Remove(Model.Agency Agency)
        {
            return _Agency.Delete(Agency);
        }

        public Model.Agency Select(Model.Agency Agency)
        {
            return _Agency.Select(Agency);
        }

        public List<Model.Agency> Select(string pQuery)
        {
            return _Agency.Select(pQuery);
        }

        public SqlDataReader GetSelect(String pQuery)
        {
            return _Agency.GetSelect(pQuery);
        }

    }
}
