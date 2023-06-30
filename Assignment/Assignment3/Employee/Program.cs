using System.Runtime.CompilerServices;

namespace Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee1 e = new Employee1();
            Console.WriteLine(e.EmpNo);
            Employee1 e1 = new Employee1();
            Console.WriteLine(e1.EmpNo);
        }
    }
    public class Employee1
    {
        private String name;
        public String Name
        {
            set
            {
                if (value != " ")
                    this.name = value;
            }
            get
            {
                return this.name;
            }
        }
        private int empNo;
        public int EmpNo
        {
            set
            {
                if (this.empNo > 0)
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
                if (this.deptNo > 0 && this.deptNo < 10)
                { this.basic = value; }

            }
            get { return this.basic; }
        }
        short deptNo;
        public short DeptNo
        {
            set
            {
                if (this.deptNo > 0)
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

        //Assignment 2
        public static int  count=0;
        
        Employee1(string name, decimal basic, short deptNo)
        {
            this.name = name;
            this.basic = basic;
            this.deptNo = deptNo;
        }

       public Employee1(String name,decimal basic)
        {
            this.name = name;
            this.basic= basic;
        }
       public Employee1(String name)
        {
            this.name= name;
        }
       public Employee1() {
            this.empNo = count++;
        }
    }
}