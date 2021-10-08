using System;

namespace DayBook
{
    internal class Program
    {
        private Student[] student = new Student[2];
        Student[] student = new Student[5];

        private string surname;
        private string name;
        private string patronymic;
        private int grade;
        private int category;


        private static void Main()
        {
            Program program = new Program();
            program.generateArray();
            Console.WriteLine();
            program.printArray();
            program.bobbleSort();
            Console.WriteLine();
            program.printArray();
            Console.WriteLine();
            program.printUnderNumber();
            Console.WriteLine();
            program.searchStudent();
            Console.ReadKey();
        }


        private void GenerateArray()
        {
            for (int i = 0; i < student.Length; i++)
            {
                Console.Write("Введите фамилию: ");
                surname = Console.ReadLine();

                Console.Write("Введите имя: ");
                name = Console.ReadLine();

                Console.Write("Введите отчество: ");
                patronymic = Console.ReadLine();

                Console.Write("Введите оценку: ");
                if (!int.TryParse(Console.ReadLine(), out grade))
                {
                    throw new ArgumentNullException("поле должно содержать числовое значение");
                }

                Console.Write("Введите группу: ");
                if (!int.TryParse(Console.ReadLine(), out category))
                {
                    throw new ArgumentNullException("поле должно содержать числовое значение");
                }

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
            for (int i = 0; i < student.Length; i++)
            {
                if (student[i].StudentProgress > 4)
                {
                    Console.WriteLine($"СТУДЕНТ [{i}]: {student[i].FullStudent}");
                }
            }
        }

        public void searchStudent()
        {
            Console.Write("Найти студента по фамилие: ");
            string s = Console.ReadLine();
            for (int i = 0; i < student.Length; i++)
            {
                if (s.Equals(student[i].Surname, StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.WriteLine($"СТУДЕНТ [{i}]: {student[i].FullStudent}");
                }
            }  
        }
    }
}
