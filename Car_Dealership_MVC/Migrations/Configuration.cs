namespace Car_Dealership_MVC.Migrations
{
    using Car_Dealership_MVC.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Car_Dealership_MVC.DAL.DealershipContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Car_Dealership_MVC.DAL.DealershipContext";
        }

        protected override void Seed(Car_Dealership_MVC.DAL.DealershipContext context)
        {
            context.inventory.AddOrUpdate(i => i.VIN,

               new Vehicle
               {

                   VIN = "FT1997BLU",
                   make = "Ford",
                   model = "Taurus",
                   color = "Blue",
                   year = 1997,
                   MSRP = 13000,
                   MPG = 26
               },
               new Vehicle
               {

                   VIN = "FT1997RED",
                   make = "Ford",
                   model = "Taurus",
                   color = "Red",
                   year = 1997,
                   MSRP = 12450,
                   MPG = 26
               },
               new Vehicle
               {

                   VIN = "FT2005SIL",
                   make = "Ford",
                   model = "Taurus",
                   color = "Silver",
                   year = 2005,
                   MSRP = 22000,
                   MPG = 28
               },
               new Vehicle
               {

                   VIN = "FE2010GRE",
                   make = "Ford",
                   model = "Explorer",
                   color = "Green",
                   year = 2010,
                   MSRP = 32000,
                   MPG = 21
               },
               new Vehicle
               {
                   VIN = "FE2007GRE",
                   make = "Ford",
                   model = "Explorer",
                   color = "Green",
                   year = 2007,
                   MSRP = 26000,
                   MPG = 19
               },
               new Vehicle
               {
                   VIN = "FE2010Whi",
                   make = "Ford",
                   model = "Explorer",
                   color = "White",
                   year = 2010,
                   MSRP = 35000,
                   MPG = 19
               },
               new Vehicle
               {
                   VIN = "CI2008RED",
                   make = "Chevy",
                   model = "Impala",
                   color = "Red",
                   year = 2008,
                   MSRP = 29000,
                   MPG = 24
               },
                new Vehicle
                {
                    VIN = "CI2012RED",
                    make = "Chevy",
                    model = "Impala",
                    color = "Red",
                    year = 2012,
                    MSRP = 36000,
                    MPG = 27
                },
               new Vehicle
               {
                   VIN = "CI2008BLU",
                   make = "Chevy",
                   model = "Impala",
                   color = "Blue",
                   year = 2008,
                   MSRP = 30000,
                   MPG = 24
               },
               new Vehicle
               {
                   VIN = "CM2013SIL",
                   make = "Chevy",
                   model = "Malibu",
                   color = "Silver",
                   year = 2013,
                   MSRP = 46000,
                   MPG = 29
               },
                new Vehicle
                {
                    VIN = "CM2010SIL",
                    make = "Chevy",
                    model = "Malibu",
                    color = "Silver",
                    year = 2010,
                    MSRP = 38000,
                    MPG = 27
                },
                new Vehicle
                {
                    VIN = "CM2010GOL",
                    make = "Chevy",
                    model = "Malibu",
                    color = "Gold",
                    year = 2010,
                    MSRP = 39000,
                    MPG = 27
                },
                new Vehicle
                {
                    VIN = "HA2010GRE",
                    make = "Honda",
                    model = "Accord",
                    color = "Green",
                    year = 2010,
                    MSRP = 35000,
                    MPG = 27
                },
               new Vehicle
               {
                   VIN = "HA2010BLA",
                   make = "Honda",
                   model = "Accord",
                   color = "Black",
                   year = 2010,
                   MSRP = 39000,
                   MPG = 27
               },
               new Vehicle
               {
                   VIN = "HA2008BLA",
                   make = "Honda",
                   model = "Accord",
                   color = "Black",
                   year = 2008,
                   MSRP = 35000,
                   MPG = 24
               },
               new Vehicle
               {
                   VIN = "HO2004BLU",
                   make = "Honda",
                   model = "Odyssey",
                   color = "Blue",
                   year = 2004,
                   MSRP = 21000,
                   MPG = 20
               },
               new Vehicle
               {
                   VIN = "HO2003BLU",
                   make = "Honda",
                   model = "Odyssey",
                   color = "Blue",
                   year = 2003,
                   MSRP = 19000,
                   MPG = 18
               },
               new Vehicle
               {
                   VIN = "HO2004SIL",
                   make = "Honda",
                   model = "Odyssey",
                   color = "Silver",
                   year = 2004,
                   MSRP = 23000,
                   MPG = 20
               },
               new Vehicle
               {
                   VIN = "JL2007BLU",
                   make = "Jeep",
                   model = "Liberty",
                   color = "Blue",
                   year = 2007,
                   MSRP = 28000,
                   MPG = 17
               },
               new Vehicle
               {
                   VIN = "JL2010BLU",
                   make = "Jeep",
                   model = "Liberty",
                   color = "Blue",
                   year = 2010,
                   MSRP = 37000,
                   MPG = 20
               },
               new Vehicle
               {
                   VIN = "JL2007BLA",
                   make = "Jeep",
                   model = "Liberty",
                   color = "Black",
                   year = 2007,
                   MSRP = 30000,
                   MPG = 17
               },
               new Vehicle
               {
                   VIN = "JW2005RED",
                   make = "Jeep",
                   model = "Wrangler",
                   color = "Red",
                   year = 2005,
                   MSRP = 28000,
                   MPG = 17
               },
               new Vehicle
               {
                   VIN = "JW2008RED",
                   make = "Jeep",
                   model = "Wrangler",
                   color = "Red",
                   year = 2008,
                   MSRP = 35000,
                   MPG = 21
               },
               new Vehicle
               {
                   VIN = "JW2007BLA",
                   make = "Jeep",
                   model = "Wrangler",
                   color = "Black",
                   year = 2007,
                   MSRP = 30000,
                   MPG = 17
               }



                );
        }
    }

}
