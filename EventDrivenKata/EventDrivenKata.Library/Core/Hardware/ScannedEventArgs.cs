namespace EventDrivenKata.Library.Core.Hardware
{
    public class ScannedEventArgs
    {
        public string SKU { get; }

        public ScannedEventArgs(string sku)
        {
            SKU = sku;
        }
    }
}