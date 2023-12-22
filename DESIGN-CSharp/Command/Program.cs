using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            //開店準備
            KitchenWorker snackChef = new Chef();
            KitchenWorker barkKeep = new Barkeep();

            Order drinkOrder = new DrinkOrder(barkKeep);
            Order snackOrder = new SnakeOrder(snackChef);

            Waitress waitress = new Waitress();

            //開始營業, 客人點餐
            waitress.setOrder(snackOrder);
            waitress.setOrder(snackOrder);
            waitress.setOrder(drinkOrder);
            waitress.setOrder(drinkOrder);
            waitress.setOrder(snackOrder);

            //取消點心
            waitress.cancelOrder(snackOrder);
            waitress.setOrder(snackOrder);

            //通知廚房
            waitress.notifyBaker();

            Console.ReadKey();
        }
    }
}
