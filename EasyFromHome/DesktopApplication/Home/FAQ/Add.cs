using Data;
using Logic.Classes.Home.FAQ;
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

namespace DesktopApplication.Home.FAQ
{
    public partial class AddFAQForm : Form
    {
        private IFAQManager faQManager;

        public AddFAQForm()
        {
            InitializeComponent();

            faQManager = new FAQManager(new FaqDBManager());
        }

        private void AddFAQForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            GeneralFAQForm fAQForm = new GeneralFAQForm();
            fAQForm.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string question = tbQuestion.Text;
            string answer = tbAnswer.Text;

            Logic.Classes.Home.FAQ.FAQ faq = new Logic.Classes.Home.FAQ.FAQ(0, question, answer);
            faQManager.AddFAQ(faq);

            MessageBox.Show("The FAQ has been added!");

            tbQuestion.Text = "";
            tbAnswer.Text = "";

        }
    }
}
