using System;
using System.Buffers;
using System.Collections;
using System.Linq;
using static ConsoleApp1.ListGenerators;
using System.Text;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Restriction Operators

            var OutOfStock = ProductList.Where(p => p.UnitsInStock == 0);

            var Res = ProductList.Where(p => (p.UnitsInStock > 0) && (p.UnitPrice > 3.00m));

            string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var Res2 = Arr.Where((name, index) => name.Length < index);

            //foreach (var unit in Res2)
            //{
            //    Console.WriteLine(unit);
            //}

            #endregion

            #region Element Operators

            var Res01 = ProductList.First(p => p.UnitsInStock == 0);

            var Res02 = ProductList.FirstOrDefault(p => p.UnitPrice > 1000);

            int[] Arr1 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var Res03 = Arr1.Where(p => p > 5).ElementAt(1);

            //Console.WriteLine(Res03);


            #endregion

            #region Aggregate Operators

            int[] Arr2 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            int[] Arr3 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var Res11 = Arr2.Count(p => p % 2 != 0);

            var Res12 = CustomerList.Select(p => new { p.Name, OrderCount = p.Orders.Count() });

            var Res13 = ProductList.GroupBy(p => p.Category).Select(p => new { Category = p.Key, ProductCount = p.Count() });

            var Res14 = Arr3.Sum();

            //Console.WriteLine(Res14);

            //foreach (var item in Res13)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Ordering Operators

            string[] Arr4 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            string[] Arr5 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var Res21 = ProductList.OrderBy(p => p.ProductName);

            var Res22 = Arr4.OrderBy(word => word, StringComparer.OrdinalIgnoreCase);

            var Res23 = ProductList.OrderByDescending(p => p.UnitsInStock);

            var Res24 = Arr5.OrderBy(p => p.Length).ThenBy(p => p);

            var Res25 = Arr4.OrderBy(p => p.Length).ThenBy(p => p, StringComparer.OrdinalIgnoreCase);

            var Res26 = ProductList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);

            var Res27 = Arr4.OrderBy(p => p.Length).ThenByDescending(p => p, StringComparer.OrdinalIgnoreCase);

            var Res28 = Arr5.Where(p => p[1] == 'i').Reverse();

            //foreach (var item in Res28)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Transformation Operators 

            string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            int[] Arr6 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var Res31 = ProductList.Select(p => new { p.ProductName });

            var Res32 = words.Select(word => new { Upper = word.ToUpper(), Lower = word.ToLower() });

            var Res33 = ProductList.Select(p => new { Name = p.ProductName, Price = p.UnitPrice });

            var Res34 = Arr6.Select((p, i) => new { p, InPlace = p == i});

            //foreach (var item in Res34)
            //{
            //    Console.WriteLine(item);
            //}

            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            var Res35 = from A in numbersA
                        from B in numbersB
                        where A < B
                        select new {A , B};

            //Console.WriteLine("Pairs where a < b:");

            //foreach (var item in Res35)
            //{
            //    Console.WriteLine($"{item.A} is less than {item.B}");
            //}

            var Res36 = from C in CustomerList
                        from O in C.Orders
                        where O.Total < 500.00
                        select new { O.Id , O.Total };

            var Res37 = from C in CustomerList
                        from O in C.Orders
                        where O.OrderDate.Year >= 1998
                        select new { O.Id, O.OrderDate};

            //foreach (var item in Res37)
            //{
            //    Console.WriteLine(item);
            //}



            #endregion

            #region Partitioning Operators 

            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };


            var Res41 = CustomerList.Where(p => p.City == "Washington")
                                    .SelectMany(c => c.Orders, (c, o) => new { o.Id, c.City })
                                    .Take(3);

            var Res42 = (from c in CustomerList
                         from O in c.Orders
                         where c.City == "Washington"
                         select new { O.Id, c.City }).Skip(2);

            var Res43 = numbers.TakeWhile((p, i) => p >= i);

            var Res44 = numbers.SkipWhile((p , i) => p % 3 != 0);

            var Res45 = numbers.SkipWhile((p, i) => p >= i);

            var Res46 = ProductList.GroupBy(p => p.Category).Where(i => i.Any(p => p.UnitsInStock == 0));
                              

            var Res47 = ProductList.GroupBy(p => p.Category).Where(i => i.Any(p => p.UnitsInStock > 0));

            foreach (var i in Res47)
            {
                foreach (var j in i)
                {
                    Console.WriteLine($"{j.ProductName} ,  {j.UnitsInStock}");
                }
            }

            #endregion
        }

    }
}
