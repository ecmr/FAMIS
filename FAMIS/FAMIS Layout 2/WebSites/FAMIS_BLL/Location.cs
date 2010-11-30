using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using FAMIS_BLL;
using System.Data.SqlClient;

namespace FAMIS_BLL
{
    public class Location
    {
        private FAMIS_DALL.Location _Location;

        public Location()
        {
            if (_Location == null)
            {
                _Location = new FAMIS_DALL.Location(); 
            }
        }

        public string Add(Model.Location Location)
        {
            return _Location.Add(Location);
        }

        public string Update(Model.Location Location)
        {
            return _Location.Update(Location);
        }

        public string Remove(Model.Location Location)
        {
            return _Location.Delete(Location);
        }

        public Model.Location Select(Model.Location Location)
        {
            return _Location.Select(Location);
        }

        public List<Model.Location> Select(string pQuery)
        {
            return _Location.Select(pQuery);
        }

        public SqlDataReader GetSelect(String pQuery)
        {
            return _Location.GetSelect(pQuery);
        }
    
    }
}
