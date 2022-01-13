export default class Endereco {
    constructor(logradouro, numero, cidade, estado, pais, cep) {
        const params = [logradouro, numero, cidade, estado, pais, cep]
        if (params.some(p => typeof p !== 'string'))
            throw new Error('Endereço inválido! Revise os dados!')
        else {
            this.logradouro = logradouro;
            this.numero = numero;
            this.cidade = cidade;
            this.estado = estado;
            this.pais = pais;
            this.cep = cep;
        }
    }
}