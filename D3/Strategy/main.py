from Adventure import Adventure
from FlightStrategy import NormalAttack, UseSkill, UseItem

adventure = Adventure()

adventure.chooseStrategy(NormalAttack())
adventure.attack()

adventure.chooseStrategy(UseSkill())
adventure.attack()

adventure.chooseStrategy(UseItem())
adventure.attack()
