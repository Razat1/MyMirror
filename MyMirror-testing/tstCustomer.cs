﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyMirror_classes;

namespace MyMirror_testing
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(ACustomer);
        }

    }
}
