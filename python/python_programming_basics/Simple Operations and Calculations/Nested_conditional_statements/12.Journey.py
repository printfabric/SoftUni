budget = float(input())
season = input().lower()

destination = None
place_to_stay = None

if budget <= 100:
    destination = 'Bulgaria'
    if season == 'summer':
        budget *= 0.3
        place_to_stay = 'Camp'
    else:
        budget *= 0.7
        place_to_stay = 'Hotel'
elif budget > 100 and budget <= 1000:
    destination = 'Balkans'
    if season == 'summer':
        budget *= 0.4
        place_to_stay = 'Camp'
    else:
        budget *= 0.8
        place_to_stay = 'Hotel'
elif budget > 1000:
    destination = 'Europe'
    place_to_stay = 'Hotel'
    budget *= 0.9

print(f'Somewhere in {destination}')
print(f'{place_to_stay} - {budget:.2f}')

