function solve(arr) {
    var result = [];

    for (let i = 0; i < arr.length; i++) {
        if (arr[i] === 'add') {
            result.push(i + 1);
        } else {
            if (result.length > 0) {
                result.pop();
            }
        }

    }

    if (result.length > 0) {
        console.log(result.join('\n'));
    } else {
        console.log('Empty')
    }
}

solve(['add', 
'add', 
'remove', 
'add', 
'add']
);