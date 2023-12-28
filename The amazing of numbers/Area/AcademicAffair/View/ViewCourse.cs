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
    public partial class ViewCourse : Form
    {
        public ViewCourse()
        {
            InitializeComponent();
        }

        private void ViewCourse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBUniversityDataSet.Subject_' table. You can move, or remove it, as needed.
            this.subject_TableAdapter.Fill(this.dBUniversityDataSet.Subject_);

        }
    }
}
