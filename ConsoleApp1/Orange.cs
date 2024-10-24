using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Orange : Fruit
    {
        public int _vitaminC;

        public int VitaminC
        {
            get { return _vitaminC; }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                _vitaminC = value;
            }
        }
        public Orange(int price, string sort, int vitaminC) : base(price, sort)
        {
            VitaminC = vitaminC;
        }
        public override void Taste()
        {
            Console.WriteLine("sweet & sour\n");
        }
    }
}
