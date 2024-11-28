using System;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        class person { 
            public string Name {get ;set;}
        }
        static void Main(string[] args)
        {
            #region  problem 1 

            //string? str = Console.ReadLine();
            //try
            //{
            //    int num2 = int.Parse(str ?? "0");
            //    int num1 = Convert.ToInt32(str);
            //    Console.WriteLine($"The Num1: {num1}\nThe Num2: {num2}");
            //} catch (FormatException err) { 
            //    Console.WriteLine(err.Message);
            //}


            #endregion

            #region problem 2
            //string? str = Console.ReadLine();
            //bool IsValid = int.TryParse(str , out int Num1);
            //if (IsValid)
            //{
            //    Console.WriteLine($"The Number: {Num1} ");
            //    return;
            //}
            //Console.WriteLine("The Number is not valid");
            #endregion

            #region problem 3
            //object variable;
            //variable = 42;
            //Console.WriteLine($"Value: {variable}, Type: {variable.GetType()}, HashCode: {variable.GetHashCode()}");
            //variable = "Ahmed";
            //Console.WriteLine($"Value: {variable}, Type: {variable.GetType()}, HashCode: {variable.GetHashCode()}");
            //variable = 15.24;
            //Console.WriteLine($"Value: {variable}, Type: {variable.GetType()}, HashCode: {variable.GetHashCode()}");
            #endregion

            #region problem 4
            //person p1 = new person();
            //p1.Name = "Ahmed";
            //person p2 = p1;
            //p1.Name = "Mostafa";
            //Console.WriteLine($"person1 Name: {p1.Name}"); 
            //Console.WriteLine($"person2 Name: {p2.Name}");
            #endregion

            #region problem 5
            //string str = "Hello";
            //Console.WriteLine($"Original string is {str} , HashCode is ${str.GetHashCode()}");
            //string Modify = str + "World";
            //Console.WriteLine($"Original string is {Modify} , HashCode is ${Modify.GetHashCode()}");
            #endregion

            #region problem 6
            //StringBuilder sb = new StringBuilder("Hello");
            //Console.WriteLine($"Original string is {sb} , HashCode is ${sb.GetHashCode()}");
            //sb.Append("World");
            //Console.WriteLine($"Modify string is {sb} , HashCode is ${sb.GetHashCode()}");

            #endregion

            #region problem 7
            //int num1 = int.Parse(Console.ReadLine()) , num2 = int.Parse(Console.ReadLine()) ;
            //int sum = num1 + num2;
            //Console.WriteLine("sum is " + num1 + " + " + num2  + " = " + sum);
            //Console.WriteLine(string.Format("Sum is {0} + {1} = {2}", num1, num2, sum));
            //Console.WriteLine($"sum is {num1} + {num2} = {sum}");
            #endregion

            #region problem 8
            StringBuilder sb = new StringBuilder("Hello ");
            sb.Append("World");
            sb.Replace("World", "C#");
            sb.Insert(5, " Beautiful");
            sb.Remove(6 , 10);
            Console.WriteLine(sb);
            #endregion
        }
    }
}
