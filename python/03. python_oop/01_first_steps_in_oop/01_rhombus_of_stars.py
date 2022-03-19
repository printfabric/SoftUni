def print_rhombus_of_stars(n):
    for i in range(1, n + 1):
        print(' ' * (n - i), end="")
        print('* ' * (i - 1), end="")
        print('*', end="")
        print()

    for i in range(n - 1, 0, -1):
        print(' ' * (n - i), end="")
        print('* ' * (i - 1), end="")
        print('*', end="")
        print()

n = int(input())

print_rhombus_of_stars(n)
