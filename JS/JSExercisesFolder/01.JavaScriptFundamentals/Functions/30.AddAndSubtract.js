function sum(numOne, numTwo, numThree) {
  let result = numOne + numTwo;
  function substract(result, num) {
    return result - num;
  }

  return substract(result, numThree);
}

console.log(sum(23, 6, 10));
