namespace DesktopApplication
{
    partial class GeneralWorkoutsForm
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
			this.lvWorkouts = new System.Windows.Forms.ListView();
			this.lblWorkouts = new System.Windows.Forms.Label();
			this.lblTitle = new System.Windows.Forms.Label();
			this.tbTitle = new System.Windows.Forms.TextBox();
			this.lblBodyMuscles = new System.Windows.Forms.Label();
			this.lblSportType = new System.Windows.Forms.Label();
			this.cbBodyMuscles = new System.Windows.Forms.ComboBox();
			this.cbSportType = new System.Windows.Forms.ComboBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lvWorkouts
			// 
			this.lvWorkouts.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lvWorkouts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
			this.lvWorkouts.FullRowSelect = true;
			this.lvWorkouts.Location = new System.Drawing.Point(67, 163);
			this.lvWorkouts.Name = "lvWorkouts";
			this.lvWorkouts.Size = new System.Drawing.Size(830, 339);
			this.lvWorkouts.TabIndex = 0;
			this.lvWorkouts.UseCompatibleStateImageBehavior = false;
			this.lvWorkouts.SelectedIndexChanged += new System.EventHandler(this.lvWorkouts_SelectedIndexChanged);
			// 
			// lblWorkouts
			// 
			this.lblWorkouts.AutoSize = true;
			this.lblWorkouts.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblWorkouts.ForeColor = System.Drawing.Color.White;
			this.lblWorkouts.Location = new System.Drawing.Point(67, 65);
			this.lblWorkouts.Name = "lblWorkouts";
			this.lblWorkouts.Size = new System.Drawing.Size(109, 24);
			this.lblWorkouts.TabIndex = 1;
			this.lblWorkouts.Text = "Workouts:";
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblTitle.ForeColor = System.Drawing.Color.White;
			this.lblTitle.Location = new System.Drawing.Point(668, 109);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(58, 24);
			this.lblTitle.TabIndex = 2;
			this.lblTitle.Text = "Title:";
			// 
			// tbTitle
			// 
			this.tbTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.tbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
			this.tbTitle.Location = new System.Drawing.Point(732, 107);
			this.tbTitle.Name = "tbTitle";
			this.tbTitle.Size = new System.Drawing.Size(165, 30);
			this.tbTitle.TabIndex = 3;
			this.tbTitle.TextChanged += new System.EventHandler(this.tbName_TextChanged);
			// 
			// lblBodyMuscles
			// 
			this.lblBodyMuscles.AutoSize = true;
			this.lblBodyMuscles.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblBodyMuscles.ForeColor = System.Drawing.Color.White;
			this.lblBodyMuscles.Location = new System.Drawing.Point(356, 109);
			this.lblBodyMuscles.Name = "lblBodyMuscles";
			this.lblBodyMuscles.Size = new System.Drawing.Size(139, 24);
			this.lblBodyMuscles.TabIndex = 4;
			this.lblBodyMuscles.Text = "Body Muscle:";
			// 
			// lblSportType
			// 
			this.lblSportType.AutoSize = true;
			this.lblSportType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblSportType.ForeColor = System.Drawing.Color.White;
			this.lblSportType.Location = new System.Drawing.Point(67, 109);
			this.lblSportType.Name = "lblSportType";
			this.lblSportType.Size = new System.Drawing.Size(116, 24);
			this.lblSportType.TabIndex = 5;
			this.lblSportType.Text = "Sport type:";
			// 
			// cbBodyMuscles
			// 
			this.cbBodyMuscles.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.cbBodyMuscles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
			this.cbBodyMuscles.FormattingEnabled = true;
			this.cbBodyMuscles.Location = new System.Drawing.Point(501, 106);
			this.cbBodyMuscles.Name = "cbBodyMuscles";
			this.cbBodyMuscles.Size = new System.Drawing.Size(151, 31);
			this.cbBodyMuscles.TabIndex = 6;
			this.cbBodyMuscles.SelectedIndexChanged += new System.EventHandler(this.cbBodyMuscles_SelectedIndexChanged);
			this.cbBodyMuscles.TextChanged += new System.EventHandler(this.cbBodyMuscles_TextChanged);
			// 
			// cbSportType
			// 
			this.cbSportType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.cbSportType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
			this.cbSportType.FormattingEnabled = true;
			this.cbSportType.Location = new System.Drawing.Point(189, 106);
			this.cbSportType.Name = "cbSportType";
			this.cbSportType.Size = new System.Drawing.Size(151, 31);
			this.cbSportType.TabIndex = 7;
			this.cbSportType.SelectedIndexChanged += new System.EventHandler(this.cbSportType_SelectedIndexChanged);
			this.cbSportType.TextChanged += new System.EventHandler(this.cbSportType_TextChanged);
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
			this.btnAdd.FlatAppearance.BorderSize = 0;
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnAdd.ForeColor = System.Drawing.Color.White;
			this.btnAdd.Location = new System.Drawing.Point(658, 528);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(239, 42);
			this.btnAdd.TabIndex = 8;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
			this.btnDelete.FlatAppearance.BorderSize = 0;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnDelete.ForeColor = System.Drawing.Color.White;
			this.btnDelete.Location = new System.Drawing.Point(67, 528);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(239, 42);
			this.btnDelete.TabIndex = 9;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
			this.btnEdit.FlatAppearance.BorderSize = 0;
			this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEdit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnEdit.ForeColor = System.Drawing.Color.White;
			this.btnEdit.Location = new System.Drawing.Point(356, 528);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(239, 42);
			this.btnEdit.TabIndex = 10;
			this.btnEdit.Text = "Edit";
			this.btnEdit.UseVisualStyleBackColor = false;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// GeneralWorkoutsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(148)))), ((int)(((byte)(110)))));
			this.ClientSize = new System.Drawing.Size(970, 637);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.cbSportType);
			this.Controls.Add(this.cbBodyMuscles);
			this.Controls.Add(this.lblSportType);
			this.Controls.Add(this.lblBodyMuscles);
			this.Controls.Add(this.tbTitle);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.lblWorkouts);
			this.Controls.Add(this.lvWorkouts);
			this.ForeColor = System.Drawing.Color.White;
			this.Name = "GeneralWorkoutsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "General workouts";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WorkoutsForm_FormClosing);
			this.Load += new System.EventHandler(this.WorkoutsForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private ListView lvWorkouts;
        private Label lblWorkouts;
        private Label lblTitle;
        private TextBox tbTitle;
        private Label lblBodyMuscles;
        private Label lblSportType;
        private ComboBox cbBodyMuscles;
        private ComboBox cbSportType;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnEdit;
	}
}