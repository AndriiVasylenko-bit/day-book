using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayBook
{
    public class Group : Student<double>
    {
        public Group(string surname, string name, string patronymic, double progress, double group) : base(surname, name, patronymic, progress, group)
        {
        }
        
        public static Group operator +(Group student1, Group student2)
        {
            string surname = (student1.Surname + student2.Surname);
            string name = (student1.Name + student2.Name);
            string patronymic = (student1.Patronymic + student2.Patronymic);
            var progress = (student1.StudentProgress + student2.StudentProgress);
            var groupNumber = (student1.GroupNumber + student2.GroupNumber);

            Group student = new Group(surname, name, patronymic, progress, groupNumber);

            return student;
        }

        public static Group operator -(Group student1, Group student2)
        {
            string surname = (student1.Surname + student2.Surname);
            string name = (student1.Name + student2.Name);
            string patronymic = (student1.Patronymic + student2.Patronymic);
            var progress = (student1.StudentProgress + student2.StudentProgress);
            var groupNumber = (student1.GroupNumber + student2.GroupNumber);

            Group student = new Group(surname, name, patronymic, progress, groupNumber);

            return student;
        }

        public static bool operator >(Group student1, Group student2)
        {
            bool progress = (student1.StudentProgress > student2.StudentProgress);
            return progress;
        }

        public static bool operator <(Group student1, Group student2)
        {
            bool progress = (student1.StudentProgress > student2.StudentProgress);
            return progress;
        }
    }
}
