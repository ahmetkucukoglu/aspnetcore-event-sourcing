namespace EventSourcingTaskApp.Core.Exceptions
{
    using System;

    public class TaskAlreadyCreatedException : Exception
    {
        public TaskAlreadyCreatedException() : base("Task already created.") { }
    }
}
