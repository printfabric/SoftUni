input_string = input().split()
num = int(input())
first_half = []
second_half = []
ll = []

for i in range(0, len(input_string) - 1, 2):
    first_half.append(input_string[i])
    second_half.append(input_string[i + 1])

ll = first_half + second_half
print(ll)
#print(second_half)
