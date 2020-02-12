using System;
using EventDrivenKata.Library.Core;
using EventDrivenKata.Library.Core.Hardware;
using EventDrivenKata.Library.Core.Sku;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace EventDrivenKata.Tests
{
    [TestClass]
    public class WorkflowTests
    {
        [TestMethod]
        public void TestingMadnessOfAsyncDoom()
        {
            var mockScanSystem = new Mock<IScanSystem>();
            var workflow = new Workflow(mockScanSystem.Object);

            workflow.Start();
            mockScanSystem.Raise( mss => mss.ItemScannedEvent += null, new object[]
            {
                new ScannedEventArgs("Sauron")
            });
            
            workflow.Stop();

            var expected = 5.0m;
            var actual = workflow.Total;
            
            Assert.AreEqual(expected, actual);
        }
    }
}