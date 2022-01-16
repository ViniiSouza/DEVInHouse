import Conta from './Conta.js'

export default class Transacao {
    constructor(conta, valorDaTransacao, idTransacao, contaRecebedora) {
        if (!conta instanceof Conta) {
            throw new Error('Conta inválida')
        }
        this.conta = conta;
        this.valorDaTransacao = valorDaTransacao;
        this.idTransacao = idTransacao;
        this.contaRecebedora = contaRecebedora || -1;
        this.dataTransacao = new Date();
    }
    transferencia () {
        this.conta.diminuirSaldo = this.valorDaTransacao;
        if (this.contaRecebedora instanceof Conta) this.contaRecebedora.aumentarSaldo = this.valorDaTransacao;
        console.log(this.contaRecebedora);
        return this.conta.saldoAtual;
    }

    deposito () {
        this.conta.aumentarSaldo = this.valorDaTransacao;
        return this.conta.saldoAtual;
    }
}