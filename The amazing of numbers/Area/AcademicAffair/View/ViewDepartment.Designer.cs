namespace The_amazing_of_numbers.Area.AcademicAffair.View
{
    partial class ViewDepartment
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
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentTableAdapter = new The_amazing_of_numbers.DBUniversityDataSetTableAdapters.DepartmentTableAdapter();
            this.departmentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBUniversityDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.departmentidDataGridViewTextBoxColumn,
            this.departmentnameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.departmentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(223, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(352, 161);
            this.dataGridView1.TabIndex = 0;
            // 
            // dBUniversityDataSet
            // 
            this.dBUniversityDataSet.DataSetName = "DBUniversityDataSet";
            this.dBUniversityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "Department";
            this.departmentBindingSource.DataSource = this.dBUniversityDataSet;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // departmentidDataGridViewTextBoxColumn
            // 
            this.departmentidDataGridViewTextBoxColumn.DataPropertyName = "department_id";
            this.departmentidDataGridViewTextBoxColumn.HeaderText = "department_id";
            this.departmentidDataGridViewTextBoxColumn.Name = "departmentidDataGridViewTextBoxColumn";
            // 
            // departmentnameDataGridViewTextBoxColumn
            // 
            this.departmentnameDataGridViewTextBoxColumn.DataPropertyName = "department_name";
            this.departmentnameDataGridViewTextBoxColumn.HeaderText = "department_name";
            this.departmentnameDataGridViewTextBoxColumn.Name = "departmentnameDataGridViewTextBoxColumn";
            // 
            // ViewDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 749);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewDepartment";
            this.Text = "ViewDepartment";
            this.Load += new System.EventHandler(this.ViewDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBUniversityDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DBUniversityDataSet dBUniversityDataSet;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private DBUniversityDataSetTableAdapters.DepartmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}