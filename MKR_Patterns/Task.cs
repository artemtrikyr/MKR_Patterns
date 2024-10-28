using System;
namespace MKR_Patterns
{
    public class Task
    {
        public string Title { get; }
        public string Description { get; }
        public string Subject { get; }
        public DateTime DueDate { get; }

        public Task(string title, string description, string subject, DateTime dueDate)
        {
            Title = title;
            Description = description;
            Subject = subject;
            DueDate = dueDate;
        }
    }
}

