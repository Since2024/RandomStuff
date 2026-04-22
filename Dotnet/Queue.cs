using System;
using System.Collections.Generic; // 'C' must be capitalized

class Program {
    public static void Main() {
        // Create a generic list of integers
        List<int> l1 = new List<int>();

        // Use a DOT (.) to access methods, not a colon (:)
        l1.Add(5);
        l1.Add(10);
        
        // Print the items
        foreach(int a in l1) {
            Console.WriteLine(a);
        }
    }
}

