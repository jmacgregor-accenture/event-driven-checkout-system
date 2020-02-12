using System;
using EventDrivenKata.Library.Core.Sku;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EventDrivenKata.Tests
{
    [TestClass]
    public class SkuManagementTests
    {
        [DataTestMethod]
        [DataRow("Frodo", 5.0)]
        [DataRow("Sauron", 499.99)]
        public void SkuReturnsPrice(string sku, double expected)
        {
            var actual = PriceFetcher.SkuToPrice(sku);
            
            Assert.AreEqual((decimal)expected, actual);
        }
    }
}