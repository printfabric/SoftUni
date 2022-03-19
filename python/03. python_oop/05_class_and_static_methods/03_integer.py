import math

class Integer:
    def __init__(self, value):
        self.value = value

    @classmethod
    def from_float(cls, float_value):
        if not isinstance(float_value, float):
            return f"value is not a float"
        return cls(math.floor(float_value))

    