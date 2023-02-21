using AtlasShopping.Models;
using AtlasShopping.Repository;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace AtlasShopping
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            ProductRepository repository = new ProductRepository();
            Product test = repository.GetProduct(100);
        }
    }
}
