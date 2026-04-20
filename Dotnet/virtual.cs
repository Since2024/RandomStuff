using System;

class Parent {
    // 'virtual' allows this method to be overridden
    public virtual void Show() {
        Console.WriteLine("This is parent");
    }
}

// FIX 1: Added ':' for inheritance
class Child : Parent {
    // 'override' changes the parent's behavior
    public override void Show() {
        Console.WriteLine("This is child"); // FIX 2: Added missing semicolon ';'
    }
}

class Program {
    public static void Main() {
        Parent p = new Parent();
        p.Show(); // Output: This is parent

        Child c = new Child();
        c.Show(); // Output: This is child

        // The "Magic" of Polymorphism:
        Parent pc = new Child();
        pc.Show(); // Output: This is child (because of override!)
        
        Console.ReadKey();
    }
}