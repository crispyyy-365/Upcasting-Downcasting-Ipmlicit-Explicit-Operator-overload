using System.Reflection;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new(500, "Red", 729348, 473287);
            Pineapple pineapple = new(1000, "Havaian", 91834, 23844);
            Orange orange = new(999999, "big", 2384483);
            Fruit[] basket = new Fruit[] { orange, pineapple, apple };

            
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type[] types = assembly.GetTypes();

            Type type1 = apple.GetType();
            Type type2 = pineapple.GetType();
            Type type3 = orange.GetType();

            Console.WriteLine(type1.Name);

            foreach (var field1 in type1.GetFields())
            {
                Console.WriteLine($"{field1.Name} : {field1.GetValue(apple)} \n");
            }
            apple.Taste();

            Console.WriteLine(type2.Name);

            foreach (var field2 in type2.GetFields())
            {
                Console.WriteLine($"{field2.Name} : {field2.GetValue(pineapple)} \n");
            }
            pineapple.Taste();

            Console.WriteLine(type3.Name);

            foreach (var field3 in type3.GetFields())
            {
                Console.WriteLine($"{field3.Name} : {field3.GetValue(orange)} \n");
            }
            orange.Taste();
        }
    }
}