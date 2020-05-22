using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the chicken name and age, type 1 to exit the program");

            var cmdArgs = Console.ReadLine().Split();
            Chicken chicken = new Chicken(cmdArgs[0], int.Parse(cmdArgs[1]));
            Console.WriteLine($"Chicekn {chicken.Name} age of {chicken.Age} can produce {chicken.ProductPerDay}.");

            Console.ReadLine();
        }
    }
}
