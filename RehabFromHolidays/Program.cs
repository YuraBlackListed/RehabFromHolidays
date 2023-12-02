using RehabFromHolidays;

Solutions solutions = new Solutions();

var squares = solutions.For14().Take(1);

foreach (var square in squares)
{
    Console.WriteLine(square);
}
Console.WriteLine(solutions.For23(2, 3));
int[] series25numbers = new int[] {1030, 2030, 3020, 4020, 5030};
Console.WriteLine(solutions.Series25(series25numbers));

int[] minmax24numbers = new int[] {1, 2, 10, 9, 3 };
Console.WriteLine(solutions.Minmax24(minmax24numbers));

int[] minmax26numbers = new int[] {1, 2, 10, 2, 3 };
Console.WriteLine(solutions.Minmax26(minmax26numbers));

int[] array17numbers = new int[] {1, 2, 10, 2, 3 };
foreach (int number in solutions.Array17(array17numbers))
{
    Console.WriteLine(number);
}

int[] array25numbers = new int[] { 2, 4, 8, 16, 32 };
Console.WriteLine(solutions.Array25(array25numbers));

int[] array48numbers = new int[] { 2, 2, 2, 16, 32 };
Console.WriteLine(solutions.Array48(array48numbers));

int[] array66numbers = new int[] { 2, 2, 2, 16, 32 };
solutions.IncreaseEvenNumbers(array66numbers);
foreach (int number in array66numbers)
{
    Console.WriteLine(number);
}

int[] array77numbers = new int[] { 4, 3, 2, 16, 3, 4 };
solutions.SquareLocalMinimum(array77numbers);
foreach (int number in array77numbers)
{
    Console.WriteLine(number);
}


Point[] points = new Point[] { new Point(1, 2), new Point(3, 4), new Point(10, 40), new Point(10, 40) };

Tuple<Point, Point, double> result = solutions.FindMaxDistancePoints(points);

Console.WriteLine("Pair of points with maximum distance:");
Console.WriteLine($"Point 1: {result.Item1}");
Console.WriteLine($"Point 2: {result.Item2}");
Console.WriteLine($"Maximum distance: {result.Item3}");
