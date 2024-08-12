namespace ComponentToComponentCommunication.Data
{
    public interface IProductServices
    {
        event Action ProductEvent;
        List<Product> Products { get; set; }
        int ProductCount { get; set; }
        void LoadProduct();
        List<Product> MyCart { get; set; }
        int CartCount {  get; set; }
        void AddToCart(Product product);
    }
}
