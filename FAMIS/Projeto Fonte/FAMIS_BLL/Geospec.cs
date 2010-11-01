using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using FAMIS_BLL;
using System.Data.SqlClient;

namespace FAMIS_BLL
{
    public class Geospec
    {
        private FAMIS_DALL.Geospec _Geospec;

        public Geospec()
        {
            if (_Geospec == null)
            {
                _Geospec = new FAMIS_DALL.Geospec(); 
            }
        }

        public string Add(Model.Geospec Geospec)
        {
            return _Geospec.Add(Geospec);
        }

        public string Update(Model.Geospec Geospec)
        {
            return _Geospec.Update(Geospec);
        }

        public string Remove(Model.Geospec Geospec)
        {
            return _Geospec.Delete(Geospec);
        }

        public Model.Geospec Select(Model.Geospec Geospec)
        {
            return _Geospec.Select(Geospec);
        }

        public List<Model.Geospec> Select(string pQuery)
        {
            return _Geospec.Select(pQuery);
        }

        public SqlDataReader GetSelect(String pQuery)
        {
            return _Geospec.GetSelect(pQuery);
        }    
    }
}
