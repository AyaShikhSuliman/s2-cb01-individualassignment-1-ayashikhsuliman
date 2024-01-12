using Logic.Classes;
using Logic.Interfaces;
using Logic.Interfaces.Data;
using Data;
using Logic.Classes.Login;
using Logic.Interfaces.Logic;

namespace DesktopApplication
{
    public partial class LoginForm : Form
    {
        private IAccountManager accountManager;

        public LoginForm()
        {
            InitializeComponent();

			accountManager = new AccountManager(new AccountDBManager());
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Provide username and password!");
                return;
            }

            if (accountManager.IsAdmin(tbUsername.Text, tbPassword.Text))
            {
                LoginOptionsForm loginOptionsForm = new LoginOptionsForm();
                loginOptionsForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect username and password");
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string message = "Do you really want to close the program?";
            string title = "Close Window";

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}