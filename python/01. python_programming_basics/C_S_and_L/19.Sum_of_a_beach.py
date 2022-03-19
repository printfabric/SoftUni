string = input()
string = string.upper()

sum = string.count("FISH") +\
      string.count("SAND") +\
      string.count("WATER") +\
      string.count("SUN")

print(sum)