namespace The_amazing_of_numbers.Area.Student.View
{
    partial class StudentForm_Progess
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
            this.StudentProgress = new Guna.UI2.WinForms.Guna2Panel();
            this.AchievementButton = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.StudentProgress.SuspendLayout();
            this.SuspendLayout();
            // 
            // StudentProgress
            // 
            this.StudentProgress.Controls.Add(this.AchievementButton);
            this.StudentProgress.Controls.Add(this.label2);
            this.StudentProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StudentProgress.Location = new System.Drawing.Point(0, 0);
            this.StudentProgress.Name = "StudentProgress";
            this.StudentProgress.Size = new System.Drawing.Size(1066, 702);
            this.StudentProgress.TabIndex = 0;
            // 
            // AchievementButton
            // 
            this.AchievementButton.Animated = true;
            this.AchievementButton.AutoRoundedCorners = true;
            this.AchievementButton.BackColor = System.Drawing.Color.Transparent;
            this.AchievementButton.BorderRadius = 22;
            this.AchievementButton.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.AchievementButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AchievementButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AchievementButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AchievementButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AchievementButton.Font = new System.Drawing.Font("Nunito", 11.25F, System.Drawing.FontStyle.Bold);
            this.AchievementButton.ForeColor = System.Drawing.Color.White;
            this.AchievementButton.Location = new System.Drawing.Point(737, 127);
            this.AchievementButton.Name = "AchievementButton";
            this.AchievementButton.Size = new System.Drawing.Size(128, 47);
            this.AchievementButton.TabIndex = 8;
            this.AchievementButton.Text = "Achievement";
            this.AchievementButton.UseTransparentBackground = true;
            this.AchievementButton.Click += new System.EventHandler(this.AchievementButton_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nunito", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(449, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Progress";
            // 
            // StudentForm_Progess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 702);
            this.Controls.Add(this.StudentProgress);
            this.Name = "StudentForm_Progess";
            this.Text = "StudentForm_Progess";
            this.Load += new System.EventHandler(this.StudentForm_Progess_Load);
            this.StudentProgress.ResumeLayout(false);
            this.StudentProgress.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel StudentProgress;
        private Guna.UI2.WinForms.Guna2Button AchievementButton;
        private System.Windows.Forms.Label label2;
    }
}