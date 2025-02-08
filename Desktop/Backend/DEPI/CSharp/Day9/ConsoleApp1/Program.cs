using System;
using System.Buffers;
using System.Drawing;
using System.Linq.Expressions;
using System.Text;

namespace ConsoleApp1
{

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem 1
            WeekdaysEnum.DisplayWeekdays();
            #endregion

            #region Problem 2
            GradesEnum.ShowGrades();
            #endregion

            #region Problem 3
            Person person1 = new Person { Name = "Alice", Department = "HR" };
            Person person2 = new Person { Name = "Bob", Department = "IT" };
            person1.PrintDetails();
            person2.PrintDetails();
            #endregion

            #region Problem 4
            Child child = new Child { Salary = 50000 };
            child.DisplaySalary();
            #endregion

            #region Problem 5
            Console.WriteLine(UtilityClass.CalculatePerimeter(5, 10));
            #endregion

            #region Problem 6
            ComplexNumber c1 = new ComplexNumber { Real = 1, Imaginary = 2 };
            ComplexNumber c2 = new ComplexNumber { Real = 3, Imaginary = 4 };

            var result = c1 * c2;
            Console.WriteLine(result);
            #endregion

            #region Problem 7
            GenderEnum.DisplayGenderSize();
            #endregion

            #region Problem 8

            Console.WriteLine(TemperatureConversion.ConvertToFahrenheit(0));
            Console.WriteLine(TemperatureConversion.ConvertToCelsius(32));
            #endregion

            #region Problem 9
            var employees = new Employee[] {
            new Employee { Name = "Alice", Department = "HR" },
            new Employee { Name = "Bob", Department = "IT" }
            };
            var target = new Employee { Name = "Alice", Department = "HR" };
            Console.WriteLine(Helper2<Employee>.SearchArray(employees, target));
            #endregion

            #region Problem 10
            Console.WriteLine(Helper.Max(3, 5));
            Console.WriteLine(Helper.Max(3.14, 2.71));
            Console.WriteLine(Helper.Max("apple", "orange"));
            #endregion

            #region Problem 11
            var intArray = new int[] { 1, 2, 3, 2 };
            Helper3<int>.ReplaceArray(intArray, 2, 5);
            Console.WriteLine(string.Join(", ", intArray));

            var stringArray = new string[] { "apple", "banana", "apple" };
            Helper3<string>.ReplaceArray(stringArray, "apple", "orange");
            Console.WriteLine(string.Join(", ", stringArray));
            #endregion

            #region Problem 12
            var rect1 = new Rectangle { Length = 5, Width = 10 };
            var rect2 = new Rectangle { Length = 15, Width = 20 };

            rect1.PrintDetails();
            rect2.PrintDetails();

            RectangleHelper.Swap(ref rect1, ref rect2);

            rect1.PrintDetails();
            rect2.PrintDetails();
            #endregion

            #region Problem 13
            //var employees1 = new EmployeeWithDepartment[] {
            //new EmployeeWithDepartment { Name = "Alice", Department = new Department { Name = "HR" } },
            //new EmployeeWithDepartment { Name = "Bob", Department = new Department { Name = "IT" } }
            //};

            //var target2 = new Department { Name = "HR" };
            //Console.WriteLine(Helper2<EmployeeWithDepartment>.SearchArray(employees1, target2));
            #endregion

            #region Problem 14
            var circleStruct1 = new Circle { Radius = 5.0, Color = "Red" };
            var circleStruct2 = new Circle { Radius = 5.0, Color = "Red" };

            Console.WriteLine(circleStruct1.Equals(circleStruct2));

            var circleClass1 = new Circle { Radius = 5.0, Color = "Red" };
            var circleClass2 = new Circle { Radius = 5.0, Color = "Red" };

            Console.WriteLine(circleClass1.Equals(circleClass2));
            #endregion

            //////////////////////////////////////////////////////////////////////////
            #region Part 02
            // Test Problem 1:
            int[] arr = { 1, 2, 3, 4, 5 };
            var reversedIntArray = Part02.ReverseArray(arr);
            Console.WriteLine("Reversed int array: " + string.Join(", ", reversedIntArray));
            // Test Problem 2:
            Stack<string> stringStack = new Stack<string>();
            stringStack.Push("Hello");
            stringStack.Push("World");
            Console.WriteLine("Stack Peek: " + stringStack.Peek());
            Console.WriteLine("Popped from Stack: " + stringStack.Pop());

            // Test Problem 3:
            string[] strArray = { "Apple", "Banana", "Cherry" };
            Part02.Swap(strArray, 0, 2);
            Console.WriteLine("Swapped Array: " + string.Join(", ", strArray));

            // Test Problem 4
            int[] numbers = { 1, 2, 5, 3, 4 };
            int maxNumber = Part02.FindMax(numbers);
            Console.WriteLine("Max number: " + maxNumber);
            #endregion
        }

    }
}
