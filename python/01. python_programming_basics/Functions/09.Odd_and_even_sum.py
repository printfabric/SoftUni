num = input()


def sum_of_odds_and_evens(num):
    sum_of_odds = 0
    sum_of_evens = 0
    for i in range(len(num)):
        digit = int(num[i])
        if digit % 2 != 0:
            sum_of_odds += digit
        else:
            sum_of_evens += digit

    return (f'Odd sum = {sum_of_odds}, Even sum = {sum_of_evens}')


print(sum_of_odds_and_evens(num))
