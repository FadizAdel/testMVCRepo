namespace MVC_christenZarif.Models
{
    public class ProductBL
    {
        private List<Product> _products;

        public ProductBL()
        {
            _products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Price = 15000, Description = "High-performance laptop", Image = "laptop.jpg" },
            new Product { Id = 2, Name = "Phone", Price = 8000, Description = "Smartphone with good camera", Image = "phone.jpg" },
            new Product { Id = 3, Name = "Headphones", Price = 1200, Description = "Noise cancelling headphones", Image = "headphones.jpg" },
            new Product { Id = 4, Name = "Keyboard", Price = 500, Description = "Mechanical keyboard", Image = "keyboard.jpg" },
            new Product { Id = 5, Name = "Mouse", Price = 300, Description = "Wireless mouse", Image = "mouse.jpg" },
            new Product { Id = 6, Name = "Monitor", Price = 4000, Description = "27 inch Full HD monitor", Image = "monitor.jpg" },
            new Product { Id = 7, Name = "Tablet", Price = 6000, Description = "10 inch Android tablet", Image = "tablet.jpg" },
            new Product { Id = 8, Name = "Smartwatch", Price = 2000, Description = "Fitness tracking smartwatch", Image = "smartwatch.jpg" },
            new Product { Id = 9, Name = "Speaker", Price = 1500, Description = "Bluetooth portable speaker", Image = "speaker.jpg" },
            new Product { Id = 10, Name = "Camera", Price = 7000, Description = "DSLR professional camera", Image = "camera.jpg" }
        };
        }

        public List<Product> GetAllProducts()
        {
            return _products;
        }

        public Product GetDetails(int id)
        {
            return _products.FirstOrDefault(s => s.Id == id);
        }

        public void AddProduct(Product product)
        {
            product.Id = _products.Max(p => p.Id) + 1;
            _products.Add(product);
        }
    }
}
