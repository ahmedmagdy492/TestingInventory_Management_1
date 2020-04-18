using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management
{
    public interface IProduct
    {
        int Id { get; set; }
        string Name { get; set; }
        DateTime ProductionDate { get; set; }
        DateTime ExpiryDate { get; set; }
    }
}
