using System.Net;
using System.Reflection;
using System.Xml.Linq;

namespace Q7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            person  person  =new    person();
            person.accept();
            Console.WriteLine("by using by display method");
            person.display();
            


        }
    }

    class person
    {
        private Date birthdate;
        private string _name;

        private int _Age;

        public int Age
        {
            get { return _Age; }
            set { _Age = value; }
        }

        private string _address;

        public string address
        {
            get { return _address; }
            set { _address = value; }
        }


        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        private bool _gender;

        public bool gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        

        public void accept()
        {
            Console.WriteLine("enter name");
            _name = Console.ReadLine();
            Console.WriteLine("enter gender");
            _gender = Convert.ToBoolean( Console.ReadLine());
            Console.WriteLine("enter date of birth");
            Console.WriteLine("enter day");
            int d = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("enter month");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter year");
            int y = Convert.ToInt32(Console.ReadLine());
            birthdate = new Date(d, m, y) ;
            Console.WriteLine("enter address");
            _address = Console.ReadLine();

            




        }
        public void display()
        {
            Console.WriteLine("Name:"+name);
            Console.WriteLine("Gender:"+gender );
            Console.WriteLine("Birth Date:" +birthdate.day+"/"+ birthdate.month+"/"+ birthdate.year);
            Console.WriteLine("Address:"+address);
            Console.WriteLine("Age:" + birthdate.calculateAge(birthdate));
           
        }
        public override string ToString()
        {
            return $"Name: {name}, Gender: {(gender ? "Male" : "Female")}, Birth Date: {birthdate.day}/{birthdate.month}/{birthdate.year}, Address: {address}, Age: {Age}";
        }
    }
    class Date
    {
        private int _year;
        public int year
        {
            get { return _year; }
            set { _year = value; }
        }
        private int _month;

        public int month
        {
            get { return _month; }
            set { _month = value; }
        }

        private int _day;

        public int day
        {
            get { return _day; }
            set { _day = value; }
        }

        public Date(int d,int m,int y)
        {
            day = d;    
            month = m;
            year = y;
            
        }

      public  int calculateAge(Date birthDate) {
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.year;
            if (birthDate.month > today.Month || (birthDate.month == today.Month && birthDate.day > today.Day))
            {
                age--;
            }
            return age;
        }

    }
}
