using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Car_Dealership_MVC.Models
{
    public class Customer
    {
        [Key] //this will make UserName the unique identifier for each customer
        public string UserName { get; set; }

        public string password { get; set; }

        public string Name { get; set; }    

        public int carID  { get; set; }
    }
}
