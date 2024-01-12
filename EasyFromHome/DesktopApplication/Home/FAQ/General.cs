using Data;
using DesktopApplication.Home.FAQ;
using Logic.Classes.Home.FAQ;
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

namespace DesktopApplication
{
    public partial class GeneralFAQForm : Form
    {
        private DataTable dataTable;
        private DataView dataView;
        private FAQ _selectedFAQFromLV;
        private IFAQManager faQManager;

        public GeneralFAQForm()
        {
            InitializeComponent();

            faQManager = new FAQManager(new FaqDBManager());

            //Listview properties
            lvFAQs.View = View.Details;
            lvFAQs.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            //Add columns
            lvFAQs.Columns.Add("ID", 50);
            lvFAQs.Columns.Add("Question", 150);
            lvFAQs.Columns.Add("Answer", 150);

            //Initialize dataTable and add columns
            dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Question");
            dataTable.Columns.Add("Answer");
        }

        private void PopulateListView(DataView dataView)
        {
            lvFAQs.Items.Clear();

            foreach (DataRow row in dataView.ToTable().Rows)
            {
                lvFAQs.Items.Add(new ListViewItem(new String[] { row[0].ToString(), row[1].ToString(), row[2].ToString() }));
            }
        }

        private void FAQForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            HomeOptionsForm homeOptionsForm = new HomeOptionsForm();
            homeOptionsForm.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddFAQForm addFAQForm = new AddFAQForm();
            addFAQForm.Show();
            this.Hide();
        }

        private void FAQForm_Load(object sender, EventArgs e)
        {
            dataTable.Clear();
            if (faQManager != null)
            {
                foreach (FAQ faq in faQManager.GetAllFAQs())
                {
                    dataTable.Rows.Add(faq.Id, faq.Question, faq.Answer);
                }

                dataView = new DataView(dataTable);
                PopulateListView(dataView);
            }
        }

        private void tbId_TextChanged(object sender, EventArgs e)
        {
            dataView.RowFilter = String.Format("Id Like '%{0}%'", tbId.Text);
            PopulateListView(dataView);
        }

        private void tbQuestion_TextChanged(object sender, EventArgs e)
        {
            dataView.RowFilter = String.Format("Question Like '%{0}%'", tbQuestion.Text);
            PopulateListView(dataView);
        }

        private void tbAnswer_TextChanged(object sender, EventArgs e)
        {
            dataView.RowFilter = String.Format("Answer Like '%{0}%'", tbAnswer.Text);
            PopulateListView(dataView);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvFAQs.SelectedItems.Count > 0)
            {
                var confirmation = MessageBox.Show($"Are you sure you want to delete this FAQ?",
                    "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmation == DialogResult.Yes)
                {
                    if (lvFAQs.SelectedItems.Count == 0)
                    {
                        return;
                    }

                    int id = int.Parse(lvFAQs.SelectedItems[0].SubItems[0].Text);
                    FAQ faq = faQManager.GetFAQ(id);
                    faQManager.RemoveFAQ(faq);

                    for (int i = lvFAQs.SelectedItems.Count - 1; i >= 0; i--)
                    {
                        ListViewItem listViewItem = lvFAQs.SelectedItems[i];
                        lvFAQs.Items[listViewItem.Index].Remove();
                    }
                }
            }
            else
            {
                MessageBox.Show("Select a FAQ first!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bnEdit_Click(object sender, EventArgs e)
        {
            EditFAQForm editFAQForm = new EditFAQForm(_selectedFAQFromLV);
            editFAQForm.Show();
            this.Hide();
        }

        private void lvFAQs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvFAQs.SelectedItems.Count == 0)
            {
                return;
            }

            int id = int.Parse(lvFAQs.SelectedItems[0].SubItems[0].Text);
            FAQ faq = faQManager.GetFAQ(id);
            _selectedFAQFromLV = faq;
        }
    }
}