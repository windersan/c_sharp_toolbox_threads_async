using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp10async
{
    class Program
    {
        static void Main(string[] args)
        {
            int k1 = 5;
            int k2 =5;
            int k_ref = f_ref(ref k1);
            int k_k = f_k(k2);
            WriteLine(k1);
            WriteLine(k2);
            


            Console.WriteLine("start");

            Class1 c1 = new Class1();

            int z = 0;

            Thread thread = new Thread(()=> {  z = c1.c1(); Console.WriteLine("lol"); });

            thread.Start();
            thread.Join();

            Console.WriteLine("MAIN");
            c1.f1Async();
                
            try
            {
                c1.f1Async().Wait();
                c1.f1Async().Wait();
                c1.f1Async().Wait();
            }

            catch (Exception ex)
            {
                
            }


        }
        public static int f_ref(ref int k)
        {
            k = k + 5;
            return k;
        }
        public static int f_k(int k)
        {
            k = k + 5;
            return k;
        }



    }
}
