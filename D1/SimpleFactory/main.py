from Factory import Factory

factory = Factory()

A = factory.train_archer(1)
aClass = A.get_type();
print(aClass)

B = factory.train_archer(2);
bClass = B.get_type();
print(bClass);
