using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management
{
    public interface IProduct
    {
        [Key]
        int Id { get; set; }
        [DisplayName("Product Name")]
        string Name { get; set; }
        DateTime ProductionDate { get; set; }
        DateTime ExpiryDate { get; set; }
    }
}
