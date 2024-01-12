using Data;
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
using Logic.Classes.Home;
using System.Net;
using System.Net.Mail;
using System.Net.NetworkInformation;
using Microsoft.VisualBasic;
using System.Net.Http;
using System.Xml.Linq;
using Logic.Enums;

namespace DesktopApplication
{
	public partial class ContactForm : Form
	{
		private DataTable dataTable;
		private DataView dataView;
		private IContactFormManager contactFormManager;
		private Logic.Classes.Home.Contact.ContactForm selectedContactForm;

		public ContactForm()
		{
			InitializeComponent();

			contactFormManager = new Logic.Classes.Home.Contact.ContactFormManager(new ContactFormDBManager());

			//Listview properties
			lvContactForms.View = View.Details;
			lvContactForms.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

			//Add columns
			lvContactForms.Columns.Add("Id", 50);
			lvContactForms.Columns.Add("Name", 100);
			lvContactForms.Columns.Add("Email Address", 200);
			lvContactForms.Columns.Add("Question", 150);
			lvContactForms.Columns.Add("Answer", 150);
			lvContactForms.Columns.Add("Status", 100);

			//Initialize dataTable and add columns
			dataTable = new DataTable();
			dataTable.Columns.Add("Id");
			dataTable.Columns.Add("Name");
			dataTable.Columns.Add("Email Address");
			dataTable.Columns.Add("Question");
			dataTable.Columns.Add("Answer");
			dataTable.Columns.Add("Status");
		}

		private void PopulateListView(DataView dataView)
		{
			lvContactForms.Items.Clear();

			foreach (DataRow row in dataView.ToTable().Rows)
			{
				lvContactForms.Items.Add(new ListViewItem(new String[] { row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString() }));
			}
		}

		private void ContactForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.Hide();
			HomeOptionsForm homeOptionsForm = new HomeOptionsForm();
			homeOptionsForm.Show();
		}

		private void ContactForm_Load(object sender, EventArgs e)
		{
			dataTable.Clear();
			if (contactFormManager != null)
			{
				foreach (var contactForm in contactFormManager.ShowContactForms())
				{
					dataTable.Rows.Add(contactForm.Id, contactForm.Name,
						contactForm.Email, contactForm.Question, contactForm.Answer,
						contactForm.ContactFormStatus);
				}

				dataView = new DataView(dataTable);
				PopulateListView(dataView);
			}
		}

		private void lvContactForms_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lvContactForms.SelectedItems.Count == 0)
			{
				return;
			}
			int id = int.Parse(lvContactForms.SelectedItems[0].SubItems[0].Text);
			selectedContactForm = contactFormManager.GetForm(id);
			lblId.Text = selectedContactForm.Id.ToString();
			lblname.Text = selectedContactForm.Name;
			lblemail.Text = selectedContactForm.Email;
			lblquestion.Text = selectedContactForm.Question;
			lblstatus.Text = selectedContactForm.ContactFormStatus.ToString();
		}

		private void btnAnswerQuestion_Click(object sender, EventArgs e)
		{
			selectedContactForm.Name = lblname.Text;
			selectedContactForm.Email = lblemail.Text;
			selectedContactForm.Question = lblquestion.Text;
			selectedContactForm.Answer = tbAnswer.Text;
			selectedContactForm.ContactFormStatus = ContactFormStatus.Answered;

			contactFormManager.AnswerContactForm(selectedContactForm);

			MessageBox.Show("The contact has been answered!");

			lblId.Text = "";
			lblname.Text = "";
			lblemail.Text = "";
			lblquestion.Text = "";
			tbAnswer.Text = "";
			lblstatus.Text = "";
		}
	}
}
