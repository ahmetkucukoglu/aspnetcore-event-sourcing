namespace EventSourcingTaskApp.Core.Events
{
    using System;

    public class CompletedTask
    {
        public Guid TaskId { get; set; }
        public string CompletedBy { get; set; }
    }
}
