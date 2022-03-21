function solve(arr) {
  let firstArr = arr.sort((a, b) => a - b);
  console.log(firstArr);
  let secondArr = firstArr.slice().reverse();
  let result = [];

  for (let i = 0; i < arr.length / 2; i++) {
    result.push(secondArr[i]);
    if (arr.length % 2 == !0) {
      if (i < arr.length / 2 - 1) {
        result.push(firstArr[i]);
      } else {
      }
    } else {
      result.push(firstArr[i]);
    }
  }

  console.log(result.join(' '));
}

console.log(solve([1, 21, 3, 52, 69, 63, 31, 2, 18, 94]));
