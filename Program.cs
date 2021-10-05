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
            string[] surname = new string[5];
            string[] name = new string[5];
            string[] patronymic = new string[5];
            int[] grade = new int[5];
            int[] category = new int[5];


            for (int i = 0; i < 5; i++)
            {
                
                {
                    Console.Write("Введите фамилию: ");
                    surname[i] = Console.ReadLine();
                }
                
                {
                    Console.Write("Введите имя: ");
                    name[i] = Console.ReadLine();
                }
                
                {
                    Console.Write("Введите отчество: ");
                    patronymic[i] = Console.ReadLine();
                }
                Student student = new Student(surname[i], name[i], patronymic[i]);

                
                {
                    Console.Write("Введите оценку: ");
                    if (!int.TryParse(Console.ReadLine(), out int result))
                    {
                        throw new ArgumentNullException("поле должно содержать числовое значение");
                    }
                    grade[i] = result;
                }
                Progress rating = new Progress(grade[i]);



                {
                    Console.Write("Введите группу: ");
                    if (!int.TryParse(Console.ReadLine(), out int result))
                    {
                        throw new ArgumentNullException("поле должно содержать числовое значение");
                    }
                    category[i] = result;
                }
                Group group = new Group(category[i]);

                Console.WriteLine($"СТУДЕНТ: {student.FullName} ОЦЕНКА: {rating.StudentProgress} № ГРУППА: {group.GroupNumber}\n");
            }

        }
    }
}
