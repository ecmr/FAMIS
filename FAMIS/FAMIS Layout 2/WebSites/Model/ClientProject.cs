using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class ClientProject
    {
        
        public ClientProject()
        {}

        private int _clientProject_id;
        private string _clientProject_name;
        private int _client_id;
        private int _project_id;

        public int ClientProject_id
        {
            get { return _clientProject_id; }
            set { _clientProject_id = value; }
        }

        public string ClientProject_Name
        {
            get { return _clientProject_name; }
            set { _clientProject_name = value; }
        }

        public int Client_id
        {
            get { return _client_id; }
            set { _client_id = value; }
        }

        public int Project_id
        {
            get { return _project_id; }
            set { _project_id = value; }
        }
    }
}
