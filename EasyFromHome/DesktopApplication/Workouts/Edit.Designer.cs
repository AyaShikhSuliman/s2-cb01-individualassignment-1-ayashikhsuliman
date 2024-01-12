namespace DesktopApplication.Workouts
{
    partial class EditWorkoutForm
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
            this.lblEdit = new System.Windows.Forms.Label();
            this.lblSportType = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblBodyMuscle = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbBodyMuscle = new System.Windows.Forms.TextBox();
            this.tbSportType = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEdit.ForeColor = System.Drawing.Color.White;
            this.lblEdit.Location = new System.Drawing.Point(122, 64);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(154, 24);
            this.lblEdit.TabIndex = 0;
            this.lblEdit.Text = "Edit a workout:";
            // 
            // lblSportType
            // 
            this.lblSportType.AutoSize = true;
            this.lblSportType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSportType.ForeColor = System.Drawing.Color.White;
            this.lblSportType.Location = new System.Drawing.Point(122, 160);
            this.lblSportType.Name = "lblSportType";
            this.lblSportType.Size = new System.Drawing.Size(116, 24);
            this.lblSportType.TabIndex = 1;
            this.lblSportType.Text = "Sport type:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(122, 323);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(125, 24);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(122, 268);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(58, 24);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Title:";
            // 
            // lblBodyMuscle
            // 
            this.lblBodyMuscle.AutoSize = true;
            this.lblBodyMuscle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBodyMuscle.ForeColor = System.Drawing.Color.White;
            this.lblBodyMuscle.Location = new System.Drawing.Point(122, 214);
            this.lblBodyMuscle.Name = "lblBodyMuscle";
            this.lblBodyMuscle.Size = new System.Drawing.Size(139, 24);
            this.lblBodyMuscle.TabIndex = 4;
            this.lblBodyMuscle.Text = "Body muscle:";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(122, 471);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(715, 42);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // tbDescription
            // 
            this.tbDescription.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbDescription.Location = new System.Drawing.Point(287, 320);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(550, 115);
            this.tbDescription.TabIndex = 11;
            // 
            // tbTitle
            // 
            this.tbTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbTitle.Location = new System.Drawing.Point(287, 265);
            this.tbTitle.Multiline = true;
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(550, 33);
            this.tbTitle.TabIndex = 10;
            // 
            // tbBodyMuscle
            // 
            this.tbBodyMuscle.Enabled = false;
            this.tbBodyMuscle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbBodyMuscle.Location = new System.Drawing.Point(287, 211);
            this.tbBodyMuscle.Multiline = true;
            this.tbBodyMuscle.Name = "tbBodyMuscle";
            this.tbBodyMuscle.Size = new System.Drawing.Size(550, 33);
            this.tbBodyMuscle.TabIndex = 12;
            // 
            // tbSportType
            // 
            this.tbSportType.Enabled = false;
            this.tbSportType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbSportType.Location = new System.Drawing.Point(287, 157);
            this.tbSportType.Multiline = true;
            this.tbSportType.Name = "tbSportType";
            this.tbSportType.Size = new System.Drawing.Size(550, 33);
            this.tbSportType.TabIndex = 13;
            // 
            // tbId
            // 
            this.tbId.Enabled = false;
            this.tbId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbId.Location = new System.Drawing.Point(287, 103);
            this.tbId.Multiline = true;
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(550, 33);
            this.tbId.TabIndex = 15;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblId.ForeColor = System.Drawing.Color.White;
            this.lblId.Location = new System.Drawing.Point(122, 106);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(34, 24);
            this.lblId.TabIndex = 14;
            this.lblId.Text = "Id:";
            // 
            // EditWorkoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(148)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(970, 637);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.tbSportType);
            this.Controls.Add(this.tbBodyMuscle);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblBodyMuscle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblSportType);
            this.Controls.Add(this.lblEdit);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "EditWorkoutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit workout";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditWorkoutForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblEdit;
        private Label lblSportType;
        private Label lblDescription;
        private Label lblTitle;
        private Label lblBodyMuscle;
        private Button btnEdit;
        private TextBox tbDescription;
        private TextBox tbTitle;
        private TextBox tbBodyMuscle;
        private TextBox tbSportType;
        private TextBox tbId;
        private Label lblId;
    }
}