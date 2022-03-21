function solve(num) {
  let arr = [
    'Monday',
    'Tuesday',
    'Wednesday',
    'Thursday',
    'Friday',
    'Saturday',
    'Sunday'
  ];

  if (num > 0 && num <= 7) {
    console.log(arr[num - 1]);
  } else {
    console.log('Invalid day!');
  }
}

solve(6);
