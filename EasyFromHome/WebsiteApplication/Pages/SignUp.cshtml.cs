using Data;
using Logic.Classes.Login;
using Logic.Interfaces.Logic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebsiteApplication.Pages
{
    public class SignUpModel : PageModel
    {
        [BindProperty]
        public Account account { get; set; }
        public IAccountManager accountManager;

        public void OnPost()
        {
			accountManager = new AccountManager(new AccountDBManager());
            foreach(Account item in accountManager.GetAccounts())
            {
                if (item.Username != account.Username)
                {
                    Response.Redirect("/Error");
                }
			}
            
			accountManager.SignUp(account);
			Response.Redirect("/Login");
		}
    }
}
