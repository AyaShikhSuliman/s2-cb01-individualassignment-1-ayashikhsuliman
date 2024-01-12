using Data;
using Logic.Classes.Login;
using Logic.Enums;
using Logic.Interfaces.Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebsiteApplication.Pages
{
    public class LoginModel : PageModel
    {
		[BindProperty]
		public Account account { get; set; }

		public IAccountManager accountManager;
		public int AccountId { get; set; }
		public string username { get; set; }
		//public string password { get; set; }

		public void OnGet()
		{

		}

		public void OnPost()
		{
			accountManager = new AccountManager(new AccountDBManager());

			if (accountManager.IsUser(account.Username, account.Password))
			{
				AccountId = accountManager.ShowAccountId(account.Username, account.Password);
		
				HttpContext.Session.SetInt32("AccountId", AccountId);
				
				Response.Redirect("/Index");
			}
		}
	}
}
