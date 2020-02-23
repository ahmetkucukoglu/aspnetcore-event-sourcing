namespace EventSourcingTaskApp.Core.Exceptions
{
    using System;

    public class TaskCompletedException : Exception
    {
        public TaskCompletedException() : base("Task is completed.") { }
    }
}
