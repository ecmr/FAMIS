using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Client
    {
        #region "[Properties]"

        private int _client_id;
        private string _local_name;
        private string _intl_name;
        private string _code;
        private int _active;
        private int _multinational;


        public int Client_id
        {
            get { return _client_id; }
            set { _client_id = value; }
        }

        public string Local_name
        {
            get { return _local_name; }
            set { _local_name = value; }
        }

        public string Intl_name
        {
            get { return _intl_name; }
            set { _intl_name = value; }
        }

        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }

        public int Active
        {
            get { return _active; }
            set { _active = value; }
        }

        public int Multinational
        {
            get { return _multinational; }
            set { _multinational = value; }
        }

        #endregion
    }
}
