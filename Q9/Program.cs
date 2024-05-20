namespace Q9
{



    class Employee
    {
        int count;
        enum DepartmentType
        {
            IT,
            HR,
            Finance,
            Marketing
        }


        private static int _id;
        private double _salary;
        private string _designation = "Manager";
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
            set { _id = value; }
        }

        public void accept()
        {
            Console.WriteLine("enter salary");
            _salary = Convert.ToDouble(Console.ReadLine());

           /* Console.WriteLine("Enter designation:");
            _designation = Console.ReadLine();*/

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

    class Manager: Employee
    {
        private double _Bonus;

        public double Bonus
        {
            get { return _Bonus; }
            set { _Bonus = value; }
        }

        public void accept1()
        {
            Employee: accept();
            Console.WriteLine("enter bonus");
            _Bonus = Convert.ToDouble(Console.ReadLine());
        }

        public  void    print2()
        {
        Employee: print();
            Console.WriteLine("Bonus="+Bonus);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           Manager  manager = new Manager();
            manager.accept1();
            manager.print2();
        }
    }
}
