import math
party_size = int(input())
days = int(input())

earnings = (days * 50) - (days * 2 * party_size)
earnings = earnings - (math.floor(days / 3) * party_size)