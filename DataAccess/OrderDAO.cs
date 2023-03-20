using BusinessObject;
using DataAccess.Repository;
using System.Windows;

namespace DataAccess
{
    public class OrderDAO : IOrderRepository
    {
        public Prn221GroceryContext db = new Prn221GroceryContext();

        public void addOrder(Order order)
        {
            db.Add<Order>(order);
            if (db.SaveChanges() > 0)
            {
                MessageBox.Show("Add successfully!");
            }
        }

        public void deleteOrder(Order order)
        {
            db.Remove<Order>(order);
            if (db.SaveChanges() > 0)
            {
                MessageBox.Show("Record removed successfully");
            }
        }

        public void editOrder(Order order)
        {
            db.Update<Order>(order);
            if (db.SaveChanges() > 0)
            {
                MessageBox.Show("Edit success.");
            }
            else
            {
                MessageBox.Show("Edit failed.");
            }
        }
    }
}
