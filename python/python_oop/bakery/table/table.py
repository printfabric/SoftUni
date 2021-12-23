import abc

from baked_food.baked_food import BakedFood
from drink.drink import Drink


class Table(abc.ABC):

    def __new__(cls, *args, **kwargs):
        if cls is Table:
            raise TypeError("Table cannot be instantiated")

        return object.__new__(cls)

    def __init__(self, table_number: int, capacity: int):
        if capacity <= 0:
            raise ValueError('Capacity has to be greater than 0!')

        self.table_number = table_number
        self.capacity = capacity
        self.food_orders = []
        self.drink_orders = []
        self.number_of_people = 0
        self.is_reserved = False

    def reserve(self, number_of_people: int):
        self.number_of_people = number_of_people
        self.is_reserved = True

    def order_food(self, baked_food: BakedFood):
        self.food_orders.append(baked_food)

    def order_drink(self, drink: Drink):
        self.drink_orders.append(drink)

    def get_bill(self):
        return sum([_.price for _ in self.drink_orders + self.food_orders])

    def clear(self):
        self.food_orders = []
        self.drink_orders = []
        self.number_of_people = 0
        self.is_reserved = False

    def free_table_info(self):
        if self.is_reserved:
            return

        return f"Table: {self.table_number}\nType: {self.__class__.__name__}\nCapacity: {self.capacity}"
