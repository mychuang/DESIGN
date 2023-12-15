from AdventurerFactory import ArcherCamp, WarriorCamp

#創建訓練營
archerCamp = ArcherCamp()
warriorCamp = WarriorCamp()

#訓練冒險者
archer = archerCamp.trainAdventurer()
archer.display()

warrior = warriorCamp.trainAdventurer()
warrior.display()