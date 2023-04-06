namespace Product.API
{
    public class Product
    {
        public Product(int id, string name, double price, double price2)
        {
            Id = id;
            Name = name;
            Price = price;
            Price2 = price2;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double Price2 { get; set; }
    }
}
