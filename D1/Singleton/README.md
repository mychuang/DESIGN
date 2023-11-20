# 單例模式

## 目的

保證一個類只有一個實例，並提供一個全局訪問點來訪問該實例。

<img src='./01.png' width='75%'>

## 適用場景

- 系統中需要一個全局對象，例如配置文件、日誌管理器、數據庫連接池等

- 某個對象的創建需要消耗大量的資源，例如打開文件、創建連接等。

- 需要對某個對象進行全局控制，例如對某個對象的訪問權限進行控制。

## 優點

- 保證系統中某個類只有一個實例，避免了資源的浪費。

- 對某個對象進行了全局控制，提高了系統的穩定性。

## 缺點

- 可能會導致系統的耦合性增強。

- 多線程環境下，可能會出現競爭狀態。

## 程式寫法 - C#

1. 開始即創建

    ```Csharp
    class SigletonGreed
    {
        // 一開始就建立物件, 接下來只需要回傳這個物件
        private static SigletonGreed sigletonGreed = new SigletonGreed(); 

        // pricate constructor, 這樣程式就無法使用New
        private SigletonGreed() { } 

        public static SigletonGreed getGreed() {
            Console.WriteLine("Return greed object");
            return sigletonGreed;
        }
    }
    ```

- 當物件創建較耗資源時, 可以等到要呼叫再創建

    ```CSharp
    class Sigleton
    {
        // 先宣告而不創建
        private static Sigleton sigleton; 

        private Sigleton() 
        {
            //To Do something...
        }

        public static Sigleton getSigleton()
        {
            if (sigleton == null) {
                Console.WriteLine("Return first time");
                sigleton = new Sigleton();
            }
            return sigleton;
        }
    }
    ```

## 多執行緒狀況

- 當多執行緒呼叫時, 可能無法保證類別只會產生一個物件, 例如下方為多執行緒呼叫

    ```CSharp
    class SingletonTest
    {
        private string myId;

        public SingletonTest(string id)
        {
            myId = id;
        }

        public void Run()
        {
            //把執行緒要做的事封裝進Run()
            Singleton singleton = Singleton.getSingleton();
            if (singleton != null)
            {
                Console.WriteLine(myId + " create Singleton: " + singleton.GetHashCode());
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 創建多個執行緒
            SingletonTest thread1 = new SingletonTest("Thread 1");
            SingletonTest thread2 = new SingletonTest("Thread 2");

            // 兩個執行緒有可能得到不同的Singleton
            Thread t1 = new Thread(new ThreadStart(thread1.Run));
            Thread t2 = new Thread(new ThreadStart(thread2.Run));

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();
        }
    }
    ```

- 修正上述問題, 只需要確保getSingleton()被呼叫時上鎖

  ```CSharp
    class Sigleton
    {
        // 先宣告而不創建
        private static Sigleton sigleton; 
        private static readonly object lockObject = new object();

        private Sigleton() 
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
    ```