namespace Tuples
{
    using static System.Console;




    class Program
    {
        public static (int x, int y) GetPoint()
        {
            return (100, 200);
        }

        static void Main()
        {
            var point = GetPoint();
            WriteLine($"{nameof(point.x)} : {point.x}");
            WriteLine($"{nameof(point.y)} : {point.y}");

            // Deconstruction
            (int x, int y) = GetPoint();
            WriteLine($"{nameof(x)} : {x}");
            WriteLine($"{nameof(y)} : {y}");


            var pointObj = new Point { X = x, Y = y };
            var (x2, y2) = pointObj;
            WriteLine($"{nameof(x2)} : {x2}");
            WriteLine($"{nameof(y2)} : {y2}");

        }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void Deconstruct(out int x, out int y)
        {
            x = X;
            y = Y;
        }
    }

}
