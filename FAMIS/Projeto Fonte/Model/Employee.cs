using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
 
namespace Model
{
    public class Employee
    {
        public Employee()
        { }

        private int _agency_id;
        private int _employee_id;
        private int _position_id;
        private string _first_name;
        private string _last_name;
        private string _code;
        private DateTime _date_hired;
        private DateTime _last_version;
        private decimal _salary;
        private Image _picture;
        private byte _cv;

        public int Agency_id 
        {
            get { return _agency_id; }
            set { _agency_id = value; }
        }

        public int Employee_id
        {
            get { return _employee_id ; }
            set { _employee_id = value; }
        }

        public int Position_id
        {
            get { return _position_id ; }
            set { _position_id = value; }
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

        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }

        public DateTime Date_hired
        {
            get { return _date_hired; }
            set { _date_hired = value; }
        }

        public DateTime Last_version
        {
            get { return _last_version; }
            set { _last_version = value; }
        }

        public decimal Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public Image Picture
        {
            get { return _picture; }
            set { _picture = value; }
        }

        public byte Cv
        {
            get { return _cv; }
            set { _cv = value; }
        }


    }
}
