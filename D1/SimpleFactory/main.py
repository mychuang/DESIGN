from Factory import Factory

factory = Factory()

A = factory.trainAdventurer(1)
aClass = A.getType();
print(aClass)

B = factory.trainAdventurer(2);
bClass = B.getType();
print(bClass);
