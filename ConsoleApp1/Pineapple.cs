using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Pineapple : Fruit
    {
        public int _vitaminE;
        public int _vitaminD;
        public int VitaminA
        {
            get { return _vitaminE; }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                _vitaminE = value;
            }
        }
        public int VitaminD
        {
            get { return _vitaminD; }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                _vitaminD = value;
            }
        }
        public Pineapple(int price, string sort, int vitaminE, int vitaminD) : base(price, sort)
        {
            _vitaminE = vitaminE;
            VitaminD = vitaminD;
        }
        public override void Taste()
        {
            Console.WriteLine("eating your tongue\n");
        }
    }
}
