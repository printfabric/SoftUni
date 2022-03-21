function solve(arr) {
  console.log(arr.slice(1, arr[0] + 1).join(' '));
  console.log(arr.slice(arr.length - arr[0]).join(' '));
}

solve([2, 7, 8, 9]);
