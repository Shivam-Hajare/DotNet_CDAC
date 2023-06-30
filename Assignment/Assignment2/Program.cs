namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStaticClass m = new MyStaticClass();
            m.Show();
        }
    }

    internal class MyStaticClass
    {
        static int a = 10;

        public void Show()
        {
            Console.WriteLine("a is: "+a);
           
        }
    }
    internal class DrivedClass:MyStaticClass
    {
        public void display()
        {
            Show();
        }
    }
}