num = float(input())
first_unit = input()
second_unit = input()
result = None

if first_unit == "m":
    if second_unit == "cm":
        result = num / 0.01
    elif second_unit == "mm":
        result = num / 0.001
elif first_unit == "cm":
    if second_unit == "m":
        result = num / 100
    elif second_unit == "mm":
        result = num * 10
elif first_unit == "mm":
    if second_unit == "m":
        result = num / 1000
    elif second_unit == "cm":
        result = num / 10

print(f"{result:.3f}")