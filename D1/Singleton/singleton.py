import threading

class Singleton:
    _singleton = None  # 使用 None 表示尚未創建物件
    _lock_object = threading.Lock()

    def __init__(self):
        pass

    #靜態方法不需要依賴類的實例化
    @staticmethod
    def getSingleton():
        # 保證 get_singleton() 被呼叫時鎖住,
        # 執行緒只有等 get_singleton() 執行完後才會讓出時間, 避免不同執行緒各自產生新的實體
        with Singleton._lock_object:
            if Singleton._singleton is None:
                print("Return first time")
                Singleton._singleton = Singleton()
                print(f"create Singleton: {id(Singleton._singleton)}")
            return Singleton._singleton

class SingletonTest:
    def __init__(self, my_id):
        self.my_id = my_id

    def run(self):
        # 把要做的事封装至run()
        singleton = Singleton.getSingleton()
        if singleton is not None:
            print(f"{self.my_id} create Singleton: {id(singleton)}")