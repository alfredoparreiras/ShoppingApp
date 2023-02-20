using AtlasShopping;
using Chevalier.Utility.ViewModels;
using System.Collections.Generic;

namespace AtlasShopping.Models
{
    public class Store : ViewModel
    {

        public string StoreName { get; private set; }
        public string StoreSlogan { get; private set; }
        private Dictionary<int, Cart> _sales;
        private List<Product> _products;

        public Store(string storeName, string storeSlogan)
        {
            StoreName = storeName;
            StoreSlogan = storeSlogan;
            _sales = new Dictionary<int, Cart>();
            _products = new List<Product>();
        }
    }
}
