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
            
            
            ///Thread thread_name = n
            Console.WriteLine("Calling background thread task method");
            Thread thread_name = new Thread(new ThreadStart(sleepTask));  //line 16 and 17 makes the thread asynchronous
            thread_name.IsBackground = true;
            Console.WriteLine("thread_name.IsBackground" + thread_name.IsBackground);
            thread_name.Start();

            Console.WriteLine("calling Foreground thread taskmethod");
            Thread Foreground_Thread = new Thread(new ThreadStart(dosomething));
            Console.WriteLine("thread_name.IsBackground for thread_name_1" + Foreground_Thread.IsBackground);
            Foreground_Thread.Start();




            Console.WriteLine("done with main program");
            Console.ReadLine();
     
              
        }

        public static void sleepTask()           //when creating thread --> create the method first
        {
            Console.WriteLine("in background task, taking a nap");
            Thread.Sleep(2000);
            Console.WriteLine("do some work");
            Thread.Sleep(5000);
            Console.WriteLine("i am done with background task");
        }

        public static void dosomething()
        {
            Console.WriteLine("perform task quickly");
        }
    }


}
