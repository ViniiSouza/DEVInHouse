import { useReducer, useState } from 'react';
import { ThemeProvider } from 'styled-components';
import './App.css';
import { Card } from './components/card';
import { ChangeTheme, NavBar, Title } from './components/styled-components/navbar.styles';
import { DarkTheme, LightTheme } from './themes/themes';

function App() {
  const dataList = [{ id: 0, nome: 'Nome do Fulano', descricao: 'Descrição do funalo', seguindo: false }]
  const [dados, setDados] = useState(dataList);
  const [themeController, setThemeController] = useState('dark');
  const [state, dispatch] = useReducer(reducer, LightTheme);

  function reducer(state, action) {
    console.log(state)
    switch(action) {
      case 'changeToDark':
        setThemeController('dark');
        return DarkTheme;
      case 'changeToLight':
        setThemeController('light');
        return LightTheme;
      default:
        return null;
    }
  }

  // atualiza o 'seguindo' mas não atualiza o componente

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
      <ThemeProvider theme={state}>
        <NavBar>
          <Title>Título Aplicação</Title>
          <ChangeTheme onClick={themeController === 'dark' ? () => dispatch('changeToLight') : () => dispatch('changeToDark')}>Alterar tema</ChangeTheme>
        </NavBar>
        {dados.map((user) => (
          <Card key={user.id} username={user.nome} description={user.descricao} isFollowing={user.seguindo} setFollow={() => FollowOrNo(user.id, user.seguindo)}></Card>
        ))}
      </ThemeProvider>
    </div>
  );
}

export default App;
