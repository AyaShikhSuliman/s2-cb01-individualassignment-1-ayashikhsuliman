using Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApplication
{
    public partial class HomeOptionsForm : Form
    {
        public HomeOptionsForm()
        {
            InitializeComponent();
        }

        private void btnFAQ_Click(object sender, EventArgs e)
        {
            GeneralFAQForm fAQForm = new GeneralFAQForm();
            fAQForm.Show();
            this.Hide();
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            ContactForm contactForm = new ContactForm();
            contactForm.Show();
            this.Hide();
        }

        private void HomeOptionsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            LoginOptionsForm loginOptionsForm = new LoginOptionsForm();
            loginOptionsForm.Show();
        }
    }
}
