function subtract() {
    let firstNumber = document.getElementById('firstNumber').value;
    let secondNumber = document.getElementById('secondNumber').value;
    let result = firstNumber - secondNumber;

    let div = document.getElementById('result');
    div.innerText = result;
}