namespace Day5Part02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem 1
            //Console.Write("Enter a positive integer: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number > 0)
            //{
            //    for (int i = 1; i <= number; i++)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Please enter a positive integer.");
            //}
            #endregion

            #region Problem 2

            //Console.Write("Enter an integer: ");
            //int number = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Multiplication table for {number}:");
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine($"{number} x {i} = {number * i}");
            //}

            #endregion

            #region Problem 3

            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());

            //Console.WriteLine("Even numbers between 1 and " + number + ":");

            //for (int i = 2; i <= number; i += 2)
            //{
            //    Console.WriteLine(i);
            //}


            #endregion

            #region Problem 4

            //Console.Write("Enter the base number: ");
            //int baseNumber = int.Parse(Console.ReadLine());

            //Console.Write("Enter the exponent: ");
            //int exponent = int.Parse(Console.ReadLine());

            //double result = Math.Pow(baseNumber, exponent);
            //Console.WriteLine($"{baseNumber} raised to the power of {exponent} is {result}");


            #endregion

            #region Problem 5

            //Console.Write("Enter a string: ");
            //string input = Console.ReadLine();
            //string reversedString = "";
            //for(int i = input.Length - 1; i >= 0; i--)
            //{
            //    reversedString += input[i];   
            //}
            //Console.WriteLine("Reversed string: " + reversedString);

            #endregion

            #region Problem 6

            //Console.Write("Enter an integer: ");
            //int number = int.Parse(Console.ReadLine());

            //int reversedNumber = 0;

            //while (number != 0)
            //{
            //    int digit = number % 10;
            //    reversedNumber = reversedNumber * 10 + digit;
            //    number /= 10;
            //}

            //Console.WriteLine("Reversed integer: " + reversedNumber);

            #endregion

            #region Problem 7

            //Console.Write("Enter the number of elements in the array: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] array = new int[n];

            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < n; i++)
            //{
            //    array[i] = int.Parse(Console.ReadLine());
            //}

            //int longestDistance = 0;
            //Dictionary<int, int> elementIndices = new Dictionary<int, int>();

            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (elementIndices.ContainsKey(array[i]))
            //    {
            //        int distance = i - elementIndices[array[i]];
            //        if (distance > longestDistance)
            //        {
            //            longestDistance = distance;
            //        }
            //    }
            //    else
            //    {
            //        elementIndices[array[i]] = i;
            //    }
            //}

            //Console.WriteLine("The longest distance between two identical elements is: " + longestDistance);


            #endregion

            #region Problem 8

            //Console.Write("Enter a sentence: ");
            //string sentence = Console.ReadLine();

            //string[] words = sentence.Split(' ');
            //Array.Reverse(words);
            //string reversedSentence = string.Join(" ", words);

            //Console.WriteLine("Reversed sentence: " + reversedSentence);


            #endregion

        }
    }
}
