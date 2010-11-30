using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Timesheet
    {
        public Timesheet()
        { }

        private int _timesheet_id;
        private int _client_id;
        private int _project_id;
        private int _user_id;
        private DateTime _startTime;
        private DateTime _endTime;
        private DateTime _fullTime;
        private DateTime _jobTime;
        private string _coment;

        public int Timesheet_id
        {
            get { return _timesheet_id; }
            set { _timesheet_id = value; }
        }

        public int Client_id
        {
            get { return _client_id; }
            set { _client_id = value; }
        }

        public int Project_id
        {
            get { return _project_id; }
            set { _project_id = value; }
        }

        public int User_id
        {
            get { return _user_id ; }
            set { _user_id = value; }
        }

        public DateTime StartTime
        {
            get { return _startTime; }
            set { _startTime = value; }
        }

        public DateTime EndTime
        {
            get { return _endTime; }
            set { _endTime = value; }
        }

        public DateTime FullTime
        {
            get { return _fullTime; }
            set { _fullTime = value; }
        }

        public DateTime JobTime
        {
            get { return _jobTime; }
            set { _jobTime = value; }
        }

        public string Coment
        {
            get { return _coment; }
            set { _coment = value; }
        }
    }
}
