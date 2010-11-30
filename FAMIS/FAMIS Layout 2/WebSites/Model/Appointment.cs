using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Appointment
    {
        public Appointment()
        {}

        private int _appointment_id;
        private int _employee_id;
        private int _region_id;
        private int _country_id;
        private int _location_id;
        private int _agency_id;
        private int _client_id;
        private DateTime _startDate;
        private DateTime _startHour;
        private DateTime _endDate;
        private DateTime _endHour;
        private string _note;

        public int Appointment_Id 
        {
            get { return _appointment_id; }
            set { _appointment_id = value; }

        }
        public int Employee_id
        {
            get { return _employee_id; }
            set { _employee_id = value; }
        }
        public int Region_id
        {
            get { return _region_id; }
            set { _region_id= value; }
        }
        public int Country_id
        {
            get { return _country_id; }
            set { _country_id = value; }
        }
        public int Location_id
        {
            get { return _location_id; }
            set { _location_id = value; }
        }
        public int Agency_id
        {
            get { return _agency_id; }
            set { _agency_id= value; }
        }
        public int Client_id
        {
            get { return _client_id; }
            set { _client_id= value; }
        }
        public DateTime StartDate
        {
            get { return _startDate ; }
            set { _startDate  = value; }
        }
        public DateTime StartHour
        {
            get { return _startHour; }
            set { _startHour = value; }
        }
        public DateTime EndDate
        {
            get { return _endDate ; }
            set { _endDate = value; }
        }
        public DateTime EndHour
        {
            get { return _endHour ; }
            set { _endHour = value; }
        }
        public string Note
        {
            get { return _note; }
            set { _note= value; }
        }




    }
}
