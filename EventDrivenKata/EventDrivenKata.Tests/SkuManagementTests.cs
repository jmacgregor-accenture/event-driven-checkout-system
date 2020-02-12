using System;
using EventDrivenKata.Library.Core.Sku;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EventDrivenKata.Tests
{
    [TestClass]
    public class SkuManagementTests
    {
        [TestMethod]
        public void SkuReturnsPrice()
        {
            Decimal expected = 5.0m;

            var actual = PriceFetcher.SkuToPrice("Frodo");
            
            Assert.AreEqual(expected, actual);
        }
    }
}