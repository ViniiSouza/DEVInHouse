// var verificarImpares = (n) => {
//     if (n % 2 != 0) {
//         return true
//     } else {
//         return false
//     }
// }
// arrayImpares = arrayNumeros.filter(verificarImpares)

// console.log(arrayImpares)

var arrayNumeros = [1,2,3,4,5,6,7,8,9];
var arrayQuadrados;

arrayQuadrados = arrayNumeros.map(n => n*n)
console.log(arrayQuadrados)