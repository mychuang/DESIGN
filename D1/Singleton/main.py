import threading
from singleton import Singleton, SingletonTest

mySingletonGreedInstance = Singleton.getSingleton()

# 創建多個執行緒
thread1 = SingletonTest("Thread 1")
thread2 = SingletonTest("Thread 2")

t1 = threading.Thread(target=thread1.run)
t2 = threading.Thread(target=thread2.run)


# 啟動執行緒
t1.start();
t2.start();

# 等待執行緒任務完成
t1.join();
t2.join();
