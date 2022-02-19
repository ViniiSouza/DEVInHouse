import { array } from 'prop-types';
import './App.css';
import { Repository } from './components/Repository/Repository';
import { Summary } from './components/Summary/Summary';
import { useEffect, useState } from 'react';
import { mapToRepoObject } from './data/data-utils';

function App() {
  const lista_repositorios = [];
  lista_repositorios.push({ id: 1, titulo: 'Primeiro', descricao: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi nunc leo, placerat sed vulputate non, mollis dapibus enim. Phasellus in tincidunt mauris. Donec id ipsum blandit, lobortis est vitae, malesuada ex. Mauris sollicitudin mi felis, a elementum dui molestie sit amet. Curabitur vitae velit malesuada, rhoncus ipsum ac, blandit erat.' });
  lista_repositorios.push({ id: 2, titulo: 'Segundo', descricao: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi nunc leo, placerat sed vulputate non, mollis dapibus enim. Phasellus in tincidunt mauris. Donec id ipsum blandit, lobortis est vitae, malesuada ex. Mauris sollicitudin mi felis, a elementum dui molestie sit amet. Curabitur vitae velit malesuada, rhoncus ipsum ac, blandit erat.' });
  lista_repositorios.push({ id: 3, titulo: 'Terceiro', descricao: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi nunc leo, placerat sed vulputate non, mollis dapibus enim. Phasellus in tincidunt mauris. Donec id ipsum blandit, lobortis est vitae, malesuada ex. Mauris sollicitudin mi felis, a elementum dui molestie sit amet. Curabitur vitae velit malesuada, rhoncus ipsum ac, blandit erat.' });
  lista_repositorios.push({ id: 4, titulo: 'Quarto', descricao: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi nunc leo, placerat sed vulputate non, mollis dapibus enim. Phasellus in tincidunt mauris. Donec id ipsum blandit, lobortis est vitae, malesuada ex. Mauris sollicitudin mi felis, a elementum dui molestie sit amet. Curabitur vitae velit malesuada, rhoncus ipsum ac, blandit erat.' });
  lista_repositorios.push({ id: 5, titulo: 'Quinto', descricao: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi nunc leo, placerat sed vulputate non, mollis dapibus enim. Phasellus in tincidunt mauris. Donec id ipsum blandit, lobortis est vitae, malesuada ex. Mauris sollicitudin mi felis, a elementum dui molestie sit amet. Curabitur vitae velit malesuada, rhoncus ipsum ac, blandit erat.' });
  
  const [repositorios, setRepositorios] = useState(lista_repositorios);
  const [idSelecionado, setIdSelecionado] = useState(412284459);
  const [nomeUsuario, setNomeUsuario] = useState('');

  function handleNomeUsuario (user) {
    setNomeUsuario(user)
  }

  function handleBuscar () {
    console.log('Clicado')
  }
  
  useEffect(() => {
    fetch('https://api.github.com/users/viniisouza/repos')
    .then(r => r.json())
    .then((result) => {const resultadoMapeado = mapToRepoObject(result); setRepositorios(resultadoMapeado)});
  }, [])

  return (
    <div className="App">
      <h1 id="main-title">Meu portfólio Github</h1>
      <Summary imgSrc="https://github.com/ViniiSouza.png" altText="Imagem perfil Vinícius" />
      <input type="text" onChange={(event) => handleNomeUsuario(event.target.value)} value={nomeUsuario}></input>
      <button type="button" onClick={handleBuscar}>Buscar</button>
      <section>
        {repositorios.length === 0 ?
          (
            <p>Nenhum repositório disponível</p>
          ) :
          (
            <div id="repo-list">
              {repositorios.map((repo) =>
                <Repository key={repo.id} titulo={repo.titulo} descricao={repo.descricao} destacar={ repo.id === idSelecionado}/>
              )}
            </div>
          )
        }
      </section>
      <h1 id="subtitle">Olá, portfólio!</h1>

    </div>
  );
}

export default App;
