import { useReducer, useState } from 'react';
import { ThemeProvider } from 'styled-components';
import './App.css';
import { Card } from './components/card';
import { NavBar } from './components/NavBar/NavBar';
import { DarkTheme, GlobalTheme, LightTheme } from './themes/themes';

function App() {
  const dataList = [{ id: 0, nome: 'Nome do Fulano', descricao: 'Descrição do funalo', seguindo: false }]
  const [dados, setDados] = useState(dataList);
  const [isThemeDark, setIsThemeDark] = useState(false);


  function FollowOrNo(id, seguindo) {
    let user = dados.find(where => where.id === id);
    let otherUsers = dados.filter(where => where.id !== id);
    user.seguindo = !seguindo;
    if (otherUsers != null && otherUsers.length > 0) {
      setDados([...otherUsers, user])
    } else {
      setDados([user])
    }
    console.log(dados)
  }

  return (
    <div className="App">
      <ThemeProvider theme={isThemeDark ? DarkTheme : LightTheme}>
        <GlobalTheme />
        <NavBar isThemeDark={isThemeDark} setIsThemeDark={setIsThemeDark} />
        {dados.map((user) => (
          <Card key={user.id} username={user.nome} description={user.descricao} isFollowing={user.seguindo} setFollow={() => FollowOrNo(user.id, user.seguindo)}></Card>
        ))}
      </ThemeProvider>
    </div>
  );
}

export default App;
