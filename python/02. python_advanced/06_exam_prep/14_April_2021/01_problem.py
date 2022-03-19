pizza_orders = [int(x) for x in input().split(", ")]
employees_making_capacities = [int(x) for x in input().split(", ")]
remaining_pizzas = 0
made_pizzas = 0

while len(pizza_orders) > 0 and len(employees_making_capacities) > 0:
    current_order = int(pizza_orders[0])
    current_employee_capacity = int(employees_making_capacities[-1])
    if current_order < 11 and current_order > 0:
        if remaining_pizzas > 0:
            made_pizzas += remaining_pizzas
            remaining_pizzas -= current_employee_capacity
            if remaining_pizzas <= 0:
                remaining_pizzas = 0
            else:
                made_pizzas -= remaining_pizzas
            employees_making_capacities = employees_making_capacities[:-1]
        elif current_order <= current_employee_capacity:
            made_pizzas += pizza_orders.pop(0)

            employees_making_capacities = employees_making_capacities[:-1]
        else:
            remaining_pizzas = current_order - current_employee_capacity
            made_pizzas += current_employee_capacity
            pizza_orders.pop(0)
            employees_making_capacities = employees_making_capacities[:-1]

    else:
        pizza_orders.pop(0)


if remaining_pizzas > 0:
    pizza_orders.insert(0, remaining_pizzas)

if len(pizza_orders) == 0:
    print("All orders are successfully completed!")
    print(f"Total pizzas made: {made_pizzas}")
    print(f"Employees: {', '.join([str(i) for i in employees_making_capacities])}")

if len(pizza_orders) > 0:
    print('Not all orders are completed.')
    print(f"Orders left: {', '.join([str(i) for i in pizza_orders])}")