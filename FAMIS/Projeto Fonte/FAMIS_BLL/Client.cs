using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using FAMIS_BLL;
 
namespace FAMIS_BLL
{
    public class Client
    {
        private FAMIS_DALL.Client _Client;

        public Client()
        {
            if (_Client == null)
            {
                _Client = new FAMIS_DALL.Client(); 
            }
        }

        public string Add(Model.Client Client)
        {
            return _Client.Add(Client);
        }

        public string Update(Model.Client Client)
        {
            return _Client.Update(Client);
        }

        public string Remove(Model.Client Client)
        {
            return _Client.Delete(Client);
        }

        public Model.Client Select(Model.Client Client)
        {
            return _Client.Select(Client);
        }

        public List<Model.Client> Select(string pQuery)
        {
            return _Client.Select(pQuery);
        }

    }
}
