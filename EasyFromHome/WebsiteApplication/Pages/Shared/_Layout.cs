namespace WebsiteApplication.Pages.Shared
{
	public class _Layout
	{
		public static bool IfLoggedIn(HttpContext httpContext)
		{
			return httpContext.Session.GetInt32("AccountId") == null;
		}
	}
}
