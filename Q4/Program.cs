/*Q4.Write a structure Student with following members: 
 string name; bool gender; int age;
int std; char div; double marks;
Provide following functionality:
Default constructor(?)
Parameterized constructor
Get and Set methods
AcceptDetails() method to accept data from console.
PrintDetails() method to print data to console.
Check the default access specifier for members of structure.
Keep all data members private and all member functions public.*/
namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1;
            s1 = new Student();
            s1.accept();
            s1.display();
        }
    }
    struct Student
    { 

        
        private string name;

        public string _Name
        {
            get { return name; }
            set { name = value; }
        }

        private int age;

        public int _Age
        {
            get { return age; }
            set { age = value; }
        }

        private bool gender;

        public bool _Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        private int std;

        public int _std
        {
            get { return std; }
            set { std = value; }
        }

        private char div;

        public char _div
        {
            get { return div; }
            set { div = value; }
        }
        private double marks;

        public double _marks
        {
            get { return marks; }
            set { marks = value; }
        }

        public Student(string name, bool gender, int age, int std, char div, double marks)
        {
            this.name = name;
            this.gender = gender;
            this.age = age;
            this.std = std;
            this.div = div;
            this.marks = marks;

        }

       public void accept()
        {
            Console.WriteLine("enter name");
            _Name = Console.ReadLine();
            Console.WriteLine("enter gender ");
            _Gender=Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("enter age");
            _Age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter std");
            _std = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter div");
            _div=Convert.ToChar(Console.ReadLine());
            Console.WriteLine("enter marks");
            _marks=Convert.ToInt32(Console.ReadLine());
        }

        public void display()
        {
            Console.WriteLine("Name="+name);
            Console.WriteLine("Gender="+gender);
            Console.WriteLine("Age="+age);
            Console.WriteLine("Std="+std);
            Console.WriteLine("Div="+div);
            Console.WriteLine("Marks="+marks);

        }


    }
}
