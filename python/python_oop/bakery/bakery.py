from baked_food.bread import Bread
from baked_food.cake import Cake
from drink.tea import Tea
from drink.water import Water
from table.inside_table import InsideTable
from table.outside_table import OutsideTable


class Bakery:
    def __init__(self, name: str):
        if not name.strip():
            raise ValueError('Name cannot be empty string or white space!')

        self.name = name
        self.food_menu = []
        self.drinks_menu = []
        self.tables_repository = []
        self.total_income = 0

    def add_food(self, food_type: str, name: str, price: float):
        klass = None

        if food_type == 'Bread':
            klass = Bread

        if food_type == 'Cake':
            klass = Cake

        if any([isinstance(f, klass) for f in self.food_menu]):
            raise Exception(f"{food_type} {name} is already in the menu!")

        self.food_menu.append(klass(name, price))
        return f"Added {name} ({food_type}) to the food menu"

    def add_drink(self, drink_type: str, name: str, portion: int, brand: str):
        klass = None

        if drink_type == 'Tea':
            klass = Tea

        if drink_type == 'Water':
            klass = Water

        if any([isinstance(f, klass) for f in self.drinks_menu]):
            raise Exception(f"{drink_type} {name} is already in the menu!")

        self.drinks_menu.append(klass(name, portion, brand))
        return f"Added {name} ({brand}) to the drink menu"

    def add_table(self, table_type: str, table_number: int, capacity: int):
        klass = None

        if table_type == "InsideTable":
            klass = InsideTable

        if table_type == "OutsideTable":
            klass = OutsideTable

        if any([_.table_number == table_number for _ in self.tables_repository]):
            raise Exception(f"Table {table_number} is already in the bakery!")

        self.tables_repository.append(klass(table_number, capacity))
        return f"Added table number {table_number} in the bakery"

    def reserve_table(self, number_of_people: int):
        for table in self.tables_repository:
            if table.is_reserved == False and table.capacity >= number_of_people:
                table.reserve(number_of_people)
                return f"Table {table.table_number} has been reserved for {number_of_people} people"

        return f"No available table for {number_of_people} people"

    def order_food(self, table_number: int, *foods: str):

        for table in self.tables_repository:
            if table.table_number != table_number:
                continue

            ordered = []
            skipped = []
            for food in foods:

                f = list(filter(lambda x: x.__class__.__name__ == food, self.food_menu))
                if f:
                    table.order_food(f[0])
                    ordered.append(str(f[0]))
                else:
                    skipped.append(food)

            message = [f"Table {table_number} ordered:"] + ordered + [f"{self.name} does not have in the menu:"] + skipped
            return "\n".join(message)

        return f"Could not find table {table_number}"

    def order_drink(self, table_number: int, *drinks: str):

        for table in self.tables_repository:
            if table.table_number != table_number:
                continue

            ordered = []
            skipped = []
            for drink in drinks:

                f = list(filter(lambda x: x.__class__.__name__ == drink, self.drinks_menu))
                if f:
                    table.order_food(f[0])
                    ordered.append(str(f[0]))
                else:
                    skipped.append(drink)

            message = [f"Table {table_number} ordered:"] + ordered + [f"{self.name} does not have in the menu:"] + skipped
            return "\n".join(message)

        return f"Could not find table {table_number}"

    def leave_table(self, table_number: int):
        for table in self.tables_repository:
            if table.table_number != table_number:
                continue

            message = f"Table: {table.table_number}\nBill: {table.get_bill():.2f}"
            self.total_income += table.get_bill()
            table.clear()
            return message

    def get_free_tables_info(self):
        message = []
        for table in self.tables_repository:
            if not table.is_reserved:
                message.append(table.free_table_info())

        return "\n".join(message)

    def get_total_income(self):
        return f"Total income: {self.total_income:.2f}lv"
