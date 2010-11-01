using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Region
    {
        public Region()
        { }

        private int _region_id;
        private string _name;

        public int Region_id
        {
            get { return _region_id; }
            set { _region_id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


 
    }
}
