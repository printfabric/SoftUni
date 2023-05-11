function solve(arr) {
    let sum = 0;
    let sumOfInverseValues = 0;
    let concat = '';

    for (let i = 0; i < arr.length; i++) {
        sum += arr[i];
        sumOfInverseValues += 1/arr[i];
        concat += arr[i];
    }
    
    console.log(sum);
    console.log(sumOfInverseValues);
    console.log(concat);
}

solve([1, 2, 3]);