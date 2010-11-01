using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;  
using FAMIS_DALL;

namespace FAMIS_BLL
{
    public class Position
    {
        private FAMIS_DALL.Position _Position;

        public Position()
        {
            if (_Position == null)
            {
                _Position = new FAMIS_DALL.Position(); 
            }
        }

        public string Add(Model.Position Position)
        {
            return _Position.Add(Position);
        }

        public string Update(Model.Position Position)
        {
            return _Position.Update(Position);
        }

        public string Remove(Model.Position Position)
        {
            return _Position.Delete(Position);
        }

        public Model.Position Select(Model.Position Position)
        {
            return _Position.Select(Position);
        }

        public List<Model.Position> Select(string pQuery)
        {
            return _Position.Select(pQuery);
        }

        public SqlDataReader GetSelect(String pQuery)
        {
            return _Position.GetSelect(pQuery);
        }
    }
}
