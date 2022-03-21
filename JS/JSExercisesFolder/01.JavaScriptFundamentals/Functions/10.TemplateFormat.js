function cooking(input) {
  let result = +input[0];
  for (let i = 1; i < input.length; i++) {
    if (input[i] === 'chop') {
      result /= 2;
      console.log(result);
    } else if (input[i] === 'dice') {
      result = Math.sqrt(result);
      console.log(result);
    } else if (input[i] === 'spice') {
      result += 1;
      console.log(result);
    } else if (input[i] === 'bake') {
      result *= 3;
      console.log(result);
    } else if (input[i] === 'fillet') {
      result *= 0.8;
      console.log(result);
    }
  }
}

cooking(['9', 'dice', 'spice', 'chop', 'bake', 'fillet']);
