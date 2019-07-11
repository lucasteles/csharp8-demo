namespace RecursivePatterns
{
    abstract class Shape
    {
        public Point Point { get; set; }
    }

    class Triangle : Shape
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        public void Deconstruct(out int a, out int b, out int c, out Point point)
        {
            a = A;
            b = B;
            c = C;

            point = Point;
        }
    }

    class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public void Deconstruct(out int width, out int height, out Point point)
        {
            width = Width;
            height = Height;
            point = Point;
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


    class Explain
    {
        public string DoIt(Shape shape)
        {
            return shape switch
            {
                Triangle t when t.A != t.B => $"A != B, ({t.A} != {t.B})",

                Triangle (var a, var b, var c, Point p) => $"A: {a}, B: {b}, C: {c}, Y: {p.Y}",

                Rectangle (0, 0, _) r => "0, 0",

                Rectangle { Width: 100 } r => $"Height: {r.Height}",
                
                Rectangle r => $"Point X: {r.Point.X}, Y: {r.Point.Y}",

                _ => "Other shapes"

            };
        }
    }


}
