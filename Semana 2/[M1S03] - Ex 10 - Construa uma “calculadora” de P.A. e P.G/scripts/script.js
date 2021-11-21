//

function verificarCampos(){
    var campo1 = document.getElementById('valor-inicial').value.trim();
    var campo2 = document.getElementById('valor-raiz').value.trim();
    console.log(campo1)
    if(campo1 == '' || campo2 == ''){
        alert('Insira os valores corretamente!');
        return true;
    }
    else{
        return false;
    }
}

function calcularPA(){
    if(verificarCampos()){}
    else{
        var listaPA = [];
        var valorInicial = parseInt(document.getElementById('valor-inicial').value);
        var raiz = parseInt(document.getElementById('valor-raiz').value);
        for(var a=0;a<10;a++){
            listaPA.push(valorInicial);
            valorInicial = valorInicial + raiz;
    }
    document.getElementById('resultado').textContent = listaPA;
    }
    
}

function calcularPG(){
    if(verificarCampos()){}
    else{
        var listaPG = [];
        var valorInicial = parseInt(document.getElementById('valor-inicial').value);
        var raiz = parseInt(document.getElementById('valor-raiz').value);
        for(var a=0;a<10;a++){
            listaPG.push(valorInicial);
            valorInicial = valorInicial * raiz;
        }
        document.getElementById('resultado').textContent = listaPG;
    }
}