operator = input()
first_number = int(input())
second_number = int(input())
result = None


def calculator(operator, first_number, second_number):
    if operator == 'multiply':
        result = first_number * second_number
    elif operator == 'divide':
        result = int(first_number / second_number)
    elif operator == 'add':
        result = first_number + second_number
    elif operator == 'subtract':
        result = first_number - second_number

    return result

print(calculator(operator, first_number, second_number))