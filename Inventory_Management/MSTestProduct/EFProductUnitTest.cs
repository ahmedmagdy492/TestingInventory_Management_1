using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestProduct
{
    /// <summary>
    /// Summary description for EFProductUnitTest
    /// </summary>
    [TestClass]
    public class EFProductUnitTest
    {
        private TestContext _context;

        public TestContext TestContext
        {
            get { return _context; }
            set { _context = value; }
        }


        [TestMethod]
        [DataSource("System.Data.SqlClient","data source=.;initial catalog=Inventory_Management.ProductModel;integrated security=True;MultipleActiveResultSets=True", "Products", DataAccessMethod.Sequential)]
        public void TestExpiryDateLargerThanExpiryDate()
        {
            DateTime prodDate = (DateTime)_context.DataRow["ProductionDate"];
            DateTime ExpiryDate = (DateTime)_context.DataRow["ExpiryDate"];

            bool expected = false;
            bool actual = prodDate > ExpiryDate;

            Assert.AreEqual(expected, actual);
        }
    }
}
