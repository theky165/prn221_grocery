using BusinessObject;
using DataAccess;
using DataAccess.Repository;
using MaterialDesignColors;
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
using System.Windows.Media.Media3D;
using System.Windows.Shapes;

namespace SalesWPFApp
{
    /// <summary>
    /// Interaction logic for WindowProducts.xaml
    /// </summary>
    public partial class WindowProducts : Window
    {
        Prn221GroceryContext db;
        private IProductRepository productRepository;
        public WindowProducts()
        {
            InitializeComponent();
            db = new Prn221GroceryContext();
            productRepository = new ProductDAO();
        }

        public void LoadData()
        {
            var products = db.Products.Select(p => new
            {
                id = p.ProductId,
                categoryId = p.CategoryId,
                productName = p.Name,
                image = p.Image,
                price = p.Price,
                quantity = p.Quantity,
            }).ToList();

            lvProduct.ItemsSource = products;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadData();
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            txtProductId.Text = "";
            txtCategoryId.Text = "";
            txtProductName.Text = "";
            txtImage.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Product p = new Product();
            p.CategoryId = int.Parse(txtCategoryId.Text);
            p.Name = txtProductName.Text;
            p.Image = txtImage.Text;
            p.Price = decimal.Parse(txtPrice.Text);
            p.Quantity = int.Parse(txtQuantity.Text);
            productRepository.addProduct(p);
            LoadData();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            Product p = new Product
            {
                ProductId = int.Parse(txtProductId.Text),
                CategoryId = int.Parse(txtCategoryId.Text),
                Name = txtProductName.Text,
                Image = txtImage.Text,
                Price = decimal.Parse(txtPrice.Text),
                Quantity = int.Parse(txtQuantity.Text),
            };
            productRepository.editProduct(p);
            LoadData();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Product product = db.Products.FirstOrDefault(x => x.ProductId == int.Parse(txtProductId.Text));
            productRepository.deleteProduct(product);
            LoadData();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            string searchValue = txtSearch.Text.ToLower();

            var productList = db.Products.Select(p => new
            {
                id = p.ProductId,
                categoryId = p.CategoryId,
                productName = p.Name,
                image = p.Image,
                price = p.Price,
                quantity = p.Quantity
            }).Where(p =>
                p.productName.ToLower().Contains(searchValue))
         .ToList();

            lvProduct.ItemsSource = productList;
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
