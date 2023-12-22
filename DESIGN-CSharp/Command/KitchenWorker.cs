using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public abstract class KitchenWorker
    {
        //完成訂單
        public abstract void finishOrder();
    }

    //飲料師
    public class Barkeep : KitchenWorker 
    {
        public override void finishOrder() 
        {
            Console.WriteLine("Complete Baverage");
        }
    }

    //廚師
    public class Chef : KitchenWorker
    {
        public override void finishOrder()
        {
            Console.WriteLine("Complete Food");
        }
    }
}
