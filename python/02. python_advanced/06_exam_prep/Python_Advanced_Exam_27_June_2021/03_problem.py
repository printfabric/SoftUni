def math_operations(*args, **kwargs):
    while len(args) > 0:
        if len(args) > 0:
            kwargs['a'] += args[0]
            args = args[1:]
        if len(args) > 0:
            kwargs['s'] -= args[0]
            args = args[1:]
        if len(args) > 0:
            if args[0] != 0:
                kwargs['d'] /= args[0]
                args = args[1:]
            else:
                args = args[1:]
        if len(args) > 0:
            kwargs['m'] *= args[0]
            args = args[1:]

    return(kwargs)



print(math_operations(6, a=0, s=0, d=0, m=0))