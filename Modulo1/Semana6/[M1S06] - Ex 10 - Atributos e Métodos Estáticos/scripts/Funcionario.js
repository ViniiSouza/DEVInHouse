import Pessoa from './Pessoa.js'

export default class Funcionario extends Pessoa {
    cargo;
    salario;

    constructor (nome, cpf, cargo, salario) {
        super(nome, cpf);
        this.cargo = cargo;
        this.salario = salario;
    }

    imprime() {
        console.log(this.nome + ' - ' + this.cargo)
    }

    static calcularSalarios(array) {
        let reducer = (a,b) => a+b.salario;
        
        return array.reduce(reducer,0)
    }
}