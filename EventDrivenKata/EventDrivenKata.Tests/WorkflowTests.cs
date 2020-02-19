using System;
using EventDrivenKata.Library.Core;
using EventDrivenKata.Library.Core.Hardware;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace EventDrivenKata.Tests
{
    [TestClass]
    public class WorkflowTests
    {
        [TestMethod]
        public void ReadScanUpdatesTotal()
        {
            var mockScanSystem = new Mock<IScanSystem>();
            var workflow = new Workflow(mockScanSystem.Object);
            
            workflow.ReadScan(null, new ScannedEventArgs("Narsil"));
            
            Assert.AreEqual(499.99m, workflow.Total);
        }
        
        [TestMethod]
        public void ReadScanTwiceUpdatesTotalTwice()
        {
            var mockScanSystem = new Mock<IScanSystem>();
            var workflow = new Workflow(mockScanSystem.Object);
            
            workflow.ReadScan(null, new ScannedEventArgs("Narsil"));
            workflow.ReadScan(null, new ScannedEventArgs("Narsil"));
            
            Assert.AreEqual(999.98m, workflow.Total);
        }
    }
}