using Logic.Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Logic.Classes;
using Logic.Interfaces.Data;
using Logic.Interfaces.Logic;
using Logic.Interfaces.MockData;

namespace Logic.Classes.Workout
{
    public class WorkoutManager : IWorkoutManager
    {
        private IWorkoutDBManager workoutDBManager;
        private IWorkoutMockDBManager workoutMockDBManager;

        public WorkoutManager(IWorkoutDBManager workoutDBManager)
        {
            this.workoutDBManager = workoutDBManager;
        }

        public WorkoutManager(IWorkoutMockDBManager workoutMockDBManager)
        {
            this.workoutMockDBManager = workoutMockDBManager;
        }

        public bool AddWorkout(Workout workout)
        {
			workoutDBManager.CreateWorkout(workout);
			workoutMockDBManager.CreateWorkout(workout);
            return true;    
		}

        public List<Workout> GetAllWorkouts()
        {
            return workoutDBManager.ReadWorkouts();
        }

        public void RemoveWorkout(Workout workout)
        {
			workoutDBManager.DeleteWorkout(workout);
        }

        public void EditWorkout(Workout workout)
        {
			workoutDBManager.UpdateWorkout(workout);
        }

        public Workout GetWorkoutById(int id)
        {
            Workout workout = workoutDBManager.GetWorkout(id);
            if (workout.WorkoutId != 0)
            {
                return workout;
            }
            return null;
        }

		public List<SportType> ShowAllSportTypes()
        {
            return workoutDBManager.GetSportTypes();
		}

		public List<BodyMuscle> ShowAllBodyMuscles()
		{
			return workoutDBManager.GetBodyMuscles();
		}
	}
}
