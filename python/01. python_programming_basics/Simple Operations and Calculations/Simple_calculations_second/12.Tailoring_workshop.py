rectangular_tables_count = int(input())
rectangular_tables_length = float(input())
rectangular_tables_width = float(input())

covers_total_area = rectangular_tables_count * (rectangular_tables_length + 2 * 0.30) *\
      (rectangular_tables_width + 2 * 0.30)
carriage_total_area = rectangular_tables_count * (rectangular_tables_length / 2) *\
      (rectangular_tables_length / 2)

price_usd = (covers_total_area * 7) + (carriage_total_area * 9)
price_bgn = price_usd * 1.85

print(f"{price_usd:.2f} USD")
print(f"{price_bgn:.2f} BGN")