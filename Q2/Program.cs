namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c = 0;
           
              c  = Convert.ToInt32(args[2]);

                switch (c) {
                    
                    case 1:
                        cal c1 = new cal();
                        String x3 = args[0];
                        int x4 = Convert.ToInt32(x3);
                        String x5 = args[1];
                        int x6 = Convert.ToInt32(x5);
                        Console.WriteLine(c1.add(x4,x6));
                        break;

                     case 2:
                    cal   c2 = new cal();
                    String y3 = args[0];
                    int y4 = Convert.ToInt32(y3);
                    String y5 = args[1];
                    int y6 = Convert.ToInt32(y5);
                    Console.WriteLine(c2.sub(y4,y6));
                    break;

                    case 3:
                    cal c3 = new cal();
                    String z3 = args[0];
                    int z4 = Convert.ToInt32(z3);
                    String z5 = args[1];
                    int z6 = Convert.ToInt32(z5);
                    Console.WriteLine(c3.mul(z4,z6));
                    break;
                    case 4:
                      cal c4 = new cal();   
                       String z14 = args[0];
                        int zz4 = Convert.ToInt32(z14);
                        String z15 = args[1];
                    int zz6 = Convert.ToInt32(z15); 
                    Console.WriteLine(c4.div(zz4, zz6));

                        
                    break;
                    

                }  

            Console.WriteLine("Hello, World!");

        }
    }
    class cal
    {
        private int x;
        private int y;

        public int MyProperty
        {
            get { return y; }
            set { y = value; }
        }


        public int MyPropertyx
        {
            get { return x; }
            set { x = value; }
        }

         public int add(int x,int y)
        { return x + y;  }

        public int sub(int x, int y)
        { return x - y; }

        public int div(int x, int y)
        { return x / y; }

        public int mul(int x, int y)
        { return x * y; }

    }
}
