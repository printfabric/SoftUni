n = int(input())
balance = 0

for i in range(n):
    increase = float(input())
    if increase > 0:
        balance += increase
        print(f'Increase: {increase:.2f}')
    else:
        print("Invalid operation!")
        break

print(f'Total: {balance:.2f}')