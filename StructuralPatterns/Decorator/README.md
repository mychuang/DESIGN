# 裝飾模式

## 目的

動態的將功能附加在物件上

<img src='./01.png' width='75%'>

## 背景故事

冒險者可以取得不同的稱號還裝飾自己，例如"晦瑟暗夜之冒險者"的敏捷較高, "炎龍的冒險者"攻擊力較高，而冒險者的稱號也能疊加，例如，"嘿瑟暗夜的炎龍冒險者"。<br>

如果說可選的稱號有3個，就必須建立3! = 6種子類別，如果有6個，就必須建立6! = 120種子類別，為避免這樣的情況，就必須使用**裝飾模式**

<img src='./02.png' width='75%'>

## 適用場景

- 需要在運行時為物件添加額外的行為

- 如果繼承擴展物件的行為難以實現或不可行，則該使用裝飾模式

## 優點

- 無須創建新子類即可擴展行為

- 可以自由添加或刪除物件的功能

## 缺點

- 各層的初始化配置程式碼可能看起來很複雜

## 程式寫法 - C#

1. 創建被裝飾物件

    ```Csharp
    //冒險者界面(component) - 規範冒險者的功能
    public abstract class Adventurer
    {
        public abstract void attack();
    }
    
    //弓箭手
    class Archer : Adventurer
    {
        public string name { get; set; }

        public Archer(string name) 
        {
            this.name = name;
        }

        public override void attack()
        {
            Console.WriteLine("Archar attack by " + this.name);
        }
    }
    ```

2. 創建裝飾界面與實做類別

    ```Csharp
    //稱號界面(decorator)
    public abstract class Title : Adventurer 
    {
        protected Adventurer adventurer; //被裝飾的冒險者

        public Title(Adventurer adventurer) 
        {
            this.adventurer = adventurer;
        }

        public override void attack()
        {
            this.adventurer.attack();
        }
    }

    //稱號: 強壯
    public class TitleStrong: Title
    {
        public TitleStrong(Adventurer adventurer) : base(adventurer)
        {
        }
        
        public override void attack()
        {
            Console.WriteLine(" Powerful ");
            base.attack();
        }
    }

    //稱號: 敏捷
    public class TitleAgile : Title
    {
        public TitleAgile(Adventurer adventurer) : base(adventurer)
        {
        }

        public override void attack()
        {
            Console.WriteLine(" Fast ");
            base.attack();
        }

        //該稱號的專屬技能
        public void useFlash() 
        {
            Console.WriteLine(" use Fast skill ");
        }
    }

    //稱號: 燃燒
    public class TitleFire : Title
    {
        public TitleFire(Adventurer adventurer) : base(adventurer)
        {
        }

        public override void attack()
        {
            Console.WriteLine(" Burning ");
            base.attack();
        }

        //該稱號的專屬技能
        public void useFire()
        {
            Console.WriteLine(" use Burning skill ");
        }
    }
    ```

3. 測試結果

    ```Csharp
    //創建沒有稱號的弓箭手
    Adventurer archer = new Archer("Miller");
    Console.WriteLine(" --- Archar Miller ---");
    archer.attack();

    Console.WriteLine(" ");
            
    Console.WriteLine(" --- get Strong Archar Miller ---");
    TitleStrong sArcher = new TitleStrong(archer);
    sArcher.attack();

    Console.WriteLine(" ");

    Console.WriteLine(" --- get Agile Strong Archar Miller ---");
    TitleAgile aArcher = new TitleAgile(sArcher);
    aArcher.attack();

    Console.WriteLine(" ");

    Console.WriteLine(" --- get Fire Agile Strong Archar Miller ---");
    TitleFire fArcher = new TitleFire(aArcher);
    fArcher.attack();

    Console.WriteLine(" ");

    Console.WriteLine(" --- get Strong Fire Agile Strong Archar Miller ---");
    TitleStrong ssArcher = new TitleStrong(fArcher);
    ssArcher.attack();
    ```

## 程式寫法 - python

1. 創建被裝飾物件

    ```python
    # 冒險者界面(component) - 規範冒險者的功能
    class Adventurer(ABC):
        @abstractmethod
        def attack(self):
            pass

    class Archer(Adventurer):
        def __init__(self, name):
            self.name = name

        def attack(self):
            print(f"Archer attack by {self.name}")
    ```

2. 創建裝飾界面與實做類別

    ```python
    # 稱號界面(decorator)
    class Title(Adventurer, ABC):
        def __init__(self, adventurer):
            self.adventurer = adventurer

        def attack(self):
            self.adventurer.attack()

    class TitleStrong(Title):
        def __init__(self, adventurer):
            super().__init__(adventurer)

        def attack(self):
            print("Powerful", end=" ")
            super().attack()

    class TitleAgile(Title):
        def __init__(self, adventurer):
            super().__init__(adventurer)

        def attack(self):
            print("Fast", end=" ")
            super().attack()

        def useFlash(self):
            print(" use Fast skill")

    class TitleFire(Title):
        def __init__(self, adventurer):
            super().__init__(adventurer)

        def attack(self):
            print("Burning", end=" ")
            super().attack()

        def useFire(self):
            print(" use Burning skill")
    ```

3. 測試結果

    ```python
    archer = Archer("Miller")
    print(" --- Archar Miller ---")
    archer.attack()

    print("")
    print(" --- get Strong Archar Miller ---");
    sarcher = TitleStrong(archer)
    sarcher.attack()

    print("")
    print(" --- get Agile Strong Archar Miller ---");
    aarcher = TitleAgile(sarcher)
    aarcher.attack()

    print("")
    print(" --- get Fire Agile Strong Archar Miller ---");
    farcher = TitleFire(aarcher)
    farcher.attack()

    print("")
    print(" --- get Strong Fire Agile Strong Archar Miller ---");
    ssarcher = TitleStrong(farcher)
    ssarcher.attack()
    ```








