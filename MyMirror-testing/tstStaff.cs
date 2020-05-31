using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Class_Library;
using MyMirror_testing;

namespace Test_Framework
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(AnStaff);
        }

        [TestMethod]
        public void isAdminPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnStaff.isAdmin = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.isAdmin, TestData);
        }


        [TestMethod]
        public void StartdatePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnStaff.Startdate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.Startdate, TestData);
        }


        [TestMethod]
        public void EmployeeIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnStaff.EmployeeId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.EmployeeId, TestData);
        }


        [TestMethod]
        public void AgePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnStaff.Age = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.Age, TestData);
        }


        [TestMethod]
        public void NamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Jen";
            //assign the data to the property
            AnStaff.Name = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.Name, TestData);
        }




    }
}


