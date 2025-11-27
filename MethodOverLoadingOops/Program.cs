using System;
using System.Runtime.InteropServices;
using System.Xml;

//namespace ConsoleApp1
//{
//Method Overloading
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

//example of By changing data type of arguments in method overloading

//namespace ConsoleApp1
//{
//    public class Cal
//    {
//        public static int add(int x, int y)
//        {
//            return x + y;
//        }
//        public static float add(float x, float y)
//        {
//            return x + y;
//        }
//    }
//    public class TestmemberOverloading
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine(Cal.add(12, 23));
//            Console.WriteLine(Cal.add(12.4f, 23.5f));
//        }
//    }
//}

// METHOD OVERRIDING
//namespace ConsoleApp1
//{
//    public class Animal
//    {
//        public  void eat()
//        {
//            Console.WriteLine("Eating...");
//        }
//    }
//    public class Dog : Animal      //here we use same method names but 2classes we use virtual keyword
//    {
//        public  void eat()
//        {
//            Console.WriteLine("Eating bread...");
//        }
//    }
//    public class Forest : Dog
//    {
//        public new void eat()
//        {
//            Console.WriteLine("writing book....");
//        }
//    }
//    public class Testmethodriding
//    {
//        public static void Main(string[] args)
//        {
//            Forest f = new Forest();
//            f.eat();
//            //Animal an=new Dog(); 
//            //an.eat();
//            Dog d = new Forest();
//            d.eat();
//            Animal s = new Forest();
//            s.eat();
//        }
//    }
//}
/// ------BASE KEYWORD--------
//namespace ConsoleApp1
//{
//    public class Animal
//    {
//        public string Color = "white";
//    }
//    public class Dog : Animal
//    {
//        string? Color ="red";
//        public void Showcolor()
//        {
//            Console.WriteLine(base.Color);
//            Console.WriteLine(Color);

//        }
//    }
//    public class Testbase
//    {
//        public static void Main(string[] args)
//        {
//            Dog d = new Dog();
//            d.Showcolor();
//        }
//    }
//}
//EXAMPLE OF BASEKEYWORD
//namespace ConsoleApp1
//{
//    public class Animal
//    {
//        public int number = 5;
//        public string color = "red";
//    }
//    public class Dog : Animal
//    {
//        int number = 7;
//        string color = "white";
//        public void Shownumber()
//        {
//            Console.WriteLine(base.number);
//            Console.WriteLine(base.color);
//            Console.WriteLine(number);
//            Console.WriteLine(color);

//        }
//    }
//    public class Testbase
//    {
//        public static void Main(string[] args)
//        {
//            Dog d = new Dog();
//            d.Shownumber();
//        }
//    }
//}
///runtime polymorphism....
//namespace MethodOverLoadingOops
//{
//    public class Animal
//    {
//        public virtual void eat()
//        {
//            Console.WriteLine("eating....");
//        }
//    }
//    public class Dog : Animal
//    {
//        public override void eat()
//        {
//            Console.WriteLine("eating bread....");
//        }
//    }
//    public class TestPolymorphism
//    {
//        public static void Main(string[] args)
//        {
//            {
//                //Animal a = new Dog();   // output in derivedclass only 
//                Animal a = new Animal();  // output in baseclass only
//                a.eat();
//            }
//        }

//    }
//}
///  Runtime Polymorphism Example 2  using data members


//namespace MethodOverLoadingOops
//{
//    sealed public class Animal
//    {
//        public void eat() 
//        {
//            Console.WriteLine("eating..."); }
//    }
//    public class Dog : Animal
//    {
//        public void bark()
//        { 
//            Console.WriteLine("barking..."); }
//    }
//    public class TestSealed
//    {
//        public static void Main()
//        {
//            Dog d = new Dog();
//            d.eat();
//            d.bark();


//        }
//    }

//}
//namespace MethodOverLoadingOops
//{
//    public class Animal
//    {
//        public virtual void eat()
//        {
//            Console.WriteLine("eating.....");
//        }
//        public virtual void run()
//        {
//            Console.WriteLine("running....");
//        }
//    }
//    public class Dog : Animal
//    {
//        public override void eat()
//        {
//            Console.WriteLine("eating bread....");
//        }
//        public sealed override void run()
//        {
//            Console.WriteLine("running very fast...");
//        }
//    }
//    public class BabyDog : Dog
//    {
//        public override void eat()
//        {
//            Console.WriteLine("eating biscuits...");
//        }
//        public override void run()
//        {
//            Console.WriteLine("running slowly...");
//        }
//    }
//    public class TestSealed
//    {
//        public static void Main()
//        {
//            BabyDog d = new BabyDog();
//            d.eat();
//            d.run();


//        }
//    }
//}


//namespace MethodOverLoadingOops
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello namespace!..");
//        }
//    }
//}
//....Namespaces examples...
//namespace MethodOverLoadingOops
//{
//    public class Hello
//    {
//        public void sayHello()
//        {
//            Console.WriteLine("Hello FirstNamespace"!);
//        }
//    }
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            Hello h = new Hello();
//            h.sayHello();
//        }
//    }
//}

//another example of namespaces....


//...Access Modifiers....//
// protected access modifier  -----'ProtectedTest.name' is inaccessible due to its protection levelna
//namespace MethodOverLoadingOops
//{
//  class ProtectedTest
//    {
//        protected string name = "venkat";
//        protected void Msg(string msg)
//        {
//            Console.WriteLine("hello"+msg);
//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            ProtectedTest protectedTest = new ProtectedTest();
//            // Accessing protected variable  
//            Console.WriteLine("Hello " + protectedTest.name);
//            // Accessing protected function  
//            protectedTest.Msg("Swami Ayyer");
//        }
//    }
//}  

// internal accessmodifier

// protected internalaccess modifier 
//namespace MethodOverLoadingOops
//{
//    class internalTest
//    {
//        protected internal string name = "venkat";
//        protected internal void Msg(string msg)
//        {
//            Console.WriteLine("hello"+msg);
//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            internalTest internalTest = new internalTest();
//            // Accessing protected internal variable  
//            Console.WriteLine("Hello " + internalTest.name);
//            // Accessing protected internal function  
//            internalTest.Msg("Peter Decosta");
//        }
//    }
//}  


//protected internal access modifier
//namespace MethodOverLoadingOops
//{
//    class InternalTest
//    {
//        protected internal string name = "santhosh";
//        protected internal void Msg(string msg)
//        {
//            Console.WriteLine("Hello" + msg);
//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            InternalTest i = new InternalTest();
//            Console.WriteLine("Hello" + i.name);
//            i.Msg("ravi");
//        }
//    }
//}
// private access modifiers example 2 within the class 

// Encapsulation 
//namespace MethodOverLoadingOops
// ------DELEGATES & Multiple Delegates------//
//namespace MethodOverLoadingOops
//{
//    delegate void Calculator(int x, int y);
//    class Program
//    {
//        public static void add(int x, int y)
//        {
//            Console.WriteLine(x + y);
//        }
//        public static void sub(int x, int y)
//        {
//            Console.WriteLine(x - y);
//        }
//        public static void mul(int x, int y)
//        {
//            Console.WriteLine(x * y);
//        }
//        static void Main(string[] args)
//        {
//            Calculator calc = new Calculator(sub);
//            calc += add;
//            calc += mul;
//            calc(20, 50);
//            Console.ReadLine();
//        }
//    }
//}
//Anamous Delegates------

//-----GENERICS------//
//namespace MethodOverLoadingOops
//{
//    public class Calculator
//    {
//        public static int Equal(int value1, int value2)
//        {
//            return a + b;
//        }

//    }
//    public class Calculator1
//    {
//        public static bool Equal(object value1, object value2)
//        {
//            return value1.Equals(value2);
//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int eq = Calculator.Equal(4, 4);
//            string eqs = Calculator1.Equal("interviewer", "Happy");
//            Console.WriteLine(eqs);
//            Console.WriteLine(eq);

//        }
//    }
//}
namespace MethodOverLoadingOops
{
    public class Calculator
    {
        public static bool AreEqual<T>(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bool equal = Calculator.AreEqual<int>(4, 4);
            bool strequal = Calculator.AreEqual<string>("interviewer", "interviewer");
            Console.WriteLine(equal + "" + strequal);
            Console.ReadLine();

        }
    }
}
