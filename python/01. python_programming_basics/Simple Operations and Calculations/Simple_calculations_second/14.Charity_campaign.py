days_count = int(input())
confectioners_count = int(input())
cake_count = int(input())
waffles_count = int(input())
pancakes_count = int(input())

cakes = cake_count * 45
waffles = waffles_count * 5.80
pancakes = pancakes_count * 3.20
sum = (((cakes + waffles + pancakes) * days_count) * confectioners_count) * 0.875

print(f"{sum:.2f}")