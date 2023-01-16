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
    /// Логика взаимодействия для RegisterPage.xaml
    /// </summary>
    public partial class RegisterPage : Page
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void BtnRegClick(object sender, RoutedEventArgs e)
        {
            //try
          //  {
                User user = new User();
                user.Login = tbxLogin.Text;
                if (pbxPassword.Password == pbxRePassword.Password)
                {
                    user.Password = pbxPassword.Password;
                    db.connection.User.Add(user);
                    db.connection.SaveChanges();
                    NavigationService.Navigate(new AuthorizPage());
                }
                else
                    MessageBox.Show("Пароли не совпадают");
          //  }
         //   catch (Exception)
          //  {

             //   MessageBox.Show("Пустые поля");
          //  }
            
        }
    }
}
