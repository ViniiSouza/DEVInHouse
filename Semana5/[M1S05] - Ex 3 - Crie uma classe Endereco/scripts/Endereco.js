// ver sobre gets and sets - o que é
export default class Endereco {
    constructor(logradouro, numero, cidade, estado, pais, cep) {
        const params = [logradouro, numero, cidade, estado, pais, cep]
        if (params.some(p => typeof p !== 'string'))
            throw 'Endereço inválido'
    }
}