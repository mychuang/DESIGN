from Order import Order

class Waitress():
    def __init__(self):
        self.__snakeQty = 2
        self.__drinkQty = 4
        self.__orderList = []
    
    #接收訂單
    def setOrder(self, order: Order):
        if(order.name == "snakeOrder"):
            if (self.__snakeQty <= 0):
                print("Snake sold out")
            else:
                print("Add snake order")
                self.__snakeQty = self.__snakeQty - 1
                self.__orderList.append(order)

        if(order.name == "drinkOrder"):
            if (self.__drinkQty <= 0):
                print("Drink sold out")
            else:
                print("Add drink order")
                self.__drinkQty = self.__drinkQty - 1
                self.__orderList.append(order)

    #取消訂單
    def cancelOrder(self, order: Order):
        if (order.name == "snakeOrder"):
            self.__snakeQty = self.__snakeQty + 1
            print("Cancel snake order")

        if (order.name == "drinkOrder"):
            self.__drinkQty = self.__drinkQty + 1
            print("Cancel drink order")
            self.__orderList.remove(order)
    
    #將訂單送到廚房
    def notifyBaker(self): 
        for order in self.__orderList:
            order.sendOrder()
        self.__orderList.clear()