namespace InterfaceCreation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            DerivedClass d = new DerivedClass();
            d.Show2();
            d.Show1();
        }

          
    }
    public interface MyInterface
    {
        void Show1();
    }
    public interface MyInterface2:MyInterface
    {
         void Show2();
    }
    public class DerivedClass : MyInterface2
    {
        public void Show1()
        {
            Console.WriteLine("in show1");
        }

        public void Show2()
        {
            Console.WriteLine("in show2");
        }
    }
}