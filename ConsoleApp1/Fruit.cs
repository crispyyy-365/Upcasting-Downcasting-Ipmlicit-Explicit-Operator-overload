using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal abstract class Fruit
    {
        public int _price;
        public string _sort { get; set; }
        public int Price
        {
            get { return _price; }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                _price = value;
            }
        }
        public Fruit(int price, string sort)
        {
            Price = price;
            _sort = sort;
        }
        public abstract void Taste();
    }
}
