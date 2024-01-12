using Logic.Classes.Home.FAQ;
using Logic.Classes.Login;
using Logic.Enums;
using Logic.Interfaces.Data;
using Logic.Interfaces.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Classes.Home.Contact
{
    public class ContactFormManager : IContactFormManager
    {
        private IContactFormDBManager _ContactFormDBManager;

        public ContactFormManager(IContactFormDBManager ContactFormDBManager)
        {
            _ContactFormDBManager = ContactFormDBManager;
        }

		public void SendContactForm(ContactForm contactForm)
        {
            _ContactFormDBManager.CreateContactForm(contactForm);
		}

		public List<ContactForm> ShowContactForms()
        {
			return _ContactFormDBManager.ReadContactForms();
		}

		public ContactForm GetForm(int id)
        {
            return _ContactFormDBManager.GetContactForm(id);
        }

		public void AnswerContactForm(ContactForm contactForm)
        {
			_ContactFormDBManager.UpdateContactForm(contactForm);

		}
	}
}
