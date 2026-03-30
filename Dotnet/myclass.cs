using System;

class MyClass {
    private int x; // Encapsulated variable

    public void SetX(int i) {
        x = i;
    }

    public int GetX() {
        return x;
    }
}

class Program {
    public static void Main() {
        MyClass m1 = new MyClass(); // 1. Create the object
        
        m1.SetX(20);                // 2. Set the value
        
        // FIX: Use the object 'm1' to call the method, not 'new'
        int v1 = m1.GetX();         
        
        Console.WriteLine("The value of x is: " + v1);
        Console.ReadKey();
    }
}