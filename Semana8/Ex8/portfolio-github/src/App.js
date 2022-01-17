import { array } from 'prop-types';
import './App.css';
import { Repository } from './components/Repository/Repository';
import { Summary } from './components/Summary/Summary';

function App() {
  const lista_repositorios = [];
  lista_repositorios.push({id: 1, titulo: 'Primeiro', descricao: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi nunc leo, placerat sed vulputate non, mollis dapibus enim. Phasellus in tincidunt mauris. Donec id ipsum blandit, lobortis est vitae, malesuada ex. Mauris sollicitudin mi felis, a elementum dui molestie sit amet. Curabitur vitae velit malesuada, rhoncus ipsum ac, blandit erat.'}); 
  lista_repositorios.push({id: 2, titulo: 'Segundo', descricao: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi nunc leo, placerat sed vulputate non, mollis dapibus enim. Phasellus in tincidunt mauris. Donec id ipsum blandit, lobortis est vitae, malesuada ex. Mauris sollicitudin mi felis, a elementum dui molestie sit amet. Curabitur vitae velit malesuada, rhoncus ipsum ac, blandit erat.'});
  lista_repositorios.push({id: 3, titulo: 'Terceiro', descricao: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi nunc leo, placerat sed vulputate non, mollis dapibus enim. Phasellus in tincidunt mauris. Donec id ipsum blandit, lobortis est vitae, malesuada ex. Mauris sollicitudin mi felis, a elementum dui molestie sit amet. Curabitur vitae velit malesuada, rhoncus ipsum ac, blandit erat.'});
  lista_repositorios.push({id: 4, titulo: 'Quarto', descricao: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi nunc leo, placerat sed vulputate non, mollis dapibus enim. Phasellus in tincidunt mauris. Donec id ipsum blandit, lobortis est vitae, malesuada ex. Mauris sollicitudin mi felis, a elementum dui molestie sit amet. Curabitur vitae velit malesuada, rhoncus ipsum ac, blandit erat.'});
  lista_repositorios.push({id: 5, titulo: 'Quinto', descricao: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi nunc leo, placerat sed vulputate non, mollis dapibus enim. Phasellus in tincidunt mauris. Donec id ipsum blandit, lobortis est vitae, malesuada ex. Mauris sollicitudin mi felis, a elementum dui molestie sit amet. Curabitur vitae velit malesuada, rhoncus ipsum ac, blandit erat.'});

  return (
    <div className="App">
      <h1 id="main-title">Meu portfólio Github</h1>
      {lista_repositorios.length === 0 ?
      (
        <p>Nenhum repositório disponível</p>
      ) :
      (
        <div id="repo-list">
        {lista_repositorios.map((repo) =>
          <div className="repo-item" key={repo.id}>
            <h5 className="repo-item-title">{`${repo.id} - ${repo.titulo}`}</h5>
            <p className="repo-item-description">{repo.descricao}</p>
          </div>
          )}
        </div>
      )
      }
      <h1 id="subtitle">Olá, portfólio!</h1>
      <Summary imgSrc="https://github.com/ViniiSouza.png" altText="Imagem perfil Vinícius"/>
      <Repository titulo="Título" descricao="descrição aqui" destacar/>
    </div>
  );
}

export default App;
