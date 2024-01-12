using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Data;
using DesktopApplication.Home.Workouts;
using DesktopApplication.Workouts;
using Logic.Classes.Workout;
using Logic.Enums;
using Logic.Interfaces.Logic;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DesktopApplication
{
    public partial class GeneralWorkoutsForm : Form
    {
        private DataTable dataTable;
        private DataView dataView;
        private Workout _selectedWorkoutFromLV;
        private IWorkoutManager workoutManager;

        public GeneralWorkoutsForm()
        {
            InitializeComponent();

            InitializeComboboxes();

            workoutManager = new WorkoutManager(new WorkoutDBManager());

            //Listview properties
            lvWorkouts.View = View.Details;
            lvWorkouts.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            //Add columns
            lvWorkouts.Columns.Add("ID", 50);
            lvWorkouts.Columns.Add("SportType", 150);
            lvWorkouts.Columns.Add("BodyMuscle", 150);
            lvWorkouts.Columns.Add("Title", 150);
            lvWorkouts.Columns.Add("Description", 250);

            //Initialize dataTable and add columns
            dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("SportType");
            dataTable.Columns.Add("BodyMuscle");
            dataTable.Columns.Add("Title");
            dataTable.Columns.Add("Description");
        }

        private void InitializeComboboxes()
        {
            cbSportType.Items.AddRange(Enum.GetNames(typeof(SportType)));
            cbBodyMuscles.Items.AddRange(Enum.GetNames(typeof(BodyMuscle)));
        }

        private void PopulateListView(DataView dataView)
        {
            lvWorkouts.Items.Clear();

            foreach (DataRow row in dataView.ToTable().Rows)
            {
                lvWorkouts.Items.Add(new ListViewItem(new String[] { row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString() }));
            }
        }

        private void DisplayWorkouts(string comboBox)
        {
            if (comboBox == "")
            {
                dataView = new DataView(dataTable);
                PopulateListView(dataView);
            }
        }

        private void WorkoutsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginOptionsForm loginOptionsForm = new LoginOptionsForm();
            loginOptionsForm.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddWorkoutForm addWorkout = new AddWorkoutForm();
            addWorkout.Show();
            this.Hide();
        }

        private void WorkoutsForm_Load(object sender, EventArgs e)
        {
            dataTable.Clear();
            if (workoutManager != null)
            {
                foreach (Workout workout in workoutManager.GetAllWorkouts())
                {
                    dataTable.Rows.Add(workout.WorkoutId, workout.SportType, workout.BodyMuscle, workout.Title, workout.Description);
                }

                dataView = new DataView(dataTable);
                PopulateListView(dataView);
            }
        }

        private void cbSportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSportType.Text != "")
            {
                dataView.RowFilter = String.Format("SportType Like '%{0}%'", cbSportType.Text);
                PopulateListView(dataView);
            }
        }

        private void cbBodyMuscles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBodyMuscles.Text != "")
            {
                dataView.RowFilter = String.Format("BodyMuscle Like '%{0}%'", cbBodyMuscles.Text);
                PopulateListView(dataView);
            }
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            dataView.RowFilter = String.Format("Title Like '%{0}%'", tbTitle.Text);
            PopulateListView(dataView);
        }

        private void cbSportType_TextChanged(object sender, EventArgs e)
        {
            DisplayWorkouts(cbSportType.Text);
        }

        private void cbBodyMuscles_TextChanged(object sender, EventArgs e)
        {
            DisplayWorkouts(cbBodyMuscles.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvWorkouts.SelectedItems.Count > 0)
            {
                var confirmation = MessageBox.Show($"Are you sure you want to delete this workout?",
                    "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmation == DialogResult.Yes)
                {
                    if (lvWorkouts.SelectedItems.Count == 0)
                    {
                        return;
                    }

                    int id = int.Parse(lvWorkouts.SelectedItems[0].SubItems[0].Text);
                    Workout workout = workoutManager.GetWorkoutById(id);
                    workoutManager.RemoveWorkout(workout);

                    for (int i = lvWorkouts.SelectedItems.Count - 1; i >= 0; i--)
                    {
                        ListViewItem listViewItem = lvWorkouts.SelectedItems[i];
                        lvWorkouts.Items[listViewItem.Index].Remove();
                    }
                }
            }
            else
            {
                MessageBox.Show("Select a workout first!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this._selectedWorkoutFromLV != null)
            {
                Workout workout = this._selectedWorkoutFromLV;
                EditWorkoutForm editWorkoutForm = new EditWorkoutForm(workout);
                editWorkoutForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Select a workout first!");
            }
        }

        private void lvWorkouts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvWorkouts.SelectedItems.Count == 0)
            {
                return;
            }

            int id = int.Parse(lvWorkouts.SelectedItems[0].SubItems[0].Text);
            Workout workout = workoutManager.GetWorkoutById(id);
            _selectedWorkoutFromLV = workout;
        }
    }
}
