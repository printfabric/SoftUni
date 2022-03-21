function solve(num) {
  let even = 0;
  let odd = 0;
  let stop = num.toString().length;
  for (let i = 0; i < stop; i++) {
    if ((num % 10) % 2 === 0) {
      even += num % 10;
      num = Math.floor(num / 1e1);
    } else {
      odd += num % 10;
      num = Math.floor(num / 1e1);
    }
  }

  console.log(`Odd sum = ${odd}, Even sum = ${even}`);
}

solve(3495892137259234);
