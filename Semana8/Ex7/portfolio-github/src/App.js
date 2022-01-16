import { array } from 'prop-types';
import './App.css';
import { Repository } from './components/Repository/Repository';
import { Summary } from './components/Summary/Summary';

function App() {
  const lista_repositorios = [];
  lista_repositorios.push({id: 1, titulo: 'Primeiro', descricao: 'descrição primeiro'});
  lista_repositorios.push({id: 2, titulo: 'Segundo', descricao: 'descrição segundo'});
  lista_repositorios.push({id: 3, titulo: 'Terceiro', descricao: 'descrição terceiro'});
  lista_repositorios.push({id: 4, titulo: 'Quarto', descricao: 'descrição quarto'});
  lista_repositorios.push({id: 5, titulo: 'Quinto', descricao: 'descrição quinto'});

  return (
    <div className="App">
      <h1>Meu portfólio Github</h1>
      {lista_repositorios.length === 0 ?
      (
        <p>Nenhum repositório disponível</p>
      ) :
      (
        <>
        {lista_repositorios.map((repo) =>
          <p key={repo.id}>{`> ${repo.id} - ${repo.titulo} - ${repo.descricao}`}</p>
          )}
        </>
      )
      }
      <h1>Olá, portfólio!</h1>
      <Summary imgSrc="https://github.com/ViniiSouza.png" altText="Imagem perfil Vinícius"/>
      <Repository titulo="Título" descricao="descrição aqui" destacar/>
    </div>
  );
}

export default App;
