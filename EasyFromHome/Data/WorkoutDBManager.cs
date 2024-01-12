using Logic.Classes.Workout;
using Logic.Enums;
using Logic.Interfaces.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
	public class WorkoutDBManager : IWorkoutDBManager
	{
		private string connectionString = "Server=mssqlstud.fhict.local;Database=dbi495487;User Id=dbi495487;Password=myDatabase123";

		public void CreateWorkout(Workout workout)
		{
			SqlConnection sqlConnection = new SqlConnection(connectionString);
			sqlConnection.Open();
			string query = "insert into workout values (@sport_type_id, @body_muscle_id, @title, @description)";
			SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

			sqlCommand.Parameters.AddWithValue("@sport_type_id", workout.SportType);
			sqlCommand.Parameters.AddWithValue("@body_muscle_id", workout.BodyMuscle);
			sqlCommand.Parameters.AddWithValue("@title", workout.Title);
			sqlCommand.Parameters.AddWithValue("@description", workout.Description);

			sqlCommand.ExecuteNonQuery();
			sqlConnection.Close();
		}

		public List<Workout> ReadWorkouts()
		{
			List<Workout> workouts = new List<Workout>();
			SqlConnection sqlConnection = new SqlConnection(connectionString);
			sqlConnection.Open();

			string query = " select workout_id,sport_type_id,body_muscle_id,title,description from workout";
			SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

			SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
			while (sqlDataReader.Read())
			{
				SportType sportType = Enum.Parse<SportType>(sqlDataReader.GetInt32(1).ToString());
				BodyMuscle bodyMuscle = Enum.Parse<BodyMuscle>(sqlDataReader.GetInt32(2).ToString());

				Workout workout = new Workout(sqlDataReader.GetInt32(0), sportType,
				   bodyMuscle, sqlDataReader.GetString(3), sqlDataReader.GetString(4));

				workouts.Add(workout);
			}

			return workouts;
		}

		public void UpdateWorkout(Workout workout)
		{
			foreach (Workout item in ReadWorkouts())
			{
				if (item.WorkoutId == workout.WorkoutId)
				{
					SqlConnection sqlConnection = new SqlConnection(connectionString);
					sqlConnection.Open();

					string query = "Update workout SET sport_type_id=@sport_type_id,body_muscle_id=@body_muscle_id, title=@title,description=@description where workout_id='" + workout.WorkoutId + "'";

					SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
					sqlCommand.Parameters.AddWithValue("@sport_type_id", workout.SportType);
					sqlCommand.Parameters.AddWithValue("@body_muscle_id", workout.BodyMuscle);
					sqlCommand.Parameters.AddWithValue("@title", workout.Title);
					sqlCommand.Parameters.AddWithValue("@description", workout.Description);

					sqlCommand.ExecuteNonQuery();
					sqlConnection.Close();
				}
			}
		}

		public void DeleteWorkout(Workout workout)
		{
			SqlConnection sqlConnection = new SqlConnection(connectionString);
			sqlConnection.Open();

			string query = "Delete From workout where workout_id ='" + workout.WorkoutId + "'";

			using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
			{
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		public Workout GetWorkout(int id)
		{
			SqlConnection sqlConnection = new SqlConnection(connectionString);
			sqlConnection.Open();

			string query = "select workout_id,sport_type_id,body_muscle_id,title,description from workout where workout_id=@id";
			SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

			sqlCommand.Parameters.AddWithValue("@id", id);

			SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

			while (sqlDataReader.Read())
			{
				SportType sportType = Enum.Parse<SportType>(sqlDataReader.GetInt32(1).ToString());
				BodyMuscle bodyMuscle = Enum.Parse<BodyMuscle>(sqlDataReader.GetInt32(2).ToString());

				Workout workout = new Workout(sqlDataReader.GetInt32(0), sportType,
				   bodyMuscle, sqlDataReader.GetString(3), sqlDataReader.GetString(4));

				return workout;
			}
			return null;
		}

		public List<SportType> GetSportTypes()
		{
			List<SportType> sportTypes = new List<SportType>();
			SqlConnection sqlConnection = new SqlConnection(connectionString);
			sqlConnection.Open();

			string query = " select sport_type_id,sport_type from sport_type";
			SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

			SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
			while (sqlDataReader.Read())
			{
				SportType sport = Enum.Parse<SportType>(sqlDataReader.GetInt32(0).ToString());

				sportTypes.Add(sport);
			}

			return sportTypes;
		}

		public List<BodyMuscle> GetBodyMuscles()
		{
			List<BodyMuscle> bodyMuscles = new List<BodyMuscle>();
			SqlConnection sqlConnection = new SqlConnection(connectionString);
			sqlConnection.Open();

			string query = " select * from body_muscle";
			SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

			SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
			while (sqlDataReader.Read())
			{
				BodyMuscle bodyMuscle = Enum.Parse<BodyMuscle>(sqlDataReader.GetInt32(0).ToString());

				bodyMuscles.Add(bodyMuscle);
			}

			return bodyMuscles;
		}
	}
}
