from collections import deque

food_quantity = int(input())
orders = deque([int(x) for x in input().split()])
biggest_order = max(orders)

while True:
    if len(orders) > 0:
        current_order = orders[0]
        if food_quantity >= current_order:
            food_quantity -= current_order
            orders.popleft()
        else:
            break
    else:
        break

if not orders:
    print(biggest_order)
    print('Orders complete')
else:
    orders = list(orders)
    orders = [str(x) for x in orders]
    print(biggest_order)
    print(f"Orders left: {' '.join(orders)}")

