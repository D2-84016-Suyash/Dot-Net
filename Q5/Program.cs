/*Create a reference of Student’s array in Main. Write a function CreateArray() to 
allocate the array as per user’s requirement. Pass it to a function AcceptInfo() to 
accept student information. Print the array using PrintInfo() function.Also write a 
function ReverseArray() that reverse the array into a new array.Reprint the
modified array in Main.
Note: Do not return array from the function. All four functions mentioned above 
should be static functions in Main()’s class*/
using System.Runtime.Intrinsics.Arm;

namespace Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Student student = new Student();*/
            Student[] student = null;
            int n = 0;
            Console.WriteLine("enter size of array");
            n = Convert.ToInt32(Console.ReadLine());
            acceptArr(student, n);






            static void acceptArr(Student[] s2, int m)
            {


                s2 = new Student[m];
                accpet(s2, m);

            }

            static void accpet(Student[] s1, int z)
            {

                for (int i = 0; i < s1.Length; i++)
                {
                    s1[i].accept();
                }

                display(s1);
                displayReverse(s1, z);
            }

            static void display(Student[] s1)
            {

                for (int i = 0; i < s1.Length; i++)
                {
                    s1[i].display();
                }
            }

            static void displayReverse(Student[] s1, int z)
            {
                Student[] s2 = new Student[z];
                int j = 0;
                for (int i = (s1.Length - 1); i >= 0; i--)
                {

                    s2[j] = s1[i];
                    j++;

                }
                for (int i = 0; i <= j; i++)
                {
                    s2[j].display();


                }



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
                _Gender = Convert.ToBoolean(Console.ReadLine());
                Console.WriteLine("enter age");
                _Age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter std");
                _std = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter div");
                _div = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("enter marks");
                _marks = Convert.ToInt32(Console.ReadLine());
            }

            public void display()
            {
                Console.WriteLine("Name=" + name);
                Console.WriteLine("Gender=" + gender);
                Console.WriteLine("Age=" + age);
                Console.WriteLine("Std=" + std);
                Console.WriteLine("Div=" + div);
                Console.WriteLine("Marks=" + marks);

            }



        }
    }
}
