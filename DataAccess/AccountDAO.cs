using BusinessObject;
using DataAccess.Repository;
using System.Windows;

namespace DataAccess
{
    public class AccountDAO : IAccountRepository
    {
        public Prn221GroceryContext db = new Prn221GroceryContext();

        public void addAccount(Account account)
        {
            throw new NotImplementedException();
        }

        public void addMember(Account account)
        {
            db.Add<Account>(account);
            if (db.SaveChanges() > 0)
            {
                MessageBox.Show("Add successfully!");
            }
        }

        public bool AuthenticateUser(string username, string password)
        {
            if (username != null && password != null)
            {
                Account account = db.Accounts.FirstOrDefault(m => m.Username == username && m.Password == password);
                if (account == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        public void deleteAccount(Account account)
        {
            throw new NotImplementedException();
        }

        public void deleteMember(Account account)
        {
            db.Remove<Account>(account);
            if (db.SaveChanges() > 0)
            {
                MessageBox.Show("Record removed successfully");
            }
        }

        public void editAccount(Account account)
        {
            throw new NotImplementedException();
        }

        public void editMember(Account account)
        {
            db.Update<Account>(account);
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
