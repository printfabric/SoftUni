function solve(n, m) {
    let sum = 0;
    n = Number(n);
    m = Number(m);
    
    for (let index = n; index < m + 1; index++) {
        sum += index;        
    }

    console.log(sum);
}

solve('1', '2');