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
    public partial class EditFAQForm : Form
    {
        private IFAQManager faQManager;
        private Logic.Classes.Home.FAQ.FAQ _faq { get; set; }

        public EditFAQForm(Logic.Classes.Home.FAQ.FAQ faq)
        {
            InitializeComponent();

            faQManager = new FAQManager(new FaqDBManager());
            _faq = faq;

            tbId.Text = _faq.Id.ToString();
            tbQuestion.Text = _faq.Question;
            tbAnswer.Text = _faq.Answer;
        }

        private void EditFAQForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            GeneralFAQForm fAQForm = new GeneralFAQForm();
            fAQForm.Show();
            this.Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            _faq.Id = int.Parse(tbId.Text);
            _faq.Question = tbQuestion.Text;
            _faq.Answer = tbAnswer.Text;

            faQManager.EditFAQ(_faq);

            MessageBox.Show("The FAQ has been edited!");

            tbId.Text = "";
            tbQuestion.Text = "";
            tbAnswer.Text = "";
        }
    }
}
