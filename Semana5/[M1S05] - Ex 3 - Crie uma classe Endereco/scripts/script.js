//
import Endereco from "./Endereco";


function validarEndereco(){

    document.getElementById('save-button').addEventListener('click', function(){
        alert('teste')
        var logradouro = pegarElemento('logradouro').value;
        var numero = pegarElemento('numero').value;
        var cidade = pegarElemento('cidade').value;
        var estado = pegarElemento('estado').value;
        var pais = pegarElemento('pais').value;
        var cep = pegarElemento('cep').value;
        var endereco = new Endereco(logradouro, numero, cidade, estado, pais, cep);
        console.log(endereco)
    })
    

}

function pegarElemento(id){
    return document.getElementById(id);
}