function growingWord() {
	let parentElement = document.getElementById('exercise');
	let growingWordElement = parentElement.lastElementChild;
	let colorsElement = document.getElementById('colors');
	let color = colorsElement.firstElementChild.innerHTML.toLowerCase();


	if (!growingWordElement.style.fontSize) {
		growingWordElement.style.fontSize = '2px';
	} else {
		growingWordElement.style.fontSize = 
		parseInt(growingWordElement.style.fontSize) * 2 + 'px';
	}

	growingWordElement.style.color = color;
	let firstColor = colorsElement.firstElementChild;

	colorsElement.appendChild(firstColor);
	console.log(firstColor);
}