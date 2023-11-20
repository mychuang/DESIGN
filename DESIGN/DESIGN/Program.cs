using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DESIGN.SINGLETON
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonGreed mySingletonGreedInstance = SingletonGreed.getGreed();

            Singleton mySingletonInstance = Singleton.getSingleton();
            Console.WriteLine("check hash code of Singleton: " + mySingletonInstance.GetHashCode());

            // 創建多個執行緒
            SingletonTest thread1 = new SingletonTest("Thread 1");
            SingletonTest thread2 = new SingletonTest("Thread 2");

            Thread t1 = new Thread(new ThreadStart(thread1.Run));
            Thread t2 = new Thread(new ThreadStart(thread2.Run));

            // 啟動執行緒
            t1.Start();
            t2.Start();

            // 等待執行緒任務完成
            t1.Join();
            t2.Join();

            Console.ReadKey();
        }
    }
}
