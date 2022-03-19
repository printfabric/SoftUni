chr_a = input()
chr_b = input()


def print_ascii(a, b):
    result = ''
    for i in range(ord(chr_a) + 1, ord(chr_b)):
        result += chr(i)

    result = " ".join(result)
    return result


print(print_ascii(chr_a, chr_b))
