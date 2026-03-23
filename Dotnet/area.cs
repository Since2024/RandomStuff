using System;

namespace s1
{
    public class area_Rect
    {
        int l = 20, b = 30;
        public void sum()
        {
            int s = l * b;
            Console.WriteLine("Area = {0}", s);
        }
    }

    public class area_Circle
    {
        double r = 3.5;

        public void display()
        {
            double a = 3.14 * r * r;
            Console.WriteLine("Area = {0}", a);
        }
    }

    class Program
    {
        public static void Main()
        {
            area_Rect a1 = new area_Rect();
            a1.sum();

            area_Circle c1 = new area_Circle();
            c1.display();
        }
    }
}