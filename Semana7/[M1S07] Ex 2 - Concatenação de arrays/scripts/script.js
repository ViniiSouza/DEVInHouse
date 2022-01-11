function logArrays (array1, array2) {
    var novoArray = [...array1, ...array2]
    console.log(novoArray)
}

logArrays(['a', 'b', 'c'], ['d', 'e', 'f'])