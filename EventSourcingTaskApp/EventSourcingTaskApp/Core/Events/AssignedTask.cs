namespace EventSourcingTaskApp.Core.Events
{
    using System;

    public class AssignedTask
    {
        public Guid TaskId { get; set; }
        public string AssignedBy { get; set; }
        public string AssignedTo { get; set; }
    }
}
