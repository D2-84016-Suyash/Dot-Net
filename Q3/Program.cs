namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c = 0;
           
            
            do
            {
                Console.WriteLine("1.add");
                Console.WriteLine("2.sub");
                Console.WriteLine("3.mul");
                Console.WriteLine("4.div");
                Console.WriteLine("enter choice");
                String c1 = Console.ReadLine();
                c = Convert.ToInt32(c1);
                switch (c)

                {
                    case 1:
                        Console.WriteLine("enter first number");
                        String s1 = Console.ReadLine();
                        int num1 = Convert.ToInt32(s1);
                        Console.WriteLine("enter second number");
                        String s2 = Console.ReadLine();
                        int num2 = Convert.ToInt32(s2);
                        Console.WriteLine(num1 + num2);

                        break;

                        case 2:
                        Console.WriteLine("enter first number");
                        String s3 = Console.ReadLine();
                        int num3 = Convert.ToInt32(s3);
                        Console.WriteLine("enter second number");
                        String s4 = Console.ReadLine();
                        int num4 = Convert.ToInt32(s4);
                        Console.WriteLine(num3 - num4);
                        break;

                        case 3:
                        Console.WriteLine("enter first number");
                        String s5 = Console.ReadLine();
                        int num5 = Convert.ToInt32(s5);
                        Console.WriteLine("enter second number");
                        String s6 = Console.ReadLine();
                        int num6 = Convert.ToInt32(s6);
                        Console.WriteLine(num5 * num6);
                        break;

                        case 4:
                        Console.WriteLine("enter first number");
                        String s7 = Console.ReadLine();
                        int num7 = Convert.ToInt32(s7);
                        Console.WriteLine("enter second number");
                        String s8 = Console.ReadLine();
                        int num8 = Convert.ToInt32(s8);
                        Console.WriteLine(num7 / num8);
                        break;


                    default:
                        break;
                }
            }while(c!=0);   
        }
    }
}
