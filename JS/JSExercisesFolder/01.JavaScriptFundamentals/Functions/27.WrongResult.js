function solve(numOne, numTwo, numThree) {
  let result = numOne * numTwo * numThree;
  if (result >= 0) {
    return 'Positive';
  } else {
    return 'Negative';
  }
}

console.log(solve(5, 12, -15));
