using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Thread thread1 = new Thread(PrintNumbers);
        Thread thread2 = new Thread(PrintNumbers);

        thread1.Start();
        thread2.Start();

         thread1.Join();
         thread2.Join();

        Console.WriteLine("Both threads have completed execution.");
    }

    static void PrintNumbers()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Thread Id: {Thread.CurrentThread.ManagedThreadId}: Number: {i}");
            Thread.Sleep(500); // Simulate some work
        }       
    }
}