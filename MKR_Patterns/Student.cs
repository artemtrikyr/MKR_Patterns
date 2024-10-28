using System;
namespace MKR_Patterns
{
    public class Student : IObserver
    {
        public string Name { get; private set; }
        private string subject;

        public Student(string name, string subject)
        {
            Name = name;
            this.subject = subject;
        }

        public void Update(Task task)
        {
            if(task.Subject == subject)
            {
                Notify(task);
            }
        }
        private void Notify(Task task)
        {
            Console.WriteLine(CreateNotificationMessage(task));
        }
        private string CreateNotificationMessage(Task task)
        {
            return $"Студент {Name} отримує повідомлення з предмету: {task.Title}\n" +
                $"Опис завдання: {task.Description}\n" +
                $"Дата виконання: {task.DueDate.ToShortDateString()}\n";
        }
    }
}

