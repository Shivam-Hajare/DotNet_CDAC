namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Name = "Test";
            employee.EmployeeNo = 1;
            employee.Basic = 25;
            employee.DeptNo = 15;

          //  System.Console.WriteLine(employee.ToString);
        }

    }

    public class Employee
    {
        private String name;
        public String Name
        {
            set
            {
                if(value!=" ")
                this.name = value;
            }
            get
            {
                return this.name;
            }
        }
        private int empNo;
        public int EmployeeNo
        {
            set
            {
                if(this.empNo>0)
                {
                    this.empNo = value;
                }
            }
            get
            {
                return this.empNo;
            }
        }
        private decimal basic;
        public decimal Basic
        {
            set
            {
                if(this.deptNo>0 && this.deptNo<10)
                { this.basic = value; }

            }
            get { return this.basic; }
        }
        short deptNo;
        public short DeptNo
        {
            set
            {
                if(this.deptNo>0)
                {
                    this.deptNo = value;    
                }
            }
            get
            {
                return this.deptNo;
            }
        }

        private decimal GetNetSalary()
        {
            return basic * 12;
        }
       

    }
}