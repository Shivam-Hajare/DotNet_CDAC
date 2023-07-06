
using System.Data;
using System.Data.SqlClient;

namespace ModelBinding.Models
{
    public class Employee
    {
        public int EmpNo { get; set; }
        public string Name { get; set; }
        public decimal Basic { get; set; }
        public int DeptNo { get; set; }
        public Employee()
        {
            // Parameterless constructor
        }
        public Employee(int empNo, string name, decimal basic, int deptNo)
        {
            EmpNo = empNo;
            Name = name;
            Basic = basic;
            DeptNo = deptNo;
        }

        public static Employee GetSingleEmployee(int EmpNo)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Emp;Integrated Security=true";
            Employee employee = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = cn;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "SELECT * FROM Employees WHERE EmpNo = @EmpNo";
                        cmd.Parameters.AddWithValue("@EmpNo", EmpNo);

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                int no = (int)dr["EmpNo"];
                                string name = (string)dr["Name"];
                                decimal basic = (decimal)dr["Basic"];
                                int deptNo = (int)dr["DeptNo"];

                                employee = new Employee(no, name, basic, deptNo);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return employee;
        }

        public static List<Employee> GetAllEmployees() 
        { 
            List<Employee> list = new List<Employee>(); 
            return list;
        }


        public static void Insert(Employee obj)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Emp;Integrated Security=true";

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = cn;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "INSERT INTO Employees VALUES (@EmpNo, @Name, @Basic, @DeptNo)";
                        cmd.Parameters.AddWithValue("@EmpNo", obj.EmpNo);
                        cmd.Parameters.AddWithValue("@Name", obj.Name);
                        cmd.Parameters.AddWithValue("@Basic", obj.Basic);
                        cmd.Parameters.AddWithValue("@DeptNo", obj.DeptNo);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        public static void Update(Employee obj)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Emp;Integrated Security=true";

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = cn;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "update employees set EmpNo=@EmpNo,Name=@Name,Basic=@Basic,DeptNo=@DeptNo where EmpNo=@EmpNo";
                        cmd.Parameters.AddWithValue("@EmpNo", obj.EmpNo);
                        cmd.Parameters.AddWithValue("@Name", obj.Name);
                        cmd.Parameters.AddWithValue("@Basic", obj.Basic);
                        cmd.Parameters.AddWithValue("@DeptNo", obj.DeptNo);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void Delete(int EmpNo)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Emp;Integrated Security=true";

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = cn;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "DELETE FROM employees WHERE EmpNo=@EmpNo";
                        cmd.Parameters.AddWithValue("@EmpNo", EmpNo);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


}

}
