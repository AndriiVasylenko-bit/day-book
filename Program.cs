using System;

namespace DayBook
{
    internal class Program
    {
        Student[] student = new Student[2];

        string surname;
        string name;
        string patronymic;
        int grade;
        int category;


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
        }


        public void generateArray()
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

        public void printArray()
        {
            Console.WriteLine();
            for (int i = 0; i < student.Length; i++)
            {
                Console.WriteLine($"СТУДЕНТ [{i}]: {student[i].FullStudent}");
            }
        }

        public void bobbleSort()
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


        public void printUnderNumber()
        {
            for (int i = 0; i < student.Length; i++)
            {
                if (student[i].StudentProgress > 4)
                {
                    Console.WriteLine($"СТУДЕНТ [{i}]: {student[i].FullStudent}");
                }
            }





        }
    }
}
