import math
income = float(input())
average_grade = float(input())
minimum_wage = float(input())
social_scholarship = 0
scholarship_for_success = 0

if income < minimum_wage and average_grade > 4.5:
    social_scholarship = minimum_wage * 0.35

if average_grade >= 5.5:
    scholarship_for_success = average_grade * 25

if scholarship_for_success == 0 and social_scholarship == 0:
    print("You cannot get a scholarship!")
else:
    if(scholarship_for_success >= social_scholarship):
        print(f"You get a scholarship for excellent results {math.floor(scholarship_for_success)} BGN")
    else:
        print(f"You get a Social scholarship {math.floor(social_scholarship)} BGN")



