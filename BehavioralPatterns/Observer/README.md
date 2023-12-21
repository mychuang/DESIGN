# 觀察者模式

## 目的

處理一個物件對應多個物件之間的連動關係。當一個被觀察物件(Subject) 改變時, 其他的觀察者物件(Observer)都會收到通知並執行對應的動作。

<img src='./01.png' width='75%'>

## 背景故事

冒險者協會定期發布一些任務, 當協會發布任務時, 每一名關注協會的冒險者都會收到消息並做出對應的動作。<br>
**發布/訂閱**就是觀察者模式的核心概念, 協會為被觀察物件(Subject), 冒險者為觀察者物件(Observer)

## 適用場景

- 當一個物件改變時, 需要改變其他物件對象

- 當物件的動態未知或動態變化時

- 當應用的物件噓要觀察其他物件時


## 優點

- 開放/封閉原則

- 可在運行時才建立物件之間的關係

## 缺點

- 觀察者物件(Observer)的通知順序是隨機的

## 程式寫法 - C#

1. 觀察者介面

    ```Csharp
    public abstract class Adventure
    {
        protected String name { get; set; }

        public Adventure(String name) 
        {
            this.name = name;
        }

        //接收任務
        public abstract void getQuestions(String questions);
    }
    ```

2. 被觀察者介面

    ```Csharp
    public abstract class Subject
    {
        protected List<Adventure> list = new List<Adventure>();

        //想接收通知的觀察者
        public void add(Adventure observer) 
        {
            list.Add(observer);
        }

        //不想接收通知的觀察者
        public void remove(Adventure observer)
        {
            list.Remove(observer);
        }

        //發布任務
        public abstract void sendQuestions(String questions);
    }
    ```

3. 實做被觀察者

    ```Csharp
    public class Association : Subject
    {
        public override void sendQuestions(String questions) 
        {
            foreach (var adventure in list)
            {
                adventure.getQuestions(questions);
            }
        }
    }
    ```

4. 實做觀察者

    ```Csharp
    //弓箭手繼承冒險者
    public class Archer : Adventure
    {
        public Archer(String name) : base(name)
        {
        }

        public override void getQuestions(String questions) 
        {
            Console.WriteLine("Archar get mission");
        }
    }

    //勇士繼承冒險者
    public class Warrior : Adventure
    {
        public Warrior(String name) : base(name)
        {
        }

        public override void getQuestions(String questions)
        {
            if (questions.Length > 10)
            {
                Console.WriteLine("Warrior get mission, The mission is too complex");
            }
            else 
            {
                Console.WriteLine("Warrior get mission, The mission is easy, should be performed");
            }
        }
    }
    ```

5. 測試

   ```Csharp
   class Program
    {
        static void Main(string[] args)
        {
            // 創建觀察者
            Archer archer = new Archer("Robin");
            Warrior warrior = new Warrior("Conan");

            // 創建冒險者協會
            Subject association = new Association();

            // 添加觀察者到冒險者協會(被觀察者)
            association.add(archer);
            association.add(warrior);

            // 發布任務
            association.sendQuestions("Defend the castle!");

            // 再次發布任務
            association.sendQuestions("Run");

            // 移除一個觀察者
            association.remove(archer);

            // 再次發布任務
            association.sendQuestions("Run again");

            Console.ReadKey();
        }
    }
   ```

## 程式寫法 - python

1. 觀察者介面

    ```python
    from abc import ABC, abstractmethod

    class Adventure(ABC):
        def __init__(self, name: str):
            self.name = name
    
        @abstractmethod
        def getQuestions(self, questions: str):
            pass
    ```

2. 被觀察者介面

    ```python
    from abc import ABC, abstractmethod
    from Adventurer import  Adventure

    # 被觀察者介面
    class Subject(ABC):
        def __init__(self):
            self._list = []

        def add(self, observer: Adventure):
            self._list.append(observer)

        def remove(self, observer: Adventure):
            self._list.remove(observer)
    
        @abstractmethod
        def sendQuestions(self, questions: str):
            pass
    ```

3. 實做被觀察者

    ```python
    class Association(Subject):
        def sendQuestions(self, questions: str):
            for adventure in self._list:
                adventure.getQuestions(questions)
    ```

4. 實做觀察者

    ```python
    class Archer(Adventure):
        def getQuestions(self, questions: str):
            print(f"Archer gets mission: {questions}")

    class Warrior(Adventure):
        def getQuestions(self, questions: str):
            print(f"Warrior gets mission: {questions}")
            if len(questions) > 10:
                print("The mission is too complex")
            else:
                print("The mission is easy, should be performed")
    ```

4. 測試

    ```python
    from Adventurer import  Archer, Warrior
    from Subject import Association

    # 創建觀察者
    archer = Archer("Robin")
    warrior = Warrior("Conan")

    # 創建冒險者協會
    association = Association()

    # 添加觀察者到冒險者協會(被觀察者)
    association.add(archer)
    association.add(warrior)

    # 發布任務
    association.sendQuestions("Defend the castle!")

    # 再次發布任務
    association.sendQuestions("Run")

    # 移除一個觀察者
    association.remove(archer)

    # 再次發布任務
    association.sendQuestions("Run again")
    ```











