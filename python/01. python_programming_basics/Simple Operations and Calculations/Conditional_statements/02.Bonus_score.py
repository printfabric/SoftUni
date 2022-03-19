num = int(input())
first_bonus = 0
second_bonus = 0

if num % 2 == 0:
    second_bonus += 1
elif num % 10 == 5:
    second_bonus += 2

if num <= 100:
    first_bonus += 5
elif num > 100 and num <= 1000:
    first_bonus = num * 0.2
elif num > 1000:
    first_bonus = num * 0.1

print(first_bonus + second_bonus)
print(num + first_bonus + second_bonus)
