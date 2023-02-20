using AtlasShopping.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Diagnostics;
using AtlasShopping.Models;

namespace AtlasShopping.Views
{
    /// <summary>
    /// Interaction logic for Store.xaml
    /// </summary>
    public partial class StoreView : Window
    {
        public StoreView()
        {
            InitializeComponent();
            StoreListViewModel storeViewModel = new StoreListViewModel();
            storeViewModel.SelectedProductChanged += OnSelectedProductChanged;
            DataContext = storeViewModel;
        }

        private void OnSelectedProductChanged(Product product)
        {
            // TODO If else
            productViewPanel.Visibility = Visibility.Visible;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void btn_Minimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btn_Close_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
