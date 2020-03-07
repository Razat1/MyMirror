using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyMirror_classes;

namespace MyMirror_testing
{
    [TestClass]
    public class tstStock
    {
        
        
        
            [TestMethod]
            public void InstanceOK()
            {
                clsStock AStock = new clsStock();
                Assert.IsNotNull(AStock);
            }
        
        [TestMethod]
        public void StockNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AStock.StockNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.StockNo, TestData);
        }

        [TestMethod]
        public void StockDescriptionPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            string TestData = "Something for stock";
            //assign the data to the property
            AStock.StockDes= TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.StockDes, TestData);
        }

        [TestMethod]
        public void QuantityPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AStock.Quantity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.Quantity, TestData);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
           AStock.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.DateAdded, TestData);
        }

        [TestMethod]
        public void PricePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AStock.Price = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.Price, TestData);
        }


        [TestMethod]
        public void AvailablePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AStock.Available = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.Available, TestData);
        }



    }

}

