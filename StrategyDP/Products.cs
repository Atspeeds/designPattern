using System.Collections.Generic;

namespace StrategyDP
{
    public class Products
    {
        private static List<string> Product = new List<string>()
        {
            new string("Product1"),
            new string ("Product2"),
            new string ("Product3"),
            new string ("Product4"),
            new string ("Product5"),
            new string ("Product6"),
            new string ("Product7"),
            new string ("Product8"),
        };

        public static List<string> GetProduct()
        {
            return Product;
        }

    }
}
