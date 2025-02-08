//using System;
//using System.Collections.Generic;
//using System.Diagnostics.Metrics;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Linq;

//namespace ConsoleApp1
//{
//    internal class Student
//    {
//        private string Address;

//        private string school;
//        public string School
//        {
//            set { school = value; }
//            get { return school; }
//        }


//        public Student() : this(-1, "Not intialized", "Not intialized", "Not intialized")
//        {
//            Console.WriteLine("paramererless ctor");
//        }

//        public Student(int id, string name)

//        {
//            Id = id;
//            Name = name;

//            Console.WriteLine("2 parameters ctor");
//        }
//        public Student(int id, string name, string address): this(id, name)
//        {
//            //Id = id;
//            //Name = name;
//            Address = address;
//            //this.school = school;
//            Console.WriteLine("3 parameter ctor");
//        }
//        public Student(int id, string name, string address, string school)
//            : this(id, name, address)
//        {
//            this.school = school;
//            Console.WriteLine("4 params ctor");
//        }

//        public void SetAddress(/*Student this, */string address) { this.Address = address; }
//        public string GetAddress(/*Student this, */) { return Address; }

//        public string Print(/*Student this, */)
//        {
//            return $"Id: {this.Id}, name: {Name}, Address: {Address}, School: {school}";
//        }
//    }
//}
