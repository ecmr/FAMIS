using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Position
    {
        public Position()
        { }

        private int _position_id;
        private string _code;
        private int _department_id;
        private decimal _salary_research;
        private string _name;

        public int Position_id
        {
            get { return _position_id; }
            set { _position_id = value; }
        }

        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }

        public int Department_id
        {
            get { return _department_id; }
            set { _department_id = value; }
        }

        public decimal Salary_research
        {
            get { return _salary_research; }
            set { _salary_research = value; }
        }

        public string  Name 
        {
            get { return _name; }
            set { _name = value; }
        }

    }
}
