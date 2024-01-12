using Data;
using Logic.Classes.Workout;
using Logic.Enums;
using Logic.Interfaces.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DesktopApplication.Home.Workouts
{
    public partial class AddWorkoutForm : Form
    {
        private IWorkoutManager _workouts;

        public AddWorkoutForm()
        {
            InitializeComponent();

            InitializeComboboxes();

            _workouts = new WorkoutManager(new WorkoutDBManager());
        }

        private void InitializeComboboxes()
        {
            cbSportType.Items.AddRange(Enum.GetNames(typeof(SportType)));
            cbBodyMuscle.Items.AddRange(Enum.GetNames(typeof(BodyMuscle)));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SportType sportType = Enum.Parse<SportType>(cbSportType.Text);
            BodyMuscle bodyMuscle = Enum.Parse<BodyMuscle>(cbBodyMuscle.Text);
            
            string title = tbTitle.Text;
            string description = tbDescription.Text;

            Workout workout = new Workout(0, sportType, bodyMuscle, title, description);
            _workouts.AddWorkout(workout);

            MessageBox.Show("The workout has been added!");

            cbSportType.Text = "";
            cbBodyMuscle.Text = "";
            tbTitle.Text = "";
            tbDescription.Text = "";
        }

        private void AddWorkoutForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            GeneralWorkoutsForm workoutsForm = new GeneralWorkoutsForm();
            workoutsForm.Show();
            this.Hide();
        }
    }
}
