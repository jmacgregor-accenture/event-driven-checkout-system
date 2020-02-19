using System;
using EventDrivenKata.Library.Core;
using EventDrivenKata.Library.Core.Hardware;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EventDrivenKata.Tests
{
    [TestClass]
    [TestCategory("Integration")]
    public class WorkflowIntegrationTests
    {
        [TestMethod]
        public void ScannedItemUpdatesTotal()
        {
            var scanSystem = new InMemoryScanSystem();
            var workflow = new Workflow(scanSystem);

            scanSystem.SimulateScannedItem("Narsil");
            scanSystem.SimulateScannedItem("Sword");
            
            Assert.AreEqual(504.99m, workflow.Total);
        }
    }

    public class InMemoryScanSystem : IScanSystem
    {
        public event EventHandler<ScannedEventArgs> ItemScannedEvent;
        public event EventHandler<WeighedEventArgs> ItemWeighedEvent;

        public void SimulateScannedItem(string sku)
        {
            ItemScannedEvent.Invoke(this, new ScannedEventArgs(sku));
        }
    }
}