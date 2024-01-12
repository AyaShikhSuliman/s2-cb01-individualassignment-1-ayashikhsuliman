namespace DesktopApplication.Home.Workouts
{
    partial class AddWorkoutForm
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
            this.lblSportType = new System.Windows.Forms.Label();
            this.lblBodyMuscle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblAdd = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.cbSportType = new System.Windows.Forms.ComboBox();
            this.cbBodyMuscle = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSportType
            // 
            this.lblSportType.AutoSize = true;
            this.lblSportType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSportType.ForeColor = System.Drawing.Color.White;
            this.lblSportType.Location = new System.Drawing.Point(122, 160);
            this.lblSportType.Name = "lblSportType";
            this.lblSportType.Size = new System.Drawing.Size(116, 24);
            this.lblSportType.TabIndex = 0;
            this.lblSportType.Text = "Sport type:";
            // 
            // lblBodyMuscle
            // 
            this.lblBodyMuscle.AutoSize = true;
            this.lblBodyMuscle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBodyMuscle.ForeColor = System.Drawing.Color.White;
            this.lblBodyMuscle.Location = new System.Drawing.Point(122, 214);
            this.lblBodyMuscle.Name = "lblBodyMuscle";
            this.lblBodyMuscle.Size = new System.Drawing.Size(139, 24);
            this.lblBodyMuscle.TabIndex = 1;
            this.lblBodyMuscle.Text = "Body muscle:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(122, 268);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(58, 24);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(122, 322);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(125, 24);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description:";
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAdd.ForeColor = System.Drawing.Color.White;
            this.lblAdd.Location = new System.Drawing.Point(122, 64);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(154, 24);
            this.lblAdd.TabIndex = 4;
            this.lblAdd.Text = "Add a workout:";
            // 
            // tbDescription
            // 
            this.tbDescription.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbDescription.Location = new System.Drawing.Point(275, 319);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(550, 115);
            this.tbDescription.TabIndex = 6;
            // 
            // cbSportType
            // 
            this.cbSportType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbSportType.FormattingEnabled = true;
            this.cbSportType.Location = new System.Drawing.Point(275, 160);
            this.cbSportType.Name = "cbSportType";
            this.cbSportType.Size = new System.Drawing.Size(550, 31);
            this.cbSportType.TabIndex = 7;
            // 
            // cbBodyMuscle
            // 
            this.cbBodyMuscle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbBodyMuscle.FormattingEnabled = true;
            this.cbBodyMuscle.Location = new System.Drawing.Point(275, 211);
            this.cbBodyMuscle.Name = "cbBodyMuscle";
            this.cbBodyMuscle.Size = new System.Drawing.Size(550, 31);
            this.cbBodyMuscle.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(110, 470);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(715, 42);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbTitle
            // 
            this.tbTitle.AcceptsReturn = true;
            this.tbTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbTitle.Location = new System.Drawing.Point(275, 268);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(550, 30);
            this.tbTitle.TabIndex = 10;
            // 
            // AddWorkoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(148)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(970, 637);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbBodyMuscle);
            this.Controls.Add(this.cbSportType);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblBodyMuscle);
            this.Controls.Add(this.lblSportType);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "AddWorkoutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddWorkout";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddWorkoutForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblSportType;
        private Label lblBodyMuscle;
        private Label lblTitle;
        private Label lblDescription;
        private Label lblAdd;
        private TextBox tbDescription;
        private ComboBox cbSportType;
        private ComboBox cbBodyMuscle;
        private Button btnAdd;
        private TextBox tbTitle;
    }
}