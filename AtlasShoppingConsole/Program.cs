namespace AtlasShoppingConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var atlasShopping = new Store("Atlas", "Shop Better, Code Better.");
            
            var mouse = new Product(15.99m, "Good Product", "Mouse");
            var computer = new Product(1599.32m, "Awesome Computer", "Computer");
            var display = new Product(599.12m,  "Display","Monitor");

            var sales1 = new Cart();
            sales1.AddProduct(computer);
            sales1.AddProduct(display);
            sales1.DisplayCartProducts();
            Console.WriteLine(sales1.CartTotalValue());

            var sales2 = new Cart();
            sales2.AddProduct(mouse);
            sales2.DisplayCartProducts();
            Console.WriteLine(sales2.CartTotalValue());
        }
    }
}