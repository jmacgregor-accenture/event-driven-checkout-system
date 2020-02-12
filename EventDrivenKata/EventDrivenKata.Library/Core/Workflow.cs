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
        }

        public decimal Total { get; private set; }

        public void Start()
        {
            _scanSystem.ItemScannedEvent += ReadScan;
        }

        public void Stop()
        {
            
        }

        private void ReadScan(object sender, ScannedEventArgs args)
        {
            Total = PriceFetcher.SkuToPrice(args.SKU);
        }
    }
}