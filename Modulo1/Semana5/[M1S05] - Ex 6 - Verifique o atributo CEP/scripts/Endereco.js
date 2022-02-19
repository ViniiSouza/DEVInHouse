export default class Endereco {
    constructor(logradouro, numero, cidade, estado, pais, cep) {
        const params = [logradouro, numero, cidade, estado, pais, cep]
        if (params.some(p => typeof p !== 'string'))
            throw new Error('Endereço inválido! Revise os dados!')
        else {
            console.log(cep)
            let myRegex = /^\d{5}[-]\d{3}/
            if (!myRegex.test(cep)) {
                throw new Error('Formato de CEP inválido')
            }
            this.logradouro = logradouro;
            this.numero = numero;
            this.cidade = cidade;
            this.estado = estado;
            this.pais = pais;
            this.cep = cep;
        }
    }
}