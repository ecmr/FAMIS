using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using FAMIS_BLL;
using System.Data.SqlClient;

namespace FAMIS_BLL
{
    public class Group
    {
        private FAMIS_DALL.Group _Group;

        public Group()
        {
            if (_Group == null)
            {
                _Group = new FAMIS_DALL.Group(); 
            }
        }

        public string Add(Model.Group Group)
        {
            return _Group.Add(Group);
        }

        public string Update(Model.Group Group)
        {
            return _Group.Update(Group);
        }

        public string Remove(Model.Group Group)
        {
            return _Group.Delete(Group);
        }

        public Model.Group Select(Model.Group Group)
        {
            return _Group.Select(Group);
        }

        public List<Model.Group> Select(string pQuery)
        {
            return _Group.Select(pQuery);
        }

        public SqlDataReader GetSelect(String pQuery)
        {
            return _Group.GetSelect(pQuery);
        }
    }
}
