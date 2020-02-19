using EventDrivenKata.Library.Core.Hardware;
using EventDrivenKata.Library.Core.Sku;

namespace EventDrivenKata.Library.Core
{
    public class Workflow
    {
        private IScanSystem _scanSystem;
        public Workflow(IScanSystem scanSystem)
        {
            _scanSystem = scanSystem;
            _scanSystem.ItemScannedEvent += ReadScan;
        }

        public decimal Total { get; private set; }

        public void ReadScan(object sender, ScannedEventArgs args)
        {
            Total += PriceFetcher.SkuToPrice(args.SKU);
        }
    }
}