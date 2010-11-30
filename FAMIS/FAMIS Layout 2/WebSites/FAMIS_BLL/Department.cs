using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using FAMIS_BLL;

namespace FAMIS_BLL
{
    public class Department
    {
        private FAMIS_DALL.Department _Department;

        public Department()
        {
            if (_Department == null)
            {
                _Department = new FAMIS_DALL.Department(); 
            }
        }

        public string Add(Model.Department Department)
        {
            return _Department.Add(Department);
        }

        public string Update(Model.Department Department)
        {
            return _Department.Update(Department);
        }

        public string Remove(Model.Department Department)
        {
            return _Department.Delete(Department);
        }

        public Model.Department Select(Model.Department Department)
        {
            return _Department.Select(Department);
        }

        public List<Model.Department> Select(string pQuery)
        {
            return _Department.Select(pQuery);
        }
    }
}
