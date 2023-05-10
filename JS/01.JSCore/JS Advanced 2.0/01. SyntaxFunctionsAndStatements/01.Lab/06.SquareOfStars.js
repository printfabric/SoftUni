function solve(n) {
    
    for (let row = 0; row < n; row++) {
        let rowSum = '';

        for (let col = 0; col < n; col++) {
            rowSum += '* ';
        }

        console.log(rowSum.trimEnd());
    }
}

solve(5);