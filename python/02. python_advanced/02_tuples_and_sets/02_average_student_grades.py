import statistics
import collections

n = int(input())
dict = {}

for x in range(n):
    student = input().split()
    student_name = student[0]
    student_grade = student[1]

    if student_name not in dict.keys():
        dict[student_name] = []
    dict[student_name].append(student_grade)

sorted_dict = collections.OrderedDict(dict)

for x in sorted_dict:
    l = [float(n) for n in sorted_dict[x]]
    average_grade = (statistics.mean(l))
    print(f"{x} -> {' '.join(dict[x])} "
          f"(avg: {'{:.2f}'.format(average_grade)})")