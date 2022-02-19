//
import Endereco from "./Endereco.js";

document.getElementById('save-button').addEventListener('click', function(){
    var logradouro = pegarElemento('logradouro').value != '' ? pegarElemento('logradouro').value : null;
    var numero = pegarElemento('numero').value != '' ? pegarElemento('numero').value : null;
    var cidade = pegarElemento('cidade').value != '' ? pegarElemento('cidade').value : null;
    var estado = pegarElemento('estado').value != '' ? pegarElemento('estado').value : null;
    var pais = pegarElemento('pais').value != '' ? pegarElemento('pais').value : null;
    var cep = pegarElemento('cep').value != '' ? pegarElemento('cep').value : null;
    var endereco = new Endereco(logradouro, numero, cidade, estado, pais, cep);
    console.log(endereco)
})

function pegarElemento(id){
    return document.getElementById(id);
}