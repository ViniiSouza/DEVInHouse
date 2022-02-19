const mensagemOla = (nome) => { return `Olá, ${nome}!` }

alert(mensagemOla('Vinícius'))

var arrayNumeros = [1,2,3,4,5,6,7,8,9]
var arrayInvertido = []

const inverterArray = () => {
    for(let i = arrayNumeros.length; i >= 0; i--) {
        arrayInvertido.push(arrayNumeros[i]);
    }
    console.log(arrayInvertido)
}
inverterArray()