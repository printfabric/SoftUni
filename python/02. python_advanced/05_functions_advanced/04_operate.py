def operate(operator, *args):
    result = 0

    if operator == '+':
        for num in args:
            result += int(num)
    elif operator == '-':
        for num in args:
            result -= int(num)
    elif operator == '*':
        result = int(args[0])
        for i in range(len(args) - 1):
            result *= int(args[i + 1])
    elif operator == '/':
        result = int(args[0])
        for i in range(len(args) - 1):
            result /= int(args[i + 1])

    return result


print(operate("*", 3, 4))