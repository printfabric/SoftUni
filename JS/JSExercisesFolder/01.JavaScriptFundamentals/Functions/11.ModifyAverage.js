function solve(input) {
  while (true) {
    let number = +input;
    let average = 0;
    while (number) {
      average += number % 10;
      number = Math.floor(number / 10);
    }

    average = average / ('' + input).length;
    if (average > 5) {
      console.log(input);
      break;
    } else {
      input = '' + input + 9;
    }
  }
}

solve(101);
