import './App.css';
import { Repository } from './components/Repository/Repository';
import { Summary } from './components/Summary/Summary';

function App() {
  return (
    <div className="App">
      <h1>Olá, portfólio!</h1>
      <Summary imgSrc="https://github.com/ViniiSouza.png" altText="Imagem perfil Vinícius"/>
      <Repository titulo="Título" descricao="descrição aqui" />
    </div>
  );
}

export default App;
