import sys
n = int(input())
max = -sys.maxsize - 1
min = sys.maxsize

for i in range(n):
    num = int(input())
    if num > max:
        max = num
    if num < min:
        min = num

print(f'Max number: {max}')
print(f'Min number: {min}')