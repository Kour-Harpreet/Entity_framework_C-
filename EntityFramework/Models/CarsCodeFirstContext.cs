﻿using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.Models
{
    public partial class CarsCodeFirstContext : DbContext
    {
        public CarsCodeFirstContext()
        {

        }

        public CarsCodeFirstContext(DbContextOptions<CarsCodeFirstContext> options) : base(options)
        {

        }
        // Called when we're configuring a database connection.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // If we aren't already configured.
            if (!optionsBuilder.IsConfigured)
            {
                // Initialize the connection to a MySQL server.
                optionsBuilder
                    .UseMySql("server=localhost;port=3306;user=root;database=code_first_cars",
                        // Retreived from PHPMyAdmin under Home > Database Server > Server Version.
                        x => x.ServerVersion("10.4.14-MariaDB"));

                /*
                    Connection strings are used to define an entire connection profile in one string. They are composed of attributes and values separated by semicolons.
                    
                    server=VALUE - Declares the server address for the connection.
                    port=VALUE - Declares the port for the conenction.
                    user=VALUE - Declares the database username for the connection.
                    password=VALUE - Declares that username's password for the connection (if applicable).
                    database=VALUE - Declares the database name to connect to.
                */

                // server=localhost;port=3306;user=root;database=code_first_cars
            }
        }

        // Called when we're doing database migrations, etc.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Declare advanced column configuration for our model.
            modelBuilder.Entity<CodeFirstCar>(entity =>
            {
                // If you have foreign keys, declare them here as "HasIndex".

                // Declare the string encoding for our text fields.
                entity.Property(e => e.Manufacturer)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                // PLEASE don't try to memorize this. Copy/paste it and change the column name.
                entity.Property(e => e.Model)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.TrimLevel)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Colour)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
                // Seed data is used for testing environments, it's kind of the equivalent of what we did with INSERTing test data using SQL.
                entity.HasData(
                    new CodeFirstCar()
                    {
                        ID = 1,
                        Manufacturer = "Mitsubishi",
                        Model = "Lancer",
                        TrimLevel = "Evolution",
                        Colour = "Black",
                        Odometer = 40000
                    }
                );

                entity.HasData(
                    new CodeFirstCar()
                    {
                        ID = 2,
                        Manufacturer = "Honda",
                        Model = "Civic",
                        TrimLevel = "LX",
                        Colour = "Red",
                        Odometer = 110000
                    },
                    new CodeFirstCar()
                    {
                        ID = 3,
                        Manufacturer = "Dodge",
                        Model = "Stealth",
                        TrimLevel = "R/T TT",
                        Colour = "Blue",
                        Odometer = 98500
                    }
                 );
            });


            // Call the partial method in case we add some stuff to another file later.
            OnModelCreatingPartial(modelBuilder);
        }

        // Not technically needed, but the scaffolding generates it for later use, so we can add it if we want for future-proofing.
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
