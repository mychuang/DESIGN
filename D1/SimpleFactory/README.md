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

1. 創建虛擬類-定義冒險者

    ```Csharp
    public abstract class Archer
    {
        public abstract string getType();
    }
    ```

2. 創建產品類-定義弓箭手與鬥士

    ```CSharp
    class Adventurer : Archer
    {
        public override string getType()
        {
            Console.WriteLine("this is Adventurer ");
            return this.GetType().Name;
        }
    }

    class Warrior: Archer
    {
        public override string getType() {
            Console.WriteLine("this is Warrior ");
            return this.GetType().Name;
        }
    }
    ```

3. 創建工廠: 冒險者訓練營

    ```CSharp
    class Factory
    {
        public static Archer trainArcher(int type) {
            if (type == 1)
            {
                return new Adventurer();
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
    class Archer:
        def get_type(self):
            pass

    class Warrior(Archer):
        def get_type(self):
            print("This is Warrior")
            return type(self).__name__

    class Adventurer(Archer):
        def get_type(self):
            print("This is Adventurer")
            return type(self).__name__
    ```

- 創建工廠

    ```python
    class Factory:
        @staticmethod
        def train_archer(type):
            if type == 1:
                return Adventurer()
            elif type == 2:
                return Warrior()
            else:
                return None
    ```



