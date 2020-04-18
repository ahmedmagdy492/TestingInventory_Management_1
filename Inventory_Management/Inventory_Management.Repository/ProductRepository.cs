using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management.Repository
{
    public class ProductRepository
    {
        private List<IProduct> Products = new List<IProduct>();
        public ProductRepository()
        {
            for(int i = 1; i <= 5; i++)
            {
                Products.Add(new Product
                {
                    Id = i,
                    Name = "Toy1",
                    ExpiryDate = DateTime.Now.AddDays(20 + i),
                    ProductionDate = DateTime.Now.AddMonths(i)
                });
            }
        }
        public IEnumerable<IProduct> List()
        {
            return Products;
        }

        public void Create(IProduct product)
        {
            Products.Add(product);
        }

        public void Remove(int id)
        {
            var prod = Products.Find(p => p.Id == id);
            if(prod != null)
            {
                Products.Remove(prod);
            }
            else
            {
                throw new NullReferenceException();
            }
        }
    }
}
