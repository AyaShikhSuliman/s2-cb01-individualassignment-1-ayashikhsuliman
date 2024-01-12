using Logic.Classes.Home.Contact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Interfaces.Logic
{
    public interface IContactFormManager
    {
		void SendContactForm(ContactForm contactForm);
		List<ContactForm> ShowContactForms();
		ContactForm GetForm(int id);
		void AnswerContactForm(ContactForm contactForm);
	}
}
