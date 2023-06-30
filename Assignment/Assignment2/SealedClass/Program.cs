namespace SealedClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    public sealed class SealedClass1
    {
        public void show()
        {
            Console.WriteLine("in sealed show!!");
        }
    }
    /* public  class DerivedClass: SealedClass1
     {

     }error*/
}