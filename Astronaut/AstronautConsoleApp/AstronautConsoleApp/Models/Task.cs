using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace AstronautConsoleApp.Models
{
    public class Task
    {
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int PriorityLevel { get; set; }
        public bool IsCompleted { get; set; }

        public Task(string description, DateTime startTime, DateTime endTime, int priorityLevel)
        {
            Description = description;
            StartTime = startTime;
            EndTime = endTime;
            PriorityLevel = priorityLevel;
            IsCompleted = false;
        }

        public void MarkAsCompleted()
        {
            IsCompleted = true;
        }

        public override string ToString()
        {
            return $"Task: {Description}, Start: {StartTime}, End: {EndTime}, Priority: {PriorityLevel}, Completed: {IsCompleted}";
        }
    }
}


