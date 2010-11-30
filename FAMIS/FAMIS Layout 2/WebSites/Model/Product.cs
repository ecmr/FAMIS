using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Product
    {
        public Product()
        {}

        private int _product_id;
        private string _name;
        private int _client_id;

        public int Product_id 
        {
            get { return _product_id; }
            set { _product_id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        
        public int Client_id 
        {
            get { return _client_id; }
            set { _client_id = value; }
        }

    }
}
