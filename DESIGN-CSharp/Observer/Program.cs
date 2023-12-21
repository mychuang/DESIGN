using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
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
}
