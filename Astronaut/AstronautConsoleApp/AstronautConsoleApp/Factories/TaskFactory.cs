using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AstronautConsoleApp.Models;



namespace AstronautConsoleApp.Factories
{
    public class TaskFactory
    {
        public Models.Task CreateTask(string description, DateTime startTime, DateTime endTime, int priorityLevel)
        {
            return new Models.Task(description, startTime, endTime, priorityLevel);
        }
    }
}

