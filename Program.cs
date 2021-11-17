using System;

namespace DayBook
{
    internal class Program
    {
        private Student[] student = new Student[2];

        private string surname;
        private string name;
        private string patronymic;
        private int grade;
        private int category;


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
            for (int i = 0; i < student.Length; i++)
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
                student[i] = new(surname, name, patronymic, grade, category);
            }
        }

        private void PrintArray()
        {
            for (int i = 0; i < student.Length; i++)
            {
                Console.WriteLine($"СТУДЕНТ [{i}]: {student[i].FullStudent}");
            }
        }

        private void BubbleSort()
        {
            for (int i = 0; i < student.Length; i++)
            {
                for (int j = i + 1; j < student.Length; j++)
                {
                    if (student[i].GroupNumber > student[j].GroupNumber)
                    {
                        string t = student[i].Surname;
                        student[i].Surname = student[j].Surname;
                        student[j].Surname = t;

                        string r = student[i].Name;
                        student[i].Name = student[j].Name;
                        student[j].Name = r;

                        string e = student[i].Patronymic;
                        student[i].Patronymic = student[j].Patronymic;
                        student[j].Patronymic = e;

                        int w = student[i].StudentProgress;
                        student[i].StudentProgress = student[j].StudentProgress;
                        student[j].StudentProgress = w;

                        int q = student[i].GroupNumber;
                        student[i].GroupNumber = student[j].GroupNumber;
                        student[j].GroupNumber = q;
                    }
                }
            }
        }


        private void PrintUnderNumber()
        {
            Console.WriteLine("СТУДЕНТЫ С ОЦЕНКОЙ БОЛЬШЕ 4");
            Console.WriteLine();
            bool x = true;
            for (int i = 0; i < student.Length; i++)
            {
                if (student[i].StudentProgress > 4)
                {
                    Console.WriteLine($"СТУДЕНТ [{i}]: {student[i].FullStudent}");
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
            for (int i = 0; i < student.Length; i++)
            {
                if (s.Equals(student[i].Surname, StringComparison.CurrentCultureIgnoreCase) || s.Equals(student[i].Name, StringComparison.CurrentCultureIgnoreCase) || s.Equals(student[i].Patronymic, StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.WriteLine();
                    Console.WriteLine($"СТУДЕНТ [{i}]: {student[i].FullStudent}");
                }
            }
        }

        public void AdditionOperators()
        {
            Console.WriteLine(student[0] > student[1]);
            var Student1 = student[0] + student[1];
            Console.WriteLine(Student1.FullStudent);
        }
    }
}
