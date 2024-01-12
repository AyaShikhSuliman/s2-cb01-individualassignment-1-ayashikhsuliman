using Logic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Classes.Home.Contact
{
	public class ContactForm
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string Question { get; set; }
		public string? Answer { get; set; }
		public ContactFormStatus ContactFormStatus { get; set; }

		public ContactForm()
		{
		}

		public ContactForm(int id, string name, string email, string question, string? answer, ContactFormStatus contactFormStatus)
		{
			Id = id;
			Name = name;
			Email = email;
			Question = question;
			Answer = answer;
			ContactFormStatus = contactFormStatus;
		}
	}
}
