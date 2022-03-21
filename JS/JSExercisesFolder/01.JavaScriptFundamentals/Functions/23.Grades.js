function solve(num) {
  if (num >= 2 && num < 3) {
    console.log('Fail');
  } else if (num >= 3 && num < 3.5) {
    console.log('Poor');
  } else if (num >= 3.5 && num < 4.5) {
    console.log('Good');
  } else if (num >= 4.5 && num < 5.5) {
    console.log('Very good');
  } else if (num >= 5.5 && num <= 6) {
    console.log('Excellent');
  }
}

solve(4.5);
