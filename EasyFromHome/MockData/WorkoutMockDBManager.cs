using Logic.Classes.Workout;
using Logic.Enums;
using Logic.Interfaces.Logic;
using Logic.Interfaces.MockData;
using System.Data.SqlClient;

namespace MockData
{
    public class WorkoutMockDBManager: IWorkoutMockDBManager
	{
		private Dictionary<int, Workout> workouts;

		public WorkoutMockDBManager() 
		{
			workouts = new Dictionary<int, Workout>();
		}

		public bool CreateWorkout(Workout workout)
		{
			this.workouts.Add(workout.WorkoutId, workout);	
			return true;
		}
	}
}