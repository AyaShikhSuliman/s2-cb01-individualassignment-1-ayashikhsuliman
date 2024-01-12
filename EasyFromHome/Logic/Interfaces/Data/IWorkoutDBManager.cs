using Logic.Classes.Workout;
using Logic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Interfaces.Data
{
	public interface IWorkoutDBManager
	{
		void CreateWorkout(Workout workout);
		List<Workout> ReadWorkouts();
		void UpdateWorkout(Workout workout);
		void DeleteWorkout(Workout workout);
		Workout GetWorkout(int id);
		List<SportType> GetSportTypes();
		List<BodyMuscle> GetBodyMuscles();
	}
}
