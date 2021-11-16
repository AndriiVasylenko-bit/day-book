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
    }
}
