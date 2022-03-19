type = input()
r = int(input())
c = int(input())

seeds_count = r * c
sum = 0

if type == 'Premiere':
    sum += seeds_count * 12
elif type == 'Normal':
    sum += seeds_count * 7.5
else:
    sum += seeds_count * 5

print(f"{sum:.2f} leva")
