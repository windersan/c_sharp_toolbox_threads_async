using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp10async
{
    public class Class1
    {


        public async Task<int> f1Async()
        {
            Task<int> task = new Task<int>(c1);
            task.Start();

            Console.WriteLine("Intermediate Step");

            int i = await task;


            Console.WriteLine(i);
            return i;

        }

        public int c1()
        {
            Thread.Sleep(7000);

            return 1;
        }
        public int f1()
        {
            int i = c1();
            Console.WriteLine("Intermediate Step");
            Console.WriteLine(i);
            return i;

        }


    }
}
