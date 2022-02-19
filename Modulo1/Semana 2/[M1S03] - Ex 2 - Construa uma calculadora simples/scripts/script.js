//
function somarValores(){
    var valor1 = parseInt(document.querySelector("#valor1").value) 
    var valor2 = parseInt(document.querySelector("#valor2").value)

    resultado = valor1 + valor2;
    document.querySelector("#resultado").textContent = resultado;
}

function subtrairValores(){
    var valor1 = parseInt(document.querySelector("#valor1").value) 
    var valor2 = parseInt(document.querySelector("#valor2").value)

    resultado = valor1 - valor2;
    document.querySelector("#resultado").textContent = resultado;
}

function multiplicarValores(){
    var valor1 = parseInt(document.querySelector("#valor1").value) 
    var valor2 = parseInt(document.querySelector("#valor2").value)

    resultado = valor1 * valor2;
    document.querySelector("#resultado").textContent = resultado;
}

function dividirValores(){
    var valor1 = parseInt(document.querySelector("#valor1").value) 
    var valor2 = parseInt(document.querySelector("#valor2").value)

    resultado = valor1 / valor2;
    document.querySelector("#resultado").textContent = resultado;
}