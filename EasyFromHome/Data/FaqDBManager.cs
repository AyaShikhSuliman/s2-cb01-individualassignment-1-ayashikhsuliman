using Logic.Classes.Home.FAQ;
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
    public class FaqDBManager : IFaqDBManager
    {
        private string connectionString = "Server=mssqlstud.fhict.local;Database=dbi495487;User Id=dbi495487;Password=myDatabase123";

        public void CreateFAQ(FAQ faq)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            string query = "insert into faq values (@question, @answer)";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            sqlCommand.Parameters.AddWithValue("@question", faq.Question);
            sqlCommand.Parameters.AddWithValue("@answer", faq.Answer);

            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public List<FAQ> ReadFAQs()
        {
            List<FAQ> faqs = new List<FAQ>();
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            string query = " select faq_id,question,answer from faq";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                FAQ faq = new FAQ(sqlDataReader.GetInt32(0), sqlDataReader.GetString(1), sqlDataReader.GetString(2));

                faqs.Add(faq);
            }

            return faqs;
        }

        public void UpdateFAQ(FAQ faq)
        {
            foreach (FAQ item in ReadFAQs())
            {
                if (item.Id == faq.Id)
                {
                    SqlConnection sqlConnection = new SqlConnection(connectionString);
                    sqlConnection.Open();

                    string query = "Update faq SET question=@question,answer=@answer where faq_id='" + faq.Id + "'";

                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@question", faq.Question);
                    sqlCommand.Parameters.AddWithValue("@answer", faq.Answer);

                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                }
            }
        }

        public void DeleteFAQ(FAQ faq)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            string query = "Delete From faq where faq_id ='" + faq.Id + "'";

            using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
            {
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }

        public FAQ GetFAQ(int id)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            string query = "select faq_id,question,answer from faq where faq_id=@id";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            sqlCommand.Parameters.AddWithValue("@id", id);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                FAQ faq = new FAQ(sqlDataReader.GetInt32(0), sqlDataReader.GetString(1), sqlDataReader.GetString(2));

                return faq;
            }
            return null;
        }
    }
}
