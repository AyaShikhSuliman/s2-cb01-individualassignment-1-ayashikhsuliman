using Logic.Classes.Workout;
using Logic.Enums;
using Logic.Interfaces.Data;
using Logic.Interfaces.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Classes.Home.FAQ
{
    public class FAQManager: IFAQManager
    {
        private IFaqDBManager dBFaq;

        public FAQManager(IFaqDBManager dBFaq)
        {
            this.dBFaq = dBFaq;
        }

        public void AddFAQ(FAQ faq)
        {
            dBFaq.CreateFAQ(faq);
        }

        public List<FAQ> GetAllFAQs()
        {
            return dBFaq.ReadFAQs();
        }

        public void RemoveFAQ(FAQ faq)
        {
            dBFaq.DeleteFAQ(faq);
        }

        public void EditFAQ(FAQ faq)
        {
            dBFaq.UpdateFAQ(faq);
        }

        public FAQ GetFAQ(int id)
        {
            FAQ faq = dBFaq.GetFAQ(id);
            if (faq.Id != 0)
            {
                return faq;
            }
            return null;
        }
    }
}
