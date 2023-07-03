namespace collectionAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            Dictionary<int,Employee> map = new Dictionary<int,Employee>();
            while(!exit)
            {
                int count = 0;
                Console.WriteLine("Want to add emp details(yes/no): ");
                String ans=Console.ReadLine();
                if(ans.Equals("no"))
                {
                    exit=true;

                    return;
                }
                Console.WriteLine("Enter emp name and dept:");
               map.Add(++count,new Employee(Console.ReadLine(),Console.ReadLine()));

            }
            foreach (KeyValuePair<int, Employee> kvp in map)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
        }
    }
    public class Employee
    {
        private int empNo;
        private static int empNoCount=0;
        public  String Name { get; set; }
        public String Department { get; set; }
        public int EmpNo
        {
            get { return empNo; }
        }
        public Employee( string name, string department)
        {
            this.empNo = ++empNoCount;
            Name = name;
            Department = department;
        }

        public override string ToString()
        {
            return $"Employee No: {EmpNo}\nName: {Name}\nDepartment: {Department}";
        }
    }
}