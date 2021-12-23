import abc


class Drink(abc.ABC):

    def __new__(cls, *args, **kwargs):
        if cls is Drink:
            raise TypeError("Drink cannot be instantiated")

        return object.__new__(cls)

    def __init__(self, name: str, portion: int, price: float, brand: str):
        if not name.strip():
            raise ValueError('Name cannot be empty string or white space!')

        if not brand.strip():
            raise ValueError('Brand cannot be empty string or white space!')

        self.name = name
        self.portion = portion
        self.price = price
        self.brand = brand

    def __repr__(self):
        return f" - {self.name} {self.brand} - {self.portion}ml - {self.price}lv"
