import { array } from 'prop-types';
import './App.css';
import { Repository } from './components/Repository/Repository';
import { Summary } from './components/Summary/Summary';

function App() {
  const lista_repositorios = [];
  lista_repositorios.push({ id: 1, titulo: 'Primeiro', descricao: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi nunc leo, placerat sed vulputate non, mollis dapibus enim. Phasellus in tincidunt mauris. Donec id ipsum blandit, lobortis est vitae, malesuada ex. Mauris sollicitudin mi felis, a elementum dui molestie sit amet. Curabitur vitae velit malesuada, rhoncus ipsum ac, blandit erat.' });
  lista_repositorios.push({ id: 2, titulo: 'Segundo', descricao: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi nunc leo, placerat sed vulputate non, mollis dapibus enim. Phasellus in tincidunt mauris. Donec id ipsum blandit, lobortis est vitae, malesuada ex. Mauris sollicitudin mi felis, a elementum dui molestie sit amet. Curabitur vitae velit malesuada, rhoncus ipsum ac, blandit erat.' });
  lista_repositorios.push({ id: 3, titulo: 'Terceiro', descricao: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi nunc leo, placerat sed vulputate non, mollis dapibus enim. Phasellus in tincidunt mauris. Donec id ipsum blandit, lobortis est vitae, malesuada ex. Mauris sollicitudin mi felis, a elementum dui molestie sit amet. Curabitur vitae velit malesuada, rhoncus ipsum ac, blandit erat.' });
  lista_repositorios.push({ id: 4, titulo: 'Quarto', descricao: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi nunc leo, placerat sed vulputate non, mollis dapibus enim. Phasellus in tincidunt mauris. Donec id ipsum blandit, lobortis est vitae, malesuada ex. Mauris sollicitudin mi felis, a elementum dui molestie sit amet. Curabitur vitae velit malesuada, rhoncus ipsum ac, blandit erat.' });
  lista_repositorios.push({ id: 5, titulo: 'Quinto', descricao: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi nunc leo, placerat sed vulputate non, mollis dapibus enim. Phasellus in tincidunt mauris. Donec id ipsum blandit, lobortis est vitae, malesuada ex. Mauris sollicitudin mi felis, a elementum dui molestie sit amet. Curabitur vitae velit malesuada, rhoncus ipsum ac, blandit erat.' });

  return (
    <div className="App">
      <h1 id="main-title">Meu portfólio Github</h1>
      <Summary imgSrc="https://github.com/ViniiSouza.png" altText="Imagem perfil Vinícius" />
      <section>
        <Repository titulo="Projeto destaque" descricao="Descrição do projeto destaque" destacar />
        {lista_repositorios.length === 0 ?
          (
            <p>Nenhum repositório disponível</p>
          ) :
          (
            <div id="repo-list">
              {lista_repositorios.map((repo) =>
                <Repository key={repo.id} titulo={repo.titulo} descricao={repo.descricao} />
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
