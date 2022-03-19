name = input()
grades = 0.0
for i in range(12):
    grade = float(input())
    grades += grade

if grades >= 4:
    print(f'{name} graduated. Average grade: {grades / 12:.2f}')