using RehabFromHolidays;

Solutions solutions = new Solutions();

solutions.Begin40(2, 3, 8, 1, -1, 1);
Console.WriteLine(solutions.Bolean20(345));
Console.WriteLine(solutions.Bolean33(3, 4, 5));
Console.WriteLine(solutions.If19(5, 3, 3, 3));
Console.WriteLine(solutions.For23(1, 5));
Console.WriteLine(solutions.Proc14(3, 4, 5));

int[] array = { 1, 5, 2, 8, 7, 8, 3, 4, 8 };
Console.WriteLine(solutions.MinMax17(array));

Point[] setA = { new Point(1, 2), new Point(3, 4), new Point(5, 6) };
Point[] setB = { new Point(7, 8), new Point(9, 10), new Point(11, 12) };
Console.WriteLine(solutions.Array135(setA, setB));

int[,] matrix = {
        {1, 2, 3},
        {4, 5, 6},
        {7, 8, 9}
    };

solutions.PrintMatrix(matrix);

solutions.Matrix51(matrix);

solutions.PrintMatrix(matrix);

solutions.PrintUppercaseLetters(10);

List<Point> points = new List<Point>
        {
            new Point(1, 2),
            new Point(3, 4),
            new Point(5, 6),
            new Point(7, 8),
            new Point(9, 10)
        };

double x0 = 4;
double y0 = 5;
double R = 3;

List<Point> pointsWithinDistance = solutions.Task12(points, new Point(x0, y0), R);
foreach (var point in pointsWithinDistance)
{
    double distance = new Point(x0, y0).DistanceTo(point);
    Console.WriteLine($"Point: {point}, Distance: {distance}");
}