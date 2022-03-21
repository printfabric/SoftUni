function solve(arr) {
  for (let i = 0; i < arr.length; i++) {
    for (let j = i + 1; j < arr.length; j++) {
      if (arr[i] === arr[j]) {
        arr.splice(j, 1);
        i--;
      }
    }
  }

  return arr.join(' ');
}

console.log(solve([20, 8, 12, 13, 4, 4, 8, 5]));
