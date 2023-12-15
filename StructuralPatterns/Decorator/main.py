from Adventurer import TitleStrong, TitleAgile, TitleFire, Archer

archer = Archer("Miller")
print(" --- Archar Miller ---")
archer.attack()

print("")
print(" --- get Strong Archar Miller ---");
sarcher = TitleStrong(archer)
sarcher.attack()

print("")
print(" --- get Agile Strong Archar Miller ---");
aarcher = TitleAgile(sarcher)
aarcher.attack()

print("")
print(" --- get Fire Agile Strong Archar Miller ---");
farcher = TitleFire(aarcher)
farcher.attack()

print("")
print(" --- get Strong Fire Agile Strong Archar Miller ---");
ssarcher = TitleStrong(farcher)
ssarcher.attack()
