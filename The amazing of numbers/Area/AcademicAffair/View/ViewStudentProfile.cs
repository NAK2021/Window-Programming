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
    public partial class ViewStudentProfile : Form
    {
        public ViewStudentProfile()
        {
            InitializeComponent();
        }

        private void ViewStudentProfile_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBUniversityDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.dBUniversityDataSet.Student);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
