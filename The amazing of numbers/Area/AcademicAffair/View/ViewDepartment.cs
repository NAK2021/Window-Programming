using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_amazing_of_numbers.Area.AcademicAffair.View
{
    public partial class ViewDepartment : Form
    {
        public ViewDepartment()
        {
            InitializeComponent();
        }

        private void ViewDepartment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBUniversityDataSet.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.dBUniversityDataSet.Department);

        }
    }
}
