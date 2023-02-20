using AtlasShopping.Models;
using Chevalier.Utility.Commands;
using Chevalier.Utility.ViewModels;
using System.Collections.ObjectModel;

namespace AtlasShopping.ViewModels
{
    public delegate void ProductEventHandler(Product product);

    class StoreListViewModel : ViewModel
    {
        public event ProductEventHandler SelectedProductChanged;
        
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
                SelectedProductChanged?.Invoke(value);
                NotifyPropertyChanged(nameof(SelectedProduct));
            }
        }

        public DelegateCommand BuyCommand { get; }


        //Fields
        private Product _selectedProduct;
        

        // Constructor 
        public StoreListViewModel()
        {
            Products = new ObservableCollection<Product>();

            var mouse = new Product(15.99m, "Mouse", "Computer Accessories", "Amazing Mouse");
            var computer = new Product(1599.32m, "PC", "Computer Accessories", "Amazing Computer");
            var display = new Product(599.12m, "Monitor 32pol", "Computer Accessories", "Amazing Monitor");

            Products.Add(mouse);
            Products.Add(computer);
            Products.Add(display);
        }
        

    }
}
