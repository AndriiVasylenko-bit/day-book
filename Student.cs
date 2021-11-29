using System;

namespace DayBook
{
    public class Student<T> 
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }

        public T StudentProgress { get; set; }
        public T GroupNumber { get; set; }
        


        public string FullStudent =>($"{Surname} {Name} {Patronymic} ОЦЕНКА: {StudentProgress} ГРУППА: {GroupNumber}");


            
        public Student(string surname, string name, string patronymic, T progress, T group)
        {
            if (string.IsNullOrWhiteSpace(surname))
            {
                throw new ArgumentNullException(nameof(surname));
            }

            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            if (string.IsNullOrWhiteSpace(patronymic))
            {
                throw new ArgumentNullException(nameof(patronymic));
            }

            //if (0 > progress)
            //{
            //    throw new ArgumentNullException(nameof(progress));
            //}

            //if (group < 0)
            //{
            //    throw new ArgumentNullException(nameof(group));
            //}

            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            StudentProgress = progress;
            GroupNumber = group;     
        }
    }
}
