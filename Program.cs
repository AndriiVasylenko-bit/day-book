using System;

namespace DayBook
{

    class Program
    {
        //    Описати клас з іменем STUDENT, який містить наступні поля: прізвище; номер групи; успішність(масив із п’яти елементів).
        //    Написати програму, яка виконує наступні дії:
        //    -   зчитування даних з рядкового потоку в масив, який складається структур типу STUDENT.
        //    -  впорядкувати їх за зростанням номера групи; 
        //    виведення на дисплей прізвищ і номерів груп для всіх студентів,
        //    включених до масиву, якщо середній бал студента більший ніж 4.0; 
        //    якщо таких студентів немає, вивести відповідне повідомлення.
        //    -  реалізувати пошук інформації по не повному прізвищу

        static void Main(string[] args)
        {
            //string nickSurname;

            //for (int i = 0; i < 5; i++)
            //{
            //    string[] surname = new string[5];
            //    {
            //        Console.Write("Введите фамилию: ");
            //        surname[i] = Console.ReadLine();
            //    }
            //    string[] name = new string[5];
            //    {
            //        Console.Write("Введите имя: ");
            //        name[i] = Console.ReadLine();
            //    }
            //    string[] patronymic = new string[5];
            //    {
            //        Console.Write("Введите отчество: ");
            //        patronymic[i] = Console.ReadLine();
            //    }

            
            Student student = new Student("f","f","f");

            //Console.WriteLine($"Студент: {student.FullName}\n");
            //}
            Console.WriteLine(student.Record());

            Console.ReadKey();
        }
    }
}
