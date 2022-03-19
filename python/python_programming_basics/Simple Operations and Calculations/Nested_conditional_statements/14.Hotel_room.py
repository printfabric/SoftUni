month = input()
overnight_count = int(input())

studio = None
apartment = None

if month == 'May' or month == 'October':
    if overnight_count > 7 and overnight_count <= 14:
        studio = (50 * 0.95) * overnight_count
        apartment = 65 * overnight_count
    elif overnight_count > 14:
        studio = (50 * 0.7) * overnight_count
        apartment = (65 * 0.9) * overnight_count
    else:
        studio = 50 * overnight_count
        apartment = 65 * overnight_count

elif month == 'June' or month == 'September':
    if overnight_count > 14:
        studio = (75.2 * 0.8) * overnight_count
        apartment = (68.7 * 0.9) * overnight_count
    else:
        studio = 75.2 * overnight_count
        apartment = 68.7 * overnight_count
elif month == 'July' or month == 'August':
    if overnight_count > 14:
        studio = 76 * overnight_count
        apartment = (77 * 0.9) * overnight_count
    else:
        studio = 76 * overnight_count
        apartment = 77 * overnight_count

print(f'Apartment: {apartment:.2f} lv.')
print(f'Studio: {studio:.2f} lv.')