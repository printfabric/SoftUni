product = input()
quantity = int(input())


def total_price(product, quantity):
    result = 0
    if product == 'coffee':
        result = 1.5 * quantity
    elif product == 'water':
        result = 1.0 * quantity
    elif product == 'coke':
        result = 1.4 * quantity
    elif product == 'snacks':
        result = 2.0 * quantity

    return result

print("%.2f" % total_price(product, quantity))