using System;
using System.Collections.Generic;
using System.Linq;
using AstronautConsoleApp.Models;
using AstronautConsoleApp.Observers;

namespace AstronautConsoleApp.Managers
{
    public class ScheduleManager
    {
        // Thread-safe Singleton initialization
        private static readonly ScheduleManager _instance = new ScheduleManager();
        private readonly List<Models.Task> _tasks;
        private readonly List<IObserver> _observers;

        // Private constructor for Singleton pattern
        private ScheduleManager()
        {
            _tasks = new List<Models.Task>();
            _observers = new List<IObserver>();
        }

        public static ScheduleManager Instance => _instance;

        public void AddObserver(IObserver observer)
        {
            if (observer != null)
                _observers.Add(observer);
        }

        private void NotifyObservers(string message)
        {
            foreach (var observer in _observers)
            {
                observer.Notify(message);
            }
        }

        public void AddTask(Models.Task task)
        {
            if (ValidateTask(task))
            {
                _tasks.Add(task);
                NotifyObservers("Task added: " + task.Description);
            }
            else
            {
                NotifyObservers("Task conflict detected: " + task.Description);
            }
        }

        public bool RemoveTaskByDescription(string description)
        {
            var task = _tasks.FirstOrDefault(t => t.Description == description);
            if (task != null)
            {
                _tasks.Remove(task);
                NotifyObservers("Task removed: " + description);
                return true;
            }
            NotifyObservers("Task not found: " + description);
            return false;
        }

        public List<Models.Task> ViewAllTasks()
        {
            return _tasks.OrderBy(t => t.StartTime).ToList();
        }

        private bool ValidateTask(Models.Task newTask)
        {
            foreach (var task in _tasks)
            {
                // Check if the new task overlaps with any existing task
                if (newTask.StartTime < task.EndTime && newTask.EndTime > task.StartTime)
                {
                    return false;
                }
            }
            return true;
        }
    }
}




