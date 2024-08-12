
namespace ComponentToComponentCommunication.Data
{
    public class ProductService : IProductServices
    {
        public List<Product> Products { get; set; } = new();
        public int ProductCount { get; set ; }
        public List<Product> MyCart { get; set; } = new();
        public int CartCount { get; set; }

        public event Action? ProductEvent;   

        void IProductServices.LoadProduct()
        {
            Products = new()
            {
                new Product(){Name = "Phone"},
                new Product(){Name = "Labtop"},
                new Product(){Name = "Bag"},
                new Product(){Name = "Computer"},
                new Product(){Name = "Wireless"},
                new Product(){Name = "pen"},
                new Product(){Name = "pencil"},
                new Product(){Name = "Car"},
                new Product(){Name = "money"},
                new Product(){Name = "door"},
                new Product(){Name = "anything"},
            };
            ProductCount = Products.Count();
            ProductEvent?.Invoke();
        }

        public void AddToCart(Product product)
        {
            MyCart.Add(product);
            CartCount = MyCart.Count;
            ProductEvent?.Invoke();
        }
    }
}
