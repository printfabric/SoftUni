N1 = int(input())
N2 = int(input())
operator = input()

if operator == '+' or operator == '-' or operator == '*':
    if operator == '+':
        if (N1 + N2) % 2 == 0:
            print(f'{N1} {operator} {N2} = {N1 + N2} - even')
        else:
            print(f'{N1} {operator} {N2} = {N1 + N2} - odd')
    elif operator == '-':
        if (N1 - N2) % 2 == 0:
            print(f'{N1} {operator} {N2} = {N1 - N2} - even')
        else:
            print(f'{N1} {operator} {N2} = {N1 - N2} - odd')
    elif operator == '*':
        if (N1 * N2) % 2 == 0:
            print(f'{N1} {operator} {N2} = {N1 * N2} - even')
        else:
            print(f'{N1} {operator} {N2} = {N1 * N2} - odd')

elif operator == '/':
    if N2 == 0:
        print(f'Cannot divide {N1} by zero')
    else:
        print(f'{N1} / {N2} = {N1 / N2:.2f}')

elif operator == '%':
    if N2 == 0:
        print(f'Cannot divide {N1} by zero')
    else:
        print(f'{N1} % {N2} = {N1 % N2}')
