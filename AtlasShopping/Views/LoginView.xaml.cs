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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AtlasShopping.Views
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public delegate void ResetPasswordHandler(Object sender);
    public partial class LoginView : UserControl
    {
        public event ResetPasswordHandler ResetPasswordRequested;
        public LoginView()
        {
            InitializeComponent();
        }
        private void OnResetButtomClick(Object sender,RoutedEventArgs e)
        {
            ResetPasswordRequested?.Invoke(sender);
        }


    }
}
