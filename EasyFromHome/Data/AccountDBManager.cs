using Logic.Classes.Login;
using Logic.Classes.Workout;
using Logic.Enums;
using Logic.Interfaces.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
	public class AccountDBManager : IAccountDBManager
	{
		private string connectionString = "Server=mssqlstud.fhict.local;Database=dbi495487;User Id=dbi495487;Password=myDatabase123";

		public void CreateLogin(Account login)
		{
			AccountType loginType = AccountType.User;

			SqlConnection sqlConnection = new SqlConnection(connectionString);
			sqlConnection.Open();
			string query = "insert into account values (@username,@password,@email_address, @login_type_id)";
			SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

			sqlCommand.Parameters.AddWithValue("@username", login.Username);
			sqlCommand.Parameters.AddWithValue("@password", login.Password);
			sqlCommand.Parameters.AddWithValue("@email_address", login.EmailAddress);
			sqlCommand.Parameters.AddWithValue("@login_type_id", loginType);

			sqlCommand.ExecuteNonQuery();
			sqlConnection.Close();
		}

		public bool GetAdmin(string username, string password)
		{
			SqlConnection sqlConnection = new SqlConnection(connectionString);

			string query = "select * from account where username='" + username.Trim() + "'and password='" + password.Trim() + "'";

			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);

			if (dataTable.Rows.Count == 1)
			{
				return true;
			}

			return false;
		}

		public bool GetUser(string username, string password)  //use my way
		{
			foreach (var item in ReadAccounts())
			{
				if (item.Username == username && item.Password == password)
				{
					return true;
				}
			}
			return false;
		}

		public List<Account> ReadAccounts()
		{
			List<Account> accounts = new List<Account>();
			SqlConnection sqlConnection = new SqlConnection(connectionString);
			sqlConnection.Open();

			string query = " select * from account";
			SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

			SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
			while (sqlDataReader.Read())
			{
				AccountType accountType = Enum.Parse<AccountType>(sqlDataReader.GetInt32(4).ToString());

				Account account = new Account(sqlDataReader.GetInt32(0), sqlDataReader.GetString(1),
				   sqlDataReader.GetString(2), sqlDataReader.GetString(3), accountType);

				accounts.Add(account);
			}

			return accounts;
		}

		public int GetAccountId(string username, string password)
		{
			SqlConnection sqlConnection = new SqlConnection(connectionString);
			sqlConnection.Open();

			string query = "select account_id from account where username=@username AND password=@password";
			SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

			sqlCommand.Parameters.AddWithValue("@username", username);
			sqlCommand.Parameters.AddWithValue("@password", password);

			SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

			while (sqlDataReader.Read())
			{
				int accountId = sqlDataReader.GetInt32(0);

				return accountId;
			}
			return 0;
		}

		public Account GetAccount(int id)
		{
			SqlConnection sqlConnection = new SqlConnection(connectionString);
			sqlConnection.Open();

			string query = "select * from account where account_id=@id";
			SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

			sqlCommand.Parameters.AddWithValue("@id", id);

			SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

			while (sqlDataReader.Read())
			{
				AccountType accountType = Enum.Parse<AccountType>(sqlDataReader.GetInt32(4).ToString());

				Account account = new Account(sqlDataReader.GetInt32(0),
					sqlDataReader.GetString(1), sqlDataReader.GetString(2),
					sqlDataReader.GetString(3), accountType);

				return account;
			}
			return null;
		}
	}
}
