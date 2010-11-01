using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Geospec
    {
        public Geospec()
        { }

        private int _geospec_id;
        private string _currency;
        private string _decimal_symbol;
        private DateTime _date_format;
        private int _region_id;
        private int _country_id;

        public int Geospec_id
        {
            get { return _geospec_id; }
            set { _geospec_id = value; }
        }

        public string Currency
        {
            get { return _currency; }
            set { _currency = value; }
        }

        public string Decimal_symbol
        {
            get { return _decimal_symbol; }
            set { _decimal_symbol = value; }
        }

        public DateTime Date_format
        {
            get { return _date_format; }
            set { _date_format = value; }
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


    }
}
