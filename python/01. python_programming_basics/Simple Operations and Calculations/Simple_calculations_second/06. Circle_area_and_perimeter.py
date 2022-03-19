import math

r = float(input())
perimeter = r * 2 * math.pi
area = math.pi * math.pow(r, 2)

print("%.2f" % area)
print("%.2f" % perimeter)
