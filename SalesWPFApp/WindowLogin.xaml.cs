using BusinessObject;
using DataAccess;
using DataAccess.Repository;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.IO;
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

namespace SalesWPFApp
{
    /// <summary>
    /// Interaction logic for WindowLogin.xaml
    /// </summary>
    public partial class WindowLogin : Window
    {
        private readonly string adminEmail;
        private readonly string adminPassword;
        private IAccountRepository memberRepository;
        private Prn221GroceryContext db = new Prn221GroceryContext();
        public WindowLogin()
        {
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Password;

            bool authenLogin = memberRepository.AuthenticateUser(username, password);
            if (authenLogin)
            {
                MessageBox.Show("Login Success!");
                WindowOrders windowOrders = new WindowOrders();
                windowOrders.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect email or password!");
            }
        }
    }
}
