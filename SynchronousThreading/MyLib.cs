using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SynchronousThreading
{
    internal class MyLib
    {
        static Mutex m = new Mutex();
        public static void ShowMessage(object message)
        {
           string msg=message.ToString();
            string[] data = msg.Split();
            m.WaitOne(1000);
            Console.WriteLine("-------------------------------------");
            foreach (string s in data)
            {
                Console.Write(s + " ");
             
            }
            Console.WriteLine("-------------------------------------");

            Console.WriteLine();
            m.ReleaseMutex();
        }
       

    }
}
