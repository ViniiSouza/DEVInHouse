function calcularIdade(){
    var dataUsuario = document.getElementById("nascimentoUsuario");
    var dataAtual = new Date();
    var diaAtual = dataAtual.getDay();
    var mesAtual = dataAtual.getMonth();
    var anoAtual = dataAtual.getFullYear();
    var nascimento = new Date(dataUsuario.value);
    var diaNasc = nascimento.getDate() + 1;
    var mesNasc = nascimento.getMonth();
    var anoNasc = nascimento.getFullYear();
    var idade = anoAtual - anoNasc;
    if(mesAtual < mesNasc){
        idade--;
    }
    else {
        if(mesAtual == mesNasc){
            if(diaAtual < diaNasc){
                idade--;
            }   
        }
    }
    document.getElementById("inserirIdade").textContent = idade + " anos";
}