// const mensagemOla = (nome) => { return `Olá, ${nome}!` }

// alert(mensagemOla('Vinícius'))

// var arrayInvertido = []

// const inverterArray = () => {
//     for(let i = arrayNumeros.length; i >= 0; i--) {
//         arrayInvertido.push(arrayNumeros[i]);
//     }
//     console.log(arrayInvertido)
// }
// inverterArray()

var arrayNumeros = [1,2,3,4,5,6,7,8,9];
var encontrado;

const encontrarNumero = () => {
    return arrayNumeros.find(i => i>5) ? arrayNumeros.find(i => i>5) : "não encontrado"
}
encontrado = encontrarNumero();
console.log(encontrado)