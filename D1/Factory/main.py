from factory import ArcherCamp, WarriorCamp

#創建訓練營
archerCamp = ArcherCamp()
warriorCamp = WarriorCamp()

#訓練冒險者
archer = archerCamp.trainAdventurer()
warrior = warriorCamp.trainAdventurer()

print("Archer type: " + archer.getType())
print("Warrior type: " + warrior.getType())