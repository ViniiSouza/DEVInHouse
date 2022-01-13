function getImages () {
    var teste = fetch('https://api.thecatapi.com/v1/images/search')
    .then(function(resolve) {
        return resolve.json();
    })
    .then(function(result) {
        result.forEach(element => {
            var img = document.createElement('img');
            img.style.maxWidth = '300px'
            img.src = element.url
            document.getElementById('container').appendChild(img)
        });
    })
    .catch();
}

document.getElementById('addImage').addEventListener('click', getImages)

getImages();