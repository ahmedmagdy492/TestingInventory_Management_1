using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management
{
    public class Product : IProduct
    {
        public int Id { get ; set ; }
        public string Name { get ; set ; }
        public DateTime ProductionDate { get ; set ; }
        public DateTime ExpiryDate { get ; set ; }        
    }
}
