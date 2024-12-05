using System;
using System.Buffers;
using System.Linq.Expressions;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {

        enum DayOfWeek
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }


        static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            #region Problem 1

            // intialize array new int[size]
            //int[] arr1 = new int[4];
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    arr1[i] = int.Parse(Console.ReadLine()??"0");
            //}
            //PrintArray(arr1);   
            ////intializer list
            //int [] arr2 = {5 , 7 , 8 , 3};
            //PrintArray(arr2);
            ////Array Syntax Sugar
            //var arr3 = new[] { 5, 7, 8, 3 };
            //PrintArray(arr3);
            //// Demonstrates an IndexOutOfRangeException. 
            //try
            //{
            //    Console.WriteLine($"Access out of range index in arr1 {arr1[arr1.Length]}");
            //}
            //catch (IndexOutOfRangeException ex) {
            //    Console.WriteLine(ex.Message);
            //}

            #endregion

            #region Problem 2

            //int[] arr1 = { 1, 2, 3 };
            //int[] clone = (int[])arr1.Clone();
            //int[] arr3Copy = new int[arr1.Length];
            //Array.Copy(arr1, arr3Copy, arr1.Length);
            //int[] arr2 = arr1;
            //arr1[0] = 50;
            //PrintArray(clone);
            //PrintArray(arr3Copy);
            //PrintArray(arr2);

            #endregion

            #region Problem 3

            //int[,] StudentGrades = new int[3,3];
            //for (int i = 0; i < StudentGrades.GetLength(0); i++) {
            //    for (int j = 0; j < StudentGrades.GetLength(1); j++) {
            //        Console.WriteLine($"Enter grade subject {j + 1} for student {i + 1}");
            //        StudentGrades[i, j] = int.Parse(Console.ReadLine() ?? "0");
            //    }
            //}
            //for (int i = 0; i < StudentGrades.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Student {i + 1}:");
            //    for (int j = 0; j < StudentGrades.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"\tSubject {j + 1}: {StudentGrades[i, j]}");
            //    }
            //    Console.WriteLine(new string('-', 20)); 
            //}

            #endregion

            #region Problem 4

            /*int[] arr1 = { 5, 2, 8, 1, 3 };
            Array.Sort(arr1);
            Console.WriteLine("The array is sorted in ascending order:");
            PrintArray(arr1);
            Array.Reverse(arr1);
            Console.WriteLine("The array is reversed:");
            PrintArray(arr1);
            int idx = Array.IndexOf(arr1, 8);
            Console.WriteLine("The index of the element '8' is: " + idx);
            int[] CopyArray = new int[arr1.Length];
            Array.Copy(arr1, CopyArray, arr1.Length);
            Console.WriteLine("Copied the elements into a new array:");
            PrintArray(CopyArray);
            Array.Clear(CopyArray, 1, 3);
            Console.WriteLine("Cleared 3 elements in the array starting from index 1:");
            PrintArray(CopyArray);*/

            #endregion

            #region Problem 5

            /* int[] arr1 = {6, 8, 1, 7, 2 };
             for (int i = 0; i < arr1.Length; i++)
             {
                 Console.Write($"{arr1[i]} ");
             }
             Console.WriteLine();
             foreach (int item in arr1) {
                 Console.Write($"{item} ");
             }
             Console.WriteLine();
             int idx = arr1.Length - 1;
             while (idx >= 0) {
                 Console.Write(arr1[idx--] + " ");
             }*/

            #endregion

            #region Problem 6

            /*int num;
            bool isValid;
            do
            {
                string? str = Console.ReadLine();
                isValid = int.TryParse(str, out num) && num > 0 && (num % 2 != 0);
                if (!isValid)
                {
                    Console.WriteLine("Invalid input! Make sure it's a positive odd number.");
                }
            }
            while (!isValid);
            Console.WriteLine($"The valid input is: {num} ");*/

            #endregion

            #region Problem 7

            /*int[,] Matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int n = Matrix.GetLength(0), m = Matrix.GetLength(1);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++) {
                    Console.Write(Matrix[i,j] + " ");
                }
                Console.WriteLine();*/


            #endregion

            #region Problem 8

            /*string[] months = new string[]
            {
            "January", "February", "March", "April", "May", "June",
            "July", "August", "September", "October", "November", "December"
            };

            int InputValue = int.Parse(Console.ReadLine() ?? "0");
            switch (InputValue) {
                case 1:
                    Console.WriteLine(months[0]);
                    break;
                case 2:
                    Console.WriteLine(months[1]);  
                    break;
                case 3:
                    Console.WriteLine(months[2]); 
                    break;
                case 4:
                    Console.WriteLine(months[3]); 
                    break;
                case 5:
                    Console.WriteLine(months[4]); 
                    break;
                case 6:
                    Console.WriteLine(months[5]); 
                    break;
                case 7:
                    Console.WriteLine(months[6]);
                    break;
                case 8:
                    Console.WriteLine(months[7]);
                    break;
                case 9:
                    Console.WriteLine(months[8]);
                    break;
                case 10:
                    Console.WriteLine(months[9]); 
                    break;
                case 11:
                    Console.WriteLine(months[10]); 
                    break;
                case 12:
                    Console.WriteLine(months[11]); 
                    break;
                default:
                    Console.WriteLine("Invalid input!");
                    break;
            }*/

            #endregion

            #region Problem 9

            /*int[] arr = {10, 20, 30, 20, 40, 50, 20};
            int[] arr2 = new int[arr.Length];
            Array.Copy(arr , arr2 , arr.Length);
            Array.Sort(arr);
            PrintArray(arr);
            int idx = Array.IndexOf(arr2, 20);
            Console.WriteLine($"The first occurrence of '20' is at index: {idx}");
            int lastIndex = Array.LastIndexOf(arr2, 20);
            Console.WriteLine($"The last occurrence of '20' is at index: {lastIndex}");*/


            #endregion

            #region Problem 10
            /*
            int[] arr = { 10, 20, 30, 20, 40, 50, 20 };
            int sum = 0 , n = arr.Length;
            for (int i = 0; i < n; i++) {
                sum += arr[i];
            }
            int sum2 = 0;
            foreach (var item in arr)
            {
                sum2 += item;
            }
            Console.WriteLine($"Sum1 is: {sum}");
            Console.WriteLine($"Sum2 is: {sum2}");*/



            #endregion

            #region Problem 11

            /*int input = int.Parse(Console.ReadLine()??"0");
            if (input >= 1 && input <= 7)
            {
                DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), input.ToString());

                Console.WriteLine($"The day corresponding to number {input} is {day}.");
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a number between 1 and 7.");
            }*/
            #endregion
        }
    }
}
