using Logic.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Classes.Workout
{
    public class Workout
    {
        public int WorkoutId { get; set; }
        public SportType SportType { get; set; }
        public BodyMuscle BodyMuscle { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public Workout(int workoutId, SportType sportType, BodyMuscle bodyMuscle, string title, string description)
        {
            WorkoutId = workoutId;
            SportType = sportType;
            BodyMuscle = bodyMuscle;
            Title = title;
            Description = description;
        }
    }
}
