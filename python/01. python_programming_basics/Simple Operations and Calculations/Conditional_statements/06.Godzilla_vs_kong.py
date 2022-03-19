movie_budget = float(input())
statists_count = int(input())
clothing_price = float(input())
sum = 0
decor = movie_budget * 0.1

if statists_count > 150:
    sum = ((clothing_price * 0.9) * statists_count) + decor
else:
    sum = (clothing_price * statists_count) + decor

if  sum > movie_budget:
    print("Not enough money!")
    print(f"Wingard needs {sum - movie_budget:.2f} leva more.")
else:
    print("Action!")
    print(f"Wingard starts filming with {movie_budget - sum:.2f} leva left.")