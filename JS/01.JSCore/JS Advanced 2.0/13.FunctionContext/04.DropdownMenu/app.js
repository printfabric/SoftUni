function solve() {
    let dropdownElement = document.getElementById('dropdown-ul');
    let dropdownButtonElement = document.getElementById('dropdown');

    dropdownButtonElement.addEventListener('click', e => {
        dropdownElement.style.display = 'block';
    });
}