using System.Collections.Generic;

namespace EventDrivenKata.Library.Core.Sku
{
    public class PriceFetcher
    {
        private static Dictionary<string, decimal> Prices = new Dictionary<string, decimal>
        {
            { "Frodo", 5.0m},
            { "Sauron", 499.99m}
        };

        public static decimal SkuToPrice(string sku)
        {
            return Prices[sku];
        }
    }
}