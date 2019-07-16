using System;
using Healthcare.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Healthcare.BL.Test
{
    [TestClass]
    public class ProductRepositioryTest
    {
        [TestMethod]
        public void ProductRepositoryTest()
        {
            var exptected = new Product();
            exptected.ProductName = "Mobile";
            exptected.CurrentPrice = 200;

            var repo = new ProductRepositiory();
            var actual = repo.Retrieve(2);

             
            Assert.AreEqual(exptected.ProductName, actual.ProductName);
            Assert.AreEqual(exptected.CurrentPrice, actual.CurrentPrice);
         


        }
    }
}
