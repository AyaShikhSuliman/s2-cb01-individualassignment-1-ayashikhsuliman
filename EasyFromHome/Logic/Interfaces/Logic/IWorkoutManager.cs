using Logic.Classes.Workout;
using Logic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Interfaces.Logic
{
    public interface IWorkoutManager
    {
        bool AddWorkout(Workout workout);
        List<Workout> GetAllWorkouts();
        void RemoveWorkout(Workout workout);
        void EditWorkout(Workout workout);
        Workout GetWorkoutById(int id);
        List<SportType> ShowAllSportTypes();
        List<BodyMuscle> ShowAllBodyMuscles();
	}
}
