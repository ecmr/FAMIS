using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class User
    {
        public User()
        { }

        #region "[Properties]"

        private int _use_id;
        private string _first_name;
        private string _last_name;
        private string _email;
        private int _active;
        private string _login;
        private string _password;

        public int User_id
        {
            get { return _use_id; }
            set { _use_id = value; }
        }

        public string First_name
        {
            get { return _first_name; }
            set { _first_name = value; }
        }

        public string Last_name
        {
            get { return _last_name; }
            set { _last_name = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public int Active
        {
            get { return _active; }
            set { _active = value; }
        }

        public string Login
        {
            get { return _login; }
            set { _login = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        #endregion

    }
}
