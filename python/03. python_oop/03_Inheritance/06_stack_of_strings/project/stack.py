class Stack:
    def __init__(self):
        self.data = []

    def push(self, element):
        self.data.append(element)

    def pop(self):
        result = self.data.pop()
        return result

    def top(self):
        return self.data[-1]

    def is_empty(self):
        return any(self.data)

    def __str__(self):
        return "[" + ", ".join(reversed(self.data)) + "]"
