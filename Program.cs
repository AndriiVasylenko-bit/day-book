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
                student[i] = new (surname, name, patronymic, grade, category);
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
                        string t = student[i].FullStudent;
                        student[i].FullStudent = student[j].FullStudent;
                        student[j].FullStudent = t;
                    }
                }
            }
        }
    }
}
