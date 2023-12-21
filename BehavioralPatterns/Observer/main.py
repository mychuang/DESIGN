from Adventurer import  Archer, Warrior
from Subject import Association

# 創建觀察者
archer = Archer("Robin")
warrior = Warrior("Conan")

# 創建冒險者協會
association = Association()

# 添加觀察者到冒險者協會(被觀察者)
association.add(archer)
association.add(warrior)

# 發布任務
association.sendQuestions("Defend the castle!")

# 再次發布任務
association.sendQuestions("Run")

# 移除一個觀察者
association.remove(archer)

# 再次發布任務
association.sendQuestions("Run again")