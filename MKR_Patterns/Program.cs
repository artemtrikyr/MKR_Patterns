using System;

namespace MKR_Patterns
{
    public class Program
    {
        public static void Main()
        {
            TaskPublisher publisher = new TaskPublisher();

            Student student1 = new Student("Аліса", "Математика");
            Student student2 = new Student("Генадій", "Фізика");

            publisher.Subscribe(student1);
            publisher.Subscribe(student2);

            publisher.PublishTask("Домашня робота", "Вирішити завдання 1-10", "Математика", DateTime.Now.AddDays(7));
            publisher.PublishTask("Лабораторна робота", "Виконайте експеримент", "Фізика", DateTime.Now.AddDays(5));
        }
    }
}