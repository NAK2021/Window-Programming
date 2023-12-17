namespace The_amazing_of_numbers.Area.Student.View
{
    partial class ProfileEdition
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
            this.ProfileUser_Info = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.EditInfoBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ProfileUser_Info.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProfileUser_Info
            // 
            this.ProfileUser_Info.AutoScroll = true;
            this.ProfileUser_Info.BorderRadius = 60;
            this.ProfileUser_Info.Controls.Add(this.EditInfoBtn);
            this.ProfileUser_Info.Controls.Add(this.label1);
            this.ProfileUser_Info.CustomizableEdges.BottomLeft = false;
            this.ProfileUser_Info.CustomizableEdges.BottomRight = false;
            this.ProfileUser_Info.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ProfileUser_Info.Location = new System.Drawing.Point(0, 62);
            this.ProfileUser_Info.Name = "ProfileUser_Info";
            this.ProfileUser_Info.Size = new System.Drawing.Size(1082, 679);
            this.ProfileUser_Info.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Nunito", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Your Profile";
            // 
            // EditInfoBtn
            // 
            this.EditInfoBtn.Animated = true;
            this.EditInfoBtn.AutoRoundedCorners = true;
            this.EditInfoBtn.BackColor = System.Drawing.Color.Transparent;
            this.EditInfoBtn.BorderRadius = 18;
            this.EditInfoBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EditInfoBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EditInfoBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EditInfoBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EditInfoBtn.Font = new System.Drawing.Font("Nunito", 11.25F, System.Drawing.FontStyle.Bold);
            this.EditInfoBtn.ForeColor = System.Drawing.Color.White;
            this.EditInfoBtn.Location = new System.Drawing.Point(12, 589);
            this.EditInfoBtn.Name = "EditInfoBtn";
            this.EditInfoBtn.Size = new System.Drawing.Size(120, 39);
            this.EditInfoBtn.TabIndex = 2;
            this.EditInfoBtn.Text = "Back ";
            this.EditInfoBtn.UseTransparentBackground = true;
            this.EditInfoBtn.Click += new System.EventHandler(this.EditInfoBtn_Click);
            // 
            // ProfileEdition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1082, 741);
            this.Controls.Add(this.ProfileUser_Info);
            this.Name = "ProfileEdition";
            this.Text = "ProfileEdition";
            this.ProfileUser_Info.ResumeLayout(false);
            this.ProfileUser_Info.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel ProfileUser_Info;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button EditInfoBtn;
    }
}