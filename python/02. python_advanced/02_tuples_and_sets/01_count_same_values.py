numbers = [float(x) for x in input().split()]
dict = {}

for x in range(len(numbers)):
    if numbers[x] not in dict.keys():
        dict[numbers[x]] = 0
    dict[numbers[x]] += 1

for x in dict:
    print(f"{x} - {dict[x]} times")
