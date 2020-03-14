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

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            Boolean Found = false;
            Int32 StockNo = 1;
            //assign the data to the property
            Found = AStock.Find(StockNo);
            //test to see that the two values are the same
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestStockNoNofound()   
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            Boolean Found = false;
            bool OK = true;
            Int32 StockNo = 21;
            //assign the data to the property
            Found = AStock.Find(StockNo);
            //test to see that the two values are the same
            if (AStock.StockNo !=21) {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockNo = 21;
            //invoke the method
            Found = AStock.Find(StockNo);
            //check the property
            if (AStock.DateAdded != Convert.ToDateTime("2016/11/11"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSttockDescriptionFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockNo = 21;
            //invoke the method
            Found = AStock.Find(StockNo);
            //check the property
            if (AStock.StockDes != "Test Description")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStockQuantityFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockNo = 21;
            //invoke the method
            Found = AStock.Find(StockNo);
            //check the property
            if (AStock.Quantity != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStockPriceFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockNo = 21;
            //invoke the method
            Found = AStock.Find(StockNo);
            //check the property
            if (AStock.Price != 11)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAvailableFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockNo = 21;
            //invoke the method
            Found = AStock.Find(StockNo);
            //check the property
            if (AStock.Available!= true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }





    }

}

