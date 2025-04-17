using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07
{
    public class Car : IMovable
    {
        private int _Id { get; set; }
        private string _Brand { get; set; }
        private double _Price { get; set; }
        public Car()
        {
            _Id = 0;
            _Brand = "Unknown";
            _Price = 0.0;
        }
        public Car(int id)
        {
            _Id = id;
            _Brand = "Unknown";
            _Price = 0.0;
        }
        public Car(int id, string brand)
        {
            _Id = id;
            _Brand = brand;
            _Price = 0.0;
        }
        public Car(int id, string brand, double price)
        {
            _Id = id;
            _Brand = brand;
            _Price = price;
        }
        public void Display()
        {
            Console.WriteLine($"Id: {_Id}, Brand: {_Brand}, Price: {_Price}");
        }
        public void Move()
        {
            Console.WriteLine("Car is moving...");
        }

    }
}
