using System;
using Inventory_Management;
using Inventory_Management.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace MSTestProduct
{
    [TestClass]
    public class MoqProductUnitTest
    {
        [TestMethod]
        public void CreateProductWithExpiryDateLargerThanProdDate_Product()
        {
            ProductMock productMock = new ProductMock
            {
                Name = "Prodcut2",
                ProductionDate = DateTime.Now,
                ExpiryDate = DateTime.Now.AddDays(12)
            };

            ProductRepository repo = new ProductRepository();
            bool expected = true;
            bool actual = repo.Create(productMock);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CreateProductWithExpiryDateLargerThanProdDate_Product_Moq()
        {
            var mock = new Mock<IProduct>();
            mock.SetupGet(mp => mp.ExpiryDate).Returns(mock.Object.ProductionDate.AddDays(23));

            ProductRepository repo = new ProductRepository();
            bool expected = true;
            bool actual = repo.Create(mock.Object);

            Assert.AreEqual(expected, actual);
        }
    }
}
