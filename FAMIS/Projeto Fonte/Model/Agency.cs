using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Agency
    {
        public Agency()
        { }

        private int _agency_id;
        private string _name;

        public int Agency_id 
        {
            get { return _agency_id; }
            set { _agency_id = value; }
        }

        public String Name 
        {
            get { return _name; }
            set { _name = value; }
        }
        

    }
}
