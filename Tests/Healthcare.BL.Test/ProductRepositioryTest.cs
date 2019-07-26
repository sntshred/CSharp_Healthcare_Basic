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

        [TestMethod]
        public void SaveTestValid()
        {
            var prodcutRepository = new ProductRepositiory();
            var updateProduct = new Product(2)
            {
                CurrentPrice = 18M,
                ProductName = "Mobile",
                HasChanges = true

            };

            var acutal = prodcutRepository.Save(updateProduct);
            Assert.AreEqual(true, acutal);
             

        }

        [TestMethod]
        public void SaveTestInValid()
        {
            var prodcutRepository = new ProductRepositiory();
            var updateProduct = new Product(2)
            {
                CurrentPrice = null,
                ProductName = "Mobile",
                HasChanges = true

            };

            var acutal = prodcutRepository.Save(updateProduct);
            Assert.AreEqual(true, acutal);


        }



    }
}
