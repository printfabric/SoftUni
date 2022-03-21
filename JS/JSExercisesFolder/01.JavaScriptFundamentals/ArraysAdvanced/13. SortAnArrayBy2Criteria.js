function solve(arr) {
  arr.sort();

  console.log(
    arr
      .sort(function(a, b) {
        return a.length - b.length;
      })
      .join('\n')
  );
}

solve(['alpha', 'beta', 'gamma']);
