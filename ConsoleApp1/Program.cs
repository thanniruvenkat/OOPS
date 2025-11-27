using System;
using System.Diagnostics;

//namespace ConsoleApp1
//{
//    public class Program
//    {
//        public int id;
//        public String name;
//        public float salary;
//        public long pincode;

//        public void insert(int i, string n, float s, long l)
//        {
//            id = i;
//            name = n;
//            salary = s;
//            pincode = l;
//        }
//        public void display()
//        {
//            Console.WriteLine(id + ", " + name + ", " + salary + "," + pincode);
//        }
//    }
//    class TestEmployee
//    {
//        public static void Main(string[] args)
//        {
//            Program p1 = new Program();
//            p1.insert(101, "sai", 0999f, 534440);
//            p1.display();
//            Program p2 = new Program();
//            p2.insert(103, "ram", 8978f, 345222);
//            p2.display();

//        }
//    }
//}
//------default constructors----
//namespace ConsoleApp1
//{
//    public class Employee
//    {
//        public Employee()
//        {
//            Console.WriteLine("Default constructor invoked");
//        }
//        public static void Main(string[] args)
//        {
//            Employee e = new Employee();
//            Employee e1 = new Employee();
//        }
//    }
//}


// parameterized constructor//

//Destrucotor//
//namespace ConsoleApp1
//{
//    public class Employee
//    {
//        public Employee()
//        {
//            Console.WriteLine("default constructor");
//        }
//        ~Employee()
//        {
//            Console.WriteLine("Destructor involved");
//        }
//    }
//    class Testemployee
//    {
//        public static void Main(string[] args)
//        {
//            Employee e1 = new Employee();
//            Employee e2 = new Employee();
//            GC.Collect();
//            GC.WaitForPendingFinalizers();
//        }
//    }
//}
//static constructor
//namespace ConsoleApp1
//{
//    public class StaticConstructor
//    {
//        static StaticConstructor()
//        {
//            Console.WriteLine("Static Constructor invoked");

//        }
//        public static void print()
//        {
//            Console.WriteLine("static print method called");
//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            StaticConstructor.print();
//            Console.ReadLine();
//        }
//    }
//}
//private constructor//

//copy constructor

//Inheritance//

//single Inheritance

//Multiple Inheritance

//multilevel inheritance//

//heiricehal inheritance 


//example of static constructor

//ex of single level inheritance

//SEaled class

//Abstraction


//namespace ConsoleApp1
//{
//    public class Program
//    {
//        public static int add(int a, int b)
//        {
//            return a + b;
//        }
//        public static int add(int a, int b, int c)
//        {
//            return a + b + c;
//        }
//        public class TestMemberOverloading
//        {
//            public static void Main(String[] args)
//            {
//                Console.WriteLine(Program.add(3, 5));
//                Console.WriteLine(Program.add(3, 2, 3));
//            }
//        }
//    }
//}
