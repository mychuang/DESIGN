using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESIGN.SINGLETON
{
    class SingletonGreed
    {
        private static SingletonGreed singletonGreed = new SingletonGreed(); // 一開始就建立物件, 接下來只需要回傳這個物件

        private SingletonGreed() { } // pricate constructor, 這樣程式就無法使用New

        public static SingletonGreed getGreed() {
            Console.WriteLine("Return greed object");
            return singletonGreed;
        }
    }

    class Singleton
    {
        private static Singleton singleton; // 先宣告而不創建
        private static readonly object lockObject = new object();

        private Singleton() 
        {
            //To Do something...
        }

        public static Singleton getSingleton()
        {
            //保證 getSingleton()被呼叫時鎖住,
            //執行緒只有等 getSingleton()執行完後才會讓出時間, 避免不同執行緒各自產生新的實體
            lock (lockObject)
            {
                if (singleton == null)
                {
                    Console.WriteLine("Return first time");
                    singleton = new Singleton();
                }
                return singleton;
            }
        }
    }

    class SingletonTest
    {
        private string myId;

        public SingletonTest(string id)
        {
            myId = id;
        }

        public void Run()
        {
            Singleton singleton = Singleton.getSingleton();
            if (singleton != null)
            {
                Console.WriteLine(myId + " create Singleton: " + singleton.GetHashCode());
            }
        }
    }
}
