using System;

namespace DayBook
{
    class Student
    {
        private string _surname;
        private string _name;
        private string _patronymic;
        
        public Progress Progress { get; set; }
        public Group Group { get; set; }

<<<<<<< HEAD
        public string FullName
        {
            get
            {
                return $"{_surname} {_name} {_patronymic}";
            }
        }

        public string StudentSurname
        {
            get =>_surname;
=======
        public string FullName => $"{studentSurname} {studentName.Substring(0, 1)}. {studentPatronymic.Substring(0, 1)}.";

        public string StudentSurname
        {
            get => studentSurname;
>>>>>>> b11852c808e538b64e5e3e457cd2d518091aa176
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Фамилия студента не может быть пустым.");
                }
                _surname = value;
            }
        }

        public string StudentName
        {
<<<<<<< HEAD
            get =>_name;
=======
            get => studentName;
>>>>>>> b11852c808e538b64e5e3e457cd2d518091aa176
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Имя студента не может быть путсым.");
                }
                _name = value;
            }
        }

        public string StudentPatronymic
        {
<<<<<<< HEAD
            get => _patronymic;
=======
            get => studentPatronymic;
>>>>>>> b11852c808e538b64e5e3e457cd2d518091aa176
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Отчество студента не может быть путсым.");
                }
                _patronymic = value;
            }
        }

        public Student(string surname, string name, string patronymic, Group group, Progress progress)
        {
            StudentSurname = surname;
            StudentName = name;
            StudentPatronymic = patronymic;
            Group = group;
            Progress = progress;
        }
    }
}
