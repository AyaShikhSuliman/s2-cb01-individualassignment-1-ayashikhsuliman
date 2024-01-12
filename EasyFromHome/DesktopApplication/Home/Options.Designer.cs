namespace DesktopApplication
{
    partial class HomeOptionsForm
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
            this.btnFAQ = new System.Windows.Forms.Button();
            this.btnContactForms = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFAQ
            // 
            this.btnFAQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.btnFAQ.FlatAppearance.BorderSize = 0;
            this.btnFAQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFAQ.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFAQ.ForeColor = System.Drawing.Color.White;
            this.btnFAQ.Location = new System.Drawing.Point(359, 244);
            this.btnFAQ.Name = "btnFAQ";
            this.btnFAQ.Size = new System.Drawing.Size(239, 63);
            this.btnFAQ.TabIndex = 0;
            this.btnFAQ.Text = "FAQ";
            this.btnFAQ.UseVisualStyleBackColor = false;
            this.btnFAQ.Click += new System.EventHandler(this.btnFAQ_Click);
            // 
            // btnContactForms
            // 
            this.btnContactForms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.btnContactForms.FlatAppearance.BorderSize = 0;
            this.btnContactForms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContactForms.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnContactForms.ForeColor = System.Drawing.Color.White;
            this.btnContactForms.Location = new System.Drawing.Point(359, 327);
            this.btnContactForms.Name = "btnContactForms";
            this.btnContactForms.Size = new System.Drawing.Size(239, 63);
            this.btnContactForms.TabIndex = 2;
            this.btnContactForms.Text = "Contact Forms";
            this.btnContactForms.UseVisualStyleBackColor = false;
            this.btnContactForms.Click += new System.EventHandler(this.btnContact_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DesktopApplication.Properties.Resources.image__20_1;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(980, 643);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // HomeOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(970, 637);
            this.Controls.Add(this.btnContactForms);
            this.Controls.Add(this.btnFAQ);
            this.Controls.Add(this.pictureBox1);
            this.Name = "HomeOptionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeOptions";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomeOptionsForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnFAQ;
        private Button btnContactForms;
        private PictureBox pictureBox1;
    }
}