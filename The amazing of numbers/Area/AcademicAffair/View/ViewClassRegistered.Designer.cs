namespace The_amazing_of_numbers.Area.AcademicAffair.View
{
    partial class ViewClassRegistered
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
            this.dbUniversityDataSet1 = new The_amazing_of_numbers.DBUniversityDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lectureRegisClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lectureRegisClassTableAdapter = new The_amazing_of_numbers.DBUniversityDataSetTableAdapters.LectureRegisClassTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateregisterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dbUniversityDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectureRegisClassBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dbUniversityDataSet1
            // 
            this.dbUniversityDataSet1.DataSetName = "DBUniversityDataSet";
            this.dbUniversityDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.classidDataGridViewTextBoxColumn,
            this.dateregisterDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lectureRegisClassBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(183, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(426, 134);
            this.dataGridView1.TabIndex = 0;
            // 
            // lectureRegisClassBindingSource
            // 
            this.lectureRegisClassBindingSource.DataMember = "LectureRegisClass";
            this.lectureRegisClassBindingSource.DataSource = this.dbUniversityDataSet1;
            // 
            // lectureRegisClassTableAdapter
            // 
            this.lectureRegisClassTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // classidDataGridViewTextBoxColumn
            // 
            this.classidDataGridViewTextBoxColumn.DataPropertyName = "class_id";
            this.classidDataGridViewTextBoxColumn.HeaderText = "class_id";
            this.classidDataGridViewTextBoxColumn.Name = "classidDataGridViewTextBoxColumn";
            // 
            // dateregisterDataGridViewTextBoxColumn
            // 
            this.dateregisterDataGridViewTextBoxColumn.DataPropertyName = "date_register";
            this.dateregisterDataGridViewTextBoxColumn.HeaderText = "date_register";
            this.dateregisterDataGridViewTextBoxColumn.Name = "dateregisterDataGridViewTextBoxColumn";
            // 
            // ViewClassRegistered
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 749);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewClassRegistered";
            this.Text = "ViewClassRegistered";
            this.Load += new System.EventHandler(this.ViewClassRegistered_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbUniversityDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectureRegisClassBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DBUniversityDataSet dbUniversityDataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource lectureRegisClassBindingSource;
        private DBUniversityDataSetTableAdapters.LectureRegisClassTableAdapter lectureRegisClassTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateregisterDataGridViewTextBoxColumn;
    }
}