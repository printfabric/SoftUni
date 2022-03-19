n = int(input())
p1 = 0 #numbesr under 200
p2 = 0 #from 200 to 399
p3 = 0 #from 400 to 599
p4 = 0 #from 600 to 799
p5 = 0 #from 800

for i in range(0, n):
    num = int(input())
    if num < 200:
        p1 += 1
    elif num >= 200 and num <= 399:
        p2 += 1
    elif num >= 400 and num <= 599:
        p3 += 1
    elif num >= 600 and num <= 799:
        p4 += 1
    elif num >= 800:
        p5 += 1

p1 = (p1 / n) * 100
p2 = (p2 / n) * 100
p3 = (p3 / n) * 100
p4 = (p4 / n) * 100
p5 = (p5 / n) * 100

print(f'{p1:.2f}%')
print(f'{p2:.2f}%')
print(f'{p3:.2f}%')
print(f'{p4:.2f}%')
print(f'{p5:.2f}%')
