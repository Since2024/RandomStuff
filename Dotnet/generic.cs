using System;
using System.Collections.Generic; // Fixed typo: Collections

class Test<T>
{
    private T[] t = new T[5];
    private int count = 0; // You must declare 'count' and initialize it

    public void AddItem(T item) { // Renamed to match Main and standard naming
        if (count < 5) {
            t[count] = item;
            count++;
        }
        else {
            Console.WriteLine("Overflow exists");
        }
    }

    public void Display() { // Added missing brackets for the method
        for (int i = 0; i < count; i++) { // Fixed 'cout' typo
            Console.WriteLine("Item at index {0} is {1}", i, t[i]);
        }
    }
}

class Program {
    public static void Main() {
        // You can now use this class for any type!
        Test<int> obj = new Test<int>();
        obj.AddItem(10); // Fixed the colon ":" syntax error
        obj.AddItem(20);
        obj.Display();

        // Bonus: Because it's generic, you can also do this:
        // Test<string> names = new Test<string>();
        // names.AddItem("Hasan");
    }
}