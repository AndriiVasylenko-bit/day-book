using System;

namespace DayBook.Src.Models
{
    public record Student
    {
        private string _surname;
        private string _name;
        private string _patronymic;
        private double _progress;
        private Group _group;

        public string Surname
        {
            get => _surname;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(value));
                }
                _surname = value;
            }
        }

        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(value));
                }
                _name = value;
            }
        }

        public string Patronymic
        {
            get => _patronymic;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(value));
                }
                _patronymic = value;
            }
        }

        public double Progress
        {
            get => _progress;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }
                _progress = value;
            }
        }

        public Group Group
        {
            get => _group;
            set => _group = value;
        }

        public override string ToString()
        {
            return $"Повне Ім'я {Surname} {Name} {Patronymic}, ОЦІНКА: {Progress}, ГРУППА: {Group}";
        }

        public Student(string surname,
            string name,
            string patronymic,
            double progress,
            Group group)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            Progress = progress;
            Group = group;
        }
    }
}
