using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            float l = 12.9f;
            int i = (int)l;
            Console.WriteLine(i);
            Console.WriteLine(i.GetType());

            char c = 'a';
            int i1 = (int)c;
            Console.WriteLine(i1);

            double d = 12345678912345678;
            int i2 = (int)d;
            Console.WriteLine(i2);

            string s = "120";
            int k = int.Parse(s);
            double g = double.Parse(s);
            Console.WriteLine(s);
            Console.WriteLine(g);
            //i=int.parse("dfglist");exception



            Console.ReadKey();
        }
    }
    class ConvertDemo
        {
            static void Main(string[] args)
            {
            bool ii = Convert.ToBoolean("false");
            Console.WriteLine(ii);
            String s = Convert.ToString("100");
            Console.WriteLine(s);
            int q = Convert.ToInt32("1000");
            Console.WriteLine(q);

            int n = 10;
            object d = n;
            Console.WriteLine(d);
            object ob = 12;
            
            int m = (int)ob;
            Console.WriteLine(m);
            
            object ob1 = 12.3;
            double d1 = (double)ob1;
            Console.WriteLine(d1);
            Console.ReadKey();
            }
        }
    
    
    }

        

        