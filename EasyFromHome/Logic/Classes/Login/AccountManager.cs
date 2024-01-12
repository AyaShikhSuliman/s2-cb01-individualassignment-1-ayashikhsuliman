using Logic.Interfaces.Data;
using Logic.Interfaces.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Classes.Login
{
	public class AccountManager : IAccountManager
	{
		private IAccountDBManager loginDB;

		public AccountManager(IAccountDBManager loginDB)
		{
			this.loginDB = loginDB;
		}

		public bool IsAdmin(string username, string password)
		{
			return loginDB.GetAdmin(username, password);
		}

		public bool IsUser(string username, string password)
		{
			return loginDB.GetUser(username, password);
		}

		public void SignUp(Account login)
		{
			loginDB.CreateLogin(login);
		}

		public List<Account> GetAccounts()
		{
			return loginDB.ReadAccounts();
		}

		public int ShowAccountId(string username, string password)
		{
			return loginDB.GetAccountId(username, password);
		}


		public Account GetAccountInfo(int id)
		{
			return loginDB.GetAccount(id);
		}
	}
}