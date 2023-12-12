using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_amazing_of_numbers.Area.Lecturer.View;
using The_amazing_of_numbers.Area.Student.View;
using The_amazing_of_numbers.Model;

namespace The_amazing_of_numbers.Area.Student.Controllers
{
    internal class StudentController
    {
        dbUniversityDataContext db = new dbUniversityDataContext();
        private User cur_user;
        public void StudentHomeView(User user_model)
        {
            cur_user = user_model;
            new StudentMainForm().Show();
        }
    }
}
