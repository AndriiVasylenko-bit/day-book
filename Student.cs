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

        public string FullName => $"{_surname} {_name} {_patronymic}";

        public string Surname
        {
            get => _surname;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Фамилия студента не может быть пустым.");
                }
                _surname = value;
            }
        }

        public string Name
        {
            get =>_name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Имя студента не может быть путсым.");
                }
                _name = value;
            }
        }

        public string Patronymic
        {
            get => _patronymic;
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
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            Group = group;
            Progress = progress;
        }
    }
}
