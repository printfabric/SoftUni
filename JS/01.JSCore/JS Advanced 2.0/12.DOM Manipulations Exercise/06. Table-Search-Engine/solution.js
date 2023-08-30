function solve() {
   let word = document.getElementById('searchField');

   document.getElementById('searchBtn').addEventListener('click', function () {
      [...document.querySelectorAll('tbody > tr')].forEach(row => {
         if (row.textContent.includes(word.value)) {
            row.className = 'select';
         } else {
            row.className = '';
         }
      })

      word.value = '';
   });
}