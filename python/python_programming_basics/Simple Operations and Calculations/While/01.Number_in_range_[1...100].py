n = int(input())

while not (n >= 1 and n <= 100):
    print("Invalid number!")
    n = int(input())

print(f'The number is: {n}')