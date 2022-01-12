async function getImages () {
    var teste = await fetch('https://api.thecatapi.com/v1/images/search').then(r => r.json()).catch();
    teste.forEach(element => {
        var img = document.createElement('img');
        img.style.maxWidth = '300px'
        img.src = element.url
        document.getElementById('container').appendChild(img)
    });
}

document.getElementById('addImage').addEventListener('click', getImages)

getImages();