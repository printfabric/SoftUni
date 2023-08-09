function focus() {
    let input = document.querySelectorAll('input[type="text"]');

    Array.from(input).forEach(x => {
        x.addEventListener('focus', function(e) {
            let parentDivElement = e.currentTarget.parentElement;
            parentDivElement.classList.add('focused');
        })

        x.addEventListener('blur', function(e) {
            let parentDivElement = e.currentTarget.parentElement;
            parentDivElement.classList.remove('focused');
        })
    })
}