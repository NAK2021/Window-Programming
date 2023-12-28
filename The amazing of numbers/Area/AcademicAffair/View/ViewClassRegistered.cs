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
    public partial class ViewClassRegistered : Form
    {
        public ViewClassRegistered()
        {
            InitializeComponent();
        }

        private void ViewClassRegistered_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbUniversityDataSet1.LectureRegisClass' table. You can move, or remove it, as needed.
            this.lectureRegisClassTableAdapter.Fill(this.dbUniversityDataSet1.LectureRegisClass);

        }
    }
}
