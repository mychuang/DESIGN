from KitchenWorker import Barkeep, Chef
from Order import DrinkOrder, SnakeOrder
from Invoker import Waitress

#開店準備
snackChef = Chef()
barkKeep = Barkeep()

drinkOrder = DrinkOrder(barkKeep)
snackOrder = SnakeOrder(snackChef)

waitress = Waitress()

#開始營業, 客人點餐
waitress.setOrder(snackOrder)
waitress.setOrder(snackOrder)
waitress.setOrder(drinkOrder)
waitress.setOrder(drinkOrder)
waitress.setOrder(snackOrder)

#取消點心
waitress.cancelOrder(snackOrder)
waitress.setOrder(snackOrder)

#通知廚房
waitress.notifyBaker()