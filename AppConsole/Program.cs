using Geometry;
internal class Program
{
    private static void Main(string[] args)
    {
        Triangle triangle = new Triangle(6, 4, 5);
        Console.WriteLine(triangle.IsRectangular);
        Console.WriteLine($"{triangle.Square()}");
    }
}