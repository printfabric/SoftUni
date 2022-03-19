from collections import deque

queue = deque(input().split())
toss_count = int(input())

while len(queue) > 1:
    for i in range(toss_count):
        queue.append(queue.popleft())
    print(f'Removed {queue.pop()}')

print(f'Last is {queue.pop()}')
