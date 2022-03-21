function solve(firstNum, secondNum) {
    let gcd = 0;
    for (let i = 0; i < firstNum; i++) {
        if (Number.isInteger(firstNum / i)) {
            if (Number.isInteger(secondNum / i)) {
                if (i > gcd) {
                    gcd = i;
                }
            }
        }
    }

    console.log(gcd);
}

solve(15, 5);