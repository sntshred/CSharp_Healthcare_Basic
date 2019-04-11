using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentBasics.BL;

namespace Healthcare.BL.Test
{
    [TestClass]
    public class Patient_test
    {
        [TestMethod]
        public void Patient_Fullname_Test()
        {
            var patient = new Patient();
           
            patient.Firstname = "John";
            patient.Lastname = "Smith";

            var exptected = "Smith, John";

            var actual = patient.Fullname;

            Assert.AreEqual(exptected, actual);

        }

        [TestMethod]
        public void Patient_FirstName_Test()
        {
            var patient = new Patient();

            patient.Firstname = "John";
            

            var exptected = "John";

            var actual = patient.Fullname;

            Assert.AreEqual(exptected, actual);

        }

        [TestMethod]
        public void Patient_LastNameTest()
        {
            var patient = new Patient();

         
            patient.Lastname = "Smith";

            var exptected = "Smith";

            var actual = patient.Fullname;

            Assert.AreEqual(exptected, actual);

        }

        [TestMethod]
        public void Patient_Total_Visit_Count_Test()
        {
            var patient = new Patient();
            patient.Firstname= "Smith";
            Patient.Patient_Visit_Count += 1;


            var patient_2 = new Patient();
            patient_2.Firstname = "Jone";
            Patient.Patient_Visit_Count += 1;


            var patient_3 = new Patient();
            patient_3.Firstname = "Dojo";
            Patient.Patient_Visit_Count += 1;


            Assert.AreEqual(3, Patient.Patient_Visit_Count);

        }
    }
}
