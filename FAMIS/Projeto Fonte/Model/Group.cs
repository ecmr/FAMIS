using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Group
    {
        public Group()
        { }

        private int _group_id;
        private string _name;
        private int _agency_id;

        public int Group_id
        {
            get { return _group_id; }
            set { _group_id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Agency_id
        {
            get { return _agency_id; }
            set { _agency_id = value; }
        }


    }
}
