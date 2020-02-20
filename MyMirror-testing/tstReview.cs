using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyMirror_testing
{
    [TestClass]
    public class tstReview
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsReview AReview = new clsReview();
            Assert.IsNotNull(AReview);
        }
    }
}
