import { array } from 'prop-types';
import './App.css';
import { Repository } from './components/Repository/Repository';
import { Summary } from './components/Summary/Summary';
import { useEffect, useState } from 'react';

function App() {
  const lista_repositorios = [];
  lista_repositorios.push({ id: 1, name: 'Primeiro', description: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi nunc leo, placerat sed vulputate non, mollis dapibus enim. Phasellus in tincidunt mauris. Donec id ipsum blandit, lobortis est vitae, malesuada ex. Mauris sollicitudin mi felis, a elementum dui molestie sit amet. Curabitur vitae velit malesuada, rhoncus ipsum ac, blandit erat.' });
  lista_repositorios.push({ id: 2, name: 'Segundo', description: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi nunc leo, placerat sed vulputate non, mollis dapibus enim. Phasellus in tincidunt mauris. Donec id ipsum blandit, lobortis est vitae, malesuada ex. Mauris sollicitudin mi felis, a elementum dui molestie sit amet. Curabitur vitae velit malesuada, rhoncus ipsum ac, blandit erat.' });
  lista_repositorios.push({ id: 3, name: 'Terceiro', description: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi nunc leo, placerat sed vulputate non, mollis dapibus enim. Phasellus in tincidunt mauris. Donec id ipsum blandit, lobortis est vitae, malesuada ex. Mauris sollicitudin mi felis, a elementum dui molestie sit amet. Curabitur vitae velit malesuada, rhoncus ipsum ac, blandit erat.' });
  lista_repositorios.push({ id: 4, name: 'Quarto', description: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi nunc leo, placerat sed vulputate non, mollis dapibus enim. Phasellus in tincidunt mauris. Donec id ipsum blandit, lobortis est vitae, malesuada ex. Mauris sollicitudin mi felis, a elementum dui molestie sit amet. Curabitur vitae velit malesuada, rhoncus ipsum ac, blandit erat.' });
  lista_repositorios.push({ id: 5, name: 'Quinto', description: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi nunc leo, placerat sed vulputate non, mollis dapibus enim. Phasellus in tincidunt mauris. Donec id ipsum blandit, lobortis est vitae, malesuada ex. Mauris sollicitudin mi felis, a elementum dui molestie sit amet. Curabitur vitae velit malesuada, rhoncus ipsum ac, blandit erat.' });
  
  const [repositorios, setRepositorios] = useState(lista_repositorios)
  const [idSelecionado, setIdSelecionado] = useState(412284459)
  
  useEffect(() => {
    fetch('https://api.github.com/users/viniisouza/repos').then(r => r.json()).then(result => setRepositorios(result))
  }, [])

  return (
    <div className="App">
      <h1 id="main-title">Meu portfólio Github</h1>
      <Summary imgSrc="https://github.com/ViniiSouza.png" altText="Imagem perfil Vinícius" />
      <section>
        {repositorios.length === 0 ?
          (
            <p>Nenhum repositório disponível</p>
          ) :
          (
            <div id="repo-list">
              {repositorios.map((repo) =>
                <Repository key={repo.id} titulo={repo.name} descricao={repo.description} destacar={ repo.id === idSelecionado}/>
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
