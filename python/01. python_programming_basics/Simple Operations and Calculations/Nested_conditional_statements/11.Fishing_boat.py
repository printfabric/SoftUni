group_budget = float(input())
season = input()
fisherman_count = int(input())

boat_price = 0

if season == 'Spring':
    boat_price = 3000
    if fisherman_count <= 6:
        boat_price *= 0.9
    elif fisherman_count >= 7 and fisherman_count <= 11:
        boat_price *= 0.85
    elif fisherman_count >= 12:
        boat_price *= 0.75

elif season == 'Summer':
    boat_price = 4200
    if fisherman_count <= 6:
        boat_price *= 0.9
    elif fisherman_count >= 7 and fisherman_count <= 11:
        boat_price *= 0.85
    elif fisherman_count >= 12:
        boat_price *= 0.75
elif season == 'Autumn':
    boat_price = 4200
    if fisherman_count <= 6:
        boat_price *= 0.9
    elif fisherman_count >= 7 and fisherman_count <= 11:
        boat_price *= 0.85
    elif fisherman_count >= 12:
        boat_price *= 0.75
elif season == 'Winter':
    boat_price = 2600
    if fisherman_count <= 6:
        boat_price *= 0.9
    elif fisherman_count >= 7 and fisherman_count <= 11:
        boat_price *= 0.85
    elif fisherman_count >= 12:
        boat_price *= 0.75

if fisherman_count % 2 == 0 and season != 'Autumn':
    boat_price *= 0.95

if group_budget >= boat_price:
    print(f"Yes! You have {group_budget - boat_price:.2f} leva left.")
else:
    print(f'Not enough money! You need {boat_price - group_budget:.2f} leva.')
