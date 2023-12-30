﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_amazing_of_numbers.Area.AcademicAffair.View;
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
            new AcademicAffairMainForm(cur_user).Show();
        }
        public Academic_Affair infoDetail(string id)
		{
            Academic_Affair aff = db.Academic_Affairs.Where(s => s.id == id).FirstOrDefault();
            return aff;
		}
        public void UpdateCourse(string course_id, string course_name, string dpt_id, int credits, int cost)
        {
            Subject_ sub = db.Subject_s.FirstOrDefault(s => s.course_id == course_id);
            if (sub != null)
            {
                sub.course_id = course_id;
                sub.course_name = course_name;
                sub.department_id = dpt_id;
                sub.credits = credits;
                sub.cost = cost;
                db.SubmitChanges();
            }
        }
        public void DeleteCourse(string id)
        {
            Subject_ sub = db.Subject_s.FirstOrDefault(s => s.course_id == id);
            db.Subject_s.DeleteOnSubmit(sub);
            db.SubmitChanges();
        }
        public void UpdateLecture(string id, string email, string name, string sex, string dob, string phone, string dpt_id, string status, int teach_E, string academicRank, string assignedSubject)
        {
            Lecture lt = db.Lectures.FirstOrDefault(l => l.id == id);
            if (lt != null)
            {
                lt.id = id;
                lt.email = email;
                lt.name_ = name;
                lt.sex = sex;
                lt.dob = dob;
                lt.phone = phone;
                lt.department_id = dpt_id;
                lt.status_ = status;
                lt.Teaching_Experience = teach_E;
                lt.Academic_rank = academicRank;
                lt.assigned_subjects = assignedSubject;
                db.SubmitChanges();
            }
        }
        public void DeleteLecture(string id)
        {
            Lecture lt = db.Lectures.FirstOrDefault(l => l.id == id);
            db.Lectures.DeleteOnSubmit(lt);
            db.SubmitChanges();
        }
        public void UpdateStudent(string id, string name, string sex, string school_year, string dob, string phone, string dpt_id, string status)
        {
			The_amazing_of_numbers.Model.Student st = db.Students.FirstOrDefault(s => s.id == id);
            if (st != null)
            {
                st.id = id;
                st.name_ = name;
                st.sex = sex;
                st.school_year = school_year;
                st.dob = dob;
                st.phone_num = phone;
                st.department_id = dpt_id;
                st.status_ = status;
                db.SubmitChanges();
            }
        }
        public void DeleteStudent(string id)
        {
            The_amazing_of_numbers.Model.Student st = db.Students.FirstOrDefault(s => s.id == id);
            db.Students.DeleteOnSubmit(st);
            db.SubmitChanges();
        }
    }
}
