//
function verificarNumero(){
    var numeroUsuario = parseInt(document.querySelector("#inputUsuario").value);

    var total=numeroUsuario/2;
    if(numeroUsuario % 2 == 0){
        document.getElementById("resultado").textContent = "Par";
    }
    if(numeroUsuario % 2 == 1){
        document.getElementById("resultado").textContent = "Ímpar";
    }
    
}