namespace AtlasShoppingConsole
{
    public class Cart
    {
        // Properties
        public int OrderId { get; }
        
        
        // Instance Fields
        private static int _nextId = 1;
        private List<Product> _products;

        public Cart()
        {
            OrderId = _nextId++;
            _products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public void DisplayCartProducts()
        {
            int display = 1;
            Console.WriteLine($"\nYour Selection in order ID {OrderId}");
            foreach (var product in _products)
            {
                Console.WriteLine($"{display++} - {product.ToString()}");
            }
        }

        public decimal CartTotalValue()
        {
            decimal totalPrice = 0;
            foreach (var product in _products)
            {
                totalPrice += product.Price;
            }

            return totalPrice;
        }
    }
}
