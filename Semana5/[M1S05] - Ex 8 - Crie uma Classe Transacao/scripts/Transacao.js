import Conta from './Conta.js'

export default class Transacao {
    constructor(conta, valorDaTransacao) {
        if (!conta instanceof Conta) {
            throw new Error('Conta inválida')
        }
        this.conta = conta;
        this.valorDaTransacao = valorDaTransacao;
    }
    transferencia () {
        this.conta.diminuirSaldo = this.valorDaTransacao;
        return this.conta.saldoAtual;
    }

    deposito () {
        this.conta.aumentarSaldo = this.valorDaTransacao;
        return this.conta.saldoAtual;
    }
}