using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Apple : Fruit
    {
        public int _vitaminA;
        public int _vitaminB;
        public int VitaminA
        {
            get { return _vitaminA; }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                _vitaminA = value;
            }
        }
        public int VitaminB
        {
            get { return _vitaminB; }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                _vitaminB = value;
            }
        }
        public Apple(int price, string sort, int vitaminA, int vitaminB) : base(price, sort)
        {
            VitaminA = vitaminA;
            VitaminB = vitaminB;
        }
        public override void Taste()
        {
            Console.WriteLine("Sweet\n");
        }
    }
}
