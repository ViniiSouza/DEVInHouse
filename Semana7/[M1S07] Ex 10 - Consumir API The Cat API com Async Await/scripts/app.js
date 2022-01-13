async function getImages () {
    try {
        var teste = await fetch('https://api.thecatapi.com/v1/images/search');
        teste = await teste.json();
        await teste.forEach(element => {
            var img = document.createElement('img');
            img.style.maxWidth = '300px'
            img.src = element.url
            document.getElementById('container').appendChild(img)
        });
    } catch (error) {
        console.log(error)
    }
}

document.getElementById('addImage').addEventListener('click', getImages)

getImages();