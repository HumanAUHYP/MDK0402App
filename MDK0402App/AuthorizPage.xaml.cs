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
using MDK0402App.DB;

namespace MDK0402App
{
    /// <summary>
    /// Логика взаимодействия для AuthorizPage.xaml
    /// </summary>
    public partial class AuthorizPage : Page
    {
        
        public AuthorizPage()
        {
            InitializeComponent();
        }

        private void BtnEnterClick(object sender, RoutedEventArgs e)
        {
            try
            {
                var user = db.connection.User.Where(a => a.Login == tbxLogin.Text && a.Password == pbxPassword.Password);
                if (user.Count() != 0)
                {
                    NavigationService.Navigate(new MainPage());
                }
                else
                    MessageBox.Show("Неверный логин или пароль");
            }
            catch (Exception)
            {
                MessageBox.Show("Пустые поля");
            }
        }

        private void BtnRegClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegisterPage());
        }
    }
}
