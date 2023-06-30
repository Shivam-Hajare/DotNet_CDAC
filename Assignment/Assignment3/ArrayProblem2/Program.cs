namespace ArrayProblem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] e = new Employee();
            
        }
    }
    public  class Employee
    {
        private String name;
        private decimal sal;
        private int empNo;

        public Employee(String name,decimal sal,int empNo) {
                this.name = name;
                this.sal = sal;
                this.empNo = empNo;
        }
        public String Name  { get; set; }
        public decimal Sal { get; set; }
        public int EmpNo { get; set; }


    }
}