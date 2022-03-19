from abc import ABC, abstractmethod


# abstraction
class Animal(ABC):
    def __init__(self, name):
        self.name = name

    @property
    def name(self):
        return self.__name

    # enccapsulation
    @name.setter
    def name(self, value):
        if len(value) < 3:
            raise ValueError("name must be at least e chars")
        self.__name = value

    @abstractmethod
    def sound(self):
        pass

class Cat(Animal):
    def sound(self):
        return "Meow"


# inheritance (common validator)
class Dog(Animal):
    def sound(self):
        return "Baw"

# cat = Cat("Petar")
#
# print(cat.name)

# polymorphism
for animal in Cat("petar"), Dog("sharo"):
    print(animal.sound())
