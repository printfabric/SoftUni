import sys

n = int(input())
equal = True
previous_sum = 0
max_diff = 0

for i in range(0, n):
    first_num = int(input())
    second_num = int(input())
    sum = first_num + second_num
    if i > 0 and previous_sum != sum:
        equal = False

    if i > 0 and max_diff < abs(previous_sum - sum):
        max_diff = abs(previous_sum - sum)

    previous_sum = sum

if equal == True:
    print(f'Yes, value={previous_sum}')
else:
    print(f'No, maxdiff={max_diff}')
