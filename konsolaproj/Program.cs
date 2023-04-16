using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konsolaproj
{
    internal class Program
    {
        public static void Unique()
        {
            var numbers = new List<int>();
            while (true)
            {
                Console.Write("Enter a number (or 'Quit' to exit): ");
                var number = Console.ReadLine();

                if (number.ToLower() == "quit") 
                {
                    Console.WriteLine("Unique numbers are: ");
                    break;
                }
                numbers.Add(Convert.ToInt32((number)));
            }
            var unique = new List<int>();
            foreach (int number in numbers)
            {
                if (!unique.Contains(number))
                    unique.Add(number);
                unique.Sort();

            }
            foreach (int number in unique)
            {

                Console.WriteLine(number);
            }

        }
        static void Main(string[] args)
        {
            Unique();
        }
    }
}
