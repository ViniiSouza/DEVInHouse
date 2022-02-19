var cep = document.getElementById('cep');
var botao = document.getElementById('button');

botao.addEventListener('click', async () => {

  try {
    var resultadoBusca = await fetch(`https://viacep.com.br/ws/${cep.value}/json`);
    resultadoBusca = await resultadoBusca.json();
    preencherDados(resultadoBusca)
  } catch (error) {
    console.log(error)
  }
  
})

function preencherDados (resultadoBusca) {
  console.log(resultadoBusca)
  document.getElementById('info-cep').style.display = 'block';
  document.getElementById('rua').textContent = resultadoBusca.logradouro;
  document.getElementById('bairro').textContent = resultadoBusca.bairro;
  document.getElementById('cidade-estado').textContent = resultadoBusca.localidade + ' - ' + resultadoBusca.uf;
}