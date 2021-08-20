using System;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            //Point point = new Point(3, 5);
            //point.Print();
            Student student = new Student() { FirstName = "Den", LastName = "jopa"};
            string fullName = student.PrintFullName();
            Console.WriteLine(fullName);
            //DateTime dateTime = DateTime.Now;
            //dateTime.Print();
            //Console.WriteLine(dateTime.IsDayOfWeek(DayOfWeek.Friday));
        }
    }

    
    //class Point
    //{
    //    public Point()
    //    {
    //        _x = _y = 1;
    //    }

    //    public Point(int x, int y)
    //    {
    //        _x = x;
    //        _y = y;
    //    }

    //    private int _x;
    //    private int _y;

    //    public void Print()
    //    {
    //        Console.WriteLine($"X: {_x}\tY: {_y}");
    //    }
    //}
}
