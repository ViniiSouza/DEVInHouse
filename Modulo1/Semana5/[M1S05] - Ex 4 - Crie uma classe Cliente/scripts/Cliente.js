import Endereco from "./Endereco.js"

export class Cliente {
    constructor(nome, cpf, endereco, numeroDoCelular) {
        let params = [nome, cpf, numeroDoCelular]
        if(params.some(p => typeof p !== 'string')) {
            throw new Error('Verifique os dados do cliente e tente novamente!')
        }
        else if(!endereco instanceof Endereco) {
            throw new Error('Endereço inválido!')
        }
        else {
            this.nome = nome;
            this.cpf = cpf;
            this.endereco = endereco;
            this.numeroDoCelular = numeroDoCelular;
        }
    }
}