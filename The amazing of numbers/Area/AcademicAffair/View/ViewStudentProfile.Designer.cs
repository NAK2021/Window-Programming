namespace The_amazing_of_numbers.Area.AcademicAffair.View
{
    partial class ViewStudentProfile
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
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schoolyearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totcredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBUniversityDataSet = new The_amazing_of_numbers.DBUniversityDataSet();
            this.dBUniversityDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new The_amazing_of_numbers.DBUniversityDataSetTableAdapters.StudentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBUniversityDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBUniversityDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.schoolyearDataGridViewTextBoxColumn,
            this.dobDataGridViewTextBoxColumn,
            this.phonenumDataGridViewTextBoxColumn,
            this.departmentidDataGridViewTextBoxColumn,
            this.totcredDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.pictureDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.studentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(40, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(913, 279);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
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
            // schoolyearDataGridViewTextBoxColumn
            // 
            this.schoolyearDataGridViewTextBoxColumn.DataPropertyName = "school_year";
            this.schoolyearDataGridViewTextBoxColumn.HeaderText = "school_year";
            this.schoolyearDataGridViewTextBoxColumn.Name = "schoolyearDataGridViewTextBoxColumn";
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
            // totcredDataGridViewTextBoxColumn
            // 
            this.totcredDataGridViewTextBoxColumn.DataPropertyName = "tot_cred";
            this.totcredDataGridViewTextBoxColumn.HeaderText = "tot_cred";
            this.totcredDataGridViewTextBoxColumn.Name = "totcredDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status_";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status_";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // pictureDataGridViewImageColumn
            // 
            this.pictureDataGridViewImageColumn.DataPropertyName = "picture";
            this.pictureDataGridViewImageColumn.HeaderText = "picture";
            this.pictureDataGridViewImageColumn.Name = "pictureDataGridViewImageColumn";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.dBUniversityDataSet;
            // 
            // dBUniversityDataSet
            // 
            this.dBUniversityDataSet.DataSetName = "DBUniversityDataSet";
            this.dBUniversityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dBUniversityDataSetBindingSource
            // 
            this.dBUniversityDataSetBindingSource.DataSource = this.dBUniversityDataSet;
            this.dBUniversityDataSetBindingSource.Position = 0;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // ViewStudentProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 749);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewStudentProfile";
            this.Text = "ViewStudentProfile";
            this.Load += new System.EventHandler(this.ViewStudentProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBUniversityDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBUniversityDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dBUniversityDataSetBindingSource;
        private DBUniversityDataSet dBUniversityDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private DBUniversityDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn schoolyearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totcredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn pictureDataGridViewImageColumn;
    }
}