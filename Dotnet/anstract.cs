using System;
abstract class parent{
    public void show(){
        Console.WriteLine("This is a parent abstract class");
    }
}
class child parent{
    public void display(){
        Console.WriteLine("THis is child class");
    }
}
class Program{
    public static void Math(){
        child  ct = new child();
        ct.show();
        ct.display();
        Console.ReadKey();
    }
}