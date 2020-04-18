using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management.Repository
{
    public class EFProductReporsitory
    {
        private ProductModel db;

        public EFProductReporsitory()
        {
            db = new ProductModel();
        }

        public IEnumerable<Product> List()
        {
            return db.Products.ToList();
        }

        public void Create(Product product)
        {
            if(product != null)
            {
                db.Products.Add(product);
                db.SaveChanges();
            }
            else
            {
                throw new NullReferenceException();
            }
        }
    }
}
