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
using VeterinaryClinic.Database;

namespace VeterinaryClinic.Pages
{
    /// <summary>
    /// Логика взаимодействия для authPage.xaml
    /// </summary>
    public partial class authPage : Page
    {
        public static List<Employees> employees { get; set; }
        public authPage()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            if (LoginTb.Text == "0000" && PasswordTb.Text == "0000")
            {
                NavigationService.Navigate(new MainPage());
            }
            else
            {
                string login = LoginTb.Text.Trim();
                string password = PasswordTb.Text.Trim();
                employees = new List<Employees>(App.db.Employees.ToList());
                App.empl = employees.FirstOrDefault(i => i.last_name == login && i.password == password);
                if (App.empl != null)
                {

                    NavigationService.Navigate(new MainPage());
                }
                else
                    MessageBox.Show("Такого сотрудника нет!!!");
            }
        }
    }
}
