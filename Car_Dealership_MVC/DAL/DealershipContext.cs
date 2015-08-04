using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Car_Dealership_MVC.Models;

namespace Car_Dealership_MVC.DAL
{
    public class DealershipContext : DbContext
    {
        public DbSet<Customer> users { get; set; }
        public DbSet<Vehicle> inventory { get; set; }
    }
}
