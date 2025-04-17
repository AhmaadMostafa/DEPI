namespace Day10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem 1
            //Employee[] employees =
            //{
            //new Employee { Name = "Ahmed", Salary = 45000 },
            //new Employee { Name = "Ali", Salary = 55000 },
            //new Employee { Name = "Ibrahim", Salary = 40000 }
            //};

            //var sorter = new SortingAlgorithm<Employee>();
            //sorter.Sort(employees, (a, b) => a.Salary.CompareTo(b.Salary));

            //foreach (var emp in employees)
            //{
            //    Console.WriteLine($"{emp.Name} : {emp.Salary}");
            //}
            #endregion

            #region Problem 2

            //int[] numbers = { 10, 5, 20, 1, 15 };

            //var sorter = new SortingTwo<int>();
            //sorter.Sort(numbers, (a, b) => b.CompareTo(a)); 

            //foreach (var num in numbers)
            //{
            //    Console.WriteLine(num);
            //}


            #endregion

            #region Problem 3

            //string[] words = { "apple", "dog", "banana", "kiwi" };

            //var sorter = new SortingTwo<string>();
            //sorter.Sort(words, (a, b) => a.Length.CompareTo(b.Length));

            //foreach (var word in words)
            //{
            //    Console.WriteLine(word);
            //}


            #endregion

            #region Problem 4
            //Manager[] managers =
            //{
            //     new Manager { Name = "Ahmed", Salary = 75000 },
            //     new Manager { Name = "Ali", Salary = 65000 },
            //     new Manager { Name = "Omar", Salary = 80000 }
            //};

            //var sorter = new SortingTwo<Manager>();
            //sorter.Sort(managers, (a, b) => a.CompareTo(b)); 

            //foreach (var m in managers)
            //{
            //    Console.WriteLine($"{m.Name} : {m.Salary}");
            //}
            #endregion

            #region Problem 5

            //Employee[] employees =
            //{
            //    new Employee { Name = "Abdelrahman" },
            //    new Employee { Name = "Ali" },
            //    new Employee { Name = "Omar" }
            //};

            //var sorter = new CustomSorter<Employee>();
            //sorter.Sort(employees, (a, b) => a.Name.Length < b.Name.Length); 

            //foreach (var emp in employees)
            //{
            //    Console.WriteLine(emp.Name);
            //}


            #endregion

            #region Problem 6

            //int[] numbers1 = { 9, 2, 7, 4 };

            //Array.Sort(numbers1, delegate (int a, int b)
            //{
            //    return a.CompareTo(b);
            //});

            //foreach (int num in numbers1)
            //{
            //    Console.Write(num + " ");
            //}
            //Console.WriteLine();

            //// lambda expression
            //int[] numbers2 = { 9, 2, 7, 4 };

            //Array.Sort(numbers2, (a, b) => a.CompareTo(b));

            //foreach (int num in numbers2)
            //{
            //    Console.Write(num+ " ");
            //}
            //Console.WriteLine();


            #endregion

            #region Problem 7

            //int[] numbers = { 10, 20, 30, 40 };

            //Console.WriteLine("Before swap:");
            //foreach (var num in numbers)
            //    Console.WriteLine(num);

            //// Swap index 1 and 3
            //SortingAlgorithm<int>.Swap(numbers, 1, 3);

            //Console.WriteLine("After swap:");
            //foreach (var num in numbers)
            //    Console.WriteLine(num);


            #endregion

            #region Problem 8

            //Employee[] employees =
            //{
            //    new Employee { Name = "Ahmed", Salary = 50000 },
            //    new Employee { Name = "Ali", Salary = 50000 },
            //    new Employee { Name = "Omar", Salary = 45000 },
            //    new Employee { Name = "Mohamed", Salary = 60000 }
            //};

            //var sorter = new SortingTwo<Employee>();
            //sorter.Sort(employees, (a, b) =>
            //{
            //    int salaryComparison = a.Salary.CompareTo(b.Salary);
            //    if (salaryComparison != 0)
            //        return salaryComparison;
            //    return string.Compare(a.Name, b.Name);
            //});

            //foreach (var e in employees)
            //{
            //    Console.WriteLine($"{e.Name} : {e.Salary}");
            //}


            #endregion

            #region Problem 9

            //int defaultInt = DefaultValueProvider.GetDefault<int>();
            //bool defaultBool = DefaultValueProvider.GetDefault<bool>();
            //string defaultString = DefaultValueProvider.GetDefault<string>();

            //Console.WriteLine($"Default int: {defaultInt}");        
            //Console.WriteLine($"Default bool: {defaultBool}");      
            //Console.WriteLine($"Default string: {defaultString}");  


            #endregion

            #region Problem 10

            //List<string> words = new List<string> { "apple", "banana", "cherry", "date" };

            //var upperCaseWords = StringTransformer.TransformList(words, s => s.ToUpper());
            //Console.WriteLine("Uppercase:");
            //upperCaseWords.ForEach(Console.WriteLine);

            //var reversedWords = StringTransformer.TransformList(words, s => new string(s.ToCharArray().Reverse().ToArray()));
            //Console.WriteLine("\nReversed:");
            //reversedWords.ForEach(Console.WriteLine);

            //var suffixedWords = StringTransformer.TransformList(words, s => s + " fruit");
            //Console.WriteLine("\nWith ' fruit' suffix:");
            //suffixedWords.ForEach(Console.WriteLine);


            #endregion

            #region Problem 11

            //int num1 = 10, num2 = 5;

            //Func<int, int, int> add = (a, b) => a + b;
            //Console.WriteLine($"Addition: {Calculator.PerformOperation(num1, num2, add)}");

            //Func<int, int, int> subtract = (a, b) => a - b;
            //Console.WriteLine($"Subtraction: {Calculator.PerformOperation(num1, num2, subtract)}");

            //Func<int, int, int> multiply = (a, b) => a * b;
            //Console.WriteLine($"Multiplication: {Calculator.PerformOperation(num1, num2, multiply)}");

            //Func<int, int, int> divide = (a, b) =>
            //{
            //    if (b == 0) throw new DivideByZeroException("Cannot divide by zero");
            //    return a / b;
            //};
            //Console.WriteLine($"Division: {Calculator.PerformOperation(num1, num2, divide)}");


            #endregion

            #region Problem 12

            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            //List<string> stringRepresentations = ListTransformer.TransformList(numbers, n => n.ToString());

            //Console.WriteLine("String Representations:");
            //stringRepresentations.ForEach(Console.WriteLine);

            //List<int> squares = ListTransformer.TransformList(numbers, n => n * n);

            //Console.WriteLine("\nSquares:");
            //squares.ForEach(Console.WriteLine);


            #endregion

            #region Problem 13

            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            //Func<int, int> square = n => n * n;

            //List<int> squares = NumberProcessor.ApplyFunction(numbers, square);

            //Console.WriteLine("Squares:");
            //squares.ForEach(Console.WriteLine);

            #endregion

            #region Problem 14

            //List<string> words = new List<string> { "apple", "banana", "cherry", "date" };

            //Action<string> printString = str => Console.WriteLine(str);

            //StringProcessor.ApplyActionToList(words, printString);

            #endregion

            #region Problem 15

            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Predicate<int> isEven = n => n % 2 == 0;

            //List<int> evenNumbers = NumberFilter.FilterList(numbers, isEven);

            //Console.WriteLine("Even Numbers:");
            //evenNumbers.ForEach(Console.WriteLine);


            #endregion

            #region Problem 16

            //List<string> words = new List<string> { "apple", "banana", "cherry", "date", "avocado" };

            //var startsWithA = StringFilter.FilterList(words, str => str.StartsWith("a"));
            //Console.WriteLine("Strings that start with 'a':");
            //startsWithA.ForEach(Console.WriteLine);

            //var containsAn = StringFilter.FilterList(words, str => str.Contains("an"));
            //Console.WriteLine("\nStrings that contain 'an':");
            //containsAn.ForEach(Console.WriteLine);


            #endregion

            #region Problem 17

            //int num1 = 10, num2 = 5;

            //Func<int, int, int> add = (a, b) => a + b;
            //Console.WriteLine($"Addition: {MathOperations.PerformOperation(num1, num2, add)}");

            //Func<int, int, int> subtract = (a, b) => a - b;
            //Console.WriteLine($"Subtraction: {MathOperations.PerformOperation(num1, num2, subtract)}");

            //Func<int, int, int> multiply = (a, b) => a * b;
            //Console.WriteLine($"Multiplication: {MathOperations.PerformOperation(num1, num2, multiply)}");


            #endregion

            #region Problem 18

            //List<string> words = new List<string> { "apple", "banana", "cherry", "date", "kiwi", "eagle" };

            //var lengthGreaterThanThree = StringFilter.FilterList(words, str => str.Length > 3);
            //Console.WriteLine("Strings with length greater than 3:");
            //lengthGreaterThanThree.ForEach(Console.WriteLine);

            //var containsE = StringFilter.FilterList(words, str => str.Contains("e"));
            //Console.WriteLine("\nStrings that contain 'e':");
            //containsE.ForEach(Console.WriteLine);


            #endregion

            #region Problem 19

            //double num1 = 10.0, num2 = 5.0;

            //Func<double, double, double> divide = (a, b) => a / b;
            //Console.WriteLine($"Division: {MathOperations.PerformOperation(num1, num2, divide)}");

            //Func<double, double, double> exponentiate = (a, b) => Math.Pow(a, b);
            //Console.WriteLine($"Exponentiation: {MathOperations.PerformOperation(num1, num2, exponentiate)}");

            #endregion

        }
    }
}
