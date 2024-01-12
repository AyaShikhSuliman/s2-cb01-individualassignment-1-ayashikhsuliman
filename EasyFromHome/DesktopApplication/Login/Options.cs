using Logic.Classes.Workout;
using Logic.Interfaces.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApplication
{
    public partial class LoginOptionsForm : Form
    {

        public LoginOptionsForm()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomeOptionsForm homeOptionsForm = new HomeOptionsForm();
            homeOptionsForm.Show();
            this.Hide();
        }

        private void btnWorkouts_Click(object sender, EventArgs e)
        {
            GeneralWorkoutsForm workoutsForm = new GeneralWorkoutsForm();
            workoutsForm.Show();
            this.Hide();
        }

        private void LoginOptionsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
