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

            Products.Add(new Product(100, 199.20m, "Mechanical Keyboard", "xpto", "Amazing Keyboard", "Computer Accessories"));
  
        }
        

    }
}
