namespace The_amazing_of_numbers.Area.AcademicAffair.View
{
    partial class ViewLectureProfile
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dBUniversityDataSet = new The_amazing_of_numbers.DBUniversityDataSet();
            this.lectureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lectureTableAdapter = new The_amazing_of_numbers.DBUniversityDataSetTableAdapters.LectureTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teachingExperienceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.academicrankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assignedsubjectsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBUniversityDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectureBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.dobDataGridViewTextBoxColumn,
            this.phonenumDataGridViewTextBoxColumn,
            this.departmentidDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.teachingExperienceDataGridViewTextBoxColumn,
            this.academicrankDataGridViewTextBoxColumn,
            this.assignedsubjectsDataGridViewTextBoxColumn,
            this.pictureDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.lectureBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(943, 197);
            this.dataGridView1.TabIndex = 0;
            // 
            // dBUniversityDataSet
            // 
            this.dBUniversityDataSet.DataSetName = "DBUniversityDataSet";
            this.dBUniversityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lectureBindingSource
            // 
            this.lectureBindingSource.DataMember = "Lecture";
            this.lectureBindingSource.DataSource = this.dBUniversityDataSet;
            // 
            // lectureTableAdapter
            // 
            this.lectureTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name_";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name_";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "sex";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            // 
            // dobDataGridViewTextBoxColumn
            // 
            this.dobDataGridViewTextBoxColumn.DataPropertyName = "dob";
            this.dobDataGridViewTextBoxColumn.HeaderText = "dob";
            this.dobDataGridViewTextBoxColumn.Name = "dobDataGridViewTextBoxColumn";
            // 
            // phonenumDataGridViewTextBoxColumn
            // 
            this.phonenumDataGridViewTextBoxColumn.DataPropertyName = "phone_num";
            this.phonenumDataGridViewTextBoxColumn.HeaderText = "phone_num";
            this.phonenumDataGridViewTextBoxColumn.Name = "phonenumDataGridViewTextBoxColumn";
            // 
            // departmentidDataGridViewTextBoxColumn
            // 
            this.departmentidDataGridViewTextBoxColumn.DataPropertyName = "department_id";
            this.departmentidDataGridViewTextBoxColumn.HeaderText = "department_id";
            this.departmentidDataGridViewTextBoxColumn.Name = "departmentidDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status_";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status_";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // teachingExperienceDataGridViewTextBoxColumn
            // 
            this.teachingExperienceDataGridViewTextBoxColumn.DataPropertyName = "Teaching_Experience";
            this.teachingExperienceDataGridViewTextBoxColumn.HeaderText = "Teaching_Experience";
            this.teachingExperienceDataGridViewTextBoxColumn.Name = "teachingExperienceDataGridViewTextBoxColumn";
            // 
            // academicrankDataGridViewTextBoxColumn
            // 
            this.academicrankDataGridViewTextBoxColumn.DataPropertyName = "Academic_rank";
            this.academicrankDataGridViewTextBoxColumn.HeaderText = "Academic_rank";
            this.academicrankDataGridViewTextBoxColumn.Name = "academicrankDataGridViewTextBoxColumn";
            // 
            // assignedsubjectsDataGridViewTextBoxColumn
            // 
            this.assignedsubjectsDataGridViewTextBoxColumn.DataPropertyName = "assigned_subjects";
            this.assignedsubjectsDataGridViewTextBoxColumn.HeaderText = "assigned_subjects";
            this.assignedsubjectsDataGridViewTextBoxColumn.Name = "assignedsubjectsDataGridViewTextBoxColumn";
            // 
            // pictureDataGridViewImageColumn
            // 
            this.pictureDataGridViewImageColumn.DataPropertyName = "picture";
            this.pictureDataGridViewImageColumn.HeaderText = "picture";
            this.pictureDataGridViewImageColumn.Name = "pictureDataGridViewImageColumn";
            // 
            // ViewLectureProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 749);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewLectureProfile";
            this.Text = "ViewLectureProfile";
            this.Load += new System.EventHandler(this.ViewLectureProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBUniversityDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectureBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DBUniversityDataSet dBUniversityDataSet;
        private System.Windows.Forms.BindingSource lectureBindingSource;
        private DBUniversityDataSetTableAdapters.LectureTableAdapter lectureTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teachingExperienceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn academicrankDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assignedsubjectsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn pictureDataGridViewImageColumn;
    }
}