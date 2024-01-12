using Data;
using Logic.Classes.Workout;
using Logic.Enums;
using Logic.Interfaces.Logic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebsiteApplication.Pages.LoginOptions
{
    public class BodyMusclesModel : PageModel
    {
		[BindProperty]
		public List<BodyMuscle> bodyMuscles { get; set; }
		[BindProperty]
		public string bodymuscle { get; set; }
		public int AccountID { get; set; }
		private IWorkoutManager workoutManager;

		public void OnGet()
		{
			workoutManager = new WorkoutManager(new WorkoutDBManager());

			bodyMuscles = workoutManager.ShowAllBodyMuscles();

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
			bodymuscle = Request.Form["bodymuscle"];
			HttpContext.Session.SetString("bodymuscle", bodymuscle);
			Response.Redirect("/LoginOptions/Workouts");
		}
	}
}
