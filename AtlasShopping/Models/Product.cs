using Chevalier.Utility.ViewModels;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.JavaScript;


namespace AtlasShopping.Models
{
    public class Product : ViewModel
    {
        //Properties
        public int Id { get; }
        public decimal Price { get; private set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        
        //Class Fields
        private static int _nextId = 1;

        public Product(decimal price, string itemName, string category)
        {
            Price = price;
            Id = _nextId++;
            ProductName = itemName;
            Category = category;

        }

        public override string ToString()
        {
            return $"The product {ProductName}\n" +
                   $"Cost {Price}\n" +
                   $"And belong to {Category}\n";
        }
        
        


    }
}
