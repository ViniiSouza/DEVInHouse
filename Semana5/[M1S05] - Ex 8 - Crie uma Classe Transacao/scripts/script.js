//
import Endereco from './Endereco.js';
import { Cliente } from './Cliente.js';
import Conta from './Conta.js';
import Transacao from './Transacao.js';

var endereco;
var cliente;
var conta;

pegarElemento('save-button').addEventListener('click', function(){
    endereco = criarEndereco();
    console.log(endereco);
    cliente = criarCliente();
    console.log(cliente);
    conta = criarConta();
    console.log(conta);
    liberarDados();
})

function pegarElemento(id){
    return document.getElementById(id);
}

function criarEndereco () {
    var logradouro = pegarElemento('logradouro').value != '' ? pegarElemento('logradouro').value : null;
    var numero = pegarElemento('numero').value != '' ? pegarElemento('numero').value : null;
    var cidade = pegarElemento('cidade').value != '' ? pegarElemento('cidade').value : null;
    var estado = pegarElemento('estado').value != '' ? pegarElemento('estado').value : null;
    var pais = pegarElemento('pais').value != '' ? pegarElemento('pais').value : null;
    var cep = pegarElemento('cep').value != '' ? pegarElemento('cep').value : null;
    return new Endereco(logradouro, numero, cidade, estado, pais, cep);
}

function criarCliente () {
    var nomeCliente = pegarElemento('nome-cliente').value != '' ? pegarElemento('nome-cliente').value : null;
    var cpfCliente = pegarElemento('cpf-cliente').value != '' ? pegarElemento('cpf-cliente').value : null;
    if (!Cliente.validaCPF(cpfCliente)) {
        pegarElemento('cpf-cliente').value = '';
        throw new Error('CPF inválido!')
    }
    var numeroCliente = pegarElemento('numero-cliente').value != '' ? pegarElemento('numero-cliente').value : null;
    return new Cliente(nomeCliente, cpfCliente, endereco, numeroCliente);
}

function criarConta () {
    var numeroDaConta = pegarElemento('numero-conta').value != '' ? pegarElemento('numero-conta').value : null;
    var saldo = pegarElemento('saldo-conta').value != '' ? parseInt(pegarElemento('saldo-conta').value) : null;
    return new Conta(numeroDaConta, saldo, cliente);
}

function liberarDados () {
    pegarElemento('mostrar-saldo-conta').style.display = 'block';
    pegarElemento('valor-deposito').disabled = false;
    pegarElemento('botao-depositar').disabled = false;
    pegarElemento('valor-transferencia').disabled = false;
    pegarElemento('botao-transferir').disabled = false;
    alterarSaldo(conta.saldo);
}

function executarDeposito () {
    var transacao = new Transacao(conta, pegarElemento('valor-deposito').value)
    pegarElemento('valor-deposito').value = null;
    alterarSaldo(transacao.deposito());
}

pegarElemento('botao-depositar').addEventListener('click', executarDeposito)

function executarTransferencia () {
    var transacao = new Transacao(conta, pegarElemento('valor-transferencia').value)
    pegarElemento('valor-transferencia').value = null;
    alterarSaldo(transacao.transferencia());
}

pegarElemento('botao-transferir').addEventListener('click', executarTransferencia)

function alterarSaldo (novoSaldo) {
    pegarElemento('balance-place').textContent = novoSaldo;
}