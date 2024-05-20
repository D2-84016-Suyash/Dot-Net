namespace Q10
{



    class Employee
    {
        
        enum DepartmentType
        {
            IT,
            HR,
            Finance,
            Marketing
        }


        private static int _id;
        private double _salary;
        private string _designation = "Supervisor";
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

        public override string ToString()
        {
            return "id="+_id+"sal="+salary+"designation"+designation+"deapartment"+designation;
        }
    }

    class Supervisor : Employee
    {
        private int _subbordinates;

        public int subbordinates
        {
            get { return _subbordinates; }
            set { _subbordinates = value; }
        }


        public void accept1()
        {
        Employee: accept();
            Console.WriteLine("enter number of subbordinates");
            _subbordinates=Convert.ToInt32(Console.ReadLine());
        }

        public void print2()
        {
        Employee: print();
            Console.WriteLine("subbordinates=" + _subbordinates);
        }

        public override string ToString()
        {
            return (base.ToString() + ""+"subbordinates="+subbordinates);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Supervisor  supervisor = new Supervisor();
            supervisor.accept1();
            //using print2 method
            supervisor.print2();
            //using toString
            /* Console.WriteLine(supervisor);*/
        }
    }
}
