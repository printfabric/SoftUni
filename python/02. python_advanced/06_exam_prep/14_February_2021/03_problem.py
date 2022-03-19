def stock_availability(input_list, *args):
    inv_list = list(input_list)
    command = args[0]
    number = 0

    if command == "delivery":
        for i in range(1, len(args)):
            inv_list.append(args[i])

    elif command == "sell":
        for i in range(1, len(args)):
            if args[i].isdigit():
                number = int(args[i])

        for i in range(number):
            inv_list.pop(0)


