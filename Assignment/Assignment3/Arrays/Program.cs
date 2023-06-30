namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int noOfBatches = 0;
            int noOfStudent = 0;
            Console.WriteLine("Enter no of batches: ");
            noOfBatches = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter no of Students: ");
            noOfStudent = int.Parse(Console.ReadLine());

            int[,] cdac = new int[noOfBatches,noOfBatches];

            for(int i=0;i<noOfBatches;i++)
            {
                for(int j=0;j<noOfBatches;j++)
                {
                    Console.WriteLine($"Enter marks of student of batch {i} studentNo {j}:");
                    cdac[i,j]= int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < noOfBatches; i++)
            {
                for (int j = 0; j < noOfBatches; j++)
                {
                    Console.WriteLine($" marks of student of batch {i} studentNo {j} marks:"+ cdac[i, j]);
                    
                }
            }
        }
    }
}