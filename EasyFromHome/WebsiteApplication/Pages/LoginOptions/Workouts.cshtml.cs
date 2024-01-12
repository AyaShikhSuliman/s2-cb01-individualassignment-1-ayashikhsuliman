using Data;
using Logic.Classes.Login;
using Logic.Classes.Workout;
using Logic.Enums;
using Logic.Interfaces.Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebsiteApplication.Pages.LoginOptions
{
	public class WorkoutsModel : PageModel
	{
		public List<Workout> Workouts = new List<Workout>();
		public int AccountID { get; set; }
		public string sportType { get; set; }
		public string bodymuscle { get; set; }
		private IWorkoutManager workoutManager;

		public void OnGet()
		{
			workoutManager = new WorkoutManager(new WorkoutDBManager());

			sportType = HttpContext.Session.GetString("sportType");
			bodymuscle = HttpContext.Session.GetString("bodymuscle");

			foreach (var workout in workoutManager.GetAllWorkouts())
			{
				if (workout.SportType.ToString() == sportType && workout.BodyMuscle.ToString() == bodymuscle)
				{
					Workouts.Add(workout);
					HttpContext.Session.Remove("sportType");
					HttpContext.Session.Remove("bodymuscle");
				}
				else
				{
					//Response.Redirect("/Error");
				}
			}

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

		}
	}
}
