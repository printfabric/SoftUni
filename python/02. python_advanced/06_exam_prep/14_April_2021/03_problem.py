def flights(*args):
    result = {}
    for i in range(0, len(args), 2):
        if args[i] == 'Finish':
            break
        else:
            if args[i] in result.keys():
                result[args[i]] += args[i + 1]
            else:
                result[args[i]] = 0
                result[args[i]] += args[i + 1]

    return(result)

print(flights('Vienna', 256, 'Vienna', 26, 'Morocco', 98, 'Paris', 115, 'Finish', 'Paris', 15))