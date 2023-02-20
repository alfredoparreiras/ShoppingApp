using AtlasShopping.Models;
using Chevalier.Utility.Commands;
using Chevalier.Utility.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtlasShopping.ViewModels
{
    class StoreListViewModel : ViewModel
    {
        // Properties 
        public ObservableCollection<Product> Products { get; }
        public Product SelectedProduct
        {
            get
            {
                return _selectedProduct;
            }
            set
            {
                _selectedProduct = value; 
                //notify
            }
        }

        public DelegateCommand BuyCommand;


        //Fields
        private Product _selectedProduct;

        // Constructor 
        public StoreListViewModel()
        {
            Products = new ObservableCollection<Product>();

            var mouse = new Product(15.99m, "Good Product", "Mouse");
            var computer = new Product(1599.32m, "Awesome Computer", "Computer");
            var display = new Product(599.12m, "Display", "Monitor");

            Products.Add(mouse);
            Products.Add(computer);
            Products.Add(display);
        }
        
    }
}
