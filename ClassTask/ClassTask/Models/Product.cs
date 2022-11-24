using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask.Models
{
    internal class Product
    {
        string _name;
        decimal _price;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
            }
        }
        public decimal Price
        {
            get { return _price; }
            set
            {
                if (value >0)
                {
                    _price = value;
                }
            }
        }
        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}
