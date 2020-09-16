using EntityFramework.Models;
using System;
using System.Linq;

namespace EntityFramework
{
    // Step 1: Install dotnet-ef if it isn't:
    // dotnet tool install --global dotnet-ef

    // Step 2: Install the packages in the project:
    // dotnet add package Microsoft.EntityFrameworkCore.Design
    // dotnet add package Pomelo.EntityFrameworkCore.MySql

    // Step 3: Create the models and context:
    // dotnet ef dbcontext scaffold "server=localhost;port=3306;user=root;password=;database=DB_NAME" Pomelo.EntityFrameworkCore.MySql -c CONTEXT_NAME -o Models -f -d

    // Step 4: Pluralize the property names in the context file.

    // Step 5: Pluralize the virtual ICollections in the table classes (and their InverseProperty's).

    // Step 6 (optional): Rename any instances of "Id" to "ID".
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize our database interaction (the context):
            using (CarsContext context = new CarsContext())
            {
                string model, colour;
                Console.Write("Please enter a model to change the colour: ");
                model = Console.ReadLine();
                Console.Write("Please enter the new colour: ");
                colour = Console.ReadLine();
                context.Cars.Where(x => x.Model == model).SingleOrDefault().Colour = colour;

                context.SaveChanges();
            }
        }
    }
}
