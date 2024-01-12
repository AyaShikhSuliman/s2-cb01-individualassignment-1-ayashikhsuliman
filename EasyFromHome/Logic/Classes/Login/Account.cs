using Logic.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Classes.Login
{
    public class Account
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string EmailAddress { get; set; }
        public AccountType accountType { get; set; }

        public Account() { }

        public Account(int id, string username, string password,string emailAddress, AccountType accountType)
        {
            Id = id;
            Username = username;
            Password = password;
            EmailAddress = emailAddress;
            this.accountType = accountType;
        }
    }
}
