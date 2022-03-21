function solve(arr) {
    const min = arr.sort((a,b) => a - b).slice(0, 2);
    console.log(min.join(' '));
}

solve([3, 0, 10, 4, 7, 3]);