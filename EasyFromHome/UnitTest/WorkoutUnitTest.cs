using Logic.Classes.Workout;
using Logic.Enums;
using Logic.Interfaces.Logic;
using MockData;

namespace UnitTest
{
	[TestClass]
	public class WorkoutUnitTest
	{
		IWorkoutManager workoutManager = new WorkoutManager( new WorkoutMockDBManager());

		[TestMethod]
		public void TestAddingNewWorkout()
		{
			Workout workout = new Workout(0, SportType.Fitness, BodyMuscle.Biceps, "Test", "Unit");
			bool result = workoutManager.AddWorkout(workout);
			Assert.IsTrue(result);
		}
	}
}