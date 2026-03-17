using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the first number: ");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("ENter operator (+, -, *, /): ");
        string op = Console.ReadLine();

        Console.WriteLine("Enter SEcond number: ");
        double b = double.Parse(Console.ReadLine());

        double result;

        switch (op)
        {
            case "+":
            result = a+ b;
            Console.WriteLine("Addition of those number is : " +result);
        }
        {
            case "-":
            result = a - b;
            Console.WriteLine("Suntraction of those number is : " +result);
        }
        {
            case "*":
            result = a * b;
            Console.WriteLine("Multiplication of those number is : " +result);
        }{
            case "/":
            if (b == 0){
                Console.WriteLine("Cannot divided by zero."); 
            }
            else{
            result = a / b;
            Console.WriteLine("Division of those number is : " +result);
            }
            break;
            default:
            Console.WriteLine("Invalid operator.");
            break;
        }
    }
}
