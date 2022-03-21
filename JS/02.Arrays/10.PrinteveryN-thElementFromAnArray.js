function solve(arr) {
    let step = +arr[arr.length - 1];

    for (let i = 0; i < arr.length - 1; i+=step) {
        console.log(arr[i]);
    }
}

solve(['5', 
'20', 
'31', 
'4', 
'20', 
'2']
);