using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public abstract class Order
    {
        //廚房工作者(receiver)
        protected KitchenWorker receiver;
        
        public string name { get; set; }

        public Order(KitchenWorker receiver)
        {
            this.receiver = receiver;
        }

        //將訂單送給廚房人員
        public void sendOrder() 
        {
            this.receiver.finishOrder();
        }
    }

    public class DrinkOrder : Order
    { 
        public DrinkOrder(KitchenWorker receiver) : base(receiver) 
        {
            base.name = "drinkOrder";
        }
    }

    public class SnakeOrder : Order
    {
        public SnakeOrder(KitchenWorker receiver) : base(receiver)
        {
            base.name = "snakeOrder";
        }
    }

}
