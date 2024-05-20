namespace Q8
{
    internal class Program
    {
        static void Main(string[] args)
        {   Employee employee = new Employee();
            employee.accept();
            employee.print();
            Employee employee1 = new Employee();
            employee1.accept();
            employee1.print();
        }
    }

    class Employee
    {
        int count ;
        enum DepartmentType
        {
            IT,
            HR,
            Finance,
            Marketing
        }
       

        private static int _id  ;
        private double _salary;
        private string _designation;
        private DepartmentType _department;

        public Employee()
        {
            _id++;
        }





        public string designation
        {
            get { return _designation; }
            set { _designation = value; }
        }


        public double salary
        {
            get { return _salary; }
            set { _salary = value; }
        }


        public int id
        {
            get { return _id = id; }
            set { _id= value; }
        }

        public void accept()
        {
            Console.WriteLine("enter salary");
            _salary=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter designation:");
            _designation = Console.ReadLine();

            Console.WriteLine("Enter department (IT, HR, Finance, Marketing):");
            _department = Enum.Parse<DepartmentType>(Console.ReadLine());
        }

        public void print()
        {
            Console.WriteLine("id=" + _id);
            Console.WriteLine("sal=" + salary);
            Console.WriteLine("designagtion=" + designation);
            Console.WriteLine("department=" + _department);
                }
    }
}
