function arrayMap(arr, func) {
    return arr.reduce(function(acc, x) {
        acc.push(func(x));
        
        return acc;
    }, []);
}