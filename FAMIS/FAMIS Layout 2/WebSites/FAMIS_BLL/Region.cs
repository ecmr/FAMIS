using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using FAMIS_DALL;

namespace FAMIS_BLL
{
    public class Region
    {
        private FAMIS_DALL.Region _Region;

        public Region()
        {
            if (_Region == null)
            {
                _Region = new FAMIS_DALL.Region();
            }
        }

        public string Add(Model.Region region)
        {
            return _Region.Add(region);
        }

        public string Update(Model.Region region)
        {
            return _Region.Update(region);
        }

        public string Remove(Model.Region region)
        {
            return _Region.Delete(region);
        }

        public Model.Region Select(Model.Region region)
        {
            return _Region.Select(region);
        }

        public List<Model.Region> Select(string pQuery)
        {
            return _Region.Select(pQuery);
        }

    }
}
