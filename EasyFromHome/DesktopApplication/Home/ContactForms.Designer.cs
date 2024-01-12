namespace DesktopApplication
{
    partial class ContactForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.btnAnswerQuestion = new System.Windows.Forms.Button();
			this.tbAnswer = new System.Windows.Forms.TextBox();
			this.lblAnswer = new System.Windows.Forms.Label();
			this.lblContact = new System.Windows.Forms.Label();
			this.lvContactForms = new System.Windows.Forms.ListView();
			this.lblId = new System.Windows.Forms.Label();
			this.lblname = new System.Windows.Forms.Label();
			this.lblemail = new System.Windows.Forms.Label();
			this.lblquestion = new System.Windows.Forms.Label();
			this.lblstatus = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnAnswerQuestion
			// 
			this.btnAnswerQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
			this.btnAnswerQuestion.FlatAppearance.BorderSize = 0;
			this.btnAnswerQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAnswerQuestion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnAnswerQuestion.ForeColor = System.Drawing.Color.White;
			this.btnAnswerQuestion.Location = new System.Drawing.Point(70, 560);
			this.btnAnswerQuestion.Name = "btnAnswerQuestion";
			this.btnAnswerQuestion.Size = new System.Drawing.Size(830, 42);
			this.btnAnswerQuestion.TabIndex = 19;
			this.btnAnswerQuestion.Text = "Answer Question";
			this.btnAnswerQuestion.UseVisualStyleBackColor = false;
			this.btnAnswerQuestion.Click += new System.EventHandler(this.btnAnswerQuestion_Click);
			// 
			// tbAnswer
			// 
			this.tbAnswer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.tbAnswer.Location = new System.Drawing.Point(70, 428);
			this.tbAnswer.Multiline = true;
			this.tbAnswer.Name = "tbAnswer";
			this.tbAnswer.Size = new System.Drawing.Size(830, 105);
			this.tbAnswer.TabIndex = 26;
			// 
			// lblAnswer
			// 
			this.lblAnswer.AutoSize = true;
			this.lblAnswer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblAnswer.ForeColor = System.Drawing.Color.White;
			this.lblAnswer.Location = new System.Drawing.Point(81, 306);
			this.lblAnswer.Name = "lblAnswer";
			this.lblAnswer.Size = new System.Drawing.Size(87, 24);
			this.lblAnswer.TabIndex = 27;
			this.lblAnswer.Text = "Answer:";
			// 
			// lblContact
			// 
			this.lblContact.AutoSize = true;
			this.lblContact.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblContact.ForeColor = System.Drawing.Color.White;
			this.lblContact.Location = new System.Drawing.Point(70, 19);
			this.lblContact.Name = "lblContact";
			this.lblContact.Size = new System.Drawing.Size(157, 24);
			this.lblContact.TabIndex = 12;
			this.lblContact.Text = "Contact Forms:";
			// 
			// lvContactForms
			// 
			this.lvContactForms.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lvContactForms.FullRowSelect = true;
			this.lvContactForms.Location = new System.Drawing.Point(70, 56);
			this.lvContactForms.Name = "lvContactForms";
			this.lvContactForms.Size = new System.Drawing.Size(830, 213);
			this.lvContactForms.TabIndex = 11;
			this.lvContactForms.UseCompatibleStateImageBehavior = false;
			this.lvContactForms.SelectedIndexChanged += new System.EventHandler(this.lvContactForms_SelectedIndexChanged);
			// 
			// lblId
			// 
			this.lblId.AutoSize = true;
			this.lblId.Location = new System.Drawing.Point(81, 340);
			this.lblId.Name = "lblId";
			this.lblId.Size = new System.Drawing.Size(22, 20);
			this.lblId.TabIndex = 28;
			this.lblId.Text = "Id";
			// 
			// lblname
			// 
			this.lblname.AutoSize = true;
			this.lblname.Location = new System.Drawing.Point(81, 370);
			this.lblname.Name = "lblname";
			this.lblname.Size = new System.Drawing.Size(46, 20);
			this.lblname.TabIndex = 29;
			this.lblname.Text = "name";
			// 
			// lblemail
			// 
			this.lblemail.AutoSize = true;
			this.lblemail.Location = new System.Drawing.Point(481, 340);
			this.lblemail.Name = "lblemail";
			this.lblemail.Size = new System.Drawing.Size(46, 20);
			this.lblemail.TabIndex = 30;
			this.lblemail.Text = "email";
			// 
			// lblquestion
			// 
			this.lblquestion.AutoSize = true;
			this.lblquestion.Location = new System.Drawing.Point(481, 370);
			this.lblquestion.Name = "lblquestion";
			this.lblquestion.Size = new System.Drawing.Size(66, 20);
			this.lblquestion.TabIndex = 31;
			this.lblquestion.Text = "question";
			// 
			// lblstatus
			// 
			this.lblstatus.AutoSize = true;
			this.lblstatus.Location = new System.Drawing.Point(743, 340);
			this.lblstatus.Name = "lblstatus";
			this.lblstatus.Size = new System.Drawing.Size(47, 20);
			this.lblstatus.TabIndex = 32;
			this.lblstatus.Text = "status";
			// 
			// ContactForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(148)))), ((int)(((byte)(110)))));
			this.ClientSize = new System.Drawing.Size(970, 637);
			this.Controls.Add(this.lblstatus);
			this.Controls.Add(this.lblquestion);
			this.Controls.Add(this.lblemail);
			this.Controls.Add(this.lblname);
			this.Controls.Add(this.lblId);
			this.Controls.Add(this.lblAnswer);
			this.Controls.Add(this.tbAnswer);
			this.Controls.Add(this.btnAnswerQuestion);
			this.Controls.Add(this.lblContact);
			this.Controls.Add(this.lvContactForms);
			this.ForeColor = System.Drawing.Color.White;
			this.Name = "ContactForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Contact";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ContactForm_FormClosing);
			this.Load += new System.EventHandler(this.ContactForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private Button btnAnswerQuestion;
		private TextBox tbAnswer;
		private Label lblContact;
		private ListView lvContactForms;
		private Label lblAnswer;
		private Label lblId;
		private Label lblname;
		private Label lblemail;
		private Label lblquestion;
		private Label lblstatus;
	}
}