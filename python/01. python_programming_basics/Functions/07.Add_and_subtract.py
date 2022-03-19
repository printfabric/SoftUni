a = int(input())
b = int(input())
c = int(input())


def add_and_subtract(a, b, c):
    def sum_numbers(a, b):
        return a + b

    def subtract(c, sumNumbers):
        return sumNumbers - c

    return subtract(c, sum_numbers(a, b))


print(add_and_subtract(a, b, c))
