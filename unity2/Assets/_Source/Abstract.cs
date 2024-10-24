using System;

public abstract class ATetragon
{
    protected float a;
    protected float b;
    protected float angle;

    public ATetragon(float a, float b, float angle)
    {
        this.a = a;
        this.b = b;
        this.angle = angle;
    }

    public virtual float CountPerimeter()
    {
        return 2 * (a + b);
    }

    public virtual float CountArea()
    {
        return a * b / 2 * (float)Math.Sin(angle);
    }
}

public class Quadrilateral : ATetragon
{
    public Quadrilateral(float a, float b, float angle) : base(a, b, angle) { }

    public override string ToString()
    {
        return $"QUADRILATERIAL\nPerimeter = {CountPerimeter()}\nArea = {CountArea()}\n\n";
    }
}

public class ConvexQuadrilateral : Quadrilateral
{
    public ConvexQuadrilateral(float a, float b, float angle) : base(a, b, angle) { }

    public override string ToString()
    {
        return $"CONVEXQUADRILATERIAL\nPerimeter = {CountPerimeter()}\nArea = {CountArea()}\n\n";
    }
}

public class Parallelogram : ConvexQuadrilateral
{
    public Parallelogram(float a, float b, float angle) : base(a, b, angle) { }

    public override float CountArea()
    {
        // Площадь параллелограмма: A = a * h, где h = b * sin(angle)
        float height = b * (float)Math.Sin(angle * Math.PI / 180);
        return a * height;
    }

    public override string ToString()
    {
        return $"PARALLELOGRAM\nPerimeter = {CountPerimeter()}\nArea = {CountArea()}\n\n";
    }
}

public class Rhombus : Parallelogram
{
    public Rhombus(float side) : base(side, side, 60) // угол 60 градусов для примера
    {
        a = side; b = side; angle = 60;
    }

    public override string ToString()
    {
        return $"RHOMBUS\nPerimeter = {CountPerimeter()}\nArea = {CountArea()}\n\n";
    }
}

public class Rectangle : Parallelogram
{
    public Rectangle(float width, float height) : base(width, height, 90) { }

    public override string ToString()
    {
        return $"RECTANGLE\nPerimeter = {CountPerimeter()}\nArea = {CountArea()}\n\n";
    }
}

public class Square : Rectangle
{
    public Square(float side) : base(side, side) { }

    public override string ToString()
    {
        return $"SQUARE\nPerimeter = {CountPerimeter()}\nArea = {CountArea()}\n\n";
    }
}

class Program
{
    static void Main(string[] args)
    {
        ATetragon[] shapes = new ATetragon[]
        {
            new Quadrilateral(4, 5, 60),
            new ConvexQuadrilateral(3, 4, 75),
            new Parallelogram(6, 4, 45),
            new Rhombus(5),
            new Rectangle(4, 6),
            new Square(3)
        };

        foreach (var shape in shapes)
        {
            Console.WriteLine(shape);
        }
    }
}