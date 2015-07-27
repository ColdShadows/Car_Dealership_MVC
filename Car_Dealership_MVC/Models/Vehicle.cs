using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Dealership_MVC.Models
{
    public class Vehicle
    {
        [Key] //this will make VIN the unique identifier for each car
        public string VIN { get; set; }
        
        public string make { get; set; }
        public string model { get; set; }
        public string color { get; set; }
        public int year { get; set; }
        public double MSRP { get; set; }
        public double MPG { get; set; }
        
    }

    public class VehicleDBContext : DbContext
    {
       public DbSet<Vehicle> inventory { get; set; }
    }
}
