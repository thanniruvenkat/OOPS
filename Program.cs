using System;

//namespace OOPS
//{
//    public class Program
//    {
//        int id;
//        string name;
//        static void Main(String[] args)
//        {
//            Program p1=new Program();
//            p1.id = 100;
//            p1.name = "venkat";
//            Console.WriteLine(p1.id);
//            Console.WriteLine(p1.name);
//        }
//    }
//}



namespace OOPS
{
    public class Program
    {
        public int id;
        public string name;

        public void insert(int i, string n)
        {
            id = i;
            name = n;

        }
        public void display()
        {
            Console.WriteLine(id + "" + name);
        }
    }
    class TestStudent
    {
        public static void Main(string[] args)
        {
            Program s1 = new Program();
            s1.insert(101, "sai");
            s1.display();
            Program s2= new Program();
            s2.insert(103, "kiran");
            s2.display();
            Program s3 = new Program();
            s3.insert(104, "raju");
            s3.display();
            Console.WriteLine("Welocme to Hyd");
        }

    }
}
