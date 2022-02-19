//

function adicionarItem(){
    var textoAdicionar = document.getElementById('textoAdicionar').value;
    if(textoAdicionar.length < 1){
        alert('O texto está vazio');
    }
    else{
        criarItemLista(textoAdicionar);
    }
}

function criarItemLista(texto){
    var itemLista = document.createElement('li');
    itemLista.textContent= texto;
    var itemSelect = document.createElement('option');
    itemSelect.textContent = texto;
    
    itemLista.classList.add('item-lista');
    document.getElementById('lista-itens').appendChild(itemLista);
    document.getElementById('lista-select').appendChild(itemSelect);

}