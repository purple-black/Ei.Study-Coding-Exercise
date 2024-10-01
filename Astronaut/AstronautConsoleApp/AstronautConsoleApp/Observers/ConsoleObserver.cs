﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace AstronautConsoleApp.Observers
{
    public class ConsoleObserver : IObserver
    {
        public void Notify(string message)
        {
            Console.WriteLine("Notification: " + message);
        }
    }
}

