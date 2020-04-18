using System;
using Inventory_Management;
using Inventory_Management.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestProduct
{
    [TestClass]
    public class MsTestProduct
    {
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void CreateProduct_Product_NullExecption()
        {
            // arrangement
            Product product = null;

            // act
            ProductRepository prod = new ProductRepository();
            prod.Create(product);
        }

        [TestMethod]
        public void CreateProduct_Product()
        {
            // arrangement
            var product = new Product
            {
                Id = 6,
                Name = "Toy4",
                ExpiryDate = DateTime.Now,
                ProductionDate = DateTime.Now.AddDays(5)
            };

            // act
            ProductRepository repo = new ProductRepository();
            bool actual = repo.Create(product);
            bool expected = false;

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
