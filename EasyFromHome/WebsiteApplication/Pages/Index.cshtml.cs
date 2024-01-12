using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Logic.Classes.Home.Contact;
using Logic.Classes.Home.FAQ;
using Logic.Enums;
using Logic.Interfaces.Logic;
using Data;
using Logic.Classes.Login;
using Logic.Classes.Workout;

namespace WebsiteApplication.Pages
{
	public class IndexModel : PageModel
	{
		[BindProperty]
		public FAQ FAQ { get; set; }
		[BindProperty]
		public List<FAQ> FAQs { get; set; }
		private IFAQManager FAQManager;
		[BindProperty]
		public ContactForm contactForm { get; set; }
		private IContactFormManager contactFormManager;
		public IAccountManager AccountManager { get; set; }
		public Account account { get; set; }

		public void OnGet()
		{
			FAQManager = new FAQManager(new FaqDBManager());
			FAQs = FAQManager.GetAllFAQs();

			AccountManager = new AccountManager(new AccountDBManager());

			try
			{
				int accountId = HttpContext.Session.GetInt32("AccountId").Value;
				account = AccountManager.GetAccountInfo(accountId);
			}
			catch
			{
				//Response.Redirect("/Index");
			}
		}

		public bool IfLoggedIn(HttpContext httpContext)
		{
			return httpContext.Session.GetInt32("AccountId") == null;
		}

		public void OnPost()
		{
			contactFormManager = new ContactFormManager(new ContactFormDBManager());
			contactFormManager.SendContactForm(contactForm);
		}
	}
}