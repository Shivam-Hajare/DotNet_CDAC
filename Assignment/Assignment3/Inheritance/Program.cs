namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    public abstract class Employee1
    {
        private String name;
        private readonly int empNo;
        private decimal basic;
        public abstract decimal Basic { set; get; }
        short deptNo;

        public abstract decimal GetNetSalary();
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
        public int EmpNo{set; get; }
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

    public class Manager : Employee1
    {
        private decimal basic;
        private String designation;

        public String Desigation
        {
            set
            {
                if (value != " ")
                    this.designation = value;
            }
            get
            {
                return this.designation;
            }
        }
        public override decimal Basic
        {
            get
            {
                return this.basic;
            }
            set
            {
              
                this.basic = value;
            }
        }

        public override decimal GetNetSalary()
        {
           return (decimal)this.basic*12;
        }
    }
    public class GeneralManager : Manager
    {
        private String perks;

        public String Perks
        {
            set
            {
                this.Perks = value;
            }
            get
            {
                return this.perks;
            }
        }
        public GeneralManager() { }
    }
    public class CEO : Employee1
    {
        private decimal basic;
        public override decimal Basic {
            get
            {
                return this.basic;
            }
            set
            {
                this.basic = value;
            }
        }

        public override sealed decimal GetNetSalary()
        {
            Console.WriteLine("in CEO GetSALMEthod");
            return this.basic*12;
        }
    }


}