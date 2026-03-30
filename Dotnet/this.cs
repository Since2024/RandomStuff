using System;

public class Calculator { // Renamed for clarity
    int a, b;

    // FIX 1: Changed return type to 'void' because you aren't returning a value.
    public void GetData(int a, int b) { 
        this.a = a;
        this.b = b;
    }

    public void Display() {
        int sum = a + b;
        // FIX 2: Fixed the string formatting for the output.
        Console.WriteLine("Sum = {0}", sum); 
    }
}

// FIX 3: Main method must be in a class, and object names must match.
class Program {
    public static void Main() {
        Calculator p1 = new Calculator(); // Use the class name defined above
        p1.GetData(30, 40);
        p1.Display();
        
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}