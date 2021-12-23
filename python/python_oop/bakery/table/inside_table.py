from table.table import Table


class InsideTable(Table):
    def __init__(self, table_number: int, capacity: int):
        if table_number < 1 or table_number > 50:
            raise ValueError("Inside table's number must be between 1 and 50 inclusive!")

        super().__init__(table_number, capacity)
