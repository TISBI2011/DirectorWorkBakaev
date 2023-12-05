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

namespace DirectorWorkBakaev
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        public AuthorizationPage()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            AuthorizationFrame.Navigate(new RegistrationPage());
            LogoLable.Visibility = Visibility.Hidden;
        }
        private void AuthorizationButton_Click(object sender, RoutedEventArgs e)
        {
            AuthorizationFrame.Navigate(new ListPage());
            LogoLable.Visibility = Visibility.Hidden;
        }
    }
}