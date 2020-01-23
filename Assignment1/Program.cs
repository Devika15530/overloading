using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        public static string Greet()
        {
            return "welcome to the world of c#";

        }
        public static string Display(string name)
        {
            return "Hi" + name + "Welcome to the world of c#";
        }
       public static void Num(int x,int y)
        {
            int i;
            for( i=x;i<=y;i++)
            {
                Console.WriteLine(i); 
            }
        }
        public static string EvenOdd(int n)
        {
            if (n % 2 == 0)
                return " even";
            else
                return " odd";
        }
        public static double Celusis(double f)
        {


            return ((f - 32) * 5) / 9; 
        }
        public static void Shop()

        {
            int n;
            do
            {

                
                Console.WriteLine("enter the product number and quantity");
                int op = int.Parse(Console.ReadLine());
                int qunt = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.WriteLine(qunt * 22.5);
                        break;
                    case 2:
                        Console.WriteLine(qunt * 44.50);
                        break;
                    case 3:
                        Console.WriteLine(qunt * 9.98);
                        break;

                }
                Console.WriteLine("if you want to purchase more press 1");
                n = int.Parse(Console.ReadLine());
            } while (n == 1);
            if (n == 0)
                Environment.Exit(0);
        }
        public static void Series()
        {
            for(int i=0;i<=25;i++)
            {
                Console.Write(i*i+" ");
            }
        }
        public static int fact(int g)
        {
            int fact = 1;
            for(int i=1;i<=g;i++)
            {
                fact = fact * i;
            }
            return fact;
        }
        public static void fib()
        {
            int a = 0;
            int b = 1;
            int c;
            Console.WriteLine(a);
            Console.WriteLine(b);



            do
            {
                c = a + b;



                Console.WriteLine(c);


                int temp = a;
                a = b;
                b = c;

            } while (c <= 40);
        }
        public static void Mul(int n)
        {
            int i;
            for( i=1;i<=20;i++)
            {
                Console.WriteLine(n + "*" + i + "=" + n * i);
            }
        }
        public static void Div()
        {
            for (int i = 200; i <= 300; i++)

            {
                if(i%7==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void Largest(int d,int e,int f)
        {
            if (d > e && d > f)
                Console.WriteLine(d + "is largest");
            else if (e > f)
                Console.WriteLine(e + "is largest");
            else
                Console.WriteLine(f + "is largest");

        }

        public static void Smallest()
        {
            int []num = new int[5];
            Console.WriteLine("enter array elements");
            for (int i=0;i<5;i++)
            {
                num[i] =int.Parse( Console.ReadLine());
            }
           
            for(int i=0;i<5;i++)
            {
              
                for(int j=i+1;j<5;j++)
                {
                    if(num[i]>num[j])
                    {
                        int temp = num[i];
                        num[i] = num[j];
                        num[j] = temp;

                    }
                }
            }
            Console.WriteLine("smallest num is"+num[0]);
        }
        public static void Marks()
        {
            int[] num = new int[5];
            Console.WriteLine("enter array elements");
            for (int i = 0; i < 5; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }
            int count = 0;
            for(int i=0;i<10;i++)
            {
                count = num[i] + count;

            }
            Console.WriteLine(count);
            int avg = count / 2;
            Console.WriteLine(avg);

            for (int i = 0; i < 5; i++)
            {

                for (int j = i + 1; j < 5; j++)
                {
                    if (num[i] > num[j])
                    {
                        int temp = num[i];
                        num[i] = num[j];
                        num[j] = temp;

                    }
                }
            }

        }
     
        static void Main(string[] args)
        {
            /* Console.WriteLine(Greet());
             Console.WriteLine("enter your name");

             string s = Console.ReadLine();
            Console.WriteLine( Display(s));

             Console.WriteLine("enter any two numbers");
             int x = int.Parse(Console.ReadLine());
             int y= int.Parse(Console.ReadLine());

             Num(x, y);

             Console.WriteLine("enter any  number to find even or odd");

             int n= int.Parse(Console.ReadLine());

             Console.WriteLine(n +"is"+EvenOdd(n));

             Console.WriteLine("enter temperature in fahrenheit");
             double f = double.Parse(Console.ReadLine());
             Console.WriteLine(Celusis(f));

            Console.WriteLine("productnum \t  productprice");
            Console.WriteLine("product 1 \t 22.5");
            Console.WriteLine("product 2 \t 44.50");
            Console.WriteLine("product 3 \t 9.98");

            Shop();


            Series();
            Console.WriteLine("enter a number to find factorial");
            int g= int.Parse(Console.ReadLine());
          Console.WriteLine(  fact(g));
            Console.WriteLine("fibonaci series");
            fib();

            Console.WriteLine("enter number for multiplication table");

            int k= int.Parse(Console.ReadLine());
            Mul(k);
            Div();
            Console.WriteLine("enter any numbers");

            int d = int.Parse(Console.ReadLine());
            int e= int.Parse(Console.ReadLine());
            int f= int.Parse(Console.ReadLine());
            Largest(d, e, f);
         
       
          
            Smallest();*/

            Marks();












            Console.ReadKey();
        }
    }
}
