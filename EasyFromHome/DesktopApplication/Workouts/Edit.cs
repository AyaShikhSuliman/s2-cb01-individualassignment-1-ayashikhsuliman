using Logic.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using Logic.Classes.Workout;
using Logic.Interfaces.Logic;
using Data;

namespace DesktopApplication.Workouts
{
    public partial class EditWorkoutForm : Form
    {
        private IWorkoutManager workoutManager;
        private Workout _workout { get; set; }

        public EditWorkoutForm(Workout workout)
        {
            InitializeComponent();

            workoutManager = new WorkoutManager(new WorkoutDBManager());
            _workout = workout;

            tbId.Text = _workout.WorkoutId.ToString();
            tbSportType.Text = _workout.SportType.ToString();
            tbBodyMuscle.Text = _workout.BodyMuscle.ToString();
            tbTitle.Text = _workout.Title.ToString();
            tbDescription.Text = _workout.Description.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            _workout.SportType = Enum.Parse<SportType>(tbSportType.Text);
            _workout.BodyMuscle = Enum.Parse<BodyMuscle>(tbBodyMuscle.Text);
            _workout.Title = tbTitle.Text;
            _workout.Description = tbDescription.Text;

            workoutManager.EditWorkout(_workout);

            MessageBox.Show("The workout has been edited!");

            tbSportType.Text = "";
            tbBodyMuscle.Text = "";
            tbTitle.Text = "";
            tbDescription.Text = "";
        }

        private void EditWorkoutForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            GeneralWorkoutsForm workoutsForm = new GeneralWorkoutsForm();
            workoutsForm.Show();
        }
    }
}
