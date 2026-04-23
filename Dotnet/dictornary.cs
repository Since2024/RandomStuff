using System;
using System.Collections.Generic;

namespace TaskManager
{
    class Program
    {
        // Dictionary to store task details by their ID (Fast access)
        static Dictionary<int, string> taskDetails = new Dictionary<int, string>();
        
        // Queue to store IDs in the order they should be finished (FIFO)
        static Queue<int> processQueue = new Queue<int>();

        static void Main(string[] args)
        {
            // 1. Adding Tasks
            AddTask(101, "Syncing database records");
            AddTask(102, "Generating PDF report");
            AddTask(103, "Sending email notifications");

            Console.WriteLine("--- Current Tasks in System ---");
            foreach (var id in processQueue)
            {
                Console.WriteLine($"ID: {id} | Description: {taskDetails[id]}");
            }

            // 2. Processing Tasks in order
            Console.WriteLine("\n--- Starting Process ---");
            while (processQueue.Count > 0)
            {
                int currentId = processQueue.Dequeue(); // Get next ID from Queue
                string description = taskDetails[currentId]; // Look up info in Dictionary
                
                Console.WriteLine($"Processing Task [{currentId}]: {description}...");
                
                // Remove from dictionary once fully completed
                taskDetails.Remove(currentId);
            }

            Console.WriteLine("\nAll tasks completed.");
        }

        static void AddTask(int id, string description)
        {
            if (!taskDetails.ContainsKey(id))
            {
                taskDetails.Add(id, description);
                processQueue.Enqueue(id);
            }
        }
    }
}
