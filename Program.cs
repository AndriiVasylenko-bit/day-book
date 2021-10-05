using System;

namespace DayBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Record();
        }

        public static void Record()
        {
            for (int i = 0; i < 5; i++)
            {
                string[] surname = new string[5];
                {
                    Console.Write("Введите фамилию: ");
                    surname[i] = Console.ReadLine();
                }
                string[] name = new string[5];
                {
                    Console.Write("Введите имя: ");
                    name[i] = Console.ReadLine();
                }
                string[] patronymic = new string[5];
                {
                    Console.Write("Введите отчество: ");
                    patronymic[i] = Console.ReadLine();
                }
                Student student = new Student(surname[i], name[i], patronymic[i]);

                int[] grade = new int[5];
                {
                    Console.Write("Введите оценку: ");
                    if (int.TryParse(Console.ReadLine(), out int result))
                    {
                        grade[i] = result;
                    }
                    else
                    {
                        throw new ArgumentNullException("поле должно содержать числовое значение");
                    }
                }
                Progress progress = new Progress(grade[i]);


                int[] category = new int[5];
                {
                    Console.Write("Введите группу: ");
                    if (int.TryParse(Console.ReadLine(), out int result))
                    {
                        category[i] = result;
                    }
                    else
                    {
                        throw new ArgumentNullException("поле должно содержать числовое значение");
                    }
                }
                Group group = new Group(category[i]);

                Console.WriteLine($"СТУДЕНТ: {student.FullName} ОЦЕНКА: {progress.StudentProgress} № ГРУППА: {group.GroupNumber}\n");
            }
        }
    }
}
