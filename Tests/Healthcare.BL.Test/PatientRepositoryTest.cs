using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Healthcare.BL.Test
{
    [TestClass]
    public class PatientRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {

            //Arrange
            var patienRepository = new PatientRepository();

            var expected = new Patient(101);
            expected.EmailAddress = "john@email.com";
            expected.Firstname = "John";
            expected.Lastname = "Doe";

            var actual = patienRepository.Retrieve(101);

            Assert.AreEqual(expected.PatientId, actual.PatientId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.Firstname, actual.Firstname);
            Assert.AreEqual(expected.Lastname, actual.Lastname);

        }


        [TestMethod]
        public void RetrieveExestingWithAddress()
        {

            //Arrange
            var patienRepository = new PatientRepository();

            var expected = new Patient(101);
            expected.EmailAddress = "john@email.com";
            expected.Firstname = "John";
            expected.Lastname = "Doe";
            expected.PatientAddressList = new System.Collections.Generic.List<Address>()
            {

                new Address()
                  {
             AddressType = 1,
            StreeLine1 = "Bag End",
            StreeLine2 = "2301 cam stree",
            City = "Cwp",
            Country = "US"


        },
            new Address()
            {
                AddressType = 2,
                StreeLine1 = "Bag End2",
                StreeLine2 = "2301 cam2 stree",
                City = "Cwp2",
                Country = "US"
            }
            };
            

            

 
            var actual = patienRepository.Retrieve(101);

            Assert.AreEqual(expected.PatientId, actual.PatientId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.Firstname, actual.Firstname);
            Assert.AreEqual(expected.Lastname, actual.Lastname);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expected.PatientAddressList[i].AddressType, actual.PatientAddressList[i].AddressType);
                Assert.AreEqual(expected.PatientAddressList[i].StreeLine1, actual.PatientAddressList[i].StreeLine1);
                Assert.AreEqual(expected.PatientAddressList[i].StreeLine2, actual.PatientAddressList[i].StreeLine2);
                Assert.AreEqual(expected.PatientAddressList[i].City, actual.PatientAddressList[i].City);
                Assert.AreEqual(expected.PatientAddressList[i].Country, actual.PatientAddressList[i].Country);

            }


        }



    }
}
