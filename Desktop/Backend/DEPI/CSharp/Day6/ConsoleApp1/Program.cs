using System;
using System.Buffers;
using System.Drawing;
using System.Linq.Expressions;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        #region Prpblem 1
        //public struct Point
        //{
        //    public int X { get; set; }
        //    public int Y { get; set; }

        //    public Point(int x, int y)
        //    {
        //        this.X = x;
        //        this.Y = y;
        //    }

        //    public override string ToString()
        //    {
        //        return $"({X}, {Y})";
        //    }
        //}
        #endregion

        #region Problem 2
        //public class TypeA
        //{
        //    private int F;     
        //    internal int G;   
        //    public int H;    

        //    public TypeA(int f, int g, int h)
        //    {
        //        F = f;
        //        G = g;
        //        H = h;
        //    }

        //    public int GetF()
        //    {
        //        return F;
        //    }

        //    public void SetF(int value)
        //    {
        //        F = value;
        //    }
        //}
        #endregion

        #region Problem 3

        //public struct Employee
        //{
        //    private int EmpId; 
        //    private string Name; 
        //    private double Salary; 

        //    public Employee(int empId, string name, double salary)
        //    {
        //        EmpId = empId;
        //        Name = name;
        //        Salary = salary;
        //    }

        //    public int EmpIdProperty
        //    {
        //        get { return EmpId; }
        //    }

        //    public double SalaryProperty
        //    {
        //        get { return Salary; }
        //    }

        //    public string GetName()
        //    {
        //        return Name;
        //    }

        //    public void SetName(string name)
        //    {
        //        Name = name;
        //    }
        //}
        #endregion

        #region Problem 4

        public struct Point
        {
            public int X { get; set; }
            public int Y { get; set; }

            public Point(int x)
            {
                X = x;
                Y = 0;
            }
            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }
            public override string ToString()
            {
                return $"({X}, {Y})";
            }
        }

        #endregion


        static void Main(string[] args)
        {
            #region Problem 1
            //Point paramPoint = new Point(3, 4);
            //Console.WriteLine(paramPoint);
            #endregion

            #region Problem 2
            //TypeA obj = new TypeA(10, 20, 30);
            //Console.WriteLine(obj.GetF());
            #endregion

            #region Problem 3

            //Employee emp = new Employee(101, "Alice", 50000);

            //Console.WriteLine("Employee ID: " + emp.EmpIdProperty); 
            //Console.WriteLine("Salary: " + emp.SalaryProperty);    

            //Console.WriteLine("Employee Name: " + emp.GetName());  

            //emp.SetName("Bob");
            //Console.WriteLine("Updated Employee Name: " + emp.GetName()); 

            #endregion

            #region Problem 4

            //Point point1 = new Point(5);
            //Console.WriteLine("Point 1: " + point1);

            //Point point2 = new Point(3, 7);
            //Console.WriteLine("Point 2: " + point2);

            #endregion

            #region Problem 5

            Point point1 = new Point(5);
            Point point2 = new Point(3, 7);
            Point point3 = new Point(8, 9);

            Console.WriteLine(point1);
            Console.WriteLine(point2);
            Console.WriteLine(point3);

            #endregion

        }
    }
}
