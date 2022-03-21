function solve(firstArr, secondArr) {
  let firstArrCopy = firstArr.splice(0, secondArr[0]);
  let counter = 0;
  for (let i = 0; i < secondArr[1]; i++) {
    firstArrCopy.shift();
  }

  for (let i = 0; i < firstArrCopy.length; i++) {
    if (secondArr[2] === firstArrCopy[i]) {
      counter++;
    }
  }

  console.log(`Number ${secondArr[2]} occurs ${counter} times.`);
}

solve([5, 2, 3, 4, 1, 6], [5, 2, 3]);
