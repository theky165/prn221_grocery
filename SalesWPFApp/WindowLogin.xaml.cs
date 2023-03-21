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
        private IAccountRepository accountRepository;
        private Prn221GroceryContext db = new Prn221GroceryContext();
        public WindowLogin()
        {
            accountRepository = new AccountDAO();
            InitializeComponent();
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Password;

            bool authenLogin = accountRepository.AuthenticateUser(username, password);
            if (authenLogin)
            {
                MessageBox.Show("Login Success!");
                Dashboard windowDashboard = new Dashboard();
                windowDashboard.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect email or password!");
            }
        }
    }
}
