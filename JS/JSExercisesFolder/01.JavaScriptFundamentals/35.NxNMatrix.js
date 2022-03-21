function solve(n) {
  for (let i = 0; i < n; i++) {
    let temp = [];
    for (let j = 0; j < n; j++) {
      temp.push(n);
    }

    console.log(temp.join(' '));
  }
}

solve(2);
