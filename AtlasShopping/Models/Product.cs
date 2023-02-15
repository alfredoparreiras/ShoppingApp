using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.JavaScript;


namespace AtlasShoppingConsole
{
    public class Product
    {
        //Properties
        public int Id { get; }
        public decimal Price { get; private set; }
        public string ItemName { get; set; }
        public string Category { get; set; }
        
        //Class Fields
        private static int _nextId = 1;

        public Product(decimal price, string itemName, string category)
        {
            Price = price;
            Id = _nextId++;
            ItemName = itemName;
            Category = category;

        }

        public override string ToString()
        {
            return $"The product {ItemName}\n" +
                   $"Cost {Price}\n" +
                   $"And belong to {Category}\n";
        }
        
        


    }
}
