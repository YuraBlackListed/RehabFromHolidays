using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RehabFromHolidays
{
    public class Solutions
    {
        private (int, int, int) CalculateDigits(int input)
        {
            int units = input % 10;
            int dozens = input % 100 / 10;
            int hundreds = input / 100;
            return (units, dozens, hundreds);
        }

        #region Integer
        public int Integer1(int input)
            => input / 100;
        public int Integer2(int input)
            => input / 1000;
        public int Integer3(int input)
            => input / 1024;
        public int Integer4(int A, int B)
            => A / B;
        public int Integer5(int A, int B)
            => A % B;
        public (int, int) Integer6(int input)
            => (input / 10, input % 10);
        public (int, int) Integer7(int input)
            => ((input / 10) + (input % 10), (input / 10) * (input % 10));
        public int Integer8(int input)
            => input / 10 + input % 10 * 10;
        public int Integer9(int input)
            => input / 100;
        public (int, int) Integer10(int input)
            => ((input % 10), (input % 100 / 10));
        public (int, int) Integer11(int input)
        {
            (int units, int dozens, int hundreds) = CalculateDigits(input);
            return (units + dozens + hundreds, units * dozens * hundreds);
        }
        public int Integer12(int input)
        {
            (int units, int dozens, int hundreds) = CalculateDigits(input);
            return units * 100 + dozens * 10 + hundreds;
        }
        public int Integer13(int input)
        {
            (int units, int dozens, int hundreds) = CalculateDigits(input);
            return dozens * 100 + hundreds * 10 + units;
        }
        public int Integer14(int input)
        {
            (int units, int dozens, int hundreds) = CalculateDigits(input);
            return units * 100 + hundreds * 10 + dozens;
        }
        public int Integer15(int input)
        {
            (int units, int dozens, int hundreds) = CalculateDigits(input);
            return dozens * 100 + hundreds * 10 + units;
        }
        public int Integer16(int input)
            => (input % 1000) / 100;
        public int Integer17(int input)
            => input / 1000;
        public int Integer18(int input)
            => input / 1000;
        public int Integer19(int input)
            => input / 60;
        public int Integer20(int input)
            => input / 60 / 60;
        public int Integer21(int input)
            => input % 60;
        public int Integer22(int input)
            => input % 60 % 60;
        public int Integer23(int input)
            => input % 60 % 60 / 60;
        public int Integer24(int input)
            => input % 7;
        public int Integer25(int input)
            => (input + 3) % 7;
        public int Integer26(int input)
            => (input + 1) % 7;
        public int Integer27(int input)
            => (input + 5) % 7;
        public int Integer28(int dayOfAYear, int weekNumberOfFirstDay)
            => (weekNumberOfFirstDay + dayOfAYear) % 7;
        public int Integer29(int a, int b, int c)
            => (a * b) / (c * c);
        public int Integer30(int input)
            => (input / 100) + 1;

        #endregion
        #region Boolean 

        public bool Boolean1(int input)
            => input > 0;
        public bool Boolean2(int input)
            => input % 2 != 0;
        public bool Boolean3(int input)
            => input % 2 == 0;
        public bool Boolean4(int a, int b)
            => a > 2 && b <= 3;
        public bool Boolean5(int a, int b)
            => a >= 0 && b < -2;
        public bool Boolean6(int a, int b, int c)
            => a < b && b < c;
        public bool Boolean7(int a, int b, int c)
            => (a < b && b < c) || (a > b && b > c);
        public bool Boolean8(int a, int b)
            => a % 2 != 0 && b % 2 != 0;
        public bool Boolean9(int a, int b)
            => a % 2 != 0 && b % 2 != 0;
        public bool Boolean10(int a, int b)
            => (a % 2 != 0 && b % 2 == 0) || (a % 2 == 0 && b % 2 != 0);
        public bool Boolean11(int a, int b)
            => (a % 2 == 0 && b % 2 == 0) || (a % 2 != 0 && b % 2 != 0);
        public bool Boolean12(int a, int b, int c)
            => a > 0 && b > 0 && c > 0;
        public bool Boolean13(int a, int b, int c)
            => a > 0 || b > 0 || c > 0;
        public bool Boolean14(int a, int b, int c)
            => (a > 0 && b <= 0 && c <= 0) || (a <= 0 && b > 0 && c <= 0) || (a <= 0 && b <= 0 && c > 0);
        public bool Boolean15(int a, int b, int c)
            => (a > 0 && b > 0 && c <= 0) || (a <= 0 && b > 0 && c > 0) || (a > 0 && b <= 0 && c > 0);
        public bool Boolean16(int input)
            => input % 2 == 0 && input > 9 && input < 100;
        public bool Boolean17(int input)
            => input % 2 != 0 && input > 99 && input < 1000;
        public bool Boolean18(int a, int b, int c)
            => a == b || b == c || a == c;
        public bool Boolean19(int a, int b, int c)
            => a == -b || b == -c || a == -c;
        public bool Boolean20(int input)
        {
            (int units, int dozens, int hundreds) = CalculateDigits(input);
            return units != dozens && units != hundreds && dozens != hundreds;
        }
        public bool Boolean21(int input)
        {
            (int units, int dozens, int hundreds) = CalculateDigits(input);
            return units < dozens && dozens < hundreds;
        }
        public bool Boolean22(int input)
        {
            (int units, int dozens, int hundreds) = CalculateDigits(input);
            return (units < dozens && dozens < hundreds) || (units > dozens && dozens > hundreds);
        }
        public bool Boolean23(int input)
            => input == Integer12(input);
        public bool Boolean24(int a, int b, int c)
            => a * b - 4 * a * c >= 0;
        public bool Boolean25(int x, int y)
            => x < 0 && y > 0;
        public bool Boolean26(int x, int y)
            => x > 0 && y < 0;
        public bool Boolean27(int x, int y)
            => (x < 0 && y > 0) || (x < 0 && y < 0);
        public bool Boolean28(int x, int y)
            => (x < 0 && y > 0) || (x < 0 && y < 0);
        public bool Boolean29(int x, int y)
            => (x > 0 && y > 0) || (x < 0 && y < 0);
        public bool Boolean30(int a, int b, int c)
            => a == b && c == b && c == a;
        public bool Boolean31(int a, int b, int c)
            => a == b || c == b || c == a;
        public bool Boolean32(int a, int b, int c)
            => (a == b + c) || (c == b + a) || (b == c + a);
        public bool Boolean33(int a, int b, int c)
            => (a + b) > c && (a + c) > b && (b + c) > a;
        public bool Boolean34(int a, int b, int c)
            => (a + b) > c && (a + c) > b && (b + c) > a;
        public bool Boolean35(int x, int y)
            => (x + y) % 2 != 0;
        public bool Boolean36(int x1, int y1, int x2, int y2)
            => (x1 + y1) % 2 != 0 && (x2 + y2) % 2 == 0 && (x2 + y2) % 2 != 0 && (x1 + y1) % 2 == 0;
        public bool Boolean37(int x1, int y1, int x2, int y2)
            => x2 - x1 <= 1 && y2 - y1 <= 1;
        public bool Boolean38(int x1, int y1, int x2, int y2)
            => Math.Abs(x2 - x1) == Math.Abs(y2 - y1);
        public bool Boolean39(int x1, int y1, int x2, int y2)
            => (x1 == x2) || (y1 == y2) || (Math.Abs(x2 - x1) == Math.Abs(y2 - y1));
        public bool Boolean40(int x1, int y1, int x2, int y2)
        {
            int deltaX = Math.Abs(x2 - x1);
            int deltaY = Math.Abs(y2 - y1);
            return (deltaX == 2 && deltaY == 1) || (deltaX == 1 && deltaY == 2);
        }
        #endregion
        #region If
        public int If1(int input)
        {
            if (input > 0)
            {
                input++;
            }
            return input;
        }
        public int If2(int input)
        {
            if (input > 0)
            {
                input++;
            }
            else
            {
                input -= 2;
            }
            return input;
        }
        public int If3(int input)
        {
            if (input > 0)
            {
                input++;
            }
            else if (input < 0)
            {
                input -= 2;
            }
            else
            {
                input = 10;
            }
            return input;
        }
        public int If4(int a, int b, int c)
        {
            int n = 0;
            if (a > 0)
            {
                n++;
            }
            if (b > 0)
            {
                n++;
            }
            if (c > 0)
            {
                n++;
            }
            return n;
        }
        public (int, int) If5(int a, int b, int c)
        {
            int npos = 0;
            int nnegative = 0;
            if (a > 0)
            {
                npos++;
            }
            else
            {
                nnegative++;
            }
            if (b > 0)
            {
                npos++;
            }
            else
            {
                nnegative++;
            }
            if (c > 0)
            {
                npos++;
            }
            else
            {
                nnegative++;
            }
            return (npos, nnegative);
        }
        //Ahh, fagg it, gon do tougher stuff 
        public int If19(int a, int b, int c, int d)
        {
            if (a == b && b == c)
            {
                return 1;
            }
            else if (a == b && a == d)
            {
                return 2;
            }
            else if (a == c && a == d)
            {
                return 3;
            }
            else if (b == d && b == d)
            {
                return 4;
            }
            else
            {
                return 5;
            }
        }
        public (int, int) If20(int a, int b, int c)
        {
            if (a - b < a - c)
            {
                return (b, a - b);
            }
            return (c, a - c);
        }
        public int If21(int x, int y)
        {
            if ((x == 0) && (y == 0))
            {
                return 0;
            }
            else if (x == 0)
            {
                return 1;
            }
            else if (y == 0)
            {
                return 2;
            }
            else
            {
                return 3;
            }
        }
        public int If22(int x, int y)
        {
            if (x > 0 && y > 0)
            {
                return 1;
            }
            else if (x < 0 && y > 0)
            {
                return 2;
            }
            else if (x < 0 && y < 0)
            {
                return 3;
            }
            else
            {
                return 4;
            }
        }
        public (int, int) If23(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            int x4 = 0;
            int y4 = 0;
            if (x1 != x2 && y1 != y2)
            {
                x4 = x3;
                y4 = y1;
            }
            else if (x1 != x3 && y1 != y3)
            {
                x4 = x2;
                y4 = y1;
            }
            else
            {
                x4 = x1;
                y4 = y2;
            }
            return (x4, y4);
        }
        public double If24(int input)
        {
            if (input > 0)
            {
                return 2 * Math.Sin(input);
            }
            else
            {
                return 6 - input;
            }
        }
        public int If25(int input)
        {
            if (input < -2 || input > 2)
            {
                return 2 * input;
            }
            else
            {
                return -3 * input;
            }

        }
        public int If26(int input)
        {
            if (input <= 0)
            {
                return -input;
            }
            else if (input > 0 && input < 2)
            {
                return input * input;
            }
            else
            {
                return 4;
            }

        }
        public int If27(int input)
        {
            if (input < 0)
            {
                return 0;
            }
            else
            {
                int integerPart = (int)input;
                if (integerPart % 2 == 0)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }

        }
        public int If28(int input)
        {
            if ((input % 4 == 0 && input % 100 != 0) || (input % 400 == 0))
            {
                return 366;
            }
            else
            {
                return 365;
            }
        }
        public string If29(int input)
        {
            string description;
            if (input < 0)
            {
                if (input % 2 == 0)
                {
                    description = "negative even number";
                }
                else
                {
                    description = "negative odd number";
                }
            }
            else if (input == 0)
            {
                description = "zero number";
            }
            else
            {
                if (input % 2 == 0)
                {
                    description = "positive even number";
                }
                else
                {
                    description = "positive odd number";
                }
            }
            return description;
        }
        public string If30(int input)
        {
            string description;
            if (input >= 1 && input <= 9)
            {
                description = "single digit number";
            }
            else if (input >= 10 && input <= 99)
            {
                if (input % 2 == 0)
                {
                    description = "even two-digit number";
                }
                else
                {
                    description = "odd two-digit number";
                }
            }
            else if (input >= 100 && input <= 999)
            {
                if (input % 2 == 0)
                {
                    description = "even three-digit number";
                }
                else
                {
                    description = "odd three-digit number";
                }
            }
            else
            {
                description = "The number is not in the range 1 to 999.";
            }
            return description;
        }
        #endregion
        #region Case
        public void Case12(int input)
        {
            double radius;
            double diameter;
            double length;
            double area;

            switch (input)
            {
                case 1:
                    radius = input;
                    diameter = 2 * radius;
                    length = 2 * 3.14 * radius;
                    area = 3.14 * radius * radius;
                    break;
                case 2:
                    diameter = input;
                    radius = diameter / 2;
                    length = 2 * 3.14 * radius;
                    area = 3.14 * radius * radius;
                    break;
                case 3:
                    length = input;
                    radius = length / (2 * 3.14);
                    diameter = 2 * radius;
                    area = 3.14 * radius * radius;
                    break;
                case 4:
                    area = input;
                    radius = Math.Sqrt(area / 3.14);
                    diameter = 2 * radius;
                    length = 2 * 3.14 * radius;
                    break;
                default:
                    Console.WriteLine("Wrong element number");
                    return;
            }

            Console.WriteLine(radius);
            Console.WriteLine(diameter);
            Console.WriteLine(length);
            Console.WriteLine(area);
        }
        public void Case13(int input)
        {
            double a;
            double c;
            double h;
            double s;

            switch (input)
            {
                case 1:
                    a = input;
                    c = a * Math.Sqrt(2);
                    h = c / 2;
                    s = (c * h) / 2;
                    break;
                case 2:
                    c = input;
                    a = c / Math.Sqrt(2);
                    h = c / 2;
                    s = (c * h) / 2;
                    break;
                case 3:
                    h = input;
                    c = 2 * h;
                    a = c / Math.Sqrt(2);
                    s = (c * h) / 2;
                    break;
                case 4:
                    s = input;
                    h = Math.Sqrt((2 * s) / 2);
                    c = 2 * h;
                    a = c / Math.Sqrt(2);
                    break;
                default:
                    Console.WriteLine("Wrong element number");
                    return;
            }

            Console.WriteLine($"Leg (a): {a}");
            Console.WriteLine($"Hypotenuse (c): {c}");
            Console.WriteLine($"Height (h): {h}");
            Console.WriteLine($"Square (S): {s}");
        }
        public void Case14(int input)
        {
            double a;
            double r1;
            double r2;
            double s;

            switch (input)
            {
                case 1:
                    a = input;
                    r1 = (a * Math.Sqrt(3)) / 6;
                    r2 = 2 * r1;
                    s = (a * a * Math.Sqrt(3)) / 4;
                    break;
                case 2:
                    r1 = input;
                    a = (r1 * 6) / Math.Sqrt(3);
                    r2 = 2 * r1;
                    s = (a * a * Math.Sqrt(3)) / 4;
                    break;
                case 3:
                    r2 = input;
                    r1 = r2 / 2;
                    a = (r1 * 6) / Math.Sqrt(3);
                    s = (a * a * Math.Sqrt(3)) / 4;
                    break;
                case 4:
                    s = input;
                    a = Math.Sqrt((4 * s) / Math.Sqrt(3));
                    r1 = (a * Math.Sqrt(3)) / 6;
                    r2 = 2 * r1;
                    break;
                default:
                    Console.WriteLine("Wrong element number");
                    return;
            }

            Console.WriteLine(a);
            Console.WriteLine(r1);
            Console.WriteLine(r2);
            Console.WriteLine(s);
        }
        public void Case18(int input)
        {
            if (input >= 100 && input <= 999)
            {
                string[] hundreds = { "", "hundred", "two hundred", "three hundred", "four hundred", "five hundred", "six hundred", "seven hundred", "eight hundred", "nine hundred" };
                string[] tens = { "", "", "twenty", "thirty", "fourty", "fifty", "sixty", "sevety", "eighty", "ninety" };
                string[] ones = { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

                int hundredsDigit = input / 100;
                int tensDigit = (input % 100) / 10;
                int onesDigit = input % 10;

                string description = $"{hundreds[hundredsDigit]}";

                if (tensDigit == 1)
                {
                    description += $" {ones[tensDigit * 10 + onesDigit]}";
                }
                else
                {
                    description += $" {tens[tensDigit]} {ones[onesDigit]}";
                }

                Console.WriteLine($"{input} — {description}");
            }
            else
            {
                Console.WriteLine("Number must be between 100 and 999");
            }
        }
        public void Case19(int input)
        {
            string[] colors = { "green", "red", "yellow", "white", "black" };
            string[] animals = { "rat", "cow", "tiger", "rabbit", "dragon", "snake", "horse", "sheep", "monke", "chicken", "dog", "pig" };

            int startYear = 1984;
            int cycleYears = 60;

            int yearInCycle = (input - startYear) % cycleYears;
            int colorIndex = yearInCycle / 12;
            int animalIndex = yearInCycle % 12;

            string color = colors[colorIndex];
            string animal = animals[animalIndex];

            Console.WriteLine($"{input} year — year {color} {animal}");
        }

        //Case 20: same shit, I'm too lazy to do this
        #endregion
        #region For
        public double For20(int input)
        {
            double sum = 0;
            double factorial = 1;

            for (int i = 1; i <= input; i++)
            {
                factorial *= i;
                sum += factorial;
            }

            return sum;
        }
        public double For21(int input)
        {
            double sum = 1.0;
            double factorial = 1.0;

            for (int i = 1; i <= input; i++)
            {
                factorial *= i;
                sum += 1.0 / factorial;
            }

            return sum;
        }
        public double For22(int n, int x)
        {
            double sum = 1.0;
            double term = 1.0;
            double factorial = 1.0;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
                term *= x;
                term /= factorial;
                sum += term;
            }

            return sum;
        }
        //same stuff till For29
        public double For27(double X, int N)
        {
            double sum = 0;
            double powerX = X;
            double factorial = 1;

            for (int i = 1; i <= N; i++)
            {
                factorial *= 2 * i * (2 * i - 1);
                sum += (powerX * factorial) / ((2 * i) * (2 * i + 1));
                powerX *= X * X;
            }

            return sum;
        }
        public double For28(double X, int N)
        {
            double sum = 1;
            double powerX = X;
            double denominator = 2;

            for (int i = 1; i <= N; i++)
            {
                double term = (i % 2 == 0) ? -1 : 1;
                term *= powerX / denominator;
                sum += term;
                powerX *= X;
                denominator *= 2 * (i + 1);
            }

            return sum;
        }
        public void For29(int a, int b, int n)
        {
            double H = (b - a) / n;

            Console.WriteLine($"Length of every line segment: {H}");

            for (int i = 0; i <= n; i++)
            {
                double point = a + i * H;
                Console.WriteLine(point);
            }
        }
        public void For30(int a, int n, int h)
        {
            Console.WriteLine($"Length of every line segment: {h}");

            for (int i = 0; i <= n; i++)
            {
                double X = a + i * h;
                double result = 1 - Math.Sin(X);
                Console.WriteLine($"F({X}) = {result}");
            }
        }
        public void For31(int n)
        {
            double[] sequence = new double[n + 1];
            sequence[0] = 2;

            for (int K = 1; K <= n; K++)
            {
                sequence[K] = 2 + 1 / sequence[K - 1];
            }

            Console.WriteLine("Sequence elements:");

            for (int K = 1; K <= n; K++)
            {
                Console.WriteLine($"A{K} = {sequence[K]}");
            }

        }
        public void For35(int n)
        {
            int[] sequence = new int[n];
            sequence[0] = 1;
            sequence[1] = 2;
            sequence[2] = 3;

            for (int K = 3; K < n; K++)
            {
                sequence[K] = sequence[K - 1] + sequence[K - 2] - 2 * sequence[K - 3];
            }

            Console.WriteLine("Sequence elements:");

            for (int K = 0; K < n; K++)
            {
                Console.WriteLine($"A{K + 1} = {sequence[K]}");
            }
        }
        #endregion
        #region While
        public void While11(int N)
        {
            int k = 1;
            int sum = 1;

            while (sum < N)
            {
                k++;
                sum += k;
            }
            Console.WriteLine(k);
            Console.WriteLine(sum);
        }
        public void While13(double A)
        {
            double sum = 0;
            int k = 1;

            while (sum <= A)
            {
                k++;
                sum += 1.0 / k;
            }

            Console.WriteLine(k);
            Console.WriteLine(sum);
        }
        public void While14(double A)
        {
            double sum = 0;
            int k = 1;

            while (sum < A)
            {
                k++;
                sum += 1.0 / k;
            }

            k--;

            Console.WriteLine(k);
            Console.WriteLine(sum);
        }
        public void While15(double P)
        {
            double initialDeposit = 1000.0;
            double targetAmount = 1100.0;
            int k = 0;

            while (initialDeposit < targetAmount)
            {
                initialDeposit += initialDeposit * (P / 100.0);
                k++;
            }

            Console.WriteLine(k);
            Console.WriteLine(targetAmount);
            Console.WriteLine(initialDeposit);
        }
        public void While17(int N)
        {
            Console.WriteLine("Digits of the number N, starting from the rightmost (ones place):");

            while (N > 0)
            {
                int digit = N % 10;
                Console.WriteLine(digit);
                N /= 10;
            }
        }
        public void While18(int N)
        {
            int sumOfDigits = 0;
            int numberOfDigits = 0;
            int digit = N % 10;

            while (N > 0)
            {
                sumOfDigits += digit;
                numberOfDigits++;
                N /= 10;
            }
            Console.WriteLine(numberOfDigits);
            Console.WriteLine(sumOfDigits);
        }
        public void While19(int N)
        {
            int reversedNumber = 0;
            while (N > 0)
            {
                int digit = N % 10;
                reversedNumber = reversedNumber * 10 + digit;
                N /= 10;
            }
            Console.WriteLine(reversedNumber);
        }
        public void While20(int N)
        {
            int digit = N % 10;
            while (N > 0)
            {
                if (digit == 2)
                {
                    Console.WriteLine(true);
                    break;
                }
                N /= 10;
            }
            
        }
        public void While22(int N)
        {
            for (int i = 2; i <= Math.Sqrt(N); i++)
            {
                if (N % i == 0)
                {
                    Console.WriteLine(true);
                    break;
                }
            }
        }
        public void While23(int A, int B)
        {
            while (B != 0)
            {
                int temp = B;
                B = A % B;
                A = temp;
            }
            Console.WriteLine(A);
        }
        public bool While24(int N)
        {
            if (N == 0 || N == 1)
            {
                return true;
            }

            int F1 = 0;
            int F2 = 1;

            while (F2 < N)
            {
                int temp = F1;
                F1 = F2;
                F2 = temp + F2;

                if (F2 == N)
                {
                    return true;
                }
            }

            return false;
        }
        public int While25(int N)
        {
            int a = 1;
            int b = 1;

            while (true)
            {
                int temp = a;
                a = b;
                b = temp + b;

                if (b > N)
                {
                    return b;
                }
            }
        }
        public void While28(int epsilon)
        {
            int k = 2;
            double akMinus1 = 2;
            double ak = akMinus1 + 1 / akMinus1;

            while (Math.Abs(ak - akMinus1) >= epsilon)
            {
                akMinus1 = ak;
                ak = akMinus1 + 1 / akMinus1;
                k++;
            }

            Console.WriteLine(k);
            Console.WriteLine(akMinus1);
            Console.WriteLine(ak);
        }
        public int While30(int A, int B, int C)
        {
            int squaresInWidth = A / C;
            int squaresInHeight = B / C;

            return squaresInWidth * squaresInHeight;
        }
        #endregion
        #region MinMax
        public (int, int) MinMax8(int[] numbers)
        {
            int min = numbers[0];
            int firstMinIndex = 0;
            int lastMinIndex = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                    firstMinIndex = i;
                    lastMinIndex = i;
                }
                else if (numbers[i] == min)
                {
                    lastMinIndex = i;
                }
            }
            return (firstMinIndex, lastMinIndex);
        }
        public int MinMax10(int[] numbers)
        {
            int min = numbers[0];
            int max = numbers[0];
            int minIndex = 0;
            int maxIndex = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                    minIndex = i;
                }
                else if (numbers[i] > max)
                {
                    max = numbers[i];
                    maxIndex = i;
                }
            }
            return (minIndex < maxIndex) ? minIndex : maxIndex;
        } 
        public int MinMax16(int[] numbers)
        {
            int min = numbers[0];
            int minIndex = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                    minIndex = i;
                }
            }
            return minIndex;
        }
        public double MinMax21(int[] numbers)
        {
            double minValue = numbers.Min();
            double maxValue = numbers.Max();

            int[] filteredValues = numbers.Where(val => val != minValue && val != maxValue).ToArray();

            double averageValue = filteredValues.Average();

            return averageValue;
        }
        public int MinMax26(int[] numbers)
        {
            int maxConsecutiveEvenCount = 0;
            int currentConsecutiveEvenCount = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    currentConsecutiveEvenCount++;
                }
                else
                {
                    maxConsecutiveEvenCount = Math.Max(maxConsecutiveEvenCount, currentConsecutiveEvenCount);

                    currentConsecutiveEvenCount = 0;
                }
            }

            maxConsecutiveEvenCount = Math.Max(maxConsecutiveEvenCount, currentConsecutiveEvenCount);

            if (maxConsecutiveEvenCount > 0)
            {
                return maxConsecutiveEvenCount;
            }
            return 0;
        }
        public (int, int) MinMax27(int[] numbers)
        {
            int longestSequenceStartIndex = 0;
            int longestSequenceLength = 1;
            int currentSequenceStartIndex = 0;
            int currentSequenceLength = 1;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentSequenceLength++;
                }
                else
                {
                    if (currentSequenceLength > longestSequenceLength)
                    {
                        longestSequenceStartIndex = currentSequenceStartIndex;
                        longestSequenceLength = currentSequenceLength;
                    }

                    currentSequenceStartIndex = i;
                    currentSequenceLength = 1;
                }
            }

            if (currentSequenceLength > longestSequenceLength)
            {
                longestSequenceStartIndex = currentSequenceStartIndex;
                longestSequenceLength = currentSequenceLength;
            }
            return (longestSequenceStartIndex, longestSequenceLength);
        }
        #endregion
        #region Array
        public void Array10(int[] numbers)
        {
            Console.WriteLine("Even numbers in ascending index order:");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine($"Index {i}: {numbers[i]}");
                }
            }

            Console.WriteLine("Odd numbers in descending order of indices:");
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                if (numbers[i] % 2 != 0)
                {
                    Console.WriteLine($"Index {i}: {numbers[i]}");
                }
            }
        }
        public void Array23(int[] numbers, int K, int L)
        {
            double sum = 0;
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i < K - 1 || i > L - 1)
                {
                    sum += numbers[i];
                    count++;
                }
            }

            if (count > 0)
            {
                double average = sum / count;
                Console.WriteLine($"The arithmetic mean of elements, except elements with numbers from{K} to {L}: {average}");
            }
            else
            {
                Console.WriteLine("There are no elements in the specified range.");
            }
        }
        public int Array25(int[] numbers)
        {
            bool isGeometricProgression = true;
            int commonRatio = numbers[1] / numbers[0];

            for (int i = 2; i < numbers.Length; i++)
            {
                if (numbers[i] != numbers[i - 1] * commonRatio)
                {
                    isGeometricProgression = false;
                    break;
                }
            }

            if (isGeometricProgression)
            {
                return commonRatio;
            }
            return 0;
        }
        public void Array30(int[] numbers)
        {
            List<int> indexes = new List<int>();

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    indexes.Add(i);
                }
            }

            foreach (int index in indexes)
            {
                Console.WriteLine($"Index {index}: {numbers[index]}");
            }

            Console.WriteLine($"Number of such elements: {indexes.Count}");
        }
        public int Array38(int[] numbers)
        {
            int decreasingSegmentsCount = 0;
            bool isInDecreasingSegment = false;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1])
                {
                    if (!isInDecreasingSegment)
                    {
                        isInDecreasingSegment = true;
                        decreasingSegmentsCount++;
                    }
                }
                else
                {
                    isInDecreasingSegment = false;
                }
            }
            return decreasingSegmentsCount;
        }
        public int Array50(int[] numbers)
        {
            int inversionCount = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        inversionCount++;
                    }
                }
            }

            return inversionCount;
        }
        #endregion

        public void Series40(int K)
        {
            List<int[]> sets = new List<int[]>();

            for (int i = 0; i < K; i++)
            {
                int[] set = ReadSet();
                sets.Add(set);
            }

            for (int i = 0; i < K; i++)
            {
                if (IsSawtooth(sets[i]))
                {
                    Console.WriteLine(sets[i].Length);
                }
                else
                {
                    int firstNonSawtooth = FindFirstNonSawtooth(sets[i]);
                    Console.WriteLine(firstNonSawtooth);
                }
            }
        }
        static int[] ReadSet()
        {
            List<int> set = new List<int>();
            int num;
            while ((num = int.Parse(Console.ReadLine())) != 0)
            {
                set.Add(num);
            }
            return set.ToArray();
        }

        static bool IsSawtooth(int[] set)
        {
            if (set.Length < 3)
            {
                return false;
            }

            bool increasing = set[0] < set[1];

            for (int i = 1; i < set.Length - 1; i++)
            {
                if ((increasing && set[i] >= set[i + 1]) || (!increasing && set[i] <= set[i + 1]))
                {
                    return false;
                }
                increasing = !increasing;
            }

            return true;
        }

        static int FindFirstNonSawtooth(int[] set)
        {
            for (int i = 0; i < set.Length; i++)
            {
                if (i % 2 == 0 && set[i] % 2 != 0)
                {
                    return set[i];
                }
                else if (i % 2 != 0 && set[i] % 2 == 0)
                {
                    return set[i];
                }
            }
            return -1;
        }
    }

}

/*Integer 8, 27
Boolean 39
If 18, 27
For 10, 25
While 10
Series 23
Proc 28, 29
Minmax 23, 28
Array 28, 47, 74*/
