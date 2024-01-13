using RehabFromHolidays;
#region N1
Point vertex1 = new Point(0, 0);
Point vertex2 = new Point(6, 0);
Point vertex3 = new Point(3, 3);

Triangle triangle = new Triangle(vertex1, vertex2, vertex3);

double height = triangle.HeightFromVertex3();

Console.WriteLine(height);
#endregion

#region N2
int[] numbers = { 123, 234, 345, 456, 567, 678, 789, 987, 876, 765 };

int count = numbers.CountIncreasingNumbers();

Console.WriteLine(count);
#endregion

#region N3
Point pointA = new Point(1, 1);
Point pointB = new Point(2, 3);

bool canReach = Point.CanKnightReach(pointA, pointB);

Console.WriteLine(canReach);
#endregion

#region For24
double x = 12;

int n = 10;

double result = x.CalculateCosApproximation(n);
Console.WriteLine(result);
#endregion

#region While21
int k = 2223;

bool hasOddDigits = k.CheckForOddDigits();

Console.WriteLine(hasOddDigits);
#endregion

#region N6
List<int> listOfNumbers = new List<int> { 5, 3, 8, 1, 7 };

List<int> sortedNumbers = listOfNumbers.SortAscending();

foreach (int num in sortedNumbers)
{
    Console.Write(num + " ");
}
#endregion

#region N7
string time1Input = "23:39:22";

string time2Input = "22:22:22";

try
{
    string sumTime = time1Input.AddTime(time2Input);
    Console.WriteLine(sumTime);
}
catch (FormatException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
#endregion

#region MinMax20
int[] extremalNumbersArray = { 4, 7, 2, 9, 3 }; 

int extremalCount = extremalNumbersArray.CountExtremalElements();
Console.WriteLine(extremalCount);
#endregion