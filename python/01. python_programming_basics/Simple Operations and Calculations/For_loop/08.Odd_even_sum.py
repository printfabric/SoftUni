n = int(input())
first_sum = 0
second_sum = 0

for i in range(n):
    num = int(input())
    if i % 2 == 0:
        first_sum += num
    else:
        second_sum += num

if(first_sum == second_sum):
    print('Yes')
    print(f'Sum = {first_sum}')
else:
    print('No')
    print(f'Diff = {abs(first_sum - second_sum)}')