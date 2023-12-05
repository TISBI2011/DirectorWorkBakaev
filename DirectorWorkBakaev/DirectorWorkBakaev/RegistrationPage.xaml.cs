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
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }
        private void RegistrationButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Аккаунт зарегистрирован!");
            RegistrationButton.Navigate(new AuthorizationPage());
        }

        private void LogBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox lb = (TextBox)sender;
            lb.Text = string.Empty;
            lb.GotFocus -= LogBox_GotFocus;
        }

        private void AgeBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox ab = (TextBox)sender;
            ab.Text = string.Empty;
            ab.GotFocus -= AgeBox_GotFocus;
        }

        private void PassBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox pb = (TextBox)sender;
            pb.Text = string.Empty;
            pb.GotFocus -= PassBox_GotFocus;
        }

        private void MailBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox mb = (TextBox)sender;
            mb.Text = string.Empty;
            mb.GotFocus -= MailBox_GotFocus;
        }
        private void AvaBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox mb = (TextBox)sender;
            mb.Text = string.Empty;
            mb.GotFocus -= AvaBox_GotFocus;
        }
    }
}
