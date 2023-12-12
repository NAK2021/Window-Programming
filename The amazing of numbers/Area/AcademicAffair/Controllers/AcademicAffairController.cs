using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_amazing_of_numbers.Area.AcademicAffair.View;
using The_amazing_of_numbers.Area.Student.View;
using The_amazing_of_numbers.Model;

namespace The_amazing_of_numbers.Area.AcademicAffair.Controllers
{
    internal class AcademicAffairController
    {
        dbUniversityDataContext db = new dbUniversityDataContext();
        private User cur_user;
        public void AcademicAffairHomeView(User user_model)
        {
            cur_user = user_model;
            new AcademicAffairMainForm().Show();
        }
    }
}
