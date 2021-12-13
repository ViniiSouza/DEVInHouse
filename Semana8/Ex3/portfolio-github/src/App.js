import './App.css';
import { Repository } from './components/Repository/Repository';
import { Summary } from './components/Summary/Summary';

function App() {
  return (
    <div className="App">
      <h1>Olá, portfólio!</h1>
      <Summary />
      <Repository/>
    </div>
  );
}

export default App;
