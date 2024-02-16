using PrototypeDP.AbstractClone;

namespace PrototypeDP.EndtityClone
{
    public class Product : ICloneable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Product(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public ICloneable Clone()
        {
            return (ICloneable)MemberwiseClone();
        }

    }
}
