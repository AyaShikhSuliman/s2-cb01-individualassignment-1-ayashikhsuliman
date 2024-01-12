using Logic.Classes.Home.Contact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Interfaces.Data
{
	public interface IContactFormDBManager
	{
		void CreateContactForm(ContactForm contactForm);
		List<ContactForm> ReadContactForms();
		ContactForm GetContactForm(int id);
		void UpdateContactForm(ContactForm contactForm);
	}
}
