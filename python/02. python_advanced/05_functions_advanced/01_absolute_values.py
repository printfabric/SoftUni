numbers = [float(x) for x in input().split()]

for i in range(len(numbers)):
    numbers[i] = abs(numbers[i])

print(numbers)