using BusinessObject;
using DataAccess;
using DataAccess.Repository;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace SalesWPFApp
{
    /// <summary>
    /// Interaction logic for WindowMembers.xaml
    /// </summary>
    public partial class WindowMembers : Window
    {
        public Prn221GroceryContext db;
        private IAccountRepository accountRepository;
        public int id { get; set; }
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
            AddMember addMember = new AddMember();
            addMember.Show();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            Account account = new Account
            {
                //AccountId = int.Parse(txtAccountId.Text),
                //Username = txtUsername.Text,
                //Password = txtPassword.Text,
                //Type = int.Parse(txtType.Text),
            };
            accountRepository.editAccount(account);
            LoadData();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var item = ((sender as Button)?.Tag as ListViewItem)?.DataContext;
            var itemId = (item as WindowMembers)?.id;
            //Account account = db.Accounts.FirstOrDefault(x => x.AccountId == aaccccount.id);
            //accountRepository.deleteAccount(account);
            LoadData();
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

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            Dashboard windowDashboard = new Dashboard();
            windowDashboard.Show();
            this.Close();
        }
    }
}
