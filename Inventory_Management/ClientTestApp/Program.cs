using Inventory_Management.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientTestApp
{
    class Program
    {
        static EFProductReporsitory ef = new EFProductReporsitory();
        static void Main(string[] args)
        {
            ef.Create(new Inventory_Management.Product
            {
                Name = "Toy1",
                ExpiryDate = DateTime.Now.AddDays(80),
                ProductionDate = DateTime.Now
            });

            ef.Create(new Inventory_Management.Product
            {
                Name = "Toy2",
                ExpiryDate = DateTime.Now.AddDays(800),
                ProductionDate = DateTime.Now
            });
        }
    }
}
