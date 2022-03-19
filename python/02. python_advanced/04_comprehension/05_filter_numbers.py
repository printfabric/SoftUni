start_integer = int(input())
enf_integer = int(input())

result = [x for x in range(start_integer, enf_integer + 1) if [d for d in range(2, 11) if x % d == 0]]

print(result)