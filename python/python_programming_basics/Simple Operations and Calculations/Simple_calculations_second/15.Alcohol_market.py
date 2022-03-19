whiskey_price = float(input())
beer_volume = float(input())
wine_volume = float(input())
rakiq_volume = float(input())
whiskey_volume = float(input())

rakiq_price = whiskey_price * 0.5
wine_price = rakiq_price * 0.6
beer_price = rakiq_price * 0.2
rakiq_sum = rakiq_volume * rakiq_price
wine_sum = wine_volume * wine_price
beer_sum = beer_volume * beer_price
whiskey_sum = whiskey_volume * whiskey_price
result = rakiq_sum + wine_sum + beer_sum + whiskey_sum

print(f"{result:.2f}")
