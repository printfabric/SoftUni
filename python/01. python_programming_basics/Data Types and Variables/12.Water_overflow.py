n = int(input())
sum = 0
capacity = 255

for i in range(0, n):
    water = int(input())
    if sum + water > capacity:
        print('Insufficient capacity!')
    else:
        sum += water
print(sum)