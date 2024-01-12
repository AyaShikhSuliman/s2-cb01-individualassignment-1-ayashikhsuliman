using Logic.Classes.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Interfaces.Logic
{
    public interface IAccountManager
    {
		void SignUp(Account login);
		bool IsAdmin(string username, string password);
        bool IsUser(string username, string password);
        List<Account> GetAccounts();
		int ShowAccountId(string username, string password);
		Account GetAccountInfo(int id);
	}
}
