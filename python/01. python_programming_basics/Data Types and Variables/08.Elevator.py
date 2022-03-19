import math
people = int(input())
capacity = int(input())

if people <= capacity:
    print('All the persons fit inside in the elevator.'
          'Only one course is needed.')
else:
    print(math.ceil(people / capacity))