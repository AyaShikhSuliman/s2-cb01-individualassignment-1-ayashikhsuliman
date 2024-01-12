using Logic.Classes.Home.Contact;
using Logic.Classes.Workout;
using Logic.Enums;
using Logic.Interfaces.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ContactFormDBManager: IContactFormDBManager
    {
		private string connectionString = "Server=mssqlstud.fhict.local;Database=dbi495487;User Id=dbi495487;Password=myDatabase123";
		
		public void CreateContactForm(ContactForm contactForm)
		{
			contactForm.Answer = "";
			ContactFormStatus contactFormStatus = ContactFormStatus.NotAnswered;

			SqlConnection sqlConnection = new SqlConnection(connectionString);
			sqlConnection.Open();
			
			string query = "insert into contact_form values (@name, @email, @question, @answer, @contact_form_status_id)";
			SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

			sqlCommand.Parameters.AddWithValue("@name", contactForm.Name);
			sqlCommand.Parameters.AddWithValue("@email", contactForm.Email);
			sqlCommand.Parameters.AddWithValue("@question", contactForm.Question);
			sqlCommand.Parameters.AddWithValue("@answer", contactForm.Answer);
			sqlCommand.Parameters.AddWithValue("@contact_form_status_id", contactFormStatus);

			sqlCommand.ExecuteNonQuery();
			sqlConnection.Close();
		}

		public List<ContactForm> ReadContactForms()
		{
			List<ContactForm> contactForms = new List<ContactForm>();
			SqlConnection sqlConnection = new SqlConnection(connectionString);
			sqlConnection.Open();

			string query = " select * from contact_form";
			SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

			SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
			while (sqlDataReader.Read())
			{
				ContactFormStatus contactFormStatus = Enum.Parse<ContactFormStatus>(sqlDataReader.GetInt32(5).ToString());

				ContactForm contactForm = new ContactForm(sqlDataReader.GetInt32(0),
					sqlDataReader.GetString(1), sqlDataReader.GetString(2), 
					sqlDataReader.GetString(3), sqlDataReader.GetString(4), 
					contactFormStatus);

				contactForms.Add(contactForm);
			}

			return contactForms;
		}

		public ContactForm GetContactForm(int id)
		{
			SqlConnection sqlConnection = new SqlConnection(connectionString);
			sqlConnection.Open();

			string query = "select * from contact_form where contact_form_id=@id";
			SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

			sqlCommand.Parameters.AddWithValue("@id", id);

			SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

			while (sqlDataReader.Read())
			{
				ContactFormStatus contactFormStatus = Enum.Parse<ContactFormStatus>(sqlDataReader.GetInt32(5).ToString());

				ContactForm contactForm = new ContactForm(sqlDataReader.GetInt32(0),
					sqlDataReader.GetString(1), sqlDataReader.GetString(2),
					sqlDataReader.GetString(3), sqlDataReader.GetString(4),
					contactFormStatus);

				return contactForm;
			}
			return null;
		}

		public void UpdateContactForm(ContactForm contactForm)
		{
			foreach (ContactForm item in ReadContactForms())
			{
				if (item.Id == contactForm.Id)
				{
					SqlConnection sqlConnection = new SqlConnection(connectionString);
					sqlConnection.Open();

					string query = "Update contact_form SET name=@name,email=@email, question=@question,answer=@answer, contact_form_status_id=@contact_form_status_id where contact_form_id='" + contactForm.Id + "'";

					SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
					sqlCommand.Parameters.AddWithValue("@name", contactForm.Name);
					sqlCommand.Parameters.AddWithValue("@email", contactForm.Email);
					sqlCommand.Parameters.AddWithValue("@question", contactForm.Question);
					sqlCommand.Parameters.AddWithValue("@answer", contactForm.Answer);
					sqlCommand.Parameters.AddWithValue("@contact_form_status_id", contactForm.ContactFormStatus);

					sqlCommand.ExecuteNonQuery();
					sqlConnection.Close();
				}
			}
		}


	}
}
    