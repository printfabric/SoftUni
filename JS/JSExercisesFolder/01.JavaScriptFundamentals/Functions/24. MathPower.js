function solve(num, power) {
  let result = num;
  for (let i = 1; i < power; i++) {
    result *= num;
  }
  return result;
}

console.log(solve(2, 8));
