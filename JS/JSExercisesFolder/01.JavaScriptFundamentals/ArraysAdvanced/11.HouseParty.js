function solve(arr) {
  let list = [];
  for (let i = 0; i < arr.length; i++) {
    let splitedArr = arr[i].split(' ');
    let name = splitedArr[0];
    if (splitedArr[2] === 'not') {
      if (list.includes(name)) {
        list = list.filter((x) => x !== name);
      } else {
        console.log(`${name} is not in the list!`);
      }
    } else {
      if (list.includes(name)) {
        console.log(`${name} is already in the list!`);
      } else {
        list.push(name);
      }
    }
  }

  console.log(list.join('\n'));
}

solve([
  'Tom is going!',
  'Annie is going!',
  'Tom is going!',
  'Garry is going!',
  'Jerry is going!',
]);
