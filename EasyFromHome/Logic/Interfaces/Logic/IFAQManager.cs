using Logic.Classes.Home.FAQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Interfaces.Logic
{
    public interface IFAQManager
    {
        void AddFAQ(FAQ faq);
        List<FAQ> GetAllFAQs();
        void RemoveFAQ(FAQ faq);
        void EditFAQ(FAQ faq);
        FAQ GetFAQ(int id);
    }
}
