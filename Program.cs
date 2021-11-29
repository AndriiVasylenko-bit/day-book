using System;

namespace DayBook
{
    internal class Program
    {
        private Group[] group = new Group[2];

        private string surname;
        private string name;
        private string patronymic;
        private int grade;
        private int category;
        int counter = 0;


        private static void Main()
        {
            Program program = new Program();
            program.GenerateArray();
            program.BubbleSort();
            Console.WriteLine();
            program.AdditionOperators();
            program.PrintArray();
            Console.WriteLine();
            program.PrintUnderNumber();
            Console.WriteLine();
            program.searchStudent();
            Console.ReadKey();
        }


        private void GenerateArray()
        {
            for (int i = 0; i < group.Length; i++)
            {
                Console.Write("ВВЕДИТЕ ФАМИЛИЮ: ");
                surname = Console.ReadLine();

                Console.Write("ВВЕДИТЕ ИМЯ: ");
                name = Console.ReadLine();

                Console.Write("ВВЕДИТЕ ОТЧЕСТВО: ");
                patronymic = Console.ReadLine();

                Console.Write("ВВЕДИТЕ ОЦЕНКУ: ");
                grade = Convert.ToInt32(Console.ReadLine());

                Console.Write("ВВЕДИТЕ ГРУППУ: ");
                category = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
                group[i] = new(surname, name, patronymic, grade, category);
            }
        }

        private void PrintArray()
        {
            for (int i = 0; i < group.Length; i++)
            {
                Console.WriteLine($"СТУДЕНТ [{i}]: {group[i].FullStudent}");
                counter++;
            }
        }

        private void BubbleSort()
        {
            for (int i = 0; i < group.Length; i++)
            {
                for (int j = i + 1; j < group.Length; j++)
                {
                    if (group[i].GroupNumber > group[j].GroupNumber)
                    {
                        string t = group[i].Surname;
                        group[i].Surname = group[j].Surname;
                        group[j].Surname = t;

                        string r = group[i].Name;
                        group[i].Name = group[j].Name;
                        group[j].Name = r;

                        string e = group[i].Patronymic;
                        group[i].Patronymic = group[j].Patronymic;
                        group[j].Patronymic = e;

                        var w = group[i].StudentProgress;
                        group[i].StudentProgress = group[j].StudentProgress;
                        group[j].StudentProgress = w;

                        var q = group[i].GroupNumber;
                        group[i].GroupNumber = group[j].GroupNumber;
                        group[j].GroupNumber = q;
                    }
                }
            }
        }


        private void PrintUnderNumber()
        {
            Console.WriteLine("СТУДЕНТЫ С ОЦЕНКОЙ БОЛЬШЕ 4");
            Console.WriteLine();
            bool x = true;
            for (int i = 0; i < group.Length; i++)
            {
                if (group[i].StudentProgress > 4)
                {
                    Console.WriteLine($"СТУДЕНТ [{i}]: {group[i].FullStudent}");
                    x = false;
                }
            }
            if (x) { Console.WriteLine("таких студентов нет"); }
        }

        public void searchStudent()
        {
            Console.WriteLine();
            Console.Write("Найти студента: ");
            string s = Console.ReadLine();
            for (int i = 0; i < group.Length; i++)
            {
                if (s.Equals(group[i].Surname, StringComparison.CurrentCultureIgnoreCase) || s.Equals(group[i].Name, StringComparison.CurrentCultureIgnoreCase) || s.Equals(group[i].Patronymic, StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.WriteLine();
                    Console.WriteLine($"СТУДЕНТ [{i}]: {group[i].FullStudent}");
                }
            }
        }

        public void AdditionOperators()
        {
            Console.WriteLine(group[0] > group[1]);
            var Student1 = group[0] + group[1];
            Console.WriteLine(Student1.FullStudent);
            Console.Write("Средний бал: ");
            Console.WriteLine((group[0].StudentProgress + group[1].StudentProgress) / counter);
        }
    }
}
