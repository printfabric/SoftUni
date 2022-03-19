exam_hour = int(input())
exam_minutes = int(input())
arriving_hour = int(input())
arriving_minutes = int(input())
diff = None
exam_to_minutes = (exam_hour * 60) + exam_minutes
arriving_to_minutes = (arriving_hour * 60) + arriving_minutes

if exam_to_minutes < arriving_to_minutes:
    diff = arriving_to_minutes - exam_to_minutes
    print('Late')
    min = diff % 60
    hour = diff // 60

    if diff < 60:
        print(f'{min} minutes after the start')
    else:
        if min < 10:
            min = '0' + str(min)
        print(f'{hour}:{min} hours after the start')

elif exam_to_minutes > arriving_to_minutes or exam_to_minutes == arriving_to_minutes:
    diff = exam_to_minutes - arriving_to_minutes

    if diff > 30:
        print('Early')
    else:
        print('On time')

    if diff > 1 and diff < 60:
        print(f'{diff} minutes before the start')
    elif diff > 1:
        min = None
        hour = diff // 60
        if diff % 60 < 10:
            min = '0' + str(diff % 60)
        else:
            min = diff % 60
        print(f'{hour}:{min} hours before the start')
