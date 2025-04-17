namespace Day5Part01
{
    internal class Program
    {
        static void TestDefensiveCode()
        {
            int x, y;
            Console.Write("Enter first integer X: ");
            while (!int.TryParse(Console.ReadLine(), out x) || x <= 0)
            {
                Console.Write("Please enter a positive integer for X: ");
            }

            Console.Write("Enter second integer Y: ");
            while (!int.TryParse(Console.ReadLine(), out y) || y <= 1)
            {
                Console.Write("Please enter an integer greater than 1 for Y: ");
            }

            Console.WriteLine($"You entered X = {x} and Y = {y}");
        }
        static void SumAndMultiply(int a, int b, out int sum, out int product)
        {
            sum = a + b;
            product = a * b;
        }
        static void PrintStringMultipleTimes(string message, int times = 5)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine(message);
            }
        }
        static int SumArray(params int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            #region Problem 1

            try
            {
                Console.Write("Enter first integer: ");
                int numerator = int.Parse(Console.ReadLine());

                Console.Write("Enter second integer: ");
                int denominator = int.Parse(Console.ReadLine());

                int result1 = numerator / denominator;
                Console.WriteLine($"Result of {numerator} / {denominator} = {result1}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero.");
            }
            finally
            {
                Console.WriteLine("Operation complete");
            }

            #endregion

            #region Problem 2

            TestDefensiveCode();

            #endregion

            #region Problem 3

            int? nullableInt = null;

            int result = nullableInt ?? 10;
            Console.WriteLine("Result using null-coalescing operator: " + result);

            if (nullableInt.HasValue)
            {
                Console.WriteLine("HasValue: " + nullableInt.Value);
            }
            else
            {
                Console.WriteLine("HasValue: false");
            }

            try
            {
                Console.WriteLine("Value property: " + nullableInt.Value);
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Value property throws exception when null.");
            }


            #endregion

            #region Problem 4

            int[] arr = new int[5];

            try
            {
                Console.WriteLine(arr[10]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index out of range.");
            }

            #endregion

            #region Problem 5

            int[,] array = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Enter value for array[{i},{j}]: ");
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Calculate and print sum of each row
            for (int i = 0; i < 3; i++)
            {
                int rowSum = 0;
                for (int j = 0; j < 3; j++)
                {
                    rowSum += array[i, j];
                }
                Console.WriteLine($"Sum of elements in row {i}: {rowSum}");
            }

            // Calculate and print sum of each column
            for (int j = 0; j < 3; j++)
            {
                int colSum = 0;
                for (int i = 0; i < 3; i++)
                {
                    colSum += array[i, j];
                }
                Console.WriteLine($"Sum of elements in column {j}: {colSum}");
            }


            #endregion

            #region Problem 6

            int[][] jaggedArray = new int[3][];

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Enter number of elements for row {i}: ");
                int size = int.Parse(Console.ReadLine());
                jaggedArray[i] = new int[size];

                for (int j = 0; j < size; j++)
                {
                    Console.Write($"Enter value for jaggedArray[{i}][{j}]: ");
                    jaggedArray[i][j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Row {i}: ");
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }

            #endregion

            #region Problem 7

            string? nullableString = null;

            Console.Write("Enter a string value (leave blank for null): ");
            string input = Console.ReadLine();

            if (!string.IsNullOrEmpty(input))
            {
                nullableString = input;
            }

            Console.WriteLine("You entered: " + nullableString!);


            #endregion

            #region Problem 8

            int valueType = 42;
            object boxedValue = valueType;

            Console.WriteLine("Boxed value: " + boxedValue);

            try
            {
                int unboxedValue = (int)boxedValue;
                Console.WriteLine("Unboxed value: " + unboxedValue);

                string invalidUnboxing = (string)boxedValue;
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Invalid cast exception: Cannot unbox to the wrong type.");
            }


            #endregion

            #region Problem 9

            int num1 = 5, num2 = 3;
            int sum, product;

            SumAndMultiply(num1, num2, out sum, out product);

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Product: {product}");


            #endregion

            #region Problem 10

            PrintStringMultipleTimes("Hello, World!");
            Console.WriteLine();
            PrintStringMultipleTimes(message: "Hello, again!", times: 3);

            #endregion

            #region Problem 11

            int[]? nullableArray = null;

            int? length = nullableArray?.Length;

            if (length.HasValue)
            {
                Console.WriteLine("Array length: " + length.Value);
            }
            else
            {
                Console.WriteLine("Array is null, cannot access its length.");
            }


            #endregion

            #region Problem 12

            Console.Write("Enter a day of the week: ");
            string day = Console.ReadLine()?.Trim();

            int dayNumber = day switch
            {
                "Monday" => 1,
                "Tuesday" => 2,
                "Wednesday" => 3,
                "Thursday" => 4,
                "Friday" => 5,
                "Saturday" => 6,
                "Sunday" => 7,
                _ => -1
            };

            if (dayNumber == -1)
            {
                Console.WriteLine("Invalid day entered.");
            }
            else
            {
                Console.WriteLine($"The number for {day} is: {dayNumber}");
            }
            #endregion

            #region Problem 13

            int[] array2 = { 1, 2, 3, 4, 5 };

            int sumFromArray = SumArray(array2);
            Console.WriteLine($"Sum from array: {sumFromArray}");

            int sumFromValues = SumArray(10, 20, 30, 40, 50);
            Console.WriteLine($"Sum from individual values: {sumFromValues}");

            #endregion
        }
    }
}
