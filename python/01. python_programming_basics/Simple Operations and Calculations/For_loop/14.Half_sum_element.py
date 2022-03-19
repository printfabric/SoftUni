import sys
n = int(input())
sum = 0
numbers = [None] * n
max_num = - sys.maxsize - 1
contains = False

for i in range(0, n):
    num = int(input())
    numbers[i] = num
    sum += num

    if num > max_num:
        max_num = num

for x in numbers:
    if (sum - x) == x:
        print('Yes')
        print(f'Sum = {sum - x}')
        contains = True
        break

if not contains:
    print('No')
    print(f'Diff = {abs(max_num - (sum - max_num))}')
