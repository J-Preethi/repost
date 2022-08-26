using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Data
{
    public delegate void MyDelagate(int x);
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDelagate obj = new MyDelagate(M1);
            obj += M2;
            obj.Invoke(10);
            Console.ReadLine();
        }
        public static void M1(int x)
        {
            Console.WriteLine(x * x*x);
        }

        public static void M2(int x)
        {
            Console.WriteLine(x * x * x*x);
        }
    }
}

      