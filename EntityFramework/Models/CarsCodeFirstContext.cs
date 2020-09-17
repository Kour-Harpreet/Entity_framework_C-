using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.Models
{
    class CarsCodeFirstContext : DbContext
    {
        public CarsCodeFirstContext()
        {

        }

        public CarsCodeFirstContext(DbContextOptions<CarsCodeFirstContext> options) : base(options)
        {

        }
    
    }
}
