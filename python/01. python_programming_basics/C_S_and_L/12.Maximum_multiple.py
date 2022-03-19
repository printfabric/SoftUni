divisor = int(input())
bound = int(input())
sum = 0

for i in range(divisor, bound + 1, divisor):
    sum += divisor

print(sum)