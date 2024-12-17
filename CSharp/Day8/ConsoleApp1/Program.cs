using System;
using System.Buffers;
using System.Drawing;
using System.Linq.Expressions;
using System.Text;

namespace ConsoleApp1
{
    #region Problem1
    public interface IVehicle
    {
        void StartEngine();
        void StopEngine();
    }

    public class Car : IVehicle
    {
        public void StartEngine() => Console.WriteLine("Car engine started.");
        public void StopEngine() => Console.WriteLine("Car engine stopped.");
    }

    public class Bike : IVehicle
    {
        public void StartEngine() => Console.WriteLine("Bike engine started.");
        public void StopEngine() => Console.WriteLine("Bike engine stopped.");
    }
    #endregion

    #region Problem2
    public abstract class Shape
    {
        public abstract double GetArea();

        public void Display() => Console.WriteLine($"Area: {GetArea()}");
    }

    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea() => Width * Height;
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea() => Math.PI * Radius * Radius;
    }
    #endregion

    #region Problem3
    public class Product : IComparable<Product>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public int CompareTo(Product other) => Price.CompareTo(other.Price);
    }
    #endregion

    #region Problem4
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Grade { get; set; }

        public Student(int id, string name, int grade)
        {
            Id = id;
            Name = name;
            Grade = grade;
        }

        public Student(Student other)
        {
            Id = other.Id;
            Name = other.Name;
            Grade = other.Grade;
        }
    }
    #endregion

    #region Problem5
    public interface IWalkable
    {
        void Walk();
    }

    public class Robot : IWalkable
    {
        void IWalkable.Walk() => Console.WriteLine("IWalkable method Walk invoked.");

        public void Walk() => Console.WriteLine("Robot-specific Walk method invoked.");
    }
    #endregion

    #region Problem6
    public struct Account
    {
        private int accountId;
        private string accountHolder;
        private decimal balance;

        public int AccountId { get => accountId; set => accountId = value; }
        public string AccountHolder { get => accountHolder; set => accountHolder = value; }
        public decimal Balance { get => balance; set => balance = value; }
    }
    #endregion

    #region Problem7
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public Book() { }

        public Book(string title)
        {
            Title = title;
        }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
    }
    #endregion


    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
