var cep = document.getElementById('cep');
var botao = document.getElementById('button');

botao.addEventListener('click', () => {

  fetch(`https://viacep.com.br/ws/${cep.value}/json`)
    .then(function (response) {
      response.json()

        .then(function (result) {
          console.log(result)
          document.getElementById('info-cep').style.display = 'block';
          document.getElementById('rua').textContent = result.logradouro;
          document.getElementById('bairro').textContent = result.bairro;
          document.getElementById('cidade-estado').textContent = result.localidade + ' - ' + result.uf;
        })
    })
})
