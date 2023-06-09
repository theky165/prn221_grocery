﻿using BusinessObject;
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
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        private Prn221GroceryContext db = new Prn221GroceryContext();
        public int totalAccount { get; set; }
        public int totalProduct { get; set; }
        public int totalOrder { get; set; }
        public Dashboard()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            totalAccount = db.Accounts.Count();
            totalProduct = db.Products.Count();
            totalOrder = db.Orders.Count();
            this.DataContext = this;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
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

        private int btnSearch_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Clicked!");
            DateTime startDate = (DateTime)dpStartDate.SelectedDate;
            DateTime endDate = (DateTime)dpEndDate.SelectedDate;
            if (startDate != null && endDate != null)
            {
                totalOrder = db.Orders
                    .Where(o => startDate <= o.OrderDate && o.OrderDate <= endDate).Count();
                return totalOrder;
            }
            else
            {
                totalOrder = db.Orders.Count();
                return totalOrder;
            }
        }
    }
}
