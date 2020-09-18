using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using EntityFramework.Models;

namespace EntityFramework.Controllers
{
    public class EmployeeController
    {
        public Employee GetEmployee(string firstName, string lastName)
        {
            // Declare Output
            Employee toReturn = null;

            // Obtain Output
            try
            {
                using (EmployeeContext context = new EmployeeContext())
                {
                    // Single will throw an Exception if there is not only one item in a collection.
                    // SingleOrDefault will return null if there is not only one.
                    toReturn = context.Employees.Where(x => x.FirstName == firstName && x.LastName == lastName).Single();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Employee Control Exception: " + e.Message);
            }

            // Return Output
            return toReturn;
        }
    }
}