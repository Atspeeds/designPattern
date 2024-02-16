using System;
using PrototypeDP.EndtityClone;

namespace PrototypeDP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var product1 = new Product(1, "Phone", "This is Phone");

            var productClone = (Product)product1.Clone();
            productClone.Id = 2;

            Console.WriteLine($"ID:{product1.Id} NAME:{product1.Name} Description:{product1.Description} \t \t");

            Console.WriteLine($"ID:{productClone.Id} NAME:{productClone.Name} Description:{productClone.Description}");

            //========================================================================================================
            var productItem = new ProductItem(120000,12,"red",product1);

            var productItemClone= (ProductItem)productItem.Clone();
            productItemClone.Product.Name = "Amir";

            Console.WriteLine($"ID:{productItem.Product.Name} NAME:{productItem.Color} Description:{productItem.UnitPrice} \t \t");

            Console.WriteLine($"ID:{productItemClone.Product.Name} NAME:{productItemClone.Color} Description:{productItemClone.UnitPrice}");


        }
    }
}
