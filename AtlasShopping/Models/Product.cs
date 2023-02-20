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
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        
        //Class Fields
        private static int _nextId = 1;

        public Product(decimal price, string itemName, string category, string description)
        {
            Price = price;
            Id = _nextId++;
            Name = itemName;
            Category = category;
            Description = description;

        }

        public override string ToString()
        {
            return $"The product {Name}\n" +
                   $"Cost {Price}\n" +
                   $"And belong to {Category}\n";
        }
    }
}
