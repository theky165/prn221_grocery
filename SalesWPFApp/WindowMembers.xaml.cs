using BusinessObject;
using DataAccess;
using DataAccess.Repository;
using System.Linq;
using System.Windows;

namespace SalesWPFApp
{
    /// <summary>
    /// Interaction logic for WindowMembers.xaml
    /// </summary>
    public partial class WindowMembers : Window
    {
        public Prn221GroceryContext db;
        private IAccountRepository accountRepository;
        public WindowMembers()
        {
            InitializeComponent();
            db = new Prn221GroceryContext();
            accountRepository = new AccountDAO();
        }

        private void LoadData()
        {
            var accounts = db.Accounts.Select(a => new
                {
                    id = a.AccountId,
                    username = a.Username,
                    type = a.Type,
                }).ToList();

            lvAccount.ItemsSource = accounts;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (txtAccountId.Text == null || txtUsername.Text == null || txtType.Text == null)
            {
                MessageBox.Show("Please fill all fields");
            } else
            {
                Account account = new Account();
                account.AccountId = int.Parse(txtAccountId.Text);
                account.Username = txtUsername.Text;
                account.Password = txtPassword.Text;
                account.Type = int.Parse(txtType.Text);
                accountRepository.addAccount(account);
                LoadData();
            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            Account account = new Account
            {
                AccountId = int.Parse(txtAccountId.Text),
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                Type = int.Parse(txtType.Text),
            };
            accountRepository.editAccount(account);
            LoadData();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Account account = db.Accounts.FirstOrDefault(x => x.AccountId == int.Parse(txtAccountId.Text));
            accountRepository.deleteAccount(account);
            LoadData();
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            txtAccountId.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtType.Text = "";
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            WindowMembers windowMembers = new WindowMembers();
            windowMembers.Show();
            this.Close();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            WindowOrders windowOrders = new WindowOrders();
            windowOrders.Show();
            this.Close();
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            WindowProducts windowProducts = new WindowProducts();
            windowProducts.Show();
            this.Close();
        }
    }
}
