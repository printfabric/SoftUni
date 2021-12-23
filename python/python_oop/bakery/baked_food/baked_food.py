import abc


class BakedFood(abc.ABC):

    def __new__(cls, *args, **kwargs):
        if cls is BakedFood:
            raise TypeError("BakedFood cannot be instantiated")

        return object.__new__(cls)

    def __init__(self, name: str, portion: float, price: float):
        if not name.strip():
            raise ValueError('Name cannot be empty string or white space!')

        if price <= 0:
            raise ValueError('Price cannot be less than or equal to zero!')

        self.name = name
        self.portion = portion
        self.price = price

    def __repr__(self):
        return f" - {self.name}: {self.portion}g - {self.price}lv"
