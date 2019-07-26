using System;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HealthCare.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpace()
        {
            var source = "JohnSmith";
            var expected = "John Smith";
            

            var actual = source.InsertSpaces();

            Assert.AreEqual(expected, actual);



        }

        [TestMethod]
        public void InsertSpacesWithExistingSpace()
        {
            var source = "John Smith";
            var expected = "John Smith";
            

            var actual = source.InsertSpaces();

            Assert.AreEqual(expected, actual);



        }
    }
}
