import Endereco from "./Endereco.js"

export class Cliente {
    constructor(nome, cpf, endereco, numeroDoCelular) {
        let params = [nome, cpf, numeroDoCelular]
        if (params.some(p => typeof p !== 'string')) {
            throw new Error('Verifique os dados do cliente e tente novamente!')
        }
        else if (!endereco instanceof Endereco) {
            throw new Error('Endereço inválido!')
        }
        else {
            this.nome = nome;
            this.cpf = cpf;
            this.endereco = endereco;
            this.numeroDoCelular = numeroDoCelular;
        }
    }

    static validaCPF(cpf) {
        var Soma;
        var Resto;
        Soma = 0;
        if (cpf == "00000000000") return false;

        for (let i = 1; i <= 9; i++) Soma = Soma + parseInt(cpf.substring(i - 1, i)) * (11 - i);
        Resto = (Soma * 10) % 11;

        if ((Resto == 10) || (Resto == 11)) Resto = 0;
        if (Resto != parseInt(cpf.substring(9, 10))) return false;

        Soma = 0;
        for (let i = 1; i <= 10; i++) Soma = Soma + parseInt(cpf.substring(i - 1, i)) * (12 - i);
        Resto = (Soma * 10) % 11;

        if ((Resto == 10) || (Resto == 11)) Resto = 0;
        if (Resto != parseInt(cpf.substring(10, 11))) return false;
        return true;
    }
}