function solve(n, k) {
    let arr = [];
    arr.push(1);

    for (let i = 0; i < n - 1; i++) {
        let currentNum = 0;

        for (let j = 0; j < k; j++) {
            if (i - j >= 0) {
                currentNum += arr[i - j];
            }
        }

        arr.push(currentNum);
    }

    console.log(arr);
}

solve(8, 2);
