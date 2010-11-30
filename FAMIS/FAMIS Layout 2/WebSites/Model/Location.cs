using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Location
    {
        public Location()
        { }

        private int _location_id;
        private int _region_id;
        private int _country_id;
        private int _agency_id;
        private string _address;
        private int _number;
        private string _city;

        public int Location_id
        {
            get { return _location_id; }
            set { _location_id = value; }
        }

        public int Region_id
        {
            get { return _region_id; }
            set { _region_id = value; }
        }

        public int Country_id
        {
            get { return _country_id ; }
            set { _country_id = value; }
        }

        public int Agency_id
        {
            get { return _agency_id; }
            set { _agency_id = value; }
        }

        public string Address
        {
            get { return _address ; }
            set { _address = value; }
        }

        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }


    }
}
