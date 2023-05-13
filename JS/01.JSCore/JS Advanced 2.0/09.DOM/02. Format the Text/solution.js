function solve() {
	let input = document.getElementById('input');
	let text = input.innerText;
	let sentences = text.split('.');
	let outputElement = document.getElementById('output');

	while (sentences.length > 0) {
		let currentSentences = sentences.splice(0, 3).join('.');
		let currentParagraph = document.createElement('p');
		currentParagraph.innerText = currentSentences;
		outputElement.appendChild(currentParagraph);

	}

	console.log(text);
}