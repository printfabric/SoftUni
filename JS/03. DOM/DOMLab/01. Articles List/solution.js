function createArticle() {
    let getTitleElement = document.getElementById('createTitle');
    let getContentElement = document.getElementById('createContent')

    let headingElement = document.createElement('h3');
    headingElement.innerHTML = getTitleElement.value;
    
    let contentElement = document.createElement('p');
    contentElement.innerHTML = getContentElement.value;
    
    let articleElement = document.createElement('article');
    articleElement.appendChild(headingElement);
    articleElement.appendChild(contentElement)
    
    if (getTitleElement.value.length > 0 && getContentElement.value.length > 0)
    { 
        let articleSectionElement = document.getElementById('articles')
        articleSectionElement.appendChild(articleElement);    
    }  
    
    getTitleElement.value = '';
    getContentElement.value = '';
}