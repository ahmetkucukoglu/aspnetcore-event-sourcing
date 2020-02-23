namespace EventSourcingTaskApp.Core.Exceptions
{
    using System;

    public class TaskNotFoundException : Exception
    {
        public TaskNotFoundException() : base("Task not found.") { }
    }
}
