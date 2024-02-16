using PrototypeDP.AbstractClone;

namespace PrototypeDP.EndtityClone
{
    public class ProductItem : ICloneable
    {
        public int UnitPrice { get; set; }
        public int QuntityInInverntoty { get; set; }
        public string Color { get; set; }
        //وقتی رفرنس به کلاس دیگه داره باید کپی عمیق بگیریم تا رفرنس به صورت اشتراکی مصرف نشه
        public Product Product { get; set; }

        public ProductItem(int unitPrice, int quntityInInverntoty, string color, Product product)
        {
            UnitPrice = unitPrice;
            QuntityInInverntoty = quntityInInverntoty;
            Color = color;
            Product = product;
        }

        public ICloneable Clone()
        {
            var resualt = (ProductItem)MemberwiseClone();
            resualt.Product = (Product)resualt.Product.Clone();

            return resualt;
        }
    }
}
