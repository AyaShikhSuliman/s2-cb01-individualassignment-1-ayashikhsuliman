namespace DesktopApplication
{
    partial class GeneralFAQForm
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblFAQs = new System.Windows.Forms.Label();
            this.lvFAQs = new System.Windows.Forms.ListView();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbQuestion = new System.Windows.Forms.TextBox();
            this.bnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(67, 527);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(239, 42);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(658, 527);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(239, 42);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblId.ForeColor = System.Drawing.Color.White;
            this.lblId.Location = new System.Drawing.Point(67, 109);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(34, 24);
            this.lblId.TabIndex = 16;
            this.lblId.Text = "Id:";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQuestion.ForeColor = System.Drawing.Color.White;
            this.lblQuestion.Location = new System.Drawing.Point(258, 109);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(103, 24);
            this.lblQuestion.TabIndex = 15;
            this.lblQuestion.Text = "Question:";
            // 
            // tbAnswer
            // 
            this.tbAnswer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbAnswer.Location = new System.Drawing.Point(666, 106);
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.Size = new System.Drawing.Size(231, 30);
            this.tbAnswer.TabIndex = 14;
            this.tbAnswer.TextChanged += new System.EventHandler(this.tbAnswer_TextChanged);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAnswer.ForeColor = System.Drawing.Color.White;
            this.lblAnswer.Location = new System.Drawing.Point(573, 109);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(87, 24);
            this.lblAnswer.TabIndex = 13;
            this.lblAnswer.Text = "Answer:";
            // 
            // lblFAQs
            // 
            this.lblFAQs.AutoSize = true;
            this.lblFAQs.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFAQs.ForeColor = System.Drawing.Color.White;
            this.lblFAQs.Location = new System.Drawing.Point(67, 65);
            this.lblFAQs.Name = "lblFAQs";
            this.lblFAQs.Size = new System.Drawing.Size(57, 24);
            this.lblFAQs.TabIndex = 12;
            this.lblFAQs.Text = "FAQ:";
            // 
            // lvFAQs
            // 
            this.lvFAQs.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvFAQs.FullRowSelect = true;
            this.lvFAQs.Location = new System.Drawing.Point(67, 163);
            this.lvFAQs.Name = "lvFAQs";
            this.lvFAQs.Size = new System.Drawing.Size(830, 339);
            this.lvFAQs.TabIndex = 11;
            this.lvFAQs.UseCompatibleStateImageBehavior = false;
            this.lvFAQs.SelectedIndexChanged += new System.EventHandler(this.lvFAQs_SelectedIndexChanged);
            // 
            // tbId
            // 
            this.tbId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbId.Location = new System.Drawing.Point(107, 106);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(125, 30);
            this.tbId.TabIndex = 22;
            this.tbId.TextChanged += new System.EventHandler(this.tbId_TextChanged);
            // 
            // tbQuestion
            // 
            this.tbQuestion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbQuestion.Location = new System.Drawing.Point(367, 106);
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.Size = new System.Drawing.Size(180, 30);
            this.tbQuestion.TabIndex = 23;
            this.tbQuestion.TextChanged += new System.EventHandler(this.tbQuestion_TextChanged);
            // 
            // bnEdit
            // 
            this.bnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.bnEdit.FlatAppearance.BorderSize = 0;
            this.bnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnEdit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bnEdit.ForeColor = System.Drawing.Color.White;
            this.bnEdit.Location = new System.Drawing.Point(367, 527);
            this.bnEdit.Name = "bnEdit";
            this.bnEdit.Size = new System.Drawing.Size(239, 42);
            this.bnEdit.TabIndex = 24;
            this.bnEdit.Text = "Edit";
            this.bnEdit.UseVisualStyleBackColor = false;
            this.bnEdit.Click += new System.EventHandler(this.bnEdit_Click);
            // 
            // GeneralFAQForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(148)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(970, 637);
            this.Controls.Add(this.bnEdit);
            this.Controls.Add(this.tbQuestion);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.tbAnswer);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblFAQs);
            this.Controls.Add(this.lvFAQs);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "GeneralFAQForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "General FAQ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FAQForm_FormClosing);
            this.Load += new System.EventHandler(this.FAQForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnDelete;
        private Button btnAdd;
        private Label lblId;
        private Label lblQuestion;
        private TextBox tbAnswer;
        private Label lblAnswer;
        private Label lblFAQs;
        private ListView lvFAQs;
        private TextBox tbId;
        private TextBox tbQuestion;
        private Button bnEdit;
    }
}