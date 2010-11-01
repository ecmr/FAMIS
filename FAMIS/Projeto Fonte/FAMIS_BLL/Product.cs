using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using FAMIS_BLL;

namespace FAMIS_BLL
{
    public class Product
    {
        private FAMIS_DALL.Product _Product;

        public Product()
        {
            if (_Product == null)
            {
                _Product = new FAMIS_DALL.Product();
            }
        }

        public string Add(Model.Product Product)
        {
            return _Product.Add(Product);
        }

        public string Update(Model.Product Product)
        {
            return _Product.Update(Product);
        }

        public string Remove(Model.Product Product)
        {
            return _Product.Delete(Product);
        }

        public Model.Product Select(Model.Product Product)
        {
            return _Product.Select(Product);
        }

        public List<Model.Product> Select(string pQuery)
        {
            return _Product.Select(pQuery);
        }

    }
}
