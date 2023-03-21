using BusinessObject;
using DataAccess;
using DataAccess.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
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
    /// Interaction logic for WindowOrders.xaml
    /// </summary>
    public partial class WindowOrders : Window
    {
        Prn221GroceryContext db;
        public IOrderRepository orderRepository;
        public WindowOrders()
        {
            InitializeComponent();
            db = new Prn221GroceryContext();
            orderRepository = new OrderDAO();
        }

        public void LoadData()
        {
            var orders = db.Orders.Include(o => o.Account)
                .Select(o => new
                {
                    id = o.OrderId,
                    account = o.Account.Username,
                    orderDate = o.OrderDate,
                    totalPrice = o.TotalPrice,
                }).ToList();

            var accounts = db.Accounts.Select(a => new
            {
                id = a.AccountId,
                username = a.Username
            }).ToList();

            // Binding to : lv Employee, cb Dept
            lvOrder.ItemsSource = orders;
            cbAccount.ItemsSource = accounts;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadData();
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            txtOrderId.Text = "";
            cbAccount.Text = "";
            dpOrderDate.Text = "";
            txtTotalPrice.Text = "";
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Order o = new Order();
            o.AccountId = int.Parse(cbAccount.SelectedValue.ToString());
            o.OrderDate = (DateTime)dpOrderDate.SelectedDate;
            o.TotalPrice = decimal.Parse(txtTotalPrice.Text);
            orderRepository.addOrder(o);
            LoadData();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            Order o = new Order
            {
                OrderId = int.Parse(txtOrderId.Text),
                AccountId = int.Parse(cbAccount.SelectedValue.ToString()),
                OrderDate = dpOrderDate.DisplayDate,
                TotalPrice = decimal.Parse(txtTotalPrice.Text)
            };
            orderRepository.editOrder(o);
            LoadData();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Order o = db.Orders.FirstOrDefault(x => x.OrderId == int.Parse(txtOrderId.Text));
            orderRepository.deleteOrder(o);
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

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            WindowProducts windowProducts = new WindowProducts();
            windowProducts.Show();
            this.Close();
        }
    }
}
