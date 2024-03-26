function solve() {
	let input = document.getElementById('input');
	let text = input.innerText;
	let outputElement = document.getElementById('output');

	let sentences = text.split('.');

	while(sentences.length > 0) {
		let currentParagraph = sentences.splice(0, 3).join('.');

		let paragraphElement = document.createElement('p');
		paragraphElement.innerText = currentParagraph;

		outputElement.appendChild(paragraphElement);
	}
	
}


	// let input = document.getElementById('input');
	// let text = input.innerText;
	// let outputElement = document.getElementById('output');

	// let sentences = text.split('.');

	// while(sentences.length > 0) {
	// 	let currentParagraph = sentences.splice(0, 3).join('.');

	// 	let paragraphElement = document.createElement('p');
	// 	paragraphElement.innerText = currentParagraph;

	// 	outputElement.appendChild(paragraphElement);
	// }