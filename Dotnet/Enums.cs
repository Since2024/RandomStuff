using System;

enum Month {
    // Setting the first value to 1 shifts the entire sequence
    Jan = 1, 
    Feb, 
    Aprl, 
    May
}

class Program {
    public static void Main() {
        // Output: Value of Jan in month: 1
        Console.WriteLine("Value of Jan in month: " + (int)Month.Jan);
    }
}