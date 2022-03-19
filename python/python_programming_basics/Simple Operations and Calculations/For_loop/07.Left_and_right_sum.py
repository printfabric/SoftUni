n = int(input())
first_half = 0
second_half = 0

for i in range(n):
    num = int(input())
    first_half += num

for i in range(n):
    num = int(input())
    second_half += num

if(first_half == second_half):
    print(f'Yes, sum = {first_half}')
else:
    print(f'No, diff = {abs(first_half - second_half)}')