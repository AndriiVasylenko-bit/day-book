using System;

namespace DayBook
{
    internal class Program
    {
        private static void Main()
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

                Student student = new(surname[i], name[i], patronymic[i], new Group(category[i]), new Progress(grade[i]));

                Console.WriteLine($"СТУДЕНТ: {student.FullName} ОЦЕНКА: {student.Progress} № ГРУППА: {student.Group}\n");
            }
        }
    }
}
