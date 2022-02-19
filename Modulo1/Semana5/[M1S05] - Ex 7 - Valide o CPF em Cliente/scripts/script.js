//
import Endereco from './Endereco.js';
import { Cliente } from './Cliente.js';
import Conta from './Conta.js';

document.getElementById('save-button').addEventListener('click', function(){
    var logradouro = pegarElemento('logradouro').value != '' ? pegarElemento('logradouro').value : null;
    var numero = pegarElemento('numero').value != '' ? pegarElemento('numero').value : null;
    var cidade = pegarElemento('cidade').value != '' ? pegarElemento('cidade').value : null;
    var estado = pegarElemento('estado').value != '' ? pegarElemento('estado').value : null;
    var pais = pegarElemento('pais').value != '' ? pegarElemento('pais').value : null;
    var cep = pegarElemento('cep').value != '' ? pegarElemento('cep').value : null;
    var endereco = new Endereco(logradouro, numero, cidade, estado, pais, cep);
    console.log(endereco);
    var nomeCliente = pegarElemento('nome-cliente').value != '' ? pegarElemento('nome-cliente').value : null;
    var cpfCliente = pegarElemento('cpf-cliente').value != '' ? pegarElemento('cpf-cliente').value : null;
    if (!Cliente.validaCPF(cpfCliente)) {
        pegarElemento('cpf-cliente').value = '';
        throw new Error('CPF inválido!')
    }
    var numeroCliente = pegarElemento('numero-cliente').value != '' ? pegarElemento('numero-cliente').value : null;
    var cliente = new Cliente(nomeCliente, cpfCliente, endereco, numeroCliente);
    console.log(cliente);
    var numeroDaConta = pegarElemento('numero-conta').value != '' ? pegarElemento('numero-conta').value : null;
    var saldo = pegarElemento('saldo-conta').value != '' ? parseInt(pegarElemento('saldo-conta').value) : null;
    var conta = new Conta(numeroDaConta, saldo, cliente);
    console.log(conta);
})

function pegarElemento(id){
    return document.getElementById(id);
}