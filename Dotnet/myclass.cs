using System;

// An abstract class cannot be instantiated (you can't do 'new parent()')
abstract class Parent {
    public void Show() {
        Console.WriteLine("This is a parent abstract class");
    }
}

// FIX 1: Use the ':' symbol to inherit from the parent class
class Child : Parent {
    public void Display() {
        Console.WriteLine("This is child class");
    }
}

class Program {
    // FIX 2: The entry point must be named 'Main', not 'Math'
    public static void Main() {
        Child ct = new Child();
        
        // This comes from the Parent class via inheritance
        ct.Show(); 
        
        // This comes from the Child class itself
        ct.Display(); 
        
        Console.ReadKey();
    }
}