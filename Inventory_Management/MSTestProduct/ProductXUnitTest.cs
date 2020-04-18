using Inventory_Management;
using Inventory_Management.Repository;
using System;
using Xunit;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestProduct
{    
    public class ProductXUnitTest
    {
        [Fact]
        public void CreateProduct_Product()
        {
            ProductRepository pr = new ProductRepository();
            bool expected = true;
            bool actual = pr.Create(new Product
            {
                Id = 7,
                Name = "Product1",
                ExpiryDate = DateTime.Now.AddDays(23),
                ProductionDate = DateTime.Now
            });

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CreateProduct_NullProduct()
        {
            Product product = null;

            ProductRepository pr = new ProductRepository();

            Assert.Throws<NullReferenceException>(() => pr.Create(product));
        }
    }
}
