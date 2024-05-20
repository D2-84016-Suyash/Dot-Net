using Microsoft.VisualBasic;
using System.Runtime.InteropServices;

namespace Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Date  d1=new Date();
            Date d2=new Date();
            d1.Accept();
            d2.Accept();

               Console.WriteLine( Date.differenceinYear(d1, d2));
            Console.WriteLine();
          if(d1.isValid () && d2.isValid())
            {
                d1.display();
                Console.WriteLine();
                Console.WriteLine(d1.T0string());
            }else { Console.WriteLine("entred date is wrong");}
            
        }
    }
    class Date
    {
        private int day;

        public int _day
        {
            get { return day; }
            set { day = value; }
        }
        private int month;

        public int _month
        {
            get { return month; }
            set { month = value; }
        }
        private int year;

        public int _year
        {
            get { return year; }
            set { year = value; }
        }

        public Date()
        {
            day = 1;
            month = 1;
            year = 1;
        }

        public Date(int d,int m,int y)
        {
            day=d;
            month = m;
            year = y;
        }

      public  void Accept()
        {
            Console.WriteLine("enter day");
            day=Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("enter month");
            month = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("enter year");
            year = Convert.ToInt32(Console.ReadLine());
        }

        public void display()
        {
            Console.WriteLine(day);
            Console.WriteLine(month);
            Console.WriteLine(year);
        }

        public bool isValid()
        { if(day>0 && day<32)
            {
                if(month>0 && month<12)
                {
                    if (year > 0)
                        return true;
                    else return false;
                }else return false;
            }else return false;
            }

        public string T0string()
        {
            String d1=Convert.ToString(day);

            String d2 = Convert.ToString(month );

            String d3 = Convert.ToString( year);
            String d4 = d1+"/" +d2+"/"+ d3;
            return d4;
        }
        public static int differenceinYear(Date date1, Date date2)
        {
            return date1._year - date2._year;
        }

        // Operator overloading for "-" to calculate difference in years
        public static int operator -(Date d1, Date d2)
        {
            return DifferenceInYears(d1, d2);
        }
    }
}

    
}





}

