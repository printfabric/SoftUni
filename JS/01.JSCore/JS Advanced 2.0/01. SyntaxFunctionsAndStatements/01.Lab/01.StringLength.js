function solve(str1, str2, str3) {
    str1 = str1.split(" ").join("").length;
    str2 = str2.split(" ").join("").length;
    str3 = str3.split(" ").join("").length;

    let letterCount = str1 + str2 + str3;
    let average = (str1 + str2 + str3) / 3;
    console.log(letterCount);
    console.log(Math.floor(average));
}

solve('chocolateda', 'asice cream', 'cake');