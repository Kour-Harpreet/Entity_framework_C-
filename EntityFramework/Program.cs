using EntityFramework.Models;
using System;
using System.Linq;

namespace EntityFramework
{
   
    class Program
    {
        static void Main(string[] args)
        {
            /*
               Location
                   -Name
                   -Address
                   -PostalCode
                   -City
               Employee
                   -FirstName
                   -LastName
                   -BirthDate
                   -HireDate
                   -EndDate
           */

            string name;
            string location;

            Console.Write("Please enter a Full Name: ");
            name = Console.ReadLine().Trim().ToUpper();
            try
            {
                using (EmployeeContext context = new EmployeeContext())
                {
                    string firstName = name.Split(' ')[0];
                    string lastName = name.Split(' ')[1];
                    // Single will throw an Exception if there is not only one item in a collection.
                    // SingleOrDefault will return null if there is not only one.
                    Employee target = context.Employees.Where(x => x.FirstName == firstName && x.LastName == lastName).Single();

                    
                        // Until we convert to a list, we are operating on a DbSet collection.
                        // DbSets require all operations performed thereon to have a direct translation to SQL.
                        // Since Contains() does not (it should translate to IN but I digress), we have to pull the full table and evaluate on our server instead of the database.
                        // Converting the DbSet to a List will force evaluation of the DbSet as-is, we can then query the list as if they were normal objects.
                        Location work = context.Locations.ToList().Where(x => x.Employees.Contains(target)).Single();

                    location = $"{work.Name} - {work.Address} {work.PostalCode}, {work.City}";
                    Console.WriteLine($"That person works at {location}.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Encountered Exception: " + e.Message);
            }
        }
    }
}