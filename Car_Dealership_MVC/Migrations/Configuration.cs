namespace Car_Dealership_MVC.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Car_Dealership_MVC.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Car_Dealership_MVC.DAL.DealershipContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Car_Dealership_MVC.DAL.DealershipContext context)
        {

            //seed for inventory (vehicle table)

            context.inventory.AddOrUpdate( v => v.ID,
                 new Vehicle
               {
                   VIN = "FT1997BLU",
                   make = "Ford",
                   model = "Taurus",
                   color = "Blue",
                   year = 1997,
                   MSRP = 13000,
                   MPG = 26,
                   imagePath = "~/Images/taurusblue.jpg"
                 },
               new Vehicle
               {
                   
                   VIN = "FT1997RED",
                   make = "Ford",
                   model = "Taurus",
                   color = "Red",
                   year = 1997,
                   MSRP = 12450,
                   MPG = 26,
                   imagePath = "~/Images/taurusred.jpg"
               },
               new Vehicle
               {
                   
                   VIN = "FT2005SIL",
                   make = "Ford",
                   model = "Taurus",
                   color = "Silver",
                   year = 2005,
                   MSRP = 22000,
                   MPG = 28,
                   imagePath = "~/Images/taurussil.jpg"
               },
               new Vehicle
               {
                   
                   VIN = "FE2010GRE",
                   make = "Ford",
                   model = "Explorer",
                   color = "Green",
                   year = 2010,
                   MSRP = 32000,
                   MPG = 21,
                   imagePath = "~/Images/explorergre.jpg"
               },
               new Vehicle
               {
                   VIN = "FE2007GRE",
                   make = "Ford",
                   model = "Explorer",
                   color = "Green",
                   year = 2007,
                   MSRP = 26000,
                   MPG = 19,
                   imagePath = "~/Images/explorergre2.jpg"
               },
               new Vehicle
               {
                   VIN = "FE2010Whi",
                   make = "Ford",
                   model = "Explorer",
                   color = "White",
                   year = 2010,
                   MSRP = 35000,
                   MPG = 19,
                   imagePath = "~/Images/explorerwhi.jpg"
               },
               new Vehicle
               {
                   VIN = "CI2008RED",
                   make = "Chevy",
                   model = "Impala",
                   color = "Red",
                   year = 2008,
                   MSRP = 29000,
                   MPG = 24,
                   imagePath = "~/Images/impalared.jpg"
               },
                new Vehicle
               {
                   VIN = "CI2012RED",
                   make = "Chevy",
                   model = "Impala",
                   color = "Red",
                   year = 2012,
                   MSRP = 36000,
                   MPG = 27,
                    imagePath = "~/Images/impalared.jpg"
                },
               new Vehicle
               {
                   VIN = "CI2008BLU",
                   make = "Chevy",
                   model = "Impala",
                   color = "Blue",
                   year = 2008,
                   MSRP = 30000,
                   MPG = 24,
                   imagePath = "~/Images/impalablue.jpg"
               },
               new Vehicle
               {
                   VIN = "CM2013SIL",
                   make = "Chevy",
                   model = "Malibu",
                   color = "Silver",
                   year = 2013,
                   MSRP = 46000,
                   MPG = 29,
                   imagePath = "~/Images/malibusil.jpg"
               },
                new Vehicle
                {
                    VIN = "CM2010SIL",
                    make = "Chevy",
                    model = "Malibu",
                    color = "Silver",
                    year = 2010,
                    MSRP = 38000,
                    MPG = 27,
                    imagePath = "~/Images/malibusil2.jpg"
                },
                new Vehicle
                {
                    VIN = "CM2010GOL",
                    make = "Chevy",
                    model = "Malibu",
                    color = "Gold",
                    year = 2010,
                    MSRP = 39000,
                    MPG = 27,
                    imagePath = "~/Images/malibugol.jpg"
                },
                new Vehicle
                {
                    VIN = "HA2010GRE",
                    make = "Honda",
                    model = "Accord",
                    color = "Green",
                    year = 2010,
                    MSRP = 35000,
                    MPG = 27,
                    imagePath = "~/Images/accordgre.jpg"
                },
               new Vehicle
               {
                   VIN = "HA2010BLA",
                   make = "Honda",
                   model = "Accord",
                   color = "Black",
                   year = 2010,
                   MSRP = 39000,
                   MPG = 27,
                   imagePath = "~/Images/accordbla.jpg"
               },
               new Vehicle
               {
                   VIN = "HA2008BLA",
                   make = "Honda",
                   model = "Accord",
                   color = "Black",
                   year = 2008,
                   MSRP = 35000,
                   MPG = 24,
                   imagePath = "~/Images/accordbla2.jpg"
               },
               new Vehicle
               {
                   VIN = "HO2004BLU",
                   make = "Honda",
                   model = "Odyssey",
                   color = "Blue",
                   year = 2004,
                   MSRP = 21000,
                   MPG = 20,
                   imagePath = "~/Images/odysseyblue.jpg"
               },
               new Vehicle
               {
                   VIN = "HO2003BLU",
                   make = "Honda",
                   model = "Odyssey",
                   color = "Blue",
                   year = 2003,
                   MSRP = 19000,
                   MPG = 18,
                   imagePath = "~/Images/odysseyblue2.jpg"
               },
               new Vehicle
               {
                   VIN = "HO2004SIL",
                   make = "Honda",
                   model = "Odyssey",
                   color = "Silver",
                   year = 2004,
                   MSRP = 23000,
                   MPG = 20,
                   imagePath = "~/Images/odysseysil.jpg"
               },
               new Vehicle
               {
                   VIN = "JL2007BLU",
                   make = "Jeep",
                   model = "Liberty",
                   color = "Blue",
                   year = 2007,
                   MSRP = 28000,
                   MPG = 17,
                   imagePath = "~/Images/libertyblue.jpg"
               },
               new Vehicle
               {
                   VIN = "JL2010BLU",
                   make = "Jeep",
                   model = "Liberty",
                   color = "Blue",
                   year = 2010,
                   MSRP = 37000,
                   MPG = 20,
                   imagePath = "~/Images/libertyblue2.jpg"
               },
               new Vehicle
               {
                   VIN = "JL2007BLA",
                   make = "Jeep",
                   model = "Liberty",
                   color = "Black",
                   year = 2007,
                   MSRP = 30000,
                   MPG = 17,
                   imagePath = "~/Images/libertybla.jpg"
               },
               new Vehicle
               {
                   VIN = "JW2005RED",
                   make = "Jeep",
                   model = "Wrangler",
                   color = "Red",
                   year = 2005,
                   MSRP = 28000,
                   MPG = 17,
                   imagePath = "~/Images/wranglerred.jpg"
               },
               new Vehicle
               {
                   VIN = "JW2008RED",
                   make = "Jeep",
                   model = "Wrangler",
                   color = "Red",
                   year = 2008,
                   MSRP = 35000,
                   MPG = 21,
                   imagePath = "~/Images/wranglerred2.jpg"
               },
               new Vehicle
               {
                   VIN = "JW2007BLA",
                   make = "Jeep",
                   model = "Wrangler",
                   color = "Black",
                   year = 2007,
                   MSRP = 30000,
                   MPG = 17,
                   imagePath = "~/Images/wranglerbla2.jpg"
               }

              
            );
            
            //seed for users (customer table)
            context.users.AddOrUpdate( u => u.UserName,
                new Customer
                {
                    UserName = "ColdShadows",
                    Name = "Travis Kean",
                    Password = "HelloWorld"
                },
                
                 new Customer
                {
                    UserName = "anheshvi100",
                    Name = "Hemalatha Kanagaraju",
                    Password = "HelloWorld"
                },

                 new Customer
                {
                    UserName = "shamseen",
                    Name = "Shamseen Rahman",
                    Password = "HelloWorld"
                },

                 new Customer
                {
                    UserName = "mizg",
                    Name = "Vaneitta Goines",
                    Password = "HelloWorld"
                }
                
                );
        }
    }
}
