function solve(arr) {
    let result = [];
    result.push(arr[0]);

    for (let i = 1; i < arr.length; i++) {
        if (arr[i] > result[result.length - 1] )
        {
            result.push(arr[i]);
        }
    }

    console.log(result.join('\n'));
}

solve([1, 
    3, 
    8, 
    4, 
    10, 
    12, 
    3, 
    2, 
    24]
    );