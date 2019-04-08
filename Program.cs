using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecFact
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Factorial of " + n + " = " + Fact(n));
            Console.ReadLine();
            Console.WriteLine("enter taban");
            int t = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter us");
            int u = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(UsAlma(t, u));
            Console.ReadLine();
        }
        public static int Fact(int n)
        {

            if (n <= 1)
                return n;

            else
                return n * Fact(n - 1);

        }


        public static int UsAlma(int taban,int us)
        {
            if (us == 0)
                return 1;

            else
                return taban * UsAlma(taban, us - 1);

        }
    }
}
