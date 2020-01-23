using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caluculator
{
    class Calci
    {
        int val1;
        int val2;
        //public int Val1 { get => val1; set => val1=value; }
        //public int Val2 { get => val2; set => val2 = value; }
        public Calci()
        {

        }
        public Calci(int val1,int val2)
        {
            this.val1 = val1;
            this.val2 = val2;
        }
        public int Add(int num1,int num2)

        {
           return num1 + num2;
        }
        public void Swap(ref int num1,ref  int num2)

        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine(num1 + " " + num2);

        }
        public void Subt(int num1,int num2,out int  res)
        {
            res = num1 - num2;
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
           Calci c1= new Calci();
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
           Console.WriteLine( c1.Add(x, y));
            c1.Swap(ref x, ref y);
            c1.Subt(x, y, out int res);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
