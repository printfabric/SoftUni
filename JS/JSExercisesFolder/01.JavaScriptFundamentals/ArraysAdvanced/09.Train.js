function solve(arr) {
  let numbers = arr[0].split(' ');
  let capacity = arr[1];

  for (let i = 2; i < arr.length; i++) {
    let command = arr[i].split(' ');
    if (command[0] === 'Add') {
      numbers.push(command[1]);
    } else {
      for (let j = 0; j < numbers.length; j++) {
        if (+numbers[j] + +command[0] <= +capacity) {
          numbers[j] = Number(numbers[j]) + Number(command[0]);
          break;
        }
      }
    }
  }

  return numbers.join(' ');
}

solve(['32 54 21 12 4 0 23', '75', 'Add 10', 'Add 0', '30', '10', '75']);
