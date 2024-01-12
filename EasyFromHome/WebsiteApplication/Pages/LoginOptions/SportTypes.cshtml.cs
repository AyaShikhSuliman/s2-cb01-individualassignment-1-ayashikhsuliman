using Data;
using Logic.Classes.Login;
using Logic.Classes.Workout;
using Logic.Enums;
using Logic.Interfaces.Logic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Primitives;

namespace WebsiteApplication.Pages.LoginOptions
{
    public class SportTypesModel : PageModel
    {
		[BindProperty]
		public List<SportType> SportTypes { get; set; }
		[BindProperty]
		public string sportType { get; set; }
		public int AccountID { get; set; }
		private IWorkoutManager workoutManager;

		public void OnGet()
		{
			workoutManager = new WorkoutManager(new WorkoutDBManager());

			SportTypes = workoutManager.ShowAllSportTypes();

			try
			{
				AccountID = HttpContext.Session.GetInt32("AccountId").Value;

			}
			catch
			{
				Response.Redirect("/Login");
			}
		}

		public void OnPost()
		{
			sportType = Request.Form["sportType"];
			HttpContext.Session.SetString("sportType", sportType);
			Response.Redirect("/LoginOptions/BodyMuscles");
		}
	}
}
