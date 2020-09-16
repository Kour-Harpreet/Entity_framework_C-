using EntityFramework.Models;
using System;
using System.Linq;

namespace EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize our database interaction (the context):
            using (CarsContext context = new CarsContext())
            {
                Console.WriteLine(context.Cars.Count(x => x.Manufacturer.Name == "BMW"));

                Console.WriteLine(context.Cars.Count(x => x.Manufacturer.Name == "Mitsubishi"));
            }
        }
    }
}
