# 簡單工廠模式

## 目的

通過將物件的創建過程封裝在一個工廠類中，根據輸入參數的不同, 以取得不同的物件, 使客戶端代碼與具體物件的創建過程解耦

## 適用場景

- 當一個系統擁有多個相似的類，且需要動態地選擇其中一個進行實例化時。

- 當客戶端無需關心物件的具體實現細節，只需知道如何使用該物件時。

- 當物件的創建過程比較複雜，且需要集中管理時。

## 優點

- 封裝了創建細節： 客戶端只需關心使用物件的接口，從而降低了客戶端代碼的複雜性。

- 集中管理： 將物件的創建過程集中到一個工廠類中，有助於集中管理和維護。

## 缺點

- 簡單工廠模式將物件的創建過程封裝在一個工廠類中，這樣可能會導致工廠類變得龐大。

- 當有多個不同的產品等級結構時，簡單工廠模式容易變得複雜難以維護。

## 程式寫法 - C#

建立一個冒險者的父類別, 弓箭手和鬥士則為實體產品; 如果有人要招募冒險者, 只需要跟訓練營說要哪種冒險者就好, 而不用理解冒險者的訓練過程。<br>

如果未來多了一個牧師冒險者，只要在訓練營新增一個條件就好，但這樣可能破壞了封閉/開放原則，因此簡單工廠不能算是一個健全的設計模式，但對於小型軟體架構還是很好用。

1. 創建虛擬類-定義冒險者

    ```Csharp
    public abstract class Adventurer
    {
        public abstract string getType();
    }
    ```

2. 創建產品類-定義弓箭手與鬥士

    ```CSharp
    class Archer : Adventurer
    {
        public override string getType()
        {
            Console.WriteLine("this is Adventurer ");
            return this.GetType().Name;
        }
    }

    class Warrior: Adventurer
    {
        public override string getType() {
            Console.WriteLine("this is Warrior ");
            return this.GetType().Name;
        }
    }
    ```

3. 創建工廠: 冒險者訓練營

    ```CSharp
    public class Factory
    {
        public static Adventurer trainAdventurer(int type) {
            if (type == 1)
            {
                return new Archer();
            }
            else if (type == 2)
            {
                return new Warrior();
            }
            else
            {
                return null;
            }
        }
    }
    ```

## 程式寫法 - python

- 創建冒險者與其產品

    ```python
    class Adventurer:
        def getType(self):
            pass

    class Warrior(Adventurer):
        def getType(self):
            print("This is Warrior")
            return type(self).__name__

    class Archer(Adventurer):
        def getType(self):
            print("This is Adventurer")
            return type(self).__name__
    ```

- 創建工廠

    ```python
    class Factory:
        @staticmethod
        def trainAdventurer(type):
            if type == 1:
                return Archer()
            elif type == 2:
                return Warrior()
            else:
                return None
    ```



