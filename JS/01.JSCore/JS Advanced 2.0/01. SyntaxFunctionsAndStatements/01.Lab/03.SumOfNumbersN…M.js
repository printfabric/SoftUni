function solve(n, m) {
    let sum = 0;
    
    for (let i = +n; i <= +m; i++) {
        sum += i;
    }

    console.log(sum);
}

solve('1', '5')