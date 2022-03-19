n = int(input())

for i in range(1, n + 1):

    num = i
    s = 0
    while num:
        s += num % 10
        num //= 10

    if s == 5 or s == 7 or s == 11:
        print(f'{i} -> {True}')
    else:
        print(f'{i} -> {False}')
