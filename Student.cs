using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayBook
{
    public class Student : Person
    {
        public Student(string surname, string name, string patronymic, int progress, int group) : base(surname, name, patronymic, progress, group)
        {
        }
        
        public static Student operator +(Student student1, Student student2)
        {
            string surname = (student1.Surname + student2.Surname);
            string name = (student1.Name + student2.Name);
            string patronymic = (student1.Patronymic + student2.Patronymic);
            int progress = (student1.StudentProgress + student2.StudentProgress);
            int groupNumber = (student1.GroupNumber + student2.GroupNumber);

            Student student = new Student(surname, name, patronymic, progress, groupNumber);

            return student;
        }

        public static Student operator -(Student student1, Student student2)
        {
            string surname = (student1.Surname + student2.Surname);
            string name = (student1.Name + student2.Name);
            string patronymic = (student1.Patronymic + student2.Patronymic);
            int progress = (student1.StudentProgress - student2.StudentProgress);
            int groupNumber = (student1.GroupNumber - student2.GroupNumber);

            Student student = new Student(surname, name, patronymic, progress, groupNumber);

            return student;
        }

        public static bool operator >(Student student1, Student student2)
        {
            bool progress = (student1.StudentProgress > student2.StudentProgress);
            return progress;
        }

        public static bool operator <(Student student1, Student student2)
        {
            bool progress = (student1.StudentProgress > student2.StudentProgress);
            return progress;
        }
    }
}
