using BusinessObject;
using DataAccess;
using DataAccess.Repository;
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

namespace SalesWPFApp
{
    /// <summary>
    /// Interaction logic for AddMember.xaml
    /// </summary>
    public partial class AddMember : Window
    {
        public Prn221GroceryContext db;
        private IAccountRepository accountRepository;
        public AddMember()
        {
            InitializeComponent();
            db = new Prn221GroceryContext();
            accountRepository = new AccountDAO();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Account account = new Account();
            account.Username = txtUsername.Text;
            account.Password = txtPassword.Text;
            account.Type = int.Parse(txtType.Text);
            accountRepository.addAccount(account);
            WindowMembers windowMember = new WindowMembers();
            windowMember.Show();
            this.Close();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
