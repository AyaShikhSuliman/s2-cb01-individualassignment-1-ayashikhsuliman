using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebsiteApplication.Pages
{
	public class LogOutModel : PageModel
	{
		public void OnGet()
		{
			HttpContext.Session.Remove("AccountId");
			Response.Redirect("/Index");
		}
	}
}
