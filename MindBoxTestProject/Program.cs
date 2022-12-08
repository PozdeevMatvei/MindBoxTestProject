using FiguresLibrary.Abstract;
using FiguresLibrary.Concret;

Triangle triangle = new Triangle(44, 117,125);
Figure circle = new Circle(2);

Console.WriteLine(triangle.Area);
Console.WriteLine(triangle.IsRectangular);
Console.WriteLine(triangle.Type);
Console.WriteLine(circle.Area);
Console.WriteLine(circle.Type);