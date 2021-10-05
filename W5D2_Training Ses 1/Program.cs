using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace W5D2_Training_Ses_1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //Thread thread_name = n
            Console.WriteLine("Calling sleep task method");
            sleepTask();
            Console.WriteLine("calling do something method");
            dosomething();
            Console.WriteLine("done with main program");
            Console.ReadLine();
              
        }

        public static void sleepTask()           //when creating thread --> create the method first
        {
            Console.WriteLine("in sleep task");
            Thread.Sleep(2000);
            Console.WriteLine("do some work");
            Thread.Sleep(5000);
            Console.WriteLine("i am done working");
        }

        public static void dosomething()
        {
            Console.WriteLine("perform task quickly");
        }
    }


}
