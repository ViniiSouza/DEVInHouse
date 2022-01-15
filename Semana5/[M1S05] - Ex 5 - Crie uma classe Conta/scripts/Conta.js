import { Cliente } from './Cliente.js'

export default class Conta {
    constructor(numeroDaConta, saldo, cliente) {
        if (typeof numeroDaConta !== 'string') {
            throw new Error('Verifique o número da conta!')
        } else if (typeof saldo !== 'number') {
            throw new Error('Verifique o saldo!')
        } else if (!cliente instanceof Cliente) {
            throw new Error('Cliente inválido!')
        } else {
            this.numeroDaConta = numeroDaConta;
            this.saldo = saldo;
            this.cliente = cliente;
        }
    }
}