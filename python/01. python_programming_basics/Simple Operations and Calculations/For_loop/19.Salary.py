n = int(input())
salary = float(input())

facebook = 150
instagram = 100
reddit = 50
fine_amoint = 0

for i in range(0, n):

    web_page = input()
    if web_page == 'Facebook':
        fine_amoint += facebook
    elif web_page == 'Instagram':
        fine_amoint += instagram
    elif web_page == 'Reddit':
        fine_amoint += reddit

    if (salary - fine_amoint) <= 0:
        print('You have lost your salary.')
        break

if salary - fine_amoint > 0:
    print(f'{salary - fine_amoint:.0f}')