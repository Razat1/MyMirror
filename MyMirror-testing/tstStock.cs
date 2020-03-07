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
    }
}
