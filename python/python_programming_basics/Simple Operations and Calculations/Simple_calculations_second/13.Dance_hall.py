import math

l = float(input())
w = float(input())
a = float(input())

hall_size = (l * 100) * (w * 100)
wardrobe_size = (a * 100) ** 2
bench_size = hall_size / 10
free_space = hall_size - wardrobe_size - bench_size
dancers = free_space / (40 + 7000)

print(math.trunc(dancers))