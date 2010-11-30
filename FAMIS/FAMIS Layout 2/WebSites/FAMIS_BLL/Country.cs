using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using FAMIS_BLL;
using System.Data.SqlClient;

namespace FAMIS_BLL
{
    public class Country
    {
        private FAMIS_DALL.Country _Country;

        public Country()
        {
            if (_Country == null)
            {
                _Country = new FAMIS_DALL.Country(); 
            }
        }

        public string Add(Model.Country Country)
        {
            return _Country.Add(Country);
        }

        public string Update(Model.Country Country)
        {
            return _Country.Update(Country);
        }

        public string Remove(Model.Country Country)
        {
            return _Country.Delete(Country);
        }

        public Model.Country Select(Model.Country Country)
        {
            return _Country.Select(Country);
        }

        public List<Model.Country> Select(string pQuery)
        {
            return _Country.Select(pQuery);
        }

        public SqlDataReader GetSelect(String pQuery)
        {
            return _Country.GetSelect(pQuery);
        }    
    }
}
