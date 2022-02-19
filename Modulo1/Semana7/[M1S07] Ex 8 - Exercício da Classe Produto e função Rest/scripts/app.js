import { Produto } from "./Produto.js";

function calcularPrecoTotal ([...Produto]) {
    var totalProdutos = 0;
    [...Produto].forEach(element => {
        totalProdutos += (element.quantidade * element.valor);
    });
    document.getElementById('totalProdutos').textContent = `O total dos produtos é de R$ ${totalProdutos}`
}

var listaProdutos = [new Produto('Sabão', 5, 1.99), new Produto('Alcatra', 1, 37.55)]

calcularPrecoTotal(listaProdutos)