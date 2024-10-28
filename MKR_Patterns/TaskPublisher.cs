using System;
namespace MKR_Patterns
{
    public class TaskPublisher
    {
        private List<IObserver> observers = new List<IObserver>();
        private List<Task> tasks = new List<Task>();

        public void Subscribe(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Unsubscrive(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void PublishTask(string title, string description, string subject, DateTime dueDate)
        {
            var task = new Task(title, description, subject, dueDate);
            tasks.Add(task);
            NotifyObservers(task);
        }

        private void NotifyObservers(Task task)
        {
            foreach (var observer in observers)
            {
                observer.Update(task);
            }
        }
    }
}

