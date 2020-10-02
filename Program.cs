using System;

namespace Point_và_MoveablePoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Point");
            Point point = new Point(5.6f, 12.11f);
            Console.WriteLine(point);
            Console.WriteLine();
            Console.WriteLine("MovablePoint");
            MovablePoint movablePoint = new MovablePoint(5.6f, 6.6f, 11.2f, 12.1f);
            Console.WriteLine(movablePoint);
        }
    }
}
