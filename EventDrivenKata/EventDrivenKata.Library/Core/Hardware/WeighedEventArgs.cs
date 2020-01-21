namespace EventDrivenKata.Library.Core.Hardware
{
    public class WeighedEventArgs : ScannedEventArgs
    {
        public double Weight { get; }

        public WeighedEventArgs(string sku, double weight) : base(sku)
        {
            Weight = weight;
        }
    }
}