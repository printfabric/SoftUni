record_in_seconds = float(input())
distance_in_m = float(input())
time_in_seconds_m = float(input())
delay = (distance_in_m // 15) * 12.5
ivancho_time = (distance_in_m * time_in_seconds_m) + delay

if record_in_seconds > ivancho_time:
    print(f"Yes, he succeeded! The new world record is {ivancho_time:.2f} seconds.")
else:
    print(f"No, he failed! He was {ivancho_time - record_in_seconds:.2f} seconds slower.")
