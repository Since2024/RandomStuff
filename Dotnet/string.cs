Write a program to make students name's input in array and display those name's where content letter 'a' by using linkq

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // 1. Ask the user for the number of students
        Console.Write("Enter the number of students: ");
        if (!int.TryParse(Console.ReadLine(), out int count) || count <= 0)
        {
            Console.WriteLine("Please enter a valid positive number.");
            return;
        }

        // 2. Initialize the array
        string[] students = new string[count];

        // 3. Take inputs from the user
        for (int i = 0; i < count; i++)
        {
            Console.Write($"Enter name for student {i + 1}: ");
            students[i] = Console.ReadLine();
        }

        // 4. Use LINQ to filter names containing the letter 'a' (case-insensitive)
        var filteredStudents = students.Where(name => name.Contains("a", StringComparison.OrdinalIgnoreCase));

        // 5. Display the results
        Console.WriteLine("\n--- Students whose names contain the letter 'a' ---");
        
        if (filteredStudents.Any())
        {
            foreach (var name in filteredStudents)
            {
                Console.WriteLine(name);
            }
        }
        else
        {
            Console.WriteLine("No student names contain the letter 'a'.");
        }
    }
}