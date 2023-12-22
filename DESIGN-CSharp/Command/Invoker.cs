using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    //服務生
    public class Waitress
    {
        private int snakeQty = 2;

        private int drinkQty = 4;

        private List<Order> orderList = new List<Order>();

        //接收訂單
        public void setOrder(Order order) 
        {
            if (order.name.Equals("snakeOrder")) 
            {
                if (this.snakeQty <= 0)
                {
                    Console.WriteLine("Snake sold out");
                }
                else
                {
                    Console.WriteLine("Add snake order");
                    snakeQty--;
                    orderList.Add(order);
                }
            }

            if (order.name.Equals("drinkOrder"))
            {
                if (this.drinkQty <= 0)
                {
                    Console.WriteLine("Drink sold out");
                }
                else
                {
                    Console.WriteLine("Add drink order");
                    drinkQty--;
                    this.orderList.Add(order);
                }
            }
        }

        //取消訂單
        public void cancelOrder(Order order)
        {
            if (order.name.Equals("snakeOrder"))
            {
                snakeQty++;
                Console.WriteLine("Cancel snake order");
            }

            if (order.name.Equals("drinkOrder"))
            {
                drinkQty++;
                Console.WriteLine("Cancel drink order");
            }

            this.orderList.Remove(order);
        }

        //將訂單送到廚房
        public void notifyBaker() 
        {
            foreach (var order in this.orderList)
            {
                order.sendOrder();
            }

            this.orderList.Clear();
        }
    }
}
