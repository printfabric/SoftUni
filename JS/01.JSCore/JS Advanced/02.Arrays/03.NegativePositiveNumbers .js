function solve(arr) {
    let result = [];
    for (let i = 0; i < arr.length; i++) {
        if (arr[i] < 0) {
            result.unshift(arr[i]);
        } else {
            result.push(arr[i]);
        }        
        
    }

    for (let i = 0; i < result.length; i++) {
        console.log(result[i]);
    }
}

solve([3, -2, 0, -1]);