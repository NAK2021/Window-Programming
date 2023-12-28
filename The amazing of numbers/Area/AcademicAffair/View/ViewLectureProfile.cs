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
    public partial class ViewLectureProfile : Form
    {
        public ViewLectureProfile()
        {
            InitializeComponent();
        }

        private void ViewLectureProfile_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBUniversityDataSet.Lecture' table. You can move, or remove it, as needed.
            this.lectureTableAdapter.Fill(this.dBUniversityDataSet.Lecture);

        }
    }
}
