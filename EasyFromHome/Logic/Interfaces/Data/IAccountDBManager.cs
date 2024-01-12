using Logic.Classes.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Interfaces.Data
{
    public interface IAccountDBManager
    {
		void CreateLogin(Account login);
		bool GetAdmin(string username, string password);
        bool GetUser(string username, string password);
		List<Account> ReadAccounts();
		int GetAccountId(string username, string password);
		Account GetAccount(int id);
	}
}
