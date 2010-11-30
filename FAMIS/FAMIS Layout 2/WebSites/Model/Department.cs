using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Department
    {
        public Department()
        { }

        private int _department_id;
        private string _name;

        public int Department_id 
        {
            get { return _department_id; }
            set { _department_id = value; }
        }

        public string  Name 
        {
            get { return _name; }
            set { _name = value; }
        }


    }
}
