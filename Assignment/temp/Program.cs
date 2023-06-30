namespace temp
{
    internal class Program
    {
        public  static void Swap(ref int n1, ref int n2)
        {
            int temp = n1; 
            n1=n2;
            n2 = temp;

        }

       public static void Calculate(float radius, out float area, out float circum)
        {
            area = 3.14f * radius * radius;
            circum = 2 * 3.14f * radius;
        }

        static void Main(string[] args)
        {
            int x = 10, y = 20;
            Swap(ref x, ref y);
            float area;
            float circum;
            Calculate(5, out area, out circum);
        }

    }
}