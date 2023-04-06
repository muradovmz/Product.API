namespace Product.API
{
    public class ProductRepository
    {
        public List<Product> Products { get; set; }
        
        public ProductRepository()
        {
            Products = new List<Product>();
            Products.Add(new Product(1,"ragaca1",10));
            Products.Add(new Product(2,"ragaca2",20));
            Products.Add(new Product(3,"ragaca3",30));
        }
    }
}
