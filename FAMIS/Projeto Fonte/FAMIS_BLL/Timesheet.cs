using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using FAMIS_BLL;

namespace FAMIS_BLL
{
    public class Timesheet
    {
        private FAMIS_DALL.Timesheet _timesheet;

        public Timesheet()
        {
            if (_timesheet == null)
            {
                _timesheet = new FAMIS_DALL.Timesheet();
            }
        }

        public string Add(Model.Timesheet timesheet)
        {
            return _timesheet.Add(timesheet);
        }

        public string Update(Model.Timesheet timesheet)
        {
            return _timesheet.Update(timesheet);
        }

        public string Remove(Model.Timesheet timesheet)
        {
            return _timesheet.Delete(timesheet);
        }

        public Model.Timesheet Select(Model.Timesheet timesheet)
        {
            return _timesheet.Select(timesheet);
        }

        public List<Model.Timesheet> Select(string pQuery)
        {
            return _timesheet.Select(pQuery);
        }

        public SqlDataReader LoadDropDow()
        {
            return _timesheet.LoadDropDow(); 
        }

        public Model.ClientProject GetClientProjectID(Int32 _id)
        {
            return _timesheet.GetClientProjectId(_id);
        }

        public Model.Timesheet SelectQuery(String _Where)
        {
            return _timesheet.SelectQuery(_Where);
        }

        public string StopTime(Int32 Timesheet_id)
        {

            Model.Timesheet _timesheetBussines = _timesheet.SelectQuery(" Where timesheet_id=" + Timesheet_id);
            TimeSpan _tsDif = DateTime.Now.Subtract(_timesheetBussines.StartTime);
            _timesheetBussines.FullTime = DateTime.Now.Add(_tsDif);
            _timesheetBussines.EndTime = Convert.ToDateTime(DateTime.Now.ToString("s"));
            return _timesheet.Update(_timesheetBussines);  
        }

    }
}
