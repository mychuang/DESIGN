from component import Association
from Leaf import ServiceDepartment, HumanResource

# 創建冒險者協會
root = Association("Adventurer Head")
root.add(HumanResource("Adventurer Head - Human Resource"))
root.add(ServiceDepartment("Adventurer Head - Service Department"))

# 創建分會
mars = Association("Mars Adventurer")
mars.add(HumanResource("Mars Adventurer - Human Resource"))
mars.add(ServiceDepartment("Mars Adventurer - Service Department"))
root.add(mars)

saturn = Association("Saturn Adventurer")
saturn.add(HumanResource("Saturn Adventurer - Human Resource"))
saturn.add(ServiceDepartment("Saturn Adventurer - Service Department"))
root.add(saturn)

# 創建分會下的子分會
saturn01 = Association("Saturn 01 Adventurer")
saturn01.add(HumanResource("Saturn 01 Adventurer - Human Resource"))
saturn01.add(ServiceDepartment("Saturn 01 Adventurer - Service Department"))
saturn.add(saturn01)

saturn02 = Association("Saturn 02 Adventurer")
saturn02.add(HumanResource("Saturn 02 Adventurer - Human Resource"))
saturn.add(saturn02)

print("\n--- Show Structure ---\n")
root.display(1)

print("\n--- Show Duty ---\n")
root.line_of_duty()