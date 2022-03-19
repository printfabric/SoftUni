num = input()
num_list = [int(d) for d in str(num)]
max_num = ''

for i in range(0, len(num)):
    max_num = max_num + str(max(num_list))
    num_list.remove((max(num_list)))
print(max_num)