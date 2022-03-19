week_skore = int(input())
exercice_name = input()
score = int(input())
average_score = 0
problems_number = 0
last_problem = None
week_skore_count = 0

while exercice_name != 'Enough':
    average_score += score
    problems_number += 1
    last_problem = exercice_name

    if  score <= 4:
        week_skore_count += 1

    if week_skore_count >= week_skore:
        print(f'You need a break, {week_skore_count} poor grades.')
        break

    exercice_name = input()
    if exercice_name != 'Enough':
        score = int(input())

if exercice_name == 'Enough':
    print(f'Average score: {average_score / problems_number:.2f}')
    print(f'Number of problems: {problems_number}')
    print(f'Last problem: {last_problem}')
