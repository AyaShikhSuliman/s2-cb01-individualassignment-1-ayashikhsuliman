using Logic.Classes.Home.FAQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Interfaces.Data
{
    public interface IFaqDBManager
    {
        void CreateFAQ(FAQ faq);
        List<FAQ> ReadFAQs();
        void UpdateFAQ(FAQ faq);
        void DeleteFAQ(FAQ faq);
        FAQ GetFAQ(int id);
    }
}
