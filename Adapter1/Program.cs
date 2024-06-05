using Adapter1;

public class Program
{
    public static void Main(string[] args)
    {
        Square square = new Square(6.0);
        IShape squareAdapter = new SquareAdapter(square);
        ShapeCalculator calculator = new ShapeCalculator();

        double area = calculator.CalculateArea(squareAdapter);
        Console.WriteLine($"The area of the square is: {area}");
    }
}