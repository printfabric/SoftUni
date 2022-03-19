input_str = input()
n = int(input())
new_str = ''

def repear_str(input_str, n):
    result = ''
    for i in range(n):
        result += input_str
    return result

print(repear_str(input_str, n))