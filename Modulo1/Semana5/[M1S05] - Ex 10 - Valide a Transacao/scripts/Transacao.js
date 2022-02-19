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
    transferencia() {
        if (this.conta.saldoAtual < this.valorDaTransacao) {
            return -1;
        }
        this.conta.diminuirSaldo = this.valorDaTransacao;
        if (this.contaRecebedora instanceof Conta) this.contaRecebedora.aumentarSaldo = this.valorDaTransacao;
        console.log(this.contaRecebedora);
        return this.conta.saldoAtual;
    }

    deposito() {
        this.conta.aumentarSaldo = this.valorDaTransacao;
        return this.conta.saldoAtual;
    }

    executarTransacao(tipoTransacao) {
        if (tipoTransacao == 1) {
            return this.deposito();
        } else if (tipoTransacao == 2 && this.conta instanceof Conta && this.contaRecebedora instanceof Conta) {
            return transferencia();
        } else {
            return -2;
        }
    }
}