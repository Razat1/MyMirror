using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_Library;
using MyMirror_testing;

namespace Test_Framework
{
    [TestClass]
    public class tstAddress
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(AnStaff);
        }
    }
}
