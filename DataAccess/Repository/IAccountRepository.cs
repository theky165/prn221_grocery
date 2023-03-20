using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IAccountRepository
    {
        bool AuthenticateUser(string username, string password);
        void addAccount(Account account);
        void editAccount(Account member);
        void deleteAccount(Account member);
    }
}
