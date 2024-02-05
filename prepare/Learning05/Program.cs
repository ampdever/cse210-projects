using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning05 World!");

        // Square mySquare = new("blue", 5.5);

        // Console.WriteLine(mySquare.GetColor());
        // Console.WriteLine(mySquare.GetArea());

        // Circle myCircle = new("red", 5.5);
        // Console.WriteLine(myCircle.GetColor());
        // Console.WriteLine(myCircle.GetArea());

        // Rectangle myRec = new("yellow", 2.0, 3.0);
        // Console.WriteLine(myRec.GetColor());
        // Console.WriteLine(myRec.GetArea());

        List<Shape> shapes = new List<Shape>();
        Square newSquare = new("green", 2);
        Circle newCircle = new("orange", 2);
        Rectangle newRectangle = new("pink", 1, 2);
        shapes.Add(newSquare);
        shapes.Add(newCircle);
        shapes.Add(newRectangle);

        foreach(Shape shape in shapes) {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }

    }
}